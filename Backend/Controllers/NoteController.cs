using System;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class NoteController : ControllerBase
{
    private readonly NoteService _noteService;

    public NoteController(NoteService noteService)
    {
        _noteService = noteService;
    }

    [HttpPost("note")]
    public IActionResult AddNote([FromBody] NoteDto noteDto)
    {
        Note note = new Note
        {
            Id = Guid.NewGuid(),
            SessionId = noteDto.SessionId,
            Name = noteDto.Name,
            StringNumber = noteDto.StringNumber,
            Fret = noteDto.Fret,
            Timestamp = noteDto.Timestamp,
            CreatedAt = DateTime.UtcNow
        };
        _noteService.Save(note);
        return Ok(noteDto); // send simplified JSON back to Unity
    }

    [HttpGet("all")]
    public IActionResult GetAllNotes()
    {
    var notes = _noteService.GetAllNotes();
    return Ok(notes);
    }
    
}