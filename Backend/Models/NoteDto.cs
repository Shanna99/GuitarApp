using System;

public class NoteDto
{
    public Guid SessionId { get; set; }
    public string Name { get; set; }
    public int StringNumber { get; set; }
    public int Fret { get; set; }
    public float Timestamp { get; set; }
}