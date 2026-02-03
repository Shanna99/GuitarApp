# User stories

Define and prioritize user stories for the MVP. Include user role, goal, and benefit, with clear acceptance criteria for each story. Focus on core features needed for initial release.

## Account

### Sign up
As a guitarist I want to be able to create an account for the application so that i have my own enviorment

**Acceptance Criteria**
- User must provide a valid email create an account.
- User has to provide a password container the four character sets
    - Numerical characters such as 12345
    - Lowercase letters such as abcde
    - Uppercase letters such as ABCDE
    - Special characters such as !$%&?
- Duplicate emails are rejected.
- An account is created in an unconfirmed state
- A confirmation email is sent after successful sign-up
- The email contains a confirmation link
    - Clicking the link within 24h activates the account
    - User cannot log in before confirming the email
- The account becomes active when the link is confirmed
- After successful sign-up, the user is automatically logged in.
- Account creation persists data in the database.

| Use case scenario |  |
|------------------|--|
| **Name** | Sign up |
| **Actor** | Guitarist |
| **Precondition** | Application is open |
| **Postcondition** | Actor has created an active account |
| **Main scenario** | 1. Actor clicks the "Sign up" button<br>2. Actor fills in all required information<br>3. Actor submits the form<br>4. Actor receives a confirmation email<br>5. Actor confirms account via email |
| **Exceptions** | 1. Actor does not fill in all required fields [Error message shown; form cannot be submitted]<br>2. Actor does not receive confirmation email [Option to resend confirmation email is shown after submitting the sign-up form]<br>3. Actor does not accept confirmation email within 24 hours [Account is deleted] |


____________

### Log in
As a guitarist, I want to be able to log in to the application so that I can access my account.

**Acceptance Criteria**
- Only existing accounts with correct email/password combinations can log in.
- Invalid credentials are rejected with an error message.
- Successful login redirects the user to the dashboard.

| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |
____________

### Log out
As a guitarist, I want the ability to log out so I can safely leave the application when I’m done.

**Acceptance Criteria**
- Clicking “Log Out” ends the session immediately.
- Logged-out users cannot access protected pages.

| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |
____________

### Reset password
As a guitarist, I want to be able to reset my password so I can regain access if I forget it.

**Acceptance Criteria**
- ..
-..


| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |


### Stay logged in
As a guitarist, I want to stay logged in between sessions so I don’t have to log in every time.

**Acceptance Criteria**
- ..
-..


| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |
____________

## Conect guitar to application

### Connect guitar
As a guitarist, I want to connect my guitar to the application so that the app can receive my guitar signal.

**Acceptance Criteria**
- The app detects a guitar plugged into the audio interface.
- The connection status is displayed as “Connected” only when a signal is present.
- The app supports one connection at a time in MVP.
- Architecture allows adding wireless support in the future.


| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |
____________

### Reponse conected
As a guitarist i want to get a noticifaction that my guitar is connected to the application so i know there is a connection

**Acceptance Criteria**
- When the guitar connects, a notification is shown immediately.
- Notifications disappear automatically after 3–5 seconds.


| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |
____________

### Response Disconected
As a guitarist i want to get a noticifaction that my guitar is disconnected to the application so i know the connection is broken.

**Acceptance Criteria**
- When the guitar disconnects, a notification is shown immediately.
- Notifications disappear automatically after 3–5 seconds.


| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |
____________

### Connection status indicator
As a guitarist, I want to see the current connection status of my guitar so I always know whether it’s connected.

**Acceptance Criteria**
- ..
-..


| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |
____________

### Detect cable connection
As a guitarist, I want the application to detect when my guitar cable is plugged in so that I know the guitar is available.

**Acceptance Criteria**
- ..
-..


| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |

## Audio Recognition

### Detect Strings
**User Story:**  
As a guitarist, I want the app to detect which string I am playing so that I can see if I am hitting the correct string.

**Acceptance Criteria**
- The app highlights the string being played
- Only one string can be detected at a time (MVP).
- If no string is played, no string is highlighted.

| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |


____________

### Detect Notes
**User Story:**  
As a guitarist, I want the app to recognize the note I am playing so that I know if it is correct.

**Acceptance Criteria**
- The app displays the note name corresponding to the detected frequency.
- Detection is considered correct if the frequency is within ±1 semitone of the target note.
- Notes outside the detection range are ignored.

| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |


____________


### Detect Basic Chords
**User Story:**  
As a guitarist, I want the app to recognize basic open chords so that I can practice chord accuracy.

**Acceptance Criteria**
- Only basic open chords (E, A, D, G, C Major, and Em, Am, Dm) are detected in MVP.
- The chord is displayed only if all notes of the chord are detected simultaneously.
- Partial chords (missing notes) are indicated as “incorrect.”

| Use case scenario |  |
| --- | --- |
| **Name**| ..|
| **Actor**|.. |
| **Precondition** |.. |
| **Postcondition**| ..|
| **Main scenario** | .. |
| **Exceptions**| .. |


