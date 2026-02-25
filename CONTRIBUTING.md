# Contributing

Thank you for your interest in contributing to this project!

This document describes the development workflow, coding standards, and contribution guidelines. Following these rules helps keep the codebase consistent, maintainable, and easy to review.

Please read this document before opening a pull request.

## Scope

This repository includes the following areas:

- **Frontend:** Unity/C# code for real-time audio analysis, note/chord detection, and UI/UX  
- **Backend:** ASP.NET Core APIs for user accounts, practice tracking, and data persistence  
- **Database:** SQL Server schema, migrations, and stored procedures  
- **Testing:** Unit and integration tests for both frontend and backend  

Contributions can include:

- Bug fixes  
- Feature implementations  
- Refactoring or performance improvements  
- Documentation updates  
- Test coverage additions  

---

## Code Conventions

- Follow the [Code Conventions](../GuitarApp/Technical%20Design/CodeConventions.md) document for C# and Unity development.  
- Maintain clean, readable, and modular code.  
- Use consistent naming conventions for classes, methods, variables, and assets.  
- Apply design patterns as outlined in the technical design.  

### Recommended IDEs

- **Visual Studio** or **JetBrains Rider** are recommended for Unity and ASP.NET development.  
- Any IDE may be used as long as code style and CI checks pass.

---

## Branching Strategy

The project follows a **GitFlow-inspired branching model**:

- `main` – Production-ready, live version of the app  
- `develop` – Integration branch containing fully tested and completed features from the sprint  
- `feature/<name>` – Short-lived branches created from `develop` for individual features or tasks  

**Workflow:**

1. Create a new branch from `develop` for your task:  

   ```bash
   git checkout develop
   git checkout -b feature/<feature-name>
2. Commit changes regularly with clear messages referencing tasks or issues.
3. Once your feature is complete and passes all tests, open a pull request targeting develop.

---
## Pull Requests

All changes must go through a pull request (PR) for review:

- PRs should be **small and focused**, ideally addressing a single feature or bug.  
- Include a **clear description** of changes, linked issues, and any relevant testing notes.  
- PRs must be **reviewed by at least one team member** before merging.  
- Draft PRs are allowed for early feedback.  
- Merge strategy: **Squash commits** to maintain a clean history on `develop` and `main`.  

---

## CI / Testing Requirements

- All code must pass automated **CI checks** before merging:  
  - Unity Unit Tests  
  - Backend Unit/Integration Tests  
  - Build verification  
- Test coverage should be updated for new features or bug fixes.  
- Feature branches should **not break `develop`**; ensure all tests pass locally before opening a PR.  

---

## Additional Notes

- Follow the principles of **clean code and modular design**.  
- Document major classes, methods, and architectural decisions.  
- Ensure that your code aligns with the patterns described in the **Technical Design**.  
- Use the PR review process for knowledge sharing and collaborative improvement.




