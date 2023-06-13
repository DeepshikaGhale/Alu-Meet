using System;

namespace AluMeet.Model;

/// <summary>
/// Represents an event with details such as ID, title, location, date, time, and description.
/// </summary>
public class EventModel
{
    /// <summary>
    /// Gets or sets the unique identifier of the event.
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Gets or sets the title of the event.
    /// </summary>
    public string EventTitle { get; set; }

    /// <summary>
    /// Gets or sets the location of the event.
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// Gets or sets the date of the event.
    /// </summary>
    public DateTime DateOfEvent { get; set; }

    /// <summary>
    /// Gets or sets the time of the event.
    /// </summary>
    public string TimeOfEvent { get; set; }

    /// <summary>
    /// Gets or sets the description of the event.
    /// </summary>
    public string Description { get; set; }
}
