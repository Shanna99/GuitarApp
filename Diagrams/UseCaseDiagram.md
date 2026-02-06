```mermaid


%% Use Case Diagram for a Guitar Learning Application
%% Mermaid syntax

%% Define the diagram type
usecaseDiagram

%% Actors
actor User
actor Instructor

%% Use cases
graph TD;
  User --> (View Lessons);
  User --> (Practice Exercises);
  User --> (Track Progress);
  User --> (Access Tips & Techniques);

  Instructor --> (Upload Lessons);
  Instructor --> (Review Student Progress);

%% Optional: System boundary
%% rectangle System {
%%     (View Lessons)
%%     (Practice Exercises)
%%     (Track Progress)
%%     (Access Tips & Techniques)
%%     (Upload Lessons)
%%     (Review Student Progress)
%% }


```
https://mermaid.live/
