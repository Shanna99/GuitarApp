using System;
using System.Collections.Generic;

public class NoteRepository
{
    // For now, we can just use an in-memory list
    private readonly List<Note> _notes = new List<Note>();

    // Add a note
    public void Add(Note note)
    {
        _notes.Add(note);
    }

    // Get all notes
    public List<Note> GetAll()
    {
        return _notes;
    }

    // Optional: find by session
    public List<Note> GetBySessionId(Guid sessionId)
    {
        return _notes.FindAll(n => n.SessionId == sessionId);
    }
}