# AuctionApp - Microservices-based Auction System

**AuctionApp** is a **.NET 9 microservices-based auction system** with a **Next.js frontend**. It features a **modular architecture** with separate services for **auctions, search, bidding, notifications, and authentication**.

## 📖 Table of Contents

- [Architecture](#architecture)
- [Technologies Used](#technologies-used)
- [Microservices Overview](#microservices-overview)
- [Installation and Setup](#installation-and-setup)
- [API Endpoints](#api-endpoints)
- [Event-Driven Communication](#event-driven-communication)

## 🏗️ Architecture

![image](https://github.com/user-attachments/assets/52a1d660-c177-47f6-a935-a8bd374a32a8)

## 🛠️ Technologies Used

### Backend:
- **.NET 9 Web API** (Microservices)
- **PostgreSQL** (Relational Data)
- **MongoDB** (NoSQL Data)
- **RabbitMQ** (Event-driven communication)
- **MassTransit** (Message broker integration)
- **Entity Framework Core** (ORM)
- **Mapster** (Object Mapping)
- **IdentityServer** (Authentication & Authorization)

### Frontend:
- **Next.js** (React-based Web Application)
- **TailwindCSS** (Styling)

### Infrastructure:
- **Docker & Docker Compose** (Containerization)
- **Kubernetes** (Future Deployment)
- **Polly** (Resilience and fault handling)

## 🏢 Microservices Overview

### **1️⃣ Identity Service**
- **Manages authentication and authorization**.
- **Database:** PostgreSQL.
- **External authentication providers support** (OAuth, JWT).

### **2️⃣ Auction Service**
- **Manages auction creation and updates**.
- **Database:** PostgreSQL.
- **Communicates with Search and Bidding services via RabbitMQ**.

### **3️⃣ Search Service**
- **Handles search queries on auctions**.
- **Database:** MongoDB.
- **Consumes auction-related events**.

### **4️⃣ Bidding Service**
- **Manages bid placements**.
- **Database:** MongoDB.
- **Consumes auction and bid events**.

### **5️⃣ Notification Service**
- **Uses SignalR for real-time updates**.
- **Broadcasts bid and auction status changes**.

## 🚀 Installation and Setup

### **1️⃣ Clone the Repository**
```sh
git clone [https://github.com/your-repo/auction-app.git](https://github.com/hadi-soufan/.NET-Microservice.git)
cd src/
```

### **2️⃣ Start Services Using Docker**
Ensure you have **Docker & Docker Compose** installed, then run:

```sh
docker-compose up -d
```

This will start:
- **PostgreSQL (for Identity & Auction Service)**
- **MongoDB (for Search & Bidding Service)**
- **RabbitMQ (for event messaging)**

### **4️⃣ Run Migrations for PostgreSQL**
```sh
dotnet ef database update
```

### **5️⃣ Start the Microservices**
Run each service individually:

```sh
cd src/AuctionService
dotnet run
```

Repeat for other services (`SearchService`, `BiddingService`, etc.).

## 📌 API Endpoints

### **🔹 Auction Service**
| Method | Endpoint | Description | Auth |
|--------|---------|-------------|------|
| `POST` | `/api/auctions` | Create an auction | ✅ |
| `PUT` | `/api/auctions/:id` | Update an auction | ✅ |
| `DELETE` | `/api/auctions/:id` | Delete an auction | ✅ |
| `GET` | `/api/auctions` | Get all auctions | ❌ |
| `GET` | `/api/auctions/:id` | Get auction by ID | ❌ |

### **🔹 Search Service**
| Method | Endpoint | Description | Auth |
|--------|---------|-------------|------|
| `GET` | `/api/search?query` | Search auctions with filters | ❌ |

## 🔄 Event-Driven Communication

### **📤 Events Emitted**
| Service | Event | Description |
|---------|-------|-------------|
| AuctionService | `AuctionCreated` | Triggered when a new auction is created |
| AuctionService | `AuctionUpdated` | Triggered when an auction is updated |
| AuctionService | `AuctionDeleted` | Triggered when an auction is deleted |
| BiddingService | `BidPlaced` | Triggered when a user places a bid |
| BiddingService | `BiddingFinished` | Triggered when an auction ends |

### **📥 Events Consumed**
| Service | Event | Source |
|---------|-------|--------|
| SearchService | `AuctionCreated` | AuctionService |
| SearchService | `AuctionUpdated` | AuctionService |
| SearchService | `AuctionDeleted` | AuctionService |
| BiddingService | `AuctionFinished` | SearchService |

