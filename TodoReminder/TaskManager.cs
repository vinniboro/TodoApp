using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoReminder.Enums;
namespace TodoReminder
{
    /// <summary>
    /// Manages list of Task objects and provides methods to manipulate the list
    /// </summary>
    public class TaskManager
    {
        /// <summary>
        /// Store a list of tasks
        /// </summary>
        private List<Task> taskList;

        /// <summary>
        /// Creates an instance of TaskManager and initializes the taskList
        /// </summary>
        public TaskManager()
        {
            taskList = new List<Task>();
        }

        /// <summary>
        /// Retrieves a task at a specified index
        /// </summary>
        /// <param name="index">The index of the task to retrieve</param>
        /// <returns>The task at the specified index, or null if the index is invalid</returns>
        public Task GetTask(int index)
        {
            if (CheckIndex(index))
                return taskList[index];
            else
                return null;
        }

        /// <summary>
        /// Adds a new task to the list
        /// </summary>
        /// <param name="newTask">The task to be added</param>
        /// <returns>True if the task was added successfully, false otherwise</returns>
        public bool AddNewTask(Task newTask)
        {
            bool ok = true;
            
            if (newTask != null)
                taskList.Add(newTask);
            else
                ok = false;
            return ok;
        }

        // Adds a new task with specified parameters to the list
        public bool AddNewTask(DateTime newTime, string description, PrioType priority)
        {
            bool ok = true;
            Task newTask = new Task(newTime, description, priority);
            if (newTask != null)
                taskList.Add(newTask);
            else
                ok = false;
            return ok;
        }

        // Checks if the provided index is valid for the taskList
        public bool CheckIndex(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < taskList.Count))
            {
                ok = true;
            }
            return ok;
        }

        // Finds a task by its description
        public Task FindTask(string description)
        {
            foreach (Task task in taskList)
            {
                if (task.Description.ToLower().Equals(description.ToLower()))
                {
                    return task;
                }
            }
            return null;
        }

        // Prepares and returns an array of strings representing the tasks currently in the task list
        public string[] GetInfoStringList()
        {
            // Create a local array of string elements with the number of elements in the taskList
            string[] infoStrings = new string[taskList.Count];

            for (int i = 0; i < infoStrings.Length; i++)
            {
                infoStrings[i] = taskList[i].ToString();
            }
            return infoStrings;
        }

        // Reads data from a file and updates the taskList
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManger = new FileManager();

            // Objects are passed by reference, so taskList will be updated
            return fileManger.ReadTaskListFromFile(taskList, fileName);
        }

        // Writes data from the taskList to a file
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }

        // Changes a task at a specified index
        public bool ChangeTaskAt(Task task, int index)
        {
            bool ok = true;
            // Check so that task is not null and index is not out of range
            if ((task != null) && CheckIndex(index))
                taskList[index] = task;
            else
                ok = false;
            return ok;
        }

        // Deletes a task at a specified index
        public bool DeleteTaskAt(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < taskList.Count))
            {
                taskList.RemoveAt(index);
                ok = true;
            }
            return ok;
        }
    }
}
