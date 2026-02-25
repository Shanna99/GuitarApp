# Pull Request & Merge Policy

## Merge Strategy

- **Squash merges only** – All feature branches will be squashed into a single commit when merged into `develop` or `main`.  
- **Linear history enforced** – Prevents merge commits from cluttering the commit history.

### Rationale

During the MVP phase, squash merging is preferred to keep the commit history **clean and easy to follow**. This ensures that the main and develop branches remain readable and concise.

### Future Considerations

As the application matures, the merge strategy might evolve to allow regular merges without squashing. This could be necessary in cases such as:

- Maintaining a **detailed audit/history** for compliance or traceability  
- Multiple developers working in parallel on a single feature or module  
- Heavy reliance on **commit-level debugging** to identify regressions  

This approach balances a clean history during early development with the flexibility to preserve detailed commit information when the project scales.

## Pull Request Rules

Pull requests (PRs) are the way to propose changes to the repository. These rules define the **process for submitting, reviewing, and merging PRs**, not the file or folder layout.

---

### PR Guidelines

1. **Branch Naming**  
   - Feature branches should be created from `develop`.  
   - Branch names must clearly describe the feature or task, e.g., `feature/user-authentication`.

2. **Commit Messages**  
   - Must be clear and descriptive.  
   - Should reference relevant tasks, stories, or issue IDs where applicable.

3. **PR Description**  
   - Explain what the PR does and why.  
   - Include details on how it meets requirements or Definition of Done.  
   - List any dependencies or related PRs.

4. **Tests**  
   - Include unit and/or integration tests where applicable.  
   - All tests must pass before merging.

---

### PR Size and Scope
- Each PR should implement a **single feature, bug fix, or task**.
- Avoid combining unrelated changes in a single PR.
- Smaller, focused PRs are easier to review, test, and merge.

--- 

### PR Rules

- **Required Reviews**: 1–2 reviewers must approve before merging.  
- **CI Validation**: All continuous integration checks must pass.  
- **Draft PRs**: Allowed for early feedback and discussion.  

---

### Summary

Following these PR rules ensures that:

- Changes are **reviewed and verified** before entering `develop` or `main`.  
- The repository maintains **stable, tested code**.  
- History and contributions are **clear and traceable**.  
- Team collaboration is **structured and consistent**.


## Branch Protection Rules

To maintain code quality, stability, and traceability, critical branches are protected with rules that enforce the team’s workflow. These rules ensure that all contributions are reviewed, tested, and approved before being merged.

---

### Rules

1. **Protect `main` and `develop`**  
   - Direct pushes to these branches are **not allowed**.  
   - All changes must go through a pull request (PR).  

2. **Require PR Approvals**  
   - Every PR must be approved by **at least one other team member** before merging.  
   - For major features, consider requiring **two approvals**.  

3. **CI Validation Required**  
   - All PRs must pass automated continuous integration (CI) tests before merging.  
   - Failed tests block the merge until the issues are resolved.  

4. **Restrict Force Pushes**  
   - Force pushes are disallowed on `main` and `develop` to prevent accidental history rewrites.  

---

### Notes for the Team

- These rules ensure that critical branches are always stable and deployable.  
- PRs provide a mechanism for **collaborative code review**, knowledge sharing, and quality control.  
- CI validation guarantees that all tests pass before new code reaches integration or production.  
- Branch protection rules scale with the team, making onboarding and code governance easier as the team grows.


