# Deployment & Environment

This section defines how the application is deployed, the environments used during development and testing, and configuration management practices.

---

## 1. Environments

The project uses separate environments to support development, testing, and production stability.

| Environment | Purpose | Notes |
|-------------|---------|-------|
| **Development (Dev)** | Active feature development and debugging | Runs locally in Unity Editor; uses test JSON data; no persistent production data. |
| **Testing (Test)** | QA and integration testing | Play Mode tests, automated unit/integration tests, edge case simulations. |
| **Production (Prod)** | End-user release | Builds packaged as standalone Unity executables; uses final song data and persistent save files. |

Each environment isolates data and configuration to prevent accidental overwrites or corruption of user data.

---

## 2. CI/CD Pipeline

Continuous Integration / Continuous Deployment (CI/CD) practices ensure reliable builds and automated testing.

- **Trigger:** Commits to the `develop` branch.
- **Automated Actions:**
  - Run all unit tests and Play Mode tests.
  - Verify JSON data and song assets.
  - Generate a development build for internal QA.
- **Release Pipeline:**
  - Merge to `main` triggers final build packaging.
  - Optionally, automated deployment to cloud storage or distribution platform.

CI/CD ensures consistent, repeatable builds and early detection of integration issues.

---

## 3. Configuration Management

Configuration and environment-specific settings are managed carefully to maintain consistency:

- **Configuration Files:**  
  - Stored separately for each environment (Dev/Test/Prod).  
  - Example: `config_dev.json`, `config_test.json`, `config_prod.json`.
- **Unity Player Settings:**  
  - Adjusted per environment (logging, debugging, quality settings).  
- **Versioning:**  
  - Builds are tagged with version numbers and commit hashes.  
  - Save files include version metadata to ensure backward compatibility.
- **Environment Flags:**  
  - The application detects the current environment via a build-time flag.  
  - Enables/disables debug logging, verbose error messages, or test assets as needed.

---

### Summary

The deployment strategy ensures:

- Clear separation between development, testing, and production.
- Automated and repeatable builds via CI/CD.
- Configuration management that maintains consistent behavior across environments.
- Safe versioning and environment-specific settings to minimize errors and regressions.