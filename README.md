# API Restful de Lista de Tarefas

Este é um projeto de uma API Restful de uma lista de tarefas desenvolvida em C#, utilizando a estrutura Minimal API. A aplicação possui funcionalidades básicas de criação, leitura, atualização e exclusão de tarefas. Os dados são armazenados temporariamente em um banco de dados em memória.

## Funcionalidades

A API oferece os seguintes endpoints para realizar as operações:

### Tarefas

- `GET /todoitems`: Retorna a lista de todas as tarefas cadastradas.
- `GET /todoitems/complete`: Retorna a lista de todas as tarefas concluídas.
- `GET /todoitems/{id}`: Retorna os detalhes de uma tarefa específica com base no ID fornecido.
- `POST /todoitems`: Cria uma nova tarefa com base nos dados fornecidos.
- `PUT /todoitems/{id}`: Atualiza uma tarefa existente com base no ID fornecido e nos dados fornecidos.
- `DELETE /todoitems/{id}`: Exclui uma tarefa existente com base no ID fornecido.

## Banco de Dados em Memória

O projeto utiliza um banco de dados em memória para armazenar temporariamente os dados das tarefas. A conexão com o banco de dados é configurada utilizando a estrutura Minimal API.

## Estrutura da Aplicação

A aplicação segue a estrutura oferecida pela Minimal API, que permite a criação rápida e simplificada de APIs em C#. Ela é composta pelos seguintes elementos principais:

- **DbContext (Contexto de Banco de Dados)**: Responsável por definir o contexto do banco de dados e configurar a conexão com o banco de dados em memória.

- **Model (Modelo)**: Representa a entidade de Tarefa (Todo) e suas propriedades, como nome e status de conclusão.

- **Endpoints (Pontos de Extremidade)**: Os endpoints são definidos para cada operação de CRUD (Create, Read, Update, Delete) e configuram as ações correspondentes em relação às tarefas.

## Contribuição

Este projeto é de código aberto e contribuições são bem-vindas! Se você encontrar bugs, tiver ideias para melhorias ou desejar adicionar novas funcionalidades, sinta-se à vontade para criar um fork, fazer suas alterações e enviar um pull request. Sua contribuição ajudará a tornar a API ainda melhor e mais útil para a comunidade.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE). Sinta-se à vontade para usá-lo e modificá-lo de acordo com suas necessidades.
