# Non-Functional Requirements 

Non-functional requirements describe how a system should behave. They define things like speed, security, reliability, usability, and scalability.


- **Performance**
  - The app should respond to user actions within 2 seconds.
  - Provide real-time feedback (<2s latency).

- **Security**
  - User credentials (account info, passwords) must be stored securely.
  - All password data must be encrypted.

- **Reliability & Availability**
  - The app should handle input from the guitar without crashing.
  - Sessions should not lose user progress unexpectedly.

- **Scalability**
  - Architecture should allow easy addition of new features like lesson tracking or multiple instruments.

- **Usability**
  - Simple, beginner-friendly interface.

- **Maintainability**
  - Code should follow code conventions described in [Code Conventions](../Technical%20Design/CodeConventions.md).
  - Code should be modular for future feature additions.

- **Compatibility**
  - Works on target platforms. 

- **Portability**
  - Easy to run on different machines without complex setup.

