 
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>


A metodologia utilizada neste projeto é baseada no SCRUM, que é uma abordagem ágil de desenvolvimento e tem como objetivo otimizar a especificação e execução de projetos. Através dessa metodologia, procura-se organizar melhor as equipes de trabalho e fragmentar suas tarefas, distribuindo-as e buscando prover mais eficiência no desenvolvimento.

O Scrum é uma metodologia que se baseia na entrega do produto de forma parcial e construtiva, ou seja, em etapas curtas e regulares, chamadas de sprints. Nesse sentido, com o Scrum, procuramos fazer com que todos trabalhem de forma colaborativa e contribuam com suas ideias e habilidades. Além disso, por meio dessa metodologia, procura-se fazer com que o problema em foco possa ser resolvido com mais facilidade, otimizando cada etapa de desenvolvimento e execução.

Como mencionado anteriormente, o Scrum é uma abordagem ágil e colaborativa que se concentra no trabalho em equipe, com responsabilidades e atividades bem definidas. Basicamente, sua estrutura está dividida nos seguintes componentes:

Os papéis: Scrum Master, Product Owner e a Equipe de Desenvolvimento;
Os eventos: planejamento, sprints e retrospectiva de sprint;
Os artefatos: backlog do produto, lista de pendências de sprint, lista de pendências do produto, gráfico de burndown, log, etc;
 
## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

A metodologia ágil escolhida para o desenvolvimento deste projeto foi o SCRUM, pois, como citam Amaral, Fleury e Isoni (2019, p. 68), seus benefícios são a visão clara dos resultados a entregar; ritmo e disciplina necessários à execução; definição de papéis e responsabilidades dos integrantes do projeto (Scrum Owner, Scrum Master e Team); empoderamento dos membros da equipe de projetos para atingir o desafio; conhecimento distribuído e compartilhado de forma colaborativa; ambiência favorável para crítica às ideias e não às pessoas.”

### Divisão de Papéis

Os papéis, na Equipe 1, foram distribuídos da seguinte maneira:

●	**Produt Owner**: Willian Barbosa de Andrade.

●	**Scrum Master**: Rafael Fernandes Mourão.

●	**Equipe de Design**: Willian Barbosa de Andrade, Caio Costa Miranda, Márcia Verônica Costa Miranda, Pablo Vinícius Ramos Lopes, Rafael Fernandes Mourão.

●	**Equipe de Desenvolvimento**: Rafael Fernandes Mourão, Caio Costa Miranda, Márcia Verônica Costa Miranda, Pablo Vinícius Ramos Lopes, Willian Barbosa de Andrade.

●	**Equipe de Documentação**: Márcia V. C. Miranda, Caio Costa Miranda.

As tarefas são organizadas no backlog do produto, e, em todo processo de construção da aplicação, a equipe reuniu-se semanalmente para definição e planejamento das tarefas, distribuição das atividades, revisão e planejamento dos próximos passos.
Esse processo de desenvolvimento foi sempre auxiliado pela utilização de diversas ferramentas de comunicação, documentação e construção de softwares.


### Processo

#### Backlog do Produto:

- **Etapa 1 (Sprint 1)**:

       Definição do problema.
       Proposta de solução.
       Personas e Histórias de usuários.
       Requisitos e Restrições.
       Diagrama de Casos de Uso.
       Vídeo de 2 minutos sobre o problema e a solução proposta.
       Documentação atualizada no Github.


- **Etapa 2 (Sprint 2)**:
  
       Documentação da Metodologia.
       Diagrama de Classes
       Diagrama de Fluxo
       Wireframes interativos
       Modelo Entidade Relacionamento (Projeto Conceitual)
       Projeto da Base de Dados
       Plano de Testes de Software
       Plano de Testes de Usabilidade
       Projeto do Github com Backlog e Plano de Sprints

- **Etapa 3 (Sprint 3)**:
  
       Template padrão da aplicação interativa
       Prova de Conceito da Arquitetura (POC) - exemplo de implementação com a integração do front-end com o back-end
       Programação de Funcionalidades
       Realização e registro dos testes de software
       Realização e registro dos testes de usabilidade
       Projeto do Github com Backlog e Plano de Sprints

- **Etapa 4 (Sprint 4)**:
  
       Conclusão da Aplicação com as entregas abaixo
       Template padrão da aplicação interativa
       Prova de Conceito da Arquitetura (POC) - exemplo de implementação com a integração do front-end com o back-end
       Programação de Funcionalidades
       Realização e registro dos testes de software
       Realização e registro dos testes de usabilidade
       Projeto do Github com Backlog e Plano de Sprints

- **Etapa 5 (Sprint 5)**:
  
       Conclusão do Teste de Software
       Conclusão do Teste de Usabilidade
       Apresentação da Solução
       Projeto do Github com Backlog e Plano de Sprints
       Construção do vídeo de, aproximadamente, 3 minutos


### Etapa 1 (Sprint 1):

*1.1 Planejamento:*

Nessa etapa, foi discutido e acordado qual o problema a ser abordado; foram planejados os seus objetivos, o público-alvo que se pretende alcançar e seus perfis, bem como proposta dos Requisitos funcionais e não-funcionais a serem atendidos, bem como as restrições da solução, no desenvolvimento da aplicação. Foi construída a apresentação, contendo a abordagem geral do projeto, e um vídeo sobre o que será abordado.

Após a formação da equipe, foram planejadas reuniões do grupo, através das ferramentas Teams e Google Meet. Foi construído um grupo do WhatsApp, para troca de ideias, discussões gerais, para definições das ferramentas a serem utilizadas no desenvolvimento do projeto.

Foi escrito e entregue a documentação referente a essa etapa, que consistiu das seguintes Sessões: Documentação do Contexto e a Especificação do projeto.


*1.2 Execução:*

Durante essa etapa, foram realizados, semanalmente, encontros com o professor, através do Teams, que orientou a respeito dos encaminhamentos, como descrever a documentação, direcionamentos a respeito da utilização do Github e dos diagramas a serem entregues nessa etapa, bem como suas correções e sugestões de melhoria. 
As reuniões da equipe foram realizadas em até duas vezes por semana, pelo Meet de forma síncrona, uma vez que se trata de uma etapa de muitas definições para os futuros encaminhamentos do projeto. Esses encontros sempre resultaram nas distribuições de atividades com os componentes, para os ajustes e composição final dos documentos.

As tarefas definidas foram distribuídas com os componentes da equipe, ficando assim dispostas: 
* A sessão de Documentação foi feita por Caio Miranda e revisada por Willian, Pablo e Márcia,
* A definição do Problema ficou com Rafael, Willian, Caio, Márcia e Pablo.
* A especificação do projeto ficou com Márcia e Rafael.
* Revisão dos Requisitos e Restrições ficou com Pablo e Caio.
* Apresentação do projeto ficou com Márcia e Caio.
* Diagrama de Casos de Uso ficou com Rafael e Willian.

Houve uma revisão geral na documentação elaborada, por parte de toda equipe, e a equipe concluiu as demais definições do projeto, como objetivos e os requisitos. A equipe colaborou, em conjunto, em todas as etapas.


*1.3 Evidências:*

Foram marcados diversos encontros e reuniões com a equipe, para discussões e definições dos objetivos, público-alvo, requisitos, perfis dos usuários e demais pontos importantes para o desenvolvimento do projeto. Essas reuniões resultaram em atas, com os resultados acordados e distribuição de tarefas. Ademais, produzimos resultados documentais, logo do projeto e a apresentação da Etapa 1.


Figura 1 – Atas das reuniões de Equipe ocorridas para discussões e decisões da etapa 1

![1-Ata reunião](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/6a1f9cc3-ed8a-405d-90fc-decf72f4bac1)


Figura 2 – Etapa da Construção da apresentação do projeto – Etapa 1

![2-Construção Apres Projeto-etapa 1-Peq](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/14e20d29-0c8b-407b-8943-c08d631906ed)

Figura 3 – Reunião da Equipe com uso da Ferramenta Astah – Etapa 1

![Reunião-02-03-2024-PEQ](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/8bbe6ebd-ea0f-4a75-b3ab-aee4a4b6fe6e)

Figura 4 - Kanban do projeto InfoGames - Etapa 1

![7-Kanban-InfoGames-Etapa 1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/cac18cfd-3d20-4432-9d6e-dc2f77a48bc2)


### Etapa 2 (Sprint 2):

*2.1 Planejamento:*

O planejamento dessa etapa consistiu da documentação da metodologia, no que concerne as descrições até esse item, com as atribuições dde atividades a cada membro da equipe (segundo a metodologia SCRUM) a ser desenvolvida no projeto. Foram construídos os Diagramas de Classes e de Fluxo, os protótipos das interfaces a serem construídas especificados e construídos o Modelo Entidade-Relacionamento (Projeto Conceitual) e o projeto da Base de Dados, foram descritos o plano de Testes de Software e plano de Testes de Usabilidade, iniciais para esse nível de etapa de desenvolvimento.

Faz-se necessário registrar que, ao final dessa etapa, a aluna Raíssa Saunier pediu cancelamento de sua matrícula no curso ADS da PUC, retirando-se, obviamente, do nosso grupo.

*2.2 Execução:*

A equipe realizou reuniões semanais e decidiu pela utilização das ferramentas Whimscal e Figma, utilizados no design do Fluxo de Usuário e protótipos das telas do aplicativo, levando em consideração os requisitos funcionais e não funcionais. Foi utilizada a ferramenta Astah para construção do diagrama de Casos de Uso e Projeto de Banco de dados, a ferramanta Lucid, em sua versão gratuita, para a construção dos modelos Entidade-Relacionamento. Foram utilizadas ferramentas, como os recursos de diagramas do Power Point, para as representações de Entidades e atributos.
Algumas dessas ferramentas, como Astah e Lucid, constituíram-se novidades para a equipe, portanto houve um esforço inicial em seu aprendizado e utilização. Verificou-se uma colaboração excelente entre os membros, principalmente no compartilhamento dos cadastros das ferramentas utilizadas, facilitando a construção e revisão dos designs, por todos os membros.

Os diagramas dos Fluxos dos usuários foram feitos por Rafael, Willian, majoritariamente, e Márcia, com correções de toda equipe. As telas do protótipo foram elaborados por Willian, e corrigidas por todos os membros. Os diagramas de Classes foram construídos por Rafael, principalmente, e Raíssa, com participação em revisão de todos. Os modelos Entidade-Relacionamento foram construídos por Márcia e Caio, com revisão de Rafael. Os modelos de projeto ficaram sob a responsabilidade de Pablo e Raíssa, com revisão geral de todos. Os planos de testes ficaram com Rafael e o Plano de Usabilidade ficou com Márcia e Caio, tendo a participação da equipe inteira, também.
Os textos construídos no Github foram realizados por Márcia, com revisão geral de todo material foi realizada por todos os membros da equipe.
Lembrando que, ao final dessa etapa, a aluna Raíssa Saunier desligou-se do curso ADS da PUC.

Além disso, o método Kanban foi adotado para formalizar o cadastro de distribuição das tarefas, registrando as tarefas a serem feitas, em etapas futuras, e as já realizadas até o momento.

*2.3 Evidências:*

Algumas demonstrações das atividades realizadas nessa etapa, estão nas imagens abaixo:

Figura 5 - Ata de reunião de Equipe

![5-Reunião equipe-Infogames-etapa 2-print](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/b00ed4d0-9ae4-4d79-91bc-529b2e48699c)

Figura 6 - Captura do Figma, no processo de construção dos Protótipos do Aplicativo.

![1-Print Figma-Infogames-etapa 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/22a49f29-f872-470d-a5e7-4bf9b153e9cf)

Figura 7 - Captura do Whisimcal, no processo de construção dos Diagramas de Fluxo do projeto.

![8-Print Whimsical-fluxo do projeto](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/95cb61df-a30e-4ed3-9b5f-0217ed31d881)


Figura 8 - Captura do Astah, no processo de construção dos Diagramas de Caso de uso e de Classes.

![2-3-Print Diagr-Casos Uso e Classes-Infogames-etapa 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/1e9a8a02-2f62-4aff-b2a9-5d0fdd9d8fc5)

Figura 9 - Captura da ferramenta Lucid, no processo de construção dos Modelos Entidade-Relacionamento (Conceitual).

![4-Print-Modelo ER-Infogames-etapa 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/77f45d07-b9b5-47c2-860e-ad8f0944ab8e)

Figura 10 - Captura da ferramenta Lucid, no processo de construção do Projeto BD.

![3-Print Lucid-Diagrama Bd](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/0b5d4d39-b6e3-4aed-81df-058ea8cbb8e8)

Figura 11 - Kanban do projeto InfoGames - Etapa 2

![8-Kanban-InfoGames-Etapa 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/d28f3340-871a-4e1c-bc05-d4d1e802ebba)

Figura 12 - Kanban do projeto InfoGames - Final da Etapa 2
![2-Kanban-final Etapa 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/755d28f3-dca9-4961-9d05-cf2ad228fd80)



### Etapa 3 (Sprint 3):

*3.1 Planejamento:*

O planejamento dessa etapa consistiu nos estudos e definições dos frameworks, estilo de arquitetura e tipo de aplicação Web utilizado no projeto. Assim sendo, a metodologia de nosso projeto é baseado nas seguintes especificações:

1.	Framework padrão de projeto utilizado: MVC
2.	Estilo de arquitetura: Cliente-Servidor 
3.	Tipo de aplicação web: CSR (Client Side Rendered) 

Foram planejados os Templates da Aplicação, baseados nos Fluxos de Usuários e Telas da interface (conforme especificados na Sessão 04), além dos protótipos já planejados anteriormente. Foram planejados e distribuídas as atividades de programação das funcionalidades de mais elevada prioridade, utilizando as ferramentas necessárias durante essa etapa, como C# e SQL server. Para essa etapa, foi planejado a implemenação do Requisito Funcional RF-01 a 04, bem como o back end das Classes Usuário, Lojas e Jogos.


*3.2 Execução:*

A equipe realizou reuniões semanais, definindo as prioridades a serem implementadas. Podemos elencar as atividades a serem implementadas: Requisito Funcional RF-01: Cadastro do Usuário, back end das classes Usuário, Lojas e Jogos, front end do Portais de Notícias e Promoções.
Houve o compartilhamento do aprendizado nas ferramentas necessárias para essa etapa: desenvolvimento back end, uso de APIs, C# e SQL, entre os membros da equipe. 

Esses frameworks e ferramentas constituíram-se novidades para a maioria dos membros da equipe, tendo sido necessário um grande esforço de aprendizado, para sua efetiva utilização. A equipe trabalhou com grande colaboração entre si. O colega de equipe Rafael iniciou a implementação da parte de back end, com integração do Banco de Dados e uso da API, necessária ao projeto, que permitiu o desenvovimento inicial das demais páginas da aplicação, pelo restante da equipe. 

Vale salientar que, para facilitar a leitura do código fonte, foi decidido, no processo de implementação, manter o nome original dos atributos, até antes de salvar no banco de dados. Posteriormente, serão devidamente passados para o português (ver Figura abaixo).  
![3-Padrão Nomenclatura Utilizado-OK2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/ba27db0d-4803-44c1-9304-c9a99b7a3dfb)


Baseado nos protótipos já planejados na etapa anterior, as atividades foram distribuídas entre os membros da equipe, que facilitou a colaboração a obtenção do produto, até essa etapa.
As tarefas, nessa etapa, foram assim distribuídas:

1. Back end e front end da Classe Usuário (RF-001 a RF-004): Caio e Márcia;
2. Back end das Classes Lojas e Jogos: Rafael; 
3. Front End do Portal de Notícias e Promoções: Willian e Pablo; 
4. GitHub - textos e atualizações: Márcia; 
5. Correções e Revisões gerais (Programação e GitHub): Rafael, Márcia, Caio, Willian e Pablo.

Foi planejado o template padrão do projeto (descrito na Sessão 06 deste documento) que irá aparecer nas páginas do projeto. A tela inicial tem um background com imagem relativo ao tema do projeto (jogos eletrônicos), botão de entrada na cor vermelha no canto superior direito. Após login, a tela tem um menu de contexto vertical, na lateral esquerda da tela,  e conteúdo centralizado na página. Optamos por utilizar, inicialmente, a Sans-serif e Exo, cor branca, para os botões de menus e para os textos das páginas. Os botões de menus de navegação superior são da cor vermelha.

Ademais, a equipe focou na construção, desde a fase de planejamento até a execução, de um padrão de responsividade, pelo programa, que fosse congruente com as necessidades dos usuários, já desenvolvendo a visualização dos elementos do programa para o desktop, tablet e dispositivos móveis. 

Os bancos de dados utilizados nesse projeto, armazenam os dados cadastrais do usuário, bem como recuperados, através de APIs de Steams de jogos eletrônicos, dados de Lojas e jogos, conforme pode ser observado nas Figuras abaixo, que comprovam a implementação dessas funcionalidades.

![1-Print BD Lojas-Jogos -det lançamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/0ea8363c-b69a-4904-aa17-35bc32f30a9d)

![2-Print BD Jogos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/ea40ee4c-ee06-42aa-9d13-c8bd6e78aae8)



*3.3 Evidências:*

Algumas demonstrações das atividades realizadas nessa etapa, estão nas imagens abaixo:

Figura 13 - Aula com o orientador, Prof Bernardo, com a Equipe do projeto. Demostração de execução das Informações de uma classe do projeto.

![2-Aula-2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/0611a552-ecb9-484c-8a10-f1f8ea110022)

Figura 14 - Reunião de equipe para planejamento e implementação da Etapa 3.

![2-Print reunião-planejamento-Equipe 1-T6](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/e75d4d41-9237-4473-b000-482869aaaef7)

Figura 15 - Exemplo de armazenamento no Banco de dados

![3-Print BD Jogos-categoria e Preços](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/1caeb941-3590-4cc2-97de-146d873fd812)

Figura 16 - Kanban do projeto InfoGames - Etapa 3

![5-Print Kanban-Etapa 3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/437a7b7a-cfd1-45ec-a7af-47a4aa707ebb)


### Etapa 4 (Sprint 4):

*4.1 Planejamento:*

O planejamento dessa etapa consistiu na definição do que faltava para a conclusão da aplicação do projeto. Nesse sentido, foi realizada uma revisão do que já estava pronto e do que tinha inicialmente sido planejado.  Com base nesse material, a equipe se reuniu e decidiu por realizar uma redução em algumas funcionalidades, sem qualquer prejuízo ao objetivo e à solução almejada. 

Para essa etapa, foram planejadas as implementações dos seguintes funcionalidades: Front-end do módulo de Usuários; Front-end de pesquisa de Lojas e Jogos; Portal de Notícias, além do término dos registros de testes de softwares e de Usabilidade dessas funcionalidades.

As atividades restantes para conclusão da aplicação foram distribuídas com a equipe. Para essa etapa, foi planejado a implemenação do Requisito Funcional RF-05 a 10, uma vez que as demais já foram concluídas na etapa 03.


*4.2 Execução:*

A equipe realizou, em 19.05.2024, reunião de avaliação geral do projeto, onde decidiu-se por reduzir algumas funcionalidades, antes planejadas, sem prejuízo ao objetivo proposto do projeto. Analisadas as funcionalidades, resolveu-se retirar, momentaneamente, o seguinte: Portal de Promoções, Portal de Novidades, inserção de comentários por parte dos Usuários e exibição de Jogos mais Jogados. Essa decisão não impede que, futuramente, essas funcionalidades sejam implementadas e incorporadas à aplicação, bem como não compromete, de forma alguma, os objetivos almejados.

As tarefas, nessa etapa, foram assim distribuídas:

a. Módulo do Usuário (back-end e front-end inicial): Caio e Márcia; <br />
b. Módulos de Lojas, Jogos e Notícias (back-end e front-end inicial): Rafael; <br />
c. Front-end das páginas Inicial, Home e Usuário: Márcia e Caio; <br />
d. Hospedagem do Projeto: Márcia; <br />
e. GitHub - textos e atualizações: Márcia; <br />
f. Correções e Revisões gerais (Programação e GitHub): toda equipe.


*4.3 Evidências:*

Algumas demonstrações das atividades realizadas nessa etapa, estão nas imagens abaixo:

Figura 17 - Resumo da reunião de equipe para planejamento e implementação da Etapa 4, decidindo reduzir as funcionalidades a serem concluídas.

![1-Ata Reunião de Equipe](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/173d63b6-987c-4bf6-a068-17363f4ccfe1)

Figura 18 - Construção da interface final da aplicação InfoGames

![1-Evidência-construção interface](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/1f234d8e-6595-47e9-9c0c-40f65e881478)


Figura 19 - Kanban da Etapa 4.

![2-Kanban -etapa4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/7d51bca6-676c-4cd6-83a6-279090215fc4)


### Etapa 5 (Sprint 5):

*5.1 Planejamento:*

O planejamento dessa etapa consistiu na revisão do código implementado, na elaboração do roteiro para construção do vídeo e da apresentação do projeto. Foram distribuídas as atividades finais do projeto com a equipe, para revisão final, após finalização das tarefas.

*5.2 Execução:*

As atividades restantes, que completam a execução do projeto, foram revisadas, executadas e atualizadas por membros da equipe.

Foi construído um pequeno roteiro para elaboração da apresentação do projeto, utilizando a ferramenta Power Point, bem como para a construção do vídeo, que é um Tutorial resumido da plataforma construída.

Nessa etapa, as atividades foram distribuídas entre os membros da equipe, da seguinte forma:

a. Vídeo: Márcia, Caio e Willian; <br/>
b. Apresentação em Power Point e PDF: Márcia; <br/>
c. Revisão do código e hospedagem: Márcia e Rafael; <br/>
d. GitHub e KanBan- textos e atualizações: Toda equipe; <br/>

*5.3 Evidências:*

Figura 20 - Kanban com finalização das tarefas do projeto InfoGame
![1-Kanban-Etapa 5](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/95d21e5f-0b4a-4a7c-9ae8-89c39f88d48d)

Figura 21 - Processo de Hospedagem do site InfoGame no Azure
![2-Azure-hospedagem-InfoGame](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/b1444722-3ab1-4b3c-9e7d-2916a2ce9af2)

Figura 22 - Projeto InfoGame hospedado - Página de entrada do Site
![3-Site Infogame Hospedado](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/assets/145228139/b9f04b3b-5293-4492-8ef1-2ebda55289ca)


### Ferramentas

As ferramentas empregadas no projeto são:


| AMBIENTE                            | PLATAFORMA                         | LINK DE ACESSO                         |
|-------------------------------------|------------------------------------|----------------------------------------|
| Documentos e Gerenciamento do projeto / Repositório de código fonte         | GitHub                             | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t6-infogames/main/         |
| Projeto de Interface                | Figma                              |                          |
| Backlog                             | Kanban                             | https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/909/views/1               |
| Encontros síncronos com Orientador  | Microsoft Teams                    |                           |
| Reuniões da equipe                  | GoogleMeet                         |             |
| Comunicação da equipe               | WhatsApp                           | web.whatsapp.com                            |
| Diagramas de Fluxo do projeto  | Whimsical                          |  https://whimsical.com/            |
| Modelos Entidade-Relacionamento (Conceitual)  | Lucid                          |  https://lucid.com/            |
| Construção e Edição de Vídeos  | ScreenCast                       |  https://screenpal.com   |
| Construção de slides  | Power Point                       |  https://support.microsoft.com/pt-br/office/  |




O editor de código foi escolhido porque ele possui uma integração com o sistema de versão. 
As ferramentas de comunicação utilizadas porque são de conhecimento de todos os membros da equipe, possuem integração semelhante, por isso foram selecionadas. 
Por fim, para criar diagramas utilizamos essa ferramenta por melhor captar as necessidades da nossa solução, acessível e conhecido por todos os membros da equipe do projeto.

