# Purchase Microservice

## Overview

The Purchase Microservice API offers a set of endpoints for managing purchase-related functionalities, including cart management, order processing, and wish list management.

## Cart Endpoints

**Description**: This group of endpoints provides functionalities to manage the shopping cart, including creation, retrieval, and updating.

### 1. Create Cart

- **POST** `/api/cart`
  - **Description**: Creates a new shopping cart.

### 2. Get All Carts

- **GET** `/api/cart`
  - **Description**: Retrieves a list of all shopping carts.

### 3. Update Cart

- **PUT** `/api/cart`
  - **Description**: Updates the contents of the shopping cart.

## Order Endpoints

**Description**: This group of endpoints manages order processing, including order creation and retrieval.

### 1. Create Order

- **POST** `/api/order`
  - **Description**: Creates a new order.

### 2. Get All Orders

- **GET** `/api/order`
  - **Description**: Retrieves a list of all orders.

### 3. Get Order by ID

- **GET** `/api/order/{orderId}`
  - **Description**: Retrieves detailed information about an order by ID.

## Wish List Endpoints

**Description**: This group of endpoints manages wish lists, allowing the creation, retrieval, updating, and deletion of wish list items.

### 1. Create Wish List

- **POST** `/api/wish-list`
  - **Description**: Creates a new wish list.

### 2. Get All Wish Lists

- **GET** `/api/wish-list`
  - **Description**: Retrieves a list of all wish lists.

### 3. Get Wish List by ID

- **GET** `/api/wish-list/{wishListId}`
  - **Description**: Retrieves detailed information about a wish list by ID.

### 4. Update Wish List by ID

- **PUT** `/api/wish-list/{wishListId}`
  - **Description**: Updates a wish list by ID.

### 5. Delete Wish List by ID

- **DELETE** `/api/wish-list/{wishListId}`
  - **Description**: Deletes a wish list by ID.

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
For detailed information on how to use the API, refer to the API documentation available at [http://localhost:5004/swagger](http://localhost:5113/swagger/index.html).
