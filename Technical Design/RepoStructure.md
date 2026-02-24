# Repository Structure

Repository structure defines how the code is physically organized:

- Folder layout
- Module boundaries
- Naming conventions
- Shared packages
- Infrastructure-as-code location

This project will use a **monorepo** approach.

---

## Root Directory

The root directory contains:

- Frontend/
- Backend/
- Database/
- Docs/
- CI-CD/
- Tests/
- .github/

---


## Folder Details

### Frontend
Contains the **Unity project**, including:

- Scripts for game logic and audio processing  
- Scenes and prefabs  
- UI elements  

### Backend
Contains the **ASP.NET Core backend**, including:

- Controllers and services  
- Data models and repositories  
- Unit and integration tests specific to backend modules  

### Database
Contains:

- SQL scripts for creating and seeding tables  
- Database migrations and schema definitions  

### Docs
Contains all project documentation:

- Technical Design and Functional Design docs  
- README.md  
- CONTRIBUTING.md  

### CI-CD
Contains automated pipeline configurations:

- GitHub Actions workflows for build, test, and deploy  
- Deployment scripts  

### Tests
Contains:

- Shared test utilities  
- Integration tests spanning multiple modules  

---

## Optional Folders

- `Tools/` → scripts, utilities, or code generators  
- `Examples/` → sample projects or demo runs  

---

## Branching Structure

- `main` → production-ready code (live)  
- `develop` → fully tested integration branch (sprint-complete features)  
- `feature/*` → short-lived branches for individual features or tasks  

> See [Branching & PR Rules](../GuitarApp/Technical%20Design/PullRequestRules.md) for full workflow details.

---

## Notes

- Folder structure should **support modularity** and **ease of onboarding**.  
- Naming conventions should be consistent across all folders and modules.  
- Infrastructure-as-code (CI/CD, deployment scripts) should live in its own folder for clarity.  
- This structure is designed to scale as the team or project grows.