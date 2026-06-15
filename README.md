# Simple Inventory Management System

A console-based inventory management application built with C# and .NET.
The system allows users to manage a list of products, each with a name, price,
and quantity in stock — all from a simple numbered menu in the terminal.

---

## Features

- Add a new product with name, price, and quantity
- View all products currently in the inventory
- Edit an existing product's name, price, or quantity
- Delete a product by name
- Search for a product by name
- Clean exit from the application

---

## Project Structure

InventoryApp/

├── Program.cs          → Entry point, starts the app

├── App.cs              → Main loop, coordinates UI and services

├── Models/

│   └── Product.cs      → Product data class

├── Services/

│   └── Inventory.cs    → Business logic and product list management

└── UI/

├── Menu.cs         → Displays the main menu

├── InputHelper.cs  → Handles and validates all user input

└── Display.cs      → Formats and prints all output to the console

---
