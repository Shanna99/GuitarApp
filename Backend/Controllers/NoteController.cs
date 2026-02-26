using System;
using Microsoft.AspNetCore.Mvc;


[HttpPost("note")]
public IActionResult AddNote([FromBody] NoteDto note)
{
    Console.WriteLine($"Received note: {note.Name} on string {note.StringNumber}");
    return Ok(note);
}