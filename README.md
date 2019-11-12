# ndbdiffer #

Lightweight open Source Command-Line Database Diff tool to facilitate the Database schema synchronization and versioning.

![GitHub](https://img.shields.io/github/license/caixaazul/ndbdiffer?style=flat-square)

## Build Status ##

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=cribeiro84_ndbdiffer&metric=alert_status)](https://sonarcloud.io/dashboard?id=cribeiro84_ndbdiffer)
[![Build status](https://dev.azure.com/caixaazul/NDbDiffer/_apis/build/status/NDbDiffer.CI)](https://dev.azure.com/caixaazul/NDbDiffer/_build/latest?definitionId=8)
![Release status](https://vsrm.dev.azure.com/caixaazul/_apis/public/Release/badge/c9c27776-1bc1-4066-8d55-ed365e1b9d8c/1/1)

## Features (In development) ##

- **Default Provider Database Engine:** SQL Server
  - Version(s): 2016
- Extract Database schema from an existing database to a target folder
- Sync an existing schema (Database or Folder) to a new target (Database or Folder)
  - Changes only
- Supported Object types:
   - Tables
     - Temporal Tables
   - Stored Procedures
   - Views
   - Functions
   - User Defined Type
   - Triggers
- Supported input types
   - Command-line inputs (priotiry)

## Future releases ##

- YAML file
- Plugins support
- New Providers support
   - Oracle
   - MySQL
   - MariaDB
   - Postgres

## Contributing ##

- [How to Contribute](.github/CONTRIBUTING.md)

### Reporting Bugs ###

We use [GitHub Issues](https://github.com/caixaazul/ndbdiffer/issues) to track issues.
