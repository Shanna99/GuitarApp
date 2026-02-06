```mermaid

graph TD
    %% Actors
    User["User"]
    Instructor["Instructor"]

    %% Use cases
    ViewLessons["View Lessons"]
    PracticeExercises["Practice Exercises"]
    TrackProgress["Track Progress"]
    AccessTips["Access Tips & Techniques"]
    UploadLessons["Upload Lessons"]
    ReviewProgress["Review Student Progress"]

    %% User interactions
    User --> ViewLessons
    User --> PracticeExercises
    User --> TrackProgress
    User --> AccessTips

    %% Instructor interactions
    Instructor --> UploadLessons
    Instructor --> ReviewProgress



```
https://mermaid.live/
