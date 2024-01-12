using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoReminder.Enums;



namespace TodoReminder
{


/// <summary>
/// Represents a task with a description, a due date, and a priority.
/// </summary>
public class Task
{
    private DateTime date;
    private string description;
    private PrioType priority;

    /// <summary>
    /// Initializes a new `Task` object with the default values for date and priority
    /// The `date` is set to the current date and the `priority` is set to `Normal`
    /// </summary>
    public Task()
    {
        date = DateTime.Now; // Set default date to current date
        priority = PrioType.Normal; // Set default priority to Normal
    }

    /// <summary>
    /// Initializes a new `Task` object with the specified `date` value
    /// </summary>
    /// <param name="taskDate">The task's due date.</param>
    /// <remarks>
    /// This constructor calls the constructor with four parameters, passing the `date` value and the default values for `description` and `priority`
    /// </remarks>
    public Task(DateTime taskDate) : this(taskDate, string.Empty, PrioType.Normal)
    {
    }

    /// <summary>
    /// Initializes a new `Task` object with the specified values for `date`, `description`, and `priority`
    /// </summary>
    /// <param name="taskDate">The task's due date.</param>
    /// <param name="description">The task's description.</param>
    /// <param name="priority">The task's priority.</param>
    public Task(DateTime taskDate, string description, PrioType priority)
    {
        this.date = taskDate; // Initialize date with specified value
        this.description = description; // Initialize description with specified value
        this.priority = priority; // Set priority to specified value
    }

    /// <summary>
    /// Gets or sets the task's description
    /// </summary>
    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.description = value;
            }
        }
    }

    /// <summary>
    /// Gets or sets the task's due date
    /// </summary>
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    /// <summary>
    /// Gets or sets the task's date and time
    /// </summary>
    public DateTime DateAndTime
    {
        get { return date; }
        set { date = value; }
    }

    /// <summary>
    /// Gets the task's priority as a string
    /// </summary>
    /// <returns>A string representation of the task's priority</returns>
    public string GetPriorityString()
    {
        string txtOut = Enum.GetName(typeof(PrioType), priority);
        txtOut = txtOut.Replace("_", " ");
        return txtOut;
    }

    /// <summary>
    /// Gets the task's date in format
    /// </summary>
    /// <returns>A string representation of the task's date</returns>
    public string getTimeString()
    {
        return date.ToLongDateString();
    }

    /// <summary>
    /// String to epresentation of the task
    /// </summary>
    /// <returns>A string representation of the task</returns>
    public override string ToString()
    {
        string textOut = $"{date.ToLongDateString(),-20} {date.ToString("HH:mm"),-8}" + $"{GetPriorityString(),16} {description,20}";

            return textOut;
        }

    }
}
