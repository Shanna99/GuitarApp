using System.Collections.Generic;

public class NoteService
{
    private readonly NoteRepository _noteRepository;

    public NoteService(NoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }

    public void Save(Note note)
    {
        // Optional: add business logic here, e.g., validate note
        if (string.IsNullOrEmpty(note.Name))
            throw new System.ArgumentException("Note name cannot be empty");

        _noteRepository.Add(note);
    }

    public List<Note> GetAllNotes()
    {
        return _noteRepository.GetAll();
    }

    
}