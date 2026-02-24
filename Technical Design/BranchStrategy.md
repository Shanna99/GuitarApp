# Branching Strategy

## Overview

This repository follows a structured branching model to ensure stability in production, maintain a fully working integration branch, and isolate feature development.

The workflow is based on three primary branch types:

- `main`
- `develop`
- `feature/*`

---

## Branch Topology

### `main`
The `main` branch represents the live production environment.

- Always reflects the current production state.
- Contains only stable, production-ready code.
- Updated only through merges from `develop` during a release or from hotfix branches when required.

### `develop`
The `develop` branch is the integration branch for completed sprint work.

- Always fully functional.
- All tests and pipelines must pass.
- No unfinished or partially implemented features are allowed.
- Every feature merged into `develop` must meet its Story Definition of Done (DoD).
- Represents the next production release candidate.

### `feature/*`
Feature branches are short-lived branches created from `develop`.

- Must always branch off from `develop`.
- Named clearly after the feature being implemented (e.g., `feature/user-authentication`).
- Used exclusively for isolated feature development.
- Merged back into `develop` only after:
  - Implementation is complete
  - All tests pass
  - CI pipelines succeed
  - The feature satisfies its defined requirements and DoD

---

## Feature Development Workflow

1. A new feature branch is created from `develop`.
2. Development occurs exclusively within the feature branch.
3. The feature branch must remain isolated from other work.
4. Once the feature is finalized and validated:
   - All tests must pass
   - CI pipelines must succeed
   - The feature must fully meet the story requirements and DoD
5. The branch is merged back into `develop`.

The `develop` branch must remain in a deployable and stable state at all times.

---

## Release Flow

Releases follow this process:

1. `develop` represents the fully integrated and sprint-complete state.
2. When ready for production deployment:
   - `develop` is merged into `main`.
3. The `main` branch then represents the new live production version.

No direct development occurs on `main`.

---

## Hotfix Flow

If a critical issue occurs in production (`main`):

1. A `hotfix/*` branch is created from `main`.
2. The fix is implemented and validated.
3. After testing:
   - The hotfix branch is merged into `main`.
   - The same hotfix must also be merged back into `develop` to prevent regression.
4. The hotfix branch is then deleted.

This ensures production stability while keeping `develop` aligned with the live state.

---

## Stability Rules

- `main` must always reflect what is currently live.
- `develop` must always be fully functional and pass all tests.
- No unfinished work may be merged into `develop`.
- All feature development must occur in dedicated feature branches.
- All merges must go through Pull Request review and CI validation.

---

## Summary

This branching strategy ensures:

- Production stability (`main`)
- Sprint-level integration safety (`develop`)
- Isolated and controlled feature development (`feature/*`)
- Clear and traceable release flow
- Safe handling of urgent production fixes

This model enforces discipline while keeping the development process structured and predictable.