# User stories

This document describes all use cases implemented or planned for the MVP version of the application. Each use case includes a user story, acceptance criteria, and a use case scenario with preconditions, post-conditions, the main scenario, and exceptions/error handling. Currently, the application has only one user type: the User.

## Account

### Sign up

As a user I want to be able to create an account for the application so that I have my own environment

**Acceptance Criteria**

- User selects a role during sign-up (default: User for MVP)
- User must provide a valid email to create an account.
- User has to provide a password containing the four character sets
  - Numerical characters (e.g., 12345)
  - Lowercase letters (e.g., abcde)
  - Uppercase letters (e.g., ABCDE)
  - Special characters (e.g., !$%&?)
- The system rejects duplicate emails
- The system creates the account in an unconfirmed state.
- The system sends a confirmation email after a successful sign-up.
- The email contains a confirmation link
  - Clicking the link within 24h activates the account
  - User cannot log in before confirming the email
- After confirming, the account becomes active.
- After a successful sign-up, the system logs in the user automatically.
- Account creation persists data in the database.

| Use case scenario | |
| --- | --- |
| **Name** | Sign up |
| **Actor** | User |
| **Precondition** | Application is open |
| **Post-condition** | Actor has created an active account |
| **Main scenario** | 1. Actor clicks the "Sign up button <br> 2. Actor fills in all required information<br>3. Actor submits the form<br>4. Actor receives a confirmation email<br>5. Actor confirms account via email |
| **Exceptions** | 1. Actor does not fill in all required fields [Error message shown; form cannot be submitted]<br>2. Actor does not receive confirmation email [Option to resend confirmation email is shown after submitting the sign-up form]<br>3. Actor does not accept confirmation email within 24 hours [Account is deleted.] |


____________

### Log in
As a User, I want to log in to my account so that I can access my personal dashboard.

**Acceptance Criteria**
- Only existing accounts with correct email/password combinations can log in.
- Invalid credentials are rejected with an error message.
- Successful login redirects to role-specific dashboard (User → User dashboard).

| Use case scenario |  |
| --- | --- |
| **Name**| Log in|
| **Actor**| User |
| **Precondition** | Actor has to have existing account |
| **Post-condition**| Actor is logged in|
| **Main scenario** | 1. Actor opens log in screen <br> 2. Actor fills in email and password combination <br> 3. Actor clicks on Log in button  |
| **Exceptions**| 1. Email and password combination does not exist [Error message; Email and password combination not found. ] |
____________

### Log out
As a User, I want the ability to log out, so I can safely leave the application when I’m done.

**Acceptance Criteria**
- Clicking “Log Out” ends the session immediately.
- Logged-out users cannot access protected pages.
- After logging out, the user is redirected to the login page. 

| Use case scenario |  |
| --- | --- |
| **Name**| Log out|
| **Actor**| User |
| **Precondition** | Actor is logged in |
| **Post-condition**| Actor is logged out|
| **Main scenario** | 1. Actor clicks on log out button |
| **Exceptions**| 1. Session has already expired [User is redirected to login page with a message “Session expired, please log in again”] |
____________

### Reset password

As a User, I want to be able to reset my password, so I can regain access if I forget it.

**Acceptance Criteria**

- Email-address must belong to an existing user.
- User receives an email to reset password
- Reset link in the email is valid for 15 minutes.
- User has to provide a password containing the four character sets
  - Numerical characters (e.g., 12345)
  - Lowercase letters (e.g., abcde)
  - Uppercase letters (e.g., ABCDE)
  - Special characters (e.g., !$%&?)


| Use case scenario |  |
| --- | --- |
| **Name**| Reset password|
| **Actor**| User |
| **Precondition** | Application open|
| **Post-condition**| Actor is logged in with a new password|
| **Main scenario** | 1. Actor clicks on "Reset password" <br> 2. Actor enters their email address <br> 3. Actor receives email with link to reset password <br> 4. Actor clicks link in email to reset password. <br> 5. Actor is redirected to the reset password screen <br> 6. Actor enters a new password following the password rules <br> 7. Actor submits form. <br> 8. Actor is logged in automatically|
| **Exceptions**| 1. Email address does not exist [Error message: "Email not found"] <br> 2. Reset link expires [Error message: "Link expired, please request a new password reset"] <br> 3. Password does not meet requirements [Error message: "Password does not meet security requirements"]|

## Connect guitar to application

### Connect guitar
As a User, I want to connect my guitar to the audio interface used by the application so that the app can receive my guitar signal.

**Acceptance Criteria**
- The app detects a guitar plugged into the audio interface.
- The connection status is continuously displayed as “Connected” only when a signal is present.
- The app supports one connection at a time in MVP.
- Architecture allows adding wireless support in the future.


| Use case scenario |  |
| --- | --- |
| **Name**| Connect guitar|
| **Actor**| User |
| **Precondition** | Actor is logged into the app |
| **Post-condition**| Guitar input is available for use within the application |
| **Main scenario** | 1. Actor connects the guitar to the audio interface using a cable. <br> 2. The system detects the audio interface and incoming guitar signal. <br> 3. The system updates the connection status to “Connected” and displays a visual notification confirming the connection. <br> 4. Actor receives a notification if guitar is connected|
| **Exceptions**| 1. No signal detected: The guitar is connected, but no audio signal is detected [Error message: “No input signal detected” and connection status remains “Disconnected”] <br> 2. Guitar does not connect [The system displays an error message and the connection fails. ] |

____________

## Audio Recognition

### Detect Strings
**User Story:**  
As a User, I want the app to detect which string I am playing so that I can see whether I am playing the correct string.

**Acceptance Criteria**
- The app highlights the string being played.
- Only one string can be detected at a time (MVP).
- If no string is played, no string is highlighted.
- The system ignores noise or signals outside guitar range.
- The highlight disappears after 2 sec or when another string is played.

| Use case scenario |  |
| --- | --- |
| **Name**| Detect Strings|
| **Actor**| User |
| **Precondition** |Guitar is connected  |
| **Post-condition**| The string being played is highlighted in the application |
| **Main scenario** | 1. Actor plays a string on the guitar <br> 2. Audio interface detects the signal from the string played <br> 3. The application highlights the string being played in the UI and notifies the actor of the detected string.  |
| **Exceptions**| 1. Audio interface does not detect signal [Error message: "No input detected"] <br> 2. Application does not notify actor [Error message: "Detection failed"] |


____________

### Detect Notes
**User Story:**  
As a User, I want the app to recognize the note I am playing so that I know whether it is correct

**Acceptance Criteria**
- The app displays the note name corresponding to the detected frequency.
- Detection is considered correct if the frequency is within ±1 semitone of the target note.
- Notes outside the detection range are ignored.
- The app displays the detected note in the UI and provides feedback to the actor.
- The system handles multiple quick notes (e.g., hammer-ons) correctly
- Notes detected are logged for practice statistics
- System ignores noise or other instruments.

| Use case scenario |  |
| --- | --- |
| **Name**| Detect Notes |
| **Actor**| User |
| **Precondition** | Guitar is connected  |
| **Post-condition**| The note being played is displayed in the application|
| **Main scenario** | 1. Actor plays a note on the guitar <br> 2. Audio interface detects the signal from the note played <br> 3. The app displays the detected note in the UI and provides visual feedback to the actor |
| **Exceptions**| 1. Audio interface does not detect signal [Error message:"No input detected"] <br> 2. Application does not notify actor [Error message:"Detection failed"] |


____________


### Detect Basic Chords
**User Story:**  
As a User, I want the app to recognize basic open chords so that I can practice chord accuracy.

**Acceptance Criteria**
- Only basic open chords (E, A, D, G, C Major, and Em, Am, Dm) are detected in MVP.
- The system displays the chord only when it detects all notes of the chord simultaneously.
- Partial chords (missing notes) are indicated as “incorrect.”
- Detect chords even if slight timing differences exist between strings (tolerance ±50ms per string)

| Use case scenario |  |
| --- | --- |
| **Name**| Detect Basic Chords|
| **Actor**| User |
| **Precondition** | Guitar is connected |
| **Post-condition**| The detected chord is displayed in the application if correct; partial chords are indicated as incorrect.|
| **Main scenario** | 1. Actor plays a chord on the guitar <br> 2. Audio interface detects the signal from the chord played <br> 3. The application displays the detected chord in the UI; if the chord is correct, it is marked as correct, otherwise it is marked as incorrect. |
| **Exceptions**| 1. Audio interface does not detect signal [Error message: "No input detected"] <br> 2. Application does not notify actor [Error message: "Detection failed"] |


