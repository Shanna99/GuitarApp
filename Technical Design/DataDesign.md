# Data Design

The Data Design chapter defines **how data is structured, stored, and accessed** across the application. Data models support the system architecture, ensuring consistency and scalability.

---

## Database Schema

- **Type:** SQL Server (relational)  
- **Purpose:** Store user accounts, practice history, progress tracking, and song metadata  
- **Tables:**  
  - `Users` – user profiles, login info, preferences  
  - `Songs` – song metadata, tuning, difficulty, and versioning  
  - `PracticeSessions` – individual practice session records  
  - `Notes` – detected notes during a session  
  - `Chords` – detected chords during a session  
  - `Progress` – aggregates and statistics per user  

> Relationships between tables are shown in the ER diagram below.

### Example ER Diagram


```text
+----------------+        +--------------------+
|     Users      | 1    n |  PracticeSessions  |
|----------------|--------|-------------------|
| UserId PK      |        | SessionId PK       |
| Name           |        | UserId FK          |
| Email          |        | SongId FK          |
| ...            |        | DatePlayed         |
+----------------+        +-------------------+
                               |
                               | 1
                               |
                               n
                    +----------------+     +----------------+
                    |      Notes     |     |     Chords     |
                    |----------------|     |----------------|
                    | NoteId PK      |     | ChordId PK     |
                    | SessionId FK   |     | SessionId FK   |
                    | Time           |     | Time           |
                    | String         |     | Strings[]      |
                    | Fret           |     | Name           |
                    | Velocity       |     | Fingering[]    |
                    +----------------+     +----------------+

+----------------+
|     Songs      |
|----------------|
| SongId PK      |
| Title          |
| Artist         |
| Tuning         |
| Difficulty     |
+----------------+
       |
       | 1
       |
       n
+----------------+
|   Progress     |
|----------------|
| ProgressId PK  |
| UserId FK      |
| SongId FK      |
| LastPlayed     |
| Accuracy       |
| HighestStreak  |
| TotalPracticeTime |
+----------------+
```
#### Notes
- `1..n` **means on-to-many relationship**
- `FK` = Foreign Key, `PK` = Primary Key


## Data formats

### Song data

- **Format:** ScriptableObject in Unity for runtime use. JSON for storage or import/export
- Filed: 
  - Song ID / Name
  - Artist
  - Tuning
  - Difficulty (enum: Beginner, intermediate, Advanced)
  - Note sequence
  - Chord sequence

### Note Structure 
```json
{
  "Time": 12.34,      // timestamp in seconds
  "String": 3,        // string number
  "Fret": 5,          // fret number
  "Velocity": 0.8     // strength / intensity
}
```


### Chord Structure
```json
{
  "Time": 15.67,
  "Strings": [0,3,2,0,1,0], // open or fretted strings
  "Name": "Cmaj",
  "Fingering": [0,3,2,0,1,0]
}
```

### Player Progress Model

- Tracks progress per user for each song and practice session
- Fields:
  - UserId
  - SongId
  - LastPlayed
  - Accuracy (percentage)
  - HighestStreak
  - TotalPracticeTime

### Save File Structue

SaveData/
 └── user_<UserId>/
      ├── progress.json
      ├── practice_sessions.json
      └── settings.json


### Indexes & Optimization
- Primary keys on all tables (UserId, SongId, SessionId, etc)
- Foreign Keys to enforce realtionships
- Optional indexes on SongId, UserId for faster queries on progress and sessions

### Notes
- **Architecture comes before data:** data sctructures are defined to support the app flow (frontend input, audio processing, session tracking)
- Use **ScriptableObjects** for in-memomry song and note data for efficiency in Unity
- Use **JSON** for persistence and portibiltiy of user data
- Maintain **consistent naming conventions** between database and Unity data models