# enterprise-bi-dashboard-rdlc-react
# ENTERPRISE BI DASHBOARD (RDLC + REACT + ASP.NET CORE)

# OVERVIEW

The Enterprise BI Dashboard is a full-stack business intelligence system built using ASP.NET Core Web API, React.js, SQL Server, and RDLC reporting.

It simulates real-world enterprise reporting systems used in finance, insurance, and analytics platforms. The system provides dashboards, secure authentication, role-based access, and exportable reports in PDF and Excel formats.

# ARCHITECTURE

React Frontend (UI Dashboard)
        ↓
ASP.NET Core Web API (Backend Services)
        ↓
Business Logic Layer (Services)
        ↓
RDLC Reporting Engine
        ↓
SQL Server Database

# FEATURES

BUSINESS INTELLIGENCE DASHBOARD
- Interactive dashboards for sales and operations
- KPI tracking system
- Real-time analytics visualization
- Chart-based data representation

RDLC REPORTING SYSTEM
- Generate PDF reports
- Export Excel reports
- Structured enterprise-grade reporting
- Printable report formats

AUTHENTICATION & SECURITY
- JWT authentication system
- Role-based authorization (Admin/User/Manager)
- Secure API endpoints
- Protected routes and data access

REST API LAYER
- ASP.NET Core Web API
- Clean architecture design
- JSON-based communication
- CORS enabled for frontend integration

DATA VISUALIZATION
- Chart.js integration
- Dynamic charts and graphs
- Business performance dashboards

EXTENSIBILITY
- Scheduled report generation
- Background processing support
- Email report automation (future enhancement)
- Multi-user analytics system

# TECH STACK

BACKEND:
- ASP.NET Core Web API (.NET 7)
- C#
- Entity Framework Core
- SQL Server
- RDLC Reporting

FRONTEND:
- React.js
- JavaScript (ES6+)
- Axios
- Chart.js

DEVOPS / TOOLS:
- Git & GitHub
- Docker (optional)
- Visual Studio / VS Code

# PROJECT STRUCTURE

enterprise-bi-dashboard-rdlc-react/
|
|-- backend/
|     |-- BiDashboard.API/
|           |-- Controllers/
|           |-- Models/
|           |-- Services/
|           |-- Program.cs
|
|-- frontend/
|     |-- public/
|     |-- src/
|           |-- components/
|           |-- pages/
|           |-- services/
|           |-- App.js
|           |-- index.js

# HOW TO RUN PROJECT

STEP 1: RUN BACKEND (.NET API)

cd backend/BiDashboard.API
dotnet restore
dotnet build
dotnet run

Backend will run on:
http://localhost:5000
https://localhost:5001

Swagger UI:
http://localhost:5000/swagger


STEP 2: RUN FRONTEND (REACT)

cd frontend
npm install
npm start

Frontend will run on:
http://localhost:3000


# API INTEGRATION

React frontend uses this base URL:

const API = "http://localhost:5000/api";


# API ENDPOINTS

GET SALES DATA:
GET /api/reports/sales

EXPORT PDF REPORT:
GET /api/reports/export/pdf

EXPORT EXCEL REPORT:
GET /api/reports/export/excel

# AUTHENTICATION FLOW

1. User logs in through API
2. Backend generates JWT token
3. Token is sent to frontend
4. Token is used for API authorization
5. Role-based access is enforced

# PLANNED ENHANCEMENTS

- Power BI style advanced dashboards
- Email scheduled reports
- Docker containerization
- Azure cloud deployment
- Multi-tenant support
- Advanced filtering and analytics

# HIGHLIGHTS

- Built enterprise BI dashboard using ASP.NET Core and React
- Implemented RDLC reporting system with PDF and Excel export
- Developed secure JWT authentication and role-based access
- Designed scalable REST APIs with clean architecture
- Integrated Chart.js for interactive dashboards
- Built full-stack enterprise reporting system

# AUTHOR

Geetha Charishma Jonnala

# PROJECT STATUS

Active Development - Enterprise Portfolio Project

# NOTES

- Always start backend before frontend
- Ensure CORS is enabled in backend
- Ensure correct API URL in React frontend
