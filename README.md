
# 🧱 Design Structure with DDD, CQRS and MediatR

This project demonstrates an API structure using **DDD (Domain-Driven Design)**, **CQRS (Command Query Responsibility Segregation)**, and **MediatR** to achieve a clean separation of concerns. The architecture is organized into four main layers:

- `API`: The entry point layer (controllers), responsible for exposing HTTP endpoints.
- `Application`: The application layer containing command and query handlers.
- `Domain`: The domain layer with entities, interfaces, and core business logic.
- `Infrastructure`: Concrete implementations of domain interfaces, such as repositories.

The structure was designed to be scalable, modular, and easy to maintain — making it ideal for medium to large-scale projects, especially when working with multiple microservices.

---

🧱 Estrutura de Projeto com DDD, CQRS e MediatR

Este projeto demonstra uma estrutura de API utilizando os padrões DDD (Domain-Driven Design), CQRS (Command Query Responsibility Segregation) e o MediatR para desacoplamento entre camadas. A arquitetura é organizada em quatro camadas principais:

API: Camada de entrada (controllers) responsável por expor os endpoints HTTP.

Application: Camada de aplicação com handlers de comandos e queries.

Domain: Camada de domínio contendo entidades, interfaces e lógica de negócio.

Infrastructure: Implementações das interfaces do domínio, como repositórios.

A estrutura foi pensada para ser facilmente escalável, modular e de fácil manutenção, sendo ideal para projetos de médio e grande porte, especialmente em cenários com múltiplos microsserviços.
