# Motivational Quotes API

RESTful API for managing and serving motivational quotes with Clean Architecture implementation.

## Features
- **Random Quotes**: Fetch random inspirational quotes
- **CRUD Operations**: Complete quote management
- **Clean Architecture**: Domain-Driven Design
- **Swagger Documentation**: Interactive API documentation
- **RESTful Design**: Standard HTTP methods

## Technology Stack
- .NET Core
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI

## Architecture Layers
- **Domain**: Quote entities
- **Application**: Business logic
- **Infrastructure**: Data access
- **API**: Controllers and endpoints

## API Endpoints
- `GET /api/quotes/random` - Get random quote
- `GET /api/quotes` - List all quotes
- `POST /api/quotes` - Create new quote
- `PUT /api/quotes/{id}` - Update quote
- `DELETE /api/quotes/{id}` - Delete quote

## Use Cases
- Mobile applications
- Websites
- Daily motivation services
- Inspiration platforms

## License
MIT License
