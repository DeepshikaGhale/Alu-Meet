using System;
namespace AluMeet.Model;


/// <summary>
/// The AlumniModel class represents an individual alumni entity in the application.
/// It contains properties to store and retrieve information such as the alumni's ID, name,
/// graduation year, contact details, twitter profile, facebook profile, linkedIn profile,
/// email, current employer, profile picture, and current position.
/// </summary>
public class AlumniModel
{
    /// <summary>
    /// Gets or sets the ID of the alumni.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the ProgramStudied of the alumni.
    /// </summary>
    public string ProgramStudied { get; set; }

    /// <summary>
    /// Gets or sets the name of the alumni.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the graduation year of the alumni.
    /// </summary>
    public int GraduationYear { get; set; }

    /// <summary>
    /// Gets or sets the contact details of the alumni.
    /// </summary>
    public string ContactDetails { get; set; }

    /// <summary>
    /// Gets or sets the current employer of the alumni.
    /// </summary>
    public string CurrentEmployer { get; set; }

    /// <summary>
    /// Gets or sets the current position of the alumni.
    /// </summary>
    public string CurrentPosition { get; set; }

    /// <summary>
    /// Gets or sets the email of the alumni.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the twitter handle of the alumni.
    /// </summary>
    public string TwitterHandle { get; set; }

    /// <summary>
    /// Gets or sets the facebook profile url of the alumni.
    /// </summary>
    public string FacebookHandle { get; set; }

    /// <summary>
    /// Gets or sets the linkedIn profile url of the alumni.
    /// </summary>
    public string LinkedInHandle { get; set; }

    /// <summary>
    /// Gets or sets the profile picture of the alumni.
    /// </summary>
    public string ProfilePicture { get; set; }

}
