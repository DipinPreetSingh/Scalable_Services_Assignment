# Product Microservice

## Overview

The Product Microservice API offers a set of endpoints for managing product-related functionalities, including the creation, retrieval, updating, and deletion of products. Additionally, it provides an endpoint for verifying product information.

## Product Endpoints

**Description**: This group of endpoints provides functionalities to manage products, including creation, retrieval, updating, and deletion. The "Verify Product" endpoint allows the verification of product information.

### 1. Create Product

- **POST** `/api/product`
  - **Description**: Creates a new product.

### 2. Get All Products

- **GET** `/api/product`
  - **Description**: Retrieves a list of all products.

### 3. Get Product by ID

- **GET** `/api/product/{productId}`
  - **Description**: Retrieves detailed information about a product by ID.

### 4. Update Product by ID

- **PUT** `/api/product/{productId}`
  - **Description**: Updates product details by ID.

### 5. Delete Product by ID

- **DELETE** `/api/product/{productId}`
  - **Description**: Deletes a product by ID.

### 6. Verify Product

- **POST** `/api/product/verify`
  - **Description**: Verifies product information.

## Installation

### Prerequisites

Ensure that you have the following prerequisites installed on your machine:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/get-started)
- [PostgreSQL](https://www.postgresql.org/)

### Setup

**1. Clone the repository:**
  ```bash
   git clone (RepositoryPath)
   cd ProductService
   ```
**2. Update DB connection string:**
    Open appsettings.json and update the database connection string.

**3.Build and Run the application locally:**
  ```bash
   dotnet build
   dotnet run
   ```
   
# License

This project is licensed under the [MIT License](LICENSE).

# Usage
For detailed information on how to use the API, refer to the API documentation available at [http://localhost:5004/swagger](http://localhost:5054/swagger/index.html).
