# Technology Stack – Guitar Learning App

The frontend will be built with **Unity/C#**, and the backend with **ASP.NET Core/C#**.  
This stack keeps the project simple, scalable, and cross-platform, while providing an opportunity to showcase strong architectural and design skills.

---

## Frontend: Framework & Language

I want this application to be scalable across multiple platforms, including **PC, Xbox, PlayStation, and mobile**.  
While the MVP may not be game-level, the intention is to build a solid foundation that can grow.

For this reason, I chose **C# with Unity**, as it allows the application to run on a wide range of devices with a single codebase.  
C# offers strong audio support, a mature ecosystem, and makes it easy to scale from an MVP to a more robust, enterprise-level application.  
It is also console-friendly, enabling consistent development across multiple platforms.

---

## Backend: Framework & Language

The backend will be written in **ASP.NET Core / C#**.  

I considered C++, but this isn’t a AAA game, and C# is a solid choice for demonstrating my skills and designing a strong architecture without overcomplicating development.  
Since I am developing this entirely on my own, C# allows me to move quickly while still creating a **durable, maintainable system**.  

This project is more of a **portfolio proof-of-concept / MVP** than an enterprise product.  
That said, I am designing the architecture to be **optimal, efficient, and high-performance**, ensuring the application is fast and scalable while leveraging C#’s stability and capabilities.

---

## Database

The database will be **SQL**, as most of the data will be structured.  
If needed in the future, a **NoSQL database** can be added to store raw audio sessions or analytics.

---

## APIs, Libraries, and Tools

### Frontend & Audio Stack

#### Essential Libraries for MVP

- **Unity**
  - Frontend framework for the application.
  - Handles audio input, UI, and cross-platform support (PC, Xbox, PlayStation, mobile).
  - Built-in audio APIs for capturing and playing back guitar signals.

- **C# Libraries**
  - **Audio Processing:** NWaves (FFT, pitch detection, filters) for detecting notes and chords.
  - **Data Structures:** Built-in collections like Lists, Dictionaries, and Queues for storing session data and stats.
  - **Async Programming:** System.Threading.Tasks or UniTask for asynchronous audio processing so the UI remains responsive.

- **Entity Framework Core**
  - ORM for SQL database access and management.
  - Simplifies reading/writing structured data such as user accounts, progress, and practice statistics.

- **ASP.NET Core Web API**
  - Backend services for authentication, session management, and stats tracking.

- **JSON / REST or gRPC**
  - Handles communication between Unity frontend and backend.
  - REST/JSON is simplest and recommended for MVP.

#### Optional / Post-MVP Libraries

- **NAudio / CSCore** – Advanced audio capture if UnityEngine.Audio isn’t enough.  
- **MathNet.Numerics** – Advanced math and signal processing beyond NWaves.  
- **Rx.NET** – Reactive/event-stream programming for multi-user or complex apps.  
- **Unity Jobs + Burst Compiler** – High-performance multithreaded audio detection.

---

### Audio & Tools Stack Summary

| Library / Tool | Purpose | MVP or Post-MVP |
|----------------|---------|----------------|
| **UnityEngine.Audio** | Handles audio input and playback; captures guitar signals | MVP |
| **NWaves** | FFT, pitch detection, filters; simplifies detecting notes/chords | MVP (optional but recommended) |
| **System.Threading.Tasks / UniTask** | Async audio processing to keep UI responsive | MVP |
| **Entity Framework Core** | ORM for SQL database; simplifies data management | MVP |
| **ASP.NET Core Web API** | Backend services for accounts, progress, stats | MVP |
| **JSON / REST or gRPC** | Client-backend communication; REST simplest for MVP | MVP |
| **NAudio / CSCore** | Advanced audio input/capture if UnityEngine.Audio isn’t enough | Post-MVP |
| **MathNet.Numerics** | Advanced math / signal transforms beyond NWaves | Post-MVP |
| **Rx.NET** | Reactive programming for complex event streams | Post-MVP |
| **Unity Jobs + Burst Compiler** | High-performance multithreaded audio processing | Post-MVP |

---

## Hosting / Cloud Platform

For the MVP, the goal is to use **free, reliable, scalable, and portfolio-friendly solutions**, while leaving room for future multi-platform expansion.

### Cloud Provider

- **Azure**  
  - Native integration with ASP.NET Core and SQL Server.  
  - Managed services for hosting APIs, databases, and authentication.  
  - Free tier available (App Service + SQL Database) sufficient for MVP.  
  - Supports containerization (Docker) and Kubernetes for future scaling.

> Alternatives: AWS or Google Cloud. Azure provides the cleanest Microsoft stack integration for a C#-based architecture.

---

### SQL Database

- **SQL Server (Azure)**  
  - Stores structured data such as user accounts, session history, progress, and stats.  
  - Managed by Azure → minimal maintenance.  
  - Free tier sufficient for a single-user MVP.  

> Alternative: PostgreSQL is supported, but requires slightly more setup.

---

### Optional NoSQL Database

- **MongoDB / Redis** (optional)  
  - MongoDB: store raw audio sessions or analytics.  
  - Redis: cache frequently accessed data to reduce latency.  
  - Free tiers exist but not required for MVP.

---

### CI/CD Tools

- **GitHub Actions**  
  - Free for public and private repositories (2000 minutes/month).  
  - Integrates seamlessly with GitHub.  
  - Automates build, test, and deployment pipelines.  

- **Azure DevOps** (optional for future)  
  - Enterprise-level pipelines.  
  - Easy migration from GitHub Actions.

---

### Deployment Approach for MVP

1. Backend API hosted on **Azure App Service (free tier)**.  
2. SQL Server database hosted on **Azure (free tier)**.  
3. CI/CD pipeline using **GitHub Actions** to automatically build and deploy on commits.  
4. Future upgrades: optional NoSQL database, Redis caching, Azure DevOps pipelines, containerized services.

---

### Free Tier Summary

| Component | Free Tier / Notes |
|-----------|-----------------|
| Azure App Service | Free tier for hosting backend APIs and web apps |
| SQL Server | Free tier for structured data storage |
| GitHub Actions | 2000 minutes/month for private repos; unlimited for public repos |
| Optional NoSQL | MongoDB Atlas 512MB, Redis Cloud free tier |

---

### Portfolio / Skillset Benefits

- Demonstrates **cross-platform Unity development with C#**.  
- Shows **backend design with ASP.NET Core and SQL Server**.  
- Highlights **asynchronous, high-performance audio processing**.  
- Displays **cloud deployment, CI/CD, and future-proof architecture awareness**.  
- Ready for portfolio reviewers or future employers to understand both **MVP practicality** and **architectural scalability**.
