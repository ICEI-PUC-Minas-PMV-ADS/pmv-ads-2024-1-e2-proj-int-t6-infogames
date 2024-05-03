﻿using InfoGames.Data;
using InfoGames.Models;
using Microsoft.AspNetCore.Mvc;
using InfoGames.Middlewares;
using System.Diagnostics;
using Microsoft.AspNetCore.Html;
using System.Text;
using System.Web;

namespace InfoGames.Controllers {
    public class JogoController : Controller {
        private readonly ApplicationDbContext _db;
        public JogoController(ApplicationDbContext db) {
            _db = db;
        }
        public ActionResult Index(int page = 1, int pageSize = 50, string searchTerm = "") {
            var jogosFiltrados = _db.Jogos.Where(j => j.Nome.Contains(searchTerm)).OrderBy(j => j.Nome).ToList();

            var jogosOnPage = jogosFiltrados.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            int totalPages = (int)Math.Ceiling((double)jogosFiltrados.Count() / pageSize);

            var paginationHelper = new Paginacao(CreateNewBasket);

            // Pass data to the view
            ViewBag.DboJogosVazio = _db.Jogos.Count() == 0;
            ViewBag.Jogos = jogosOnPage;
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.SearchTerm = searchTerm;
            ViewBag.TotalPages = totalPages;
            ViewBag.Pagination = paginationHelper.GeneratePagination(page, pageSize, searchTerm, totalPages);

            return View(jogosOnPage);
        }

        private string CreateNewBasket(int page, int pageSize, string searchTerm) {
            return $"/Jogo/Index?page={page}&pageSize={pageSize}&searchTerm={searchTerm}";
        }

        public IActionResult ChangePageSize(int pageSize, string searchTerm) {
            return RedirectToAction("Index", new { pageSize, searchTerm });
        }

        public IActionResult Search(string searchTerm) {
            return RedirectToAction("Index", new { searchTerm });
        }

        public IActionResult RecuperarJogos() {
            var recuperarJogos = new RecuperarJogos();
            recuperarJogos.BuscarNaSteam(_db);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> GetAppPrices() { // Ainda não implementado 100%
            GetAppPrices getAppPrices = new GetAppPrices(_db);
            return await getAppPrices.Index();
        }

        public IActionResult Form(string method, string id) {
            if (method == "add") {
                return View();
            } else if (method == "edit" && !string.IsNullOrEmpty(id)) {
                var obj = _db.Jogos.Find(id);
                if (obj == null) {
                    return NotFound();
                }
                return View(obj);
            } else {
                return BadRequest();
            }
        }

        public IActionResult Add(JogoModel obj) {
            if (ModelState.IsValid) {
                _db.Jogos.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Form");
        }

        public IActionResult Edit(JogoModel obj) {
            if (ModelState.IsValid) {
                _db.Jogos.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(string id) {
            if (id == null || id == "") {
                return NotFound();
            }
            var obj = _db.Jogos.Find(id);
            if (obj == null) {
                return NotFound();
            }
            _db.Jogos.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detalhes(string id) {
            if (id == null || id == "") {
                return NotFound();
            }
            JogoModel? _jogo = ConstruirInstanciaJogo(id);
            if (_jogo == null) {
                return BadRequest();
            }
            ViewData["App"] = _jogo;

            if (_jogo.DetalhesJogo?.Dlc?.Count > 0) {
                List<JogoModel> dlcs = [];
                foreach (var dlc in _jogo.DetalhesJogo.Dlc) {
                    JogoModel? _dlc = BuscarJogo.PorAppId(dlc, _db);
                    if (_dlc is null) {
                        Debug.WriteLine("DLC " + dlc + " não encontrada no banco de dados.");
                        continue;
                    }
                    _dlc = ConstruirInstanciaJogo(_dlc.Id);
                    if (_dlc?.DetalhesJogo is not null) {
                        dlcs.Add(_dlc);
                    }
                }
                if (dlcs.Count > 0) ViewData["Dlcs"] = dlcs;
            }

            if (_jogo.DetalhesJogo?.JogoCompleto is not null) {
                JogoModel? _jogoCompleto = BuscarJogo.PorAppId(_jogo.DetalhesJogo.JogoCompleto.IdJogoCompleto, _db);
                if (_jogoCompleto is null) {
                    Debug.WriteLine("Jogo completo " + _jogo.DetalhesJogo.JogoCompleto.IdJogoCompleto + " não encontrado no banco de dados.");
                } else {
                    _jogoCompleto = ConstruirInstanciaJogo(_jogoCompleto.Id);
                    if (_jogoCompleto is not null) {
                        ViewData["JogoCompleto"] = _jogoCompleto;
                    }
                }
            }

            if (_jogo.DetalhesJogo?.Demonstracao is not null) {
                List<JogoModel> demos = [];
                foreach (var demo in _jogo.DetalhesJogo.Demonstracao) {
                    if (demo.Appid is null) {
                        Debug.WriteLine("Appid da demo não encontrado.");
                        continue;
                    }
                    JogoModel? _demo = BuscarJogo.PorAppId(demo.Appid, _db);
                    if (_demo is null) {
                        Debug.WriteLine("Demo " + demo.Appid + " não encontrada no banco de dados.");
                        continue;
                    }
                    _demo = ConstruirInstanciaJogo(_demo.Id);
                    if (_demo?.DetalhesJogo is not null) {
                        demos.Add(_demo);
                    }
                }
                if (demos.Count > 0) ViewData["Demos"] = demos;
            }

            return View();
        }

        public JogoModel? ConstruirInstanciaJogo(string id) {
            JogoModel? _jogo = BuscarJogo.PorId(id, _db);
            if (_jogo == null) {
                return null;
            }
            Debug.WriteLine("Buscando app \"" + _jogo.Nome + "\" no banco de dados.");
            _jogo.DetalhesJogo = BuscarDetalhes.PorIdJogo(_jogo.Id, _db);

            if (_jogo.DetalhesJogo is null) {
                Debug.WriteLine("Detalhes do app \"" + _jogo.Nome + "\" não encontrados no banco de dados. Buscando da API Steam.");
                _ = RecuperarDetalhes.BuscarNaSteam(_jogo, _db);
                if (_jogo.DetalhesJogo is null) {
                    Debug.WriteLine("Detalhes do app \"" + _jogo.Nome + "\" não encontrados na API Steam.");
                    return null;
                }
            } else {
                Debug.WriteLine("Detalhes do app \"" + _jogo.Nome + "\" encontrados no banco de dados.");
                _ = RecuperarDetalhes.BuscarNoBancoDeDados(_jogo, _db);
                if (_jogo.DetalhesJogo is null) {
                    Debug.WriteLine("Erro ao processar banco de dados");
                    return null;
                }
            }
            return _jogo;
        }
    }
}
