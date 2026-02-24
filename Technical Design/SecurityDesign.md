# Security Design

The Security Design chapter defines how the application protects user data, ensures system integrity, and mitigates potential threats.  
Since the current version of the application is single-player and offline, security requirements are intentionally lightweight. However, core protections are still implemented to ensure stability and data integrity.

---

## 1. Authentication & Authorization

### Current Scope (Single-Player Mode)

- Authentication is local only.
- Users are identified by `UserId` stored in local save data.
- No online authentication or role-based access control is required.
- Access to data is restricted to the currently active local user profile.

### Future Scope (If Online Features Are Added)

If an online leaderboard or cloud sync is introduced:

- Secure login system (email/password or OAuth provider).
- Password hashing using a secure algorithm (e.g., bcrypt).
- Token-based authentication (JWT or similar).
- Role-based access control (e.g., admin/moderator for leaderboard management).

---

## 2. Data Protection

### 2.1 Local Data Storage

User data is stored locally in:

```
SaveData/
 └── user_<UserId>/
      ├── progress.json
      ├── practice_sessions.json
      └── settings.json
```

### Protection Measures

- JSON schema validation before loading data.
- Defensive deserialization (null checks, type validation).
- Default fallback values if corrupted fields are detected.
- Automatic recreation of missing files.

### Optional Enhancements (If Required)

- Basic file checksum (SHA-256) to detect tampering.
- Lightweight encryption of save files.
- Version tagging in save files to support safe migrations.

---

## 3. Save File Integrity

To prevent crashes or corrupted runtime behavior:

- Validate all JSON before parsing.
- Reject malformed entries.
- Clamp numeric ranges (e.g., `Accuracy` must be between 0–100%).
- Validate arrays (e.g., `Strings[]` must contain exactly 6 elements).
- Handle missing or extra fields gracefully.

If corruption is detected:

- Log the error.
- Restore last valid state (if backup exists).
- Reset only the invalid portion instead of the entire profile.

---

## 4. Input Validation

All user input is validated before processing.

### Text Input (e.g., username, song names)

- Length limits.
- Character filtering.

### Numeric Values

- Range validation (e.g., fret numbers must be valid).

### Audio Input

- Ignore invalid pitch detection.
- Prevent buffer overflow or unexpected input size.

### Defensive Programming Ensures

- No crashes due to malformed input.
- No invalid database inserts.
- No invalid runtime state.

---

## 5. Threat Considerations

### 5.1 Single-Player Threat Model

Primary risks:

- Save file tampering.
- Corrupted JSON.
- Malformed input.
- Accidental data loss.

**Impact level:** Low  
(Users modifying their own progress does not affect other users.)

---

### 5.2 Future Online Leaderboard (If Implemented)

If competitive features are added, potential threats include:

- Score tampering.
- Fake progress uploads.
- Replay attacks.
- API abuse.

#### Mitigation Plan

- Server-side validation of score submissions.
- Signed score payloads.
- Rate limiting.
- Anti-cheat validation logic.
- Never trust client-side data.

---

## 6. Security Principles Applied

- **Least privilege** (only required data is accessible per user profile).
- **Fail-safe defaults** (invalid data is rejected).
- **Comprehensive input validation**.
- **Do not trust client data** (for future online model).

---

## Summary

For the current single-player version, security is intentionally lightweight and focuses on:

- Save file integrity.
- Defensive input validation.
- Protection against corrupted data.
- Stable deserialization.

If online functionality is introduced later, the security model will be extended to include authentication, server-side validation, and anti-tampering mechanisms.