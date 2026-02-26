using System;

public class Note
{
    public Guid Id { get; set; }           // DB primary key
    public Guid SessionId { get; set; }
    public string Name { get; set; }
    public int StringNumber { get; set; }
    public int Fret { get; set; }
    public float Timestamp { get; set; }
    public DateTime CreatedAt { get; set; } // extra field not needed in client
}