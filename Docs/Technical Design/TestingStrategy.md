# Testing Strategy

The Testing Strategy defines how the system is verified to ensure correctness, stability, and performance.  
Testing is conducted after the system design is fully defined and core architecture decisions are finalized.

The application uses a combination of automated and manual testing approaches.

---

## 1. Types of Testing

### 1.1 Unit Testing

Unit tests validate isolated components of core logic without external dependencies.

**Focus Areas:**

- Scoring calculations
- Accuracy percentage computation
- Highest streak tracking
- Note timing validation logic
- Input validation functions
- Data parsing and validation methods

**Goal:**  
Ensure that core gameplay logic produces correct and predictable results.

Unit tests are fast, repeatable, and run automatically during development.

---

### 1.2 Integration Testing

Integration tests verify interaction between components.

**Examples:**

- Practice session → Progress update
- Song loading → Audio playback initialization
- JSON save loading → Runtime model mapping
- Note detection → Score calculation pipeline

**Goal:**  
Ensure that system components work correctly together.

---

### 1.3 Play Mode Tests (Unity)

Play Mode tests validate behavior during runtime in the Unity engine.

**Examples:**

- Scene loading transitions
- Audio playback synchronization
- Note spawning timing
- UI updates during practice session

**Goal:**  
Ensure runtime systems behave correctly under realistic conditions.

---

### 1.4 End-to-End (E2E) Testing

End-to-end testing validates complete user flows.

**Example Flow:**

1. Select user profile
2. Choose song
3. Start practice session
4. Complete session
5. Save progress
6. Return to main menu
7. Reload progress successfully

**Goal:**  
Confirm that the entire gameplay loop functions without failure.

---

## 2. Branch Testing Policy

### Develop Branch

- All unit tests must pass.
- Play Mode tests must pass.
- New features must include relevant tests.
- Manual testing required before merge.

Develop branch is used for active feature development and validation.

---

### Main Branch

- Only stable, fully tested builds are merged.
- All automated tests must pass.
- No known critical bugs.
- Performance verified.

Main branch represents production-ready code.

---

## 3. Coverage Expectations

Test coverage measures the percentage of code executed during automated tests. Higher coverage provides greater confidence in system correctness and stability.

| Coverage | Meaning                  |
| -------- | ------------------------ |
| 50%      | Low                      |
| 70%      | Acceptable               |
| 80%+     | Strong                   |
| 90%+     | Very strong (core logic) |

Coverage targets for GuitarApp:

- **Core gameplay logic:** Very strong coverage ≥90% (scoring, accuracy, streak tracking)  
- **Utility and validation functions:** Strong coverage ≥80%  
- **UI logic:** Acceptable coverage ≥70%  
- **Engine-dependent features:** Covered via Play Mode tests  

Priority is given to testing deterministic logic, ensuring critical gameplay mechanics are thoroughly verified.

---

## 4. Manual Play Testing Checklist

Manual testing ensures realistic gameplay validation.

### Checklist:

- [ ] Start new user profile
- [ ] Load existing user profile
- [ ] Select and load a song
- [ ] Play full session without errors
- [ ] Pause and resume session
- [ ] Complete session and verify progress updates
- [ ] Restart application and confirm save persistence
- [ ] Test invalid or missing save files
- [ ] Switch between multiple songs
- [ ] Rapidly restart sessions

Manual play testing validates usability and real-time stability.

---

## 5. Edge Case Testing

Edge cases are tested to ensure system robustness.

### Examples:

- Extremely fast note sequences
- Very long practice sessions
- Empty song data
- Missing audio file
- Corrupted JSON save file
- Maximum streak scenarios
- Accuracy values at 0% and 100%

The system must handle edge cases without crashing or corrupting data.

---

## 6. Performance Testing

Performance testing ensures smooth gameplay under heavy load.

### Stress Test Scenarios:

- Rapid note spawning ("note spam")
- High-frequency audio input
- Long sessions (extended runtime)
- Multiple consecutive sessions without restart

Metrics observed:

- Frame rate stability
- Memory usage
- Garbage collection spikes
- Audio latency

The system must maintain stable performance without frame drops or memory leaks.

---

## 7. Testing Philosophy

The testing approach follows these principles:

- Test critical logic early.
- Automate repeatable tests.
- Validate real gameplay behavior.
- Prioritize stability over feature quantity.
- Catch regressions before merging to main.

---

## Summary

The testing strategy combines:

- Unit testing for core logic
- Integration testing for system interactions
- Play Mode testing for runtime behavior
- End-to-end flow validation
- Manual play testing
- Edge case and stress testing

This layered approach ensures correctness, resilience, and performance across the entire application lifecycle.