# Code Conventions

## C# Naming Conventions

| Naming Style | Applies To |
|-------------|------------|
| PascalCase | Types (classes, structs, interfaces, enums), Methods, Properties |
| camelCase  | Local variables, Method parameters |
| _camelCase | Private fields in Unity or for serialized variables |
| snake_case | Rarely used; external systems or interoperability |
| UPPER_SNAKE_CASE | Constants (`const` or `static readonly`), Enum values |
| lowercase | Namespace aliases, Folder/file names |

---

## Formatting

- **Indentation**: 4 spaces per level; no tabs  
- **Line Length**: Maximum 120 characters  
- **Braces**: Consistent style across the project (K&R or Allman)  
- **Spacing**: Single space after keywords (`if`, `for`, `while`); no trailing spaces  
- **File Layout**: One type per file; filename matches type name; UTF-8 encoding without BOM  
- **Using Directives**: Top of file, alphabetically sorted, remove unused  

---

## Comments & Docstrings

- Use XML comments (`///`) for public APIs  
- Keep inline comments concise and relevant  
- Avoid redundant comments that restate code  
- Document nullable reference types where applicable  

---

## Code Structure

- Clear folder structure: e.g., `src/` for code, `tests/` for unit tests  
- One class/struct/interface/enum per file  
- Method order: public → protected → private  
- Keep classes focused on a single responsibility  
- Private fields in Unity can be `_camelCase` for serialized or internal use  

---

## Error Handling

- Use exceptions appropriately; prefer specific exception types  
- Catch only what can be handled meaningfully  
- Validate method inputs and throw exceptions for invalid arguments  
- Avoid empty catch blocks or generic exception swallowing  

---

## Commit / Git Practices

- Use descriptive, atomic commit messages  
- Follow branch strategy: `main` (stable), `develop` (integration), `feature/<name>`, `hotfix/<name>`  
- Pull requests require at least one review and passing CI checks  
- Use **squash merges** to keep history clean  

---

## Optional Tools for Consistency

- `.editorconfig` for enforcing indentation, spacing, and line length  
- Linters/analyzers (StyleCop, Roslyn) to enforce naming and formatting rules  
- CI/CD pipeline checks for formatting, unit tests, and build  
- Recommended IDEs: Visual Studio or JetBrains Rider; VS Code is acceptable with extensions  
