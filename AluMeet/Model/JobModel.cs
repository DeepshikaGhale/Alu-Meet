using System;

namespace AluMeet.Model;

/// <summary>
/// Represents a job with details such as title, company name, location, description, and deadline.
/// </summary>
public class JobModel
{
    /// <summary>
    /// Gets or sets the id of the job.
    /// </summary>
    public string ID { get; set; }

    /// <summary>
    /// Gets or sets the title of the job.
    /// </summary>
    public string JobTitle { get; set; }

    /// <summary>
    /// Gets or sets the name of the company offering the job.
    /// </summary>
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or sets the location of the job.
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// Gets or sets the description of the job.
    /// </summary>
    public string JobDescription { get; set; }

    /// <summary>
    /// Gets or sets the deadline for applying to the job.
    /// </summary>
    public DateTime JobDeadline { get; set; }
}
