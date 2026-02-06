%% Use Case Diagram for Guitar Learning Application

%% Mermaid uses "usecaseDiagram" without spaces
%% Use "actor" and "usecase" properly

%% Define actors
actor User
actor Instructor

%% Define use cases
usecase "View Lessons" as UC1
usecase "Practice Exercises" as UC2
usecase "Track Progress" as UC3
usecase "Access Tips & Techniques" as UC4
usecase "Upload Lessons" as UC5
usecase "Review Student Progress" as UC6

%% Link actors to use cases
User --> UC1
User --> UC2
User --> UC3
User --> UC4

Instructor --> UC5
Instructor --> UC6

