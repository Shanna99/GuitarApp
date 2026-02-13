# System Architecture

## Architecture Overview

The **Guitar Learning App** is designed as a **modular, scalable, and cross-platform application** with a clear separation between frontend and backend responsibilities.

- **Frontend (Unity/C#):** Handles audio input, real-time note and chord recognition, user interface, and user feedback.  
- **Backend (ASP.NET Core / C#):** Manages account authentication, session persistence, practice statistics, and optional future cloud features.  
- **Database (SQL Server):** Stores structured user data such as accounts, session history, and practice statistics.  

The architecture follows **component-based design principles** and leverages design patterns to maintain modularity and scalability:

- **State Pattern:** Manages application flow (Login, Dashboard, Practice Mode, Results).  
- **Observer/Event Pattern:** Allows decoupled communication between systems (e.g., audio input → note detection → UI feedback).  
- **Strategy Pattern:** Supports difficulty and detection tuning (e.g., tolerance thresholds for note/chord recognition).  
- **Factory + Object Pooling:** Optimizes creation and reuse of audio feedback objects, UI indicators, and note representations.  

> This architecture ensures the MVP can evolve into a full-featured, multi-platform guitar-learning platform with minimal refactoring.

---

## Example Workflow – Detecting a Chord

1. **User plays a chord** → GuitarInputManager captures the signal.  
2. **AudioProcessingSystem** performs real-time frequency analysis.  
3. **NoteDetectionSystem** identifies individual notes; **ChordDetectionSystem** evaluates if the combination matches a valid chord.  
4. **FeedbackManager** updates the UI: correct chord → green highlight, incorrect → red highlight.  
5. **PracticeLogger** records detection results for statistics.  
6. **Observer Pattern** ensures all systems receive updates without tight coupling.  

> This decoupling allows systems to evolve independently, such as adding wireless guitar support or advanced chord libraries in future releases.

---

## Simplified Component Diagram

```text
          +----------------------+
          |      GameManager     | <- State Pattern
          +----------------------+
                     |
     ---------------------------------------
     |            |           |            |
AccountManager   Practice   GuitarInput   Backend API
                 Logger      Manager       (ASP.NET Core)
                                |
                         AudioProcessingSystem
                                |
       ------------------------------------------------
       |                     |                        |
  StringDetection        NoteDetection           ChordDetection
       |                     |                        |
       --------------------->|<-----------------------
                                |
                         FeedbackManager
                                |
                               UI
```

## Technology Choices Rationale

- **Unity/C#:** Cross-platform frontend, high-quality audio handling, scalable to consoles and mobile.  
- **ASP.NET Core/C#:** Lightweight, performant backend API for authentication, data persistence, and statistics management.  
- **SQL Server (Azure):** Structured storage for user accounts, session history, and progress data.  
- **NWaves / Unity Audio:** Efficient real-time audio processing (FFT, pitch detection, filters) for detecting strings, notes, and chords.  
- **Design Patterns:**  
  - **State:** Organizes application flow.  
  - **Observer:** Decouples detection, feedback, and logging.  
  - **Strategy:** Enables flexible detection rules (tolerance, difficulty).  
  - **Factory/Object Pool:** Optimizes performance for UI/audio objects.  
- **Cloud Hosting (Azure free tier):** Simplifies deployment and future scaling, with managed SQL and App Service.

---

## Scalability & Extensibility

The architecture is designed to support:

- Wireless guitar support (future feature)  
- Expanded chord libraries and advanced notes detection  
- Additional difficulty levels or practice modes  
- Multi-platform builds (PC, consoles, mobile)  
- Advanced analytics (via optional NoSQL database or Redis caching)  

> The modular design ensures new systems can be added with minimal impact on existing code.
