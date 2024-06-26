# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

__Figura 1: Diagrama de Classes: Jogos e demais__

![1-Jogos-jpeg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/e010fd1a-4900-430e-aaab-7676df3a8ee3)

Para uma melhor visualização, acessar à versão PDF abaixo:
[2-Diagrama de Classes-Jogos.pdf](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/files/15155885/2-Diagrama.de.Classes-Jogos.pdf)


__Figura 2: Diagrama de Classes: Usuário e demais__

![2-Usuário](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/24102708-1c00-44b8-8dba-abde28fc31a0)

[2-Diagrama de Classes-Usuario.pdf](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/files/14968447/2-Diagrama.de.Classes-Usuario.pdf)



## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Conforme especificação do porjeto InfoGames, o Modelo ER, com as relações entre as entidades, está representada nas Figuras abaixo:

Figura 3: Entidades do conjunto de Classes Steam

![2-Modelo ER-InfoGames-Jogos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/45ece1d9-57a9-4f7f-8f42-13e49e9e7450)

Figura 4: Entidades do conjunto de Classes Usuário e Jogador

![2-Modelo ER-Usuário](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/3ce6648a-9d3b-45af-9e4d-3071061f9359)

Abaixo, Figutas com as representações dos objetos, entidades e seus atributos, dos modelos ER do projeto InfoGames:

![1-Modelo E-R-Usuário-após etapa 3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/0524ce98-0c79-4bba-95e1-6c548d8022ae)


![4-Respres-Entidades-Atrib-Jogos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/1c8236b9-88cb-4ec0-b2a9-eae1dcab884f)

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

![1-Diagrama BD-Jogos-2-Final](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/a48e383e-6c1b-44ea-abec-ac26eb6f6bab)

![2-Projeto BD-Usuário-após etapa 3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/1bf8b470-4ab0-43ab-852f-f7bfe87ae348)



## Tecnologias Utilizadas

As ferramentas empregadas no projeto são:

* Linguagens utlizadas para desenvolver o projeto: HTML, CSS, JavaScript, MySQL e C#.
*	IDEs de desenvolvimento: Visual Studio Code
*	Plataforma para hospedagem dos arquivos: GitHub
*	Ferramenta para a criação de logo e imagens: Canva
*	Ferramenta para Projeto de Interface: Figma.
* Ferramenta para criação do Fluxo do Usuário: Whisimcal.
* Ferramenta para o Backlog: Kanban.
* Ferramenta para os Modelos Entidade-Relacionamento (Conceitual) e Projeto BD: Lucid.


## Hospedagem

A hospedagem do projeto foi implementada na ferramenta Azure, através do seu portal.
Após seguir os passos de implementação do próprio tutorial do Azure, o projeto InfoGame está hospedado no link: https://infogame20240606.azurewebsites.net

Para utilizá-lo, basta clicar no link acima, realizar seu cadastro e fazer login com as credenciais cadastradas. Após isso, você poderá navegar, facilmente, no Menu para ter acesso às informações disponíveis sobre jogos eletrônicos.

