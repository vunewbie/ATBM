# QLTDH - University Management System

[![Language](https://img.shields.io/badge/.NET-4.8-blue.svg)](https://dotnet.microsoft.com/)
[![Database](https://img.shields.io/badge/Oracle-19c-red.svg)](https://www.oracle.com/database/)
[![Docker](https://img.shields.io/badge/Docker-Compose-green.svg)](https://www.docker.com/)

The University Management System is an application built for database administrators to manage university databases in an intuitive way, allowing operations such as creating users, roles, granting permissions, revoking permissions, auditing...

This project was developed as part of the course project requirement for **Data Security in Information Systems (CSC12001 - CQ2022/1) at HCMUS**.

## Project Structure

```
ATBM/
├── App/                      # .NET Application
│   ├── QLTDH.exe             # Main executable
│   ├── QLTDH.exe.config      # Application configuration
│   └── dlls/                 # Support libraries
├── Init_Scripts/             # Database initialization scripts
│   ├── 01_create_admin.sql   # Admin creation and permissions
│   ├── 02_database.sql       # Database schema creation
│   ├── 03_procedures.sql     # Stored procedures creation
│   └── 04_data.sql           # Sample data generation
├── Source/                   # Source code of the application
│   ├── QLTDH/                # Main project folder
│   ├── QLTDH.sln             # Visual Studio solution file
│   └── packages/             # NuGet package dependencies
├── docker-compose.yml        # Docker configuration
├── Dockerfile.db             # Database Dockerfile
├── .gitignore                # Git ignore file
└── README.md                 # Project overview
```

## Database Schema

The database consists of the following primary tables:

- **DONVI**: Manages department and faculty information
- **NHANVIEN**: Manages staff and faculty information
- **SINHVIEN**: Manages student records
- **HOCPHAN**: Manages course catalog
- **MOMON**: Manages course offerings
- **DANGKY**: Manages student course registration

## System Requirements

- Docker and Docker Compose
- Windows with .NET Framework 4.8 or higher
- Network connectivity for container image retrieval

## Installation and Execution

### 1. Initialize the Database with Docker

1. **Clone the repository**:

   ```
   git clone <repository-url>
   cd <repository-folder>
   ```
2. **Make sure Docker is running**:
Before continuing, ensure that Docker is running on your machine (e.g., Docker Desktop must be started and running in the background).
4. **Build and start the Oracle container**:

   ```
   docker-compose build
   docker-compose up -d
   ```

   > **Note**: Oracle Database initialization may take 1-2 minutes. You can monitor the progress with `docker-compose logs -f oracledb`.

5. **Verify container status**:
   ```
   docker-compose ps
   ```
   The container must be in "Up" state before proceeding.

### 2. Launch the Application

1. **Navigate to the App directory**:

   ```
   cd App
   ```

2. **Execute the application**:
   ```
   QLTDH.exe
   ```

## Default Administrative Account

```
Username: QLTDH
Password: admin123
```

## Troubleshooting

### Database Connection Issues

- Verify Docker container status: `docker-compose ps`
- Check container logs: `docker-compose logs oracledb`

### Resetting the Database

```
docker-compose down -v
docker-compose up -d
```

## Development

For further project development:

1. Use Visual Studio to open and modify the source code
2. When changing the database schema, update scripts in the Init_Scripts directory
