# User stories

Define and prioritize user stories for the MVP. Include user role, goal, and benefit, with clear acceptance criteria for each story. Focus on core features needed for initial release.

## Account

### Sign up
As a guitarist I want to be able to create an account for the application so that i have my own enviorment

**Acceptance Criteria**
- User must be on Sign Up page
- User must provide a valid email create an account.
- User has to provide a password container the four character sets
    - Numerical characters such as 12345
    - Lowercase letters such as abcde
    - Uppercase letters such as ABCDE
    - Special characters such as !$%&?
- Duplicate emails are rejected.
- After successful sign-up, the user is automatically logged in.
- Account creation persists data in the database.
____________

### Log in
As a guitarist, I want to be able to log in to the application so that I can access my account.

**Acceptance Criteria**
- Only existing accounts with correct email/password combinations can log in.
- Invalid credentials are rejected with an error message.
- Successful login redirects the user to the dashboard.
____________

### Log out
As a guitarist, I want the ability to log out so I can safely leave the application when I’m done.

**Acceptance Criteria**
- Clicking “Log Out” ends the session immediately.
- Logged-out users cannot access protected pages.
____________

### Reset password
As a guitarist, I want to be able to reset my password so I can regain access if I forget it.


### Stay logged in
As a guitarist, I want to stay logged in between sessions so I don’t have to log in every time.
____________

## Conect guitar to application

### Connect guitar
As a guitarist, I want to connect my guitar to the application so that the app can receive my guitar signal.

**Acceptance Criteria:**
- The connection architecture must allow future support for wireless guitar connections.
- ..
____________

### Reponse conected
As a guitarist i want to get a noticifaction that my guitar is connected to the application so i know there is a connection
____________

### Response Disconected
As a guitarist i want to get a noticifaction that my guitar is disconnected to the application so i know the connection is broken.
____________

### Connection status indicator
As a guitarist, I want to see the current connection status of my guitar so I always know whether it’s connected.
____________

### Detect cable connection
As a guitarist, I want the application to detect when my guitar cable is plugged in so that I know the guitar is available.



