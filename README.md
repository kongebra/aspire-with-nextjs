# Next.js with .NET Aspire

This repository contains the code and setup instructions for integrating a Next.js application with the .NET Aspire stack. The project demonstrates how to containerize the Next.js application with Docker and run it within a .NET Aspire project.

## Prerequisites

Before you begin, ensure you have the following installed:

- [Node.js](https://nodejs.org/)
- [Yarn](https://yarnpkg.com/)
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- [Git](https://git-scm.com/)

## Run project

### Install NPM dependencies

```shell
cd src/frontend
npm install
```

### Run .NET Aspire

```shell
dotnet run --project src/Kongebra/Kongebra.AppHost
```
