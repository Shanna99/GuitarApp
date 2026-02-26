using System;
using System.Collections.Generic;
using Xunit;

public class NoteServiceTests
{
    [Fact]
    public void Save_ValidNote_AddsNoteToRepository()
    {
        // Arrange
        var repository = new NoteRepository();
        var service = new NoteService(repository);

        var note = new Note
        {
            Id = Guid.NewGuid(),
            SessionId = Guid.NewGuid(),
            Name = "E",
            StringNumber = 6,
            Fret = 0,
            Timestamp = 0f,
            CreatedAt = DateTime.UtcNow
        };

        // Act
        service.Save(note);
        var allNotes = service.GetAllNotes();

        // Assert
        Assert.Single(allNotes);
        Assert.Equal("E", allNotes[0].Name);
    }

    [Fact]
    public void Save_EmptyName_ThrowsArgumentException()
    {
        // Arrange
        var repository = new NoteRepository();
        var service = new NoteService(repository);

        var note = new Note
        {
            Id = Guid.NewGuid(),
            SessionId = Guid.NewGuid(),
            Name = "",
            StringNumber = 6,
            Fret = 0,
            Timestamp = 0f,
            CreatedAt = DateTime.UtcNow
        };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => service.Save(note));
    }
}