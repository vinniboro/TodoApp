using System;
using System.Collections.Generic;
using System.IO;
using TodoReminder.Enums;

namespace TodoReminder
{
    class FileManager
    {
        private const string fileVersionToken = "TodoApp";
        private const double fileVersionNr = 1.0;

    /// <summary>
    /// Saves a list of tasks to a text file
    /// </summary>
    /// <param name="taskList">The task list to save</param>
    /// <param name="fileName">The file name to save to</param>
    /// <returns>True if saving was successful, false otherwise</returns>
    /// <exception cref="Exception">Thrown if an I/O error occurs</exception>
    public bool SaveTaskListToFile(List<Task> taskList, string fileName)
    {
    try
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            // Write file version information
            writer.WriteLine(fileVersionToken); // Specify the file version token
            writer.WriteLine(fileVersionNr); // Write the file version number
            writer.WriteLine(taskList.Count); // Write the number of tasks in the list

            // Iterate through each task and save its properties
            foreach (Task task in taskList)
            {
                // Save the task description
                writer.WriteLine(task.Description);
                writer.WriteLine(task.Priority.ToString()); // Write the task priority as a string
                writer.WriteLine(task.Date.ToString("yyyy-MM-dd HH:mm:ss")); // Write the task due date in a specific format
            }
        }

        return true; // Indicate successful saving
    }
    catch (Exception)
    {
        // Handle I/O errors and return false
        return false;
    }
}


/// <summary>
/// Reads a list of tasks from a text file
/// </summary>
/// <param name="taskList">The list to store the read tasks</param>
/// <param name="fileName">The file name to read from</param>
/// <returns>True if reading was successful, false otherwise</returns>
/// <exception cref="Exception">Thrown if an I/O error occurs</exception>
public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
{
    try
    {
        // Clear the existing task list
        taskList.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            // Read file version information
            string versionTest = reader.ReadLine(); // Read the first line containing the file version token
            double version = double.Parse(reader.ReadLine()); // Read the second line containing the file version number

            // Check if the file version matches the expected version
            if (versionTest == fileVersionToken && version == fileVersionNr)
            {
                int count = int.Parse(reader.ReadLine()); // Read the number of tasks from the file

                // Iterate through each task in the file
                for (int i = 0; i < count; i++)
                {
                    Task task = new Task(); // Create a new task object

                    task.Description = reader.ReadLine(); // Read the task description from the file

                    string priorityStr = reader.ReadLine(); // Read the task priority string
                    task.Priority = (PrioType)Enum.Parse(typeof(PrioType), priorityStr); // Convert the priority string to a priority enum value

                    string dueDateStr = reader.ReadLine(); // Read the task due date string
                    task.Date = DateTime.ParseExact(dueDateStr, "yyyy-MM-dd HH:mm:ss", null); // Convert the due date string to a DateTime object

                    // Add the task to the list
                    taskList.Add(task); // Add the task object to the task list
                }
            }
            else
            {
                // Cancel reading if the file version does not match
                return false;
            }
        }

        return true; // Indicate successful reading
    }
    catch (Exception)
    {
        // Handle I/O errors and return false
        return false;
    }

    }
}
}