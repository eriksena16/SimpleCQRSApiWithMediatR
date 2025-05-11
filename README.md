
# 🧱 Estrutura de Projeto com DDD, CQRS e MediatR

## 📝 Project Description (English)

This project demonstrates an API structure using **DDD (Domain-Driven Design)**, **CQRS (Command Query Responsibility Segregation)**, and **MediatR** to achieve a clean separation of concerns. The architecture is organized into four main layers:

- `API`: The entry point layer (controllers), responsible for exposing HTTP endpoints.
- `Application`: The application layer containing command and query handlers.
- `Domain`: The domain layer with entities, interfaces, and core business logic.
- `Infrastructure`: Concrete implementations of domain interfaces, such as repositories.

The structure was designed to be scalable, modular, and easy to maintain — making it ideal for medium to large-scale projects, especially when working with multiple microservices.
