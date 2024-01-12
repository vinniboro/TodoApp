using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoReminder.Enums;
using System.IO;

namespace TodoReminder
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;

        private string fileName = Application.StartupPath + "\\Tasks.txt";
        public MainForm()
        {
            InitializeComponent();

            // Initialize TaskManager and set the file name
            taskManager = new TaskManager();
            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tasks.txt");

            // Initialize GUI
            InitilizeGUI();
        }
    
    /// <summary>
    /// Initializes the GUI components.
    /// </summary>
    private void InitilizeGUI()
    {
    // Set the form's title
    this.Text = "toDo Reminder by Vincent Borowiec";

    // Initialize the combo box with priority options
    comboPrio.Items.Clear();
    comboPrio.Items.AddRange(Enum.GetNames(typeof(PrioType)));
    comboPrio.SelectedIndex = (int)PrioType.Normal;

    // Clear the list box
    listTasks.Items.Clear();

    // Clear the to-do text box
    txtTodo.Text = String.Empty;

    // Set the date picker format to year-month-day hour:minute
    datePicker.Format = DateTimePickerFormat.Custom;
    datePicker.CustomFormat = "yyyy-MM-dd HH:mm";

    // Enable tooltips for all components
    toolTip1.ShowAlways = true;

    // Set tooltips for the date picker and priority combo box
    toolTip1.SetToolTip(datePicker, "Click to open calendar for date, write in time here");
    toolTip1.SetToolTip(comboPrio, "Selet the priority");

    // Set a tooltip for the list box and the change button, indicating how to change an item
    string tips = "To change: Select an item first!" + Environment.NewLine;
    tips += "Make you changes in the input controls, " + Environment.NewLine;
    tips += "Click the cghange button" + Environment.NewLine;

    toolTip1.SetToolTip(listTasks, tips);
    toolTip1.SetToolTip(btnChange, tips);

    // Set a tooltip for the change button indicating how to delete an item
    string delTips = "Select an item first and the click button!";
    toolTip1.SetToolTip(btnChange, delTips);

    // Set a tooltip for the todo text box indicating how to enter a task
    string desTips = "Write here!";
    toolTip1.SetToolTip(txtTodo, desTips);

    // Enable the save and open file menu items
    openDataFileToolStripMenuItem.Enabled = true;
    saveDataFileToolStripMenuItem.Enabled = true;
}


        //convert the array of strings to a List<string> and then add the items one by one. 
        //Cast<object>().ToArray() to convert the array of strings to an array of objects, which is what ListBox.Items.AddRange expects.
        public void UpdateGUI()
        {
            listTasks.Items.Clear();
            string[] infoStrings = taskManager.GetInfoStringList();
            if (infoStrings != null)
            {
                foreach (var infoString in infoStrings)
                {
                    listTasks.Items.Add(infoString);
                }
            }
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private Task ReadInput()
        {
            Task task = new Task();

            if (string.IsNullOrEmpty(txtTodo.Text))
            {
                MessageBox.Show("todo empty");
                return null;
            }
            task.Description = txtTodo.Text;
            task.Date = datePicker.Value;
            task.Priority = (PrioType)comboPrio.SelectedIndex;

            return task;
        }

        private void clockTimer_Tick(object sender, EventArgs e)

        {

            lblClock.Text = DateTime.Now.ToLongTimeString();

        }


        private List<Task> taskList;

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // Initialize taskList
            taskList = new List<Task>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            if(taskManager.AddNewTask(task))
            {
                UpdateGUI();
            }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = listTasks.SelectedIndex;
            if (index >= 0)
            {
                Task task = ReadInput();
                bool ok = taskManager.ChangeTaskAt(task, index);
                if (ok)
                    UpdateGUI();

            }
            else
                MessageBox.Show("Select an elemnt to change!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //Click on this menu item should close the form, but to make your application more user-friendly,
        //you should let the user confirm or the chance to cancel exiting
        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Sure to exit program?",
                             "Think twice", MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.OK)
                Application.Exit();
        }

        public bool AddNewTask(Task newTask)
        {
            bool ok = true;

            if (newTask != null)
            {
                taskList.Add(newTask);
            }
            else
            {
                ok = false;
            }

            return ok;
        }
        public bool ChangeTaskAt(Task task, int index)
        {
            bool ok = true;

            if ((task != null) && taskManager.CheckIndex(index))
                taskList[index] = task;
            else
                ok = false;

            return ok;
        }




        /// When the user clicks the submenu item File-New, the program
        ///should be put into the start mode.All you have to do here is to
        ///call the method InitializeGU
        private void newCtrlNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InitilizeGUI();
        }

        // Event handler for Save datafile menu item
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Attempt to save data to the file
            bool ok = taskManager.WriteDataToFile(fileName);

            if (!ok)
            {
                // Show an error message if saving fails
                MessageBox.Show("Something went wrong while saving data to file");
            }
            else
            {
                // Show a success message if saving is successful
                MessageBox.Show("Data saved to file:\n" + fileName);
            }
        }

        // Event handler for Open datafile menu item
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Attempt to read data from the file
            bool ok = taskManager.ReadDataFromFile(fileName);

            if (!ok)
            {
                // Show an error message if reading fails
                MessageBox.Show("Something went wrong while reading data from file");
            }
            else
            {
                // Update the GUI and show a success message if reading is successful
                UpdateGUI();
                MessageBox.Show("Data loaded from file:\n" + fileName);
            }
        }






    }
}
