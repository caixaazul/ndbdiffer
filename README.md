[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=cribeiro84_ndbdiffer&metric=alert_status)](https://sonarcloud.io/dashboard?id=cribeiro84_ndbdiffer) [![Build status](https://dev.azure.com/caixaazul/NDbDiffer/_apis/build/status/NDbDiffer.CI)](https://dev.azure.com/caixaazul/NDbDiffer/_build/latest?definitionId=8) ![Release status](https://vsrm.dev.azure.com/caixaazul/_apis/public/Release/badge/c9c27776-1bc1-4066-8d55-ed365e1b9d8c/1/1)

# ndbdiffer
Lightweight open Source Command-Line Database Diff tool to facilitate the Database schema synchronization and versioning. 

# Features (In development)
- **Default Provider Database Engine:** SQL Server
- Extract Database schema from an existing database to a target folder
- Sync an existing schema (Database or Folder) to a new target (Database or Folder)
  - Changes only
- Supported Object types:
   - Tables
   - Stored Procedures
   - Views
   - Functions
   - User Defined Type
   - Triggers
- Supported input types
   - Command-line inputs (priotiry)
   - YAML file (future releases)

# Future releaes
- Plugins support
- New Providers support
   - Oracle
   - MySQL
   - MariaDB
   - Postgres
