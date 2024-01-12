namespace TodoReminder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            colorDialog1 = new ColorDialog();
            datePicker = new DateTimePicker();
            comboPrio = new ComboBox();
            txtTodo = new TextBox();
            btnAdd = new Button();
            listTasks = new ListBox();
            btnChange = new Button();
            btnDel = new Button();
            menuStrip1 = new MenuStrip();
            newCtrlNToolStripMenuItem = new ToolStripMenuItem();
            newCtrlNToolStripMenuItem1 = new ToolStripMenuItem();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            exitAltF4ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            clockTimer = new System.Windows.Forms.Timer(components);
            lblClock = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // datePicker
            // 
            datePicker.Location = new Point(310, 92);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(938, 39);
            datePicker.TabIndex = 0;
            datePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboPrio
            // 
            comboPrio.FormattingEnabled = true;
            comboPrio.Location = new Point(1307, 94);
            comboPrio.Name = "comboPrio";
            comboPrio.Size = new Size(236, 40);
            comboPrio.TabIndex = 1;
            // 
            // txtTodo
            // 
            txtTodo.Location = new Point(310, 158);
            txtTodo.Name = "txtTodo";
            txtTodo.Size = new Size(1243, 39);
            txtTodo.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(715, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(404, 46);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listTasks
            // 
            listTasks.FormattingEnabled = true;
            listTasks.Location = new Point(310, 297);
            listTasks.Name = "listTasks";
            listTasks.Size = new Size(1248, 164);
            listTasks.TabIndex = 4;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(522, 490);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(404, 46);
            btnChange.TabIndex = 5;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(968, 490);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(404, 46);
            btnDel.TabIndex = 6;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newCtrlNToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1861, 40);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // newCtrlNToolStripMenuItem
            // 
            newCtrlNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCtrlNToolStripMenuItem1, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, exitAltF4ToolStripMenuItem });
            newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            newCtrlNToolStripMenuItem.Size = new Size(71, 36);
            newCtrlNToolStripMenuItem.Text = "File";
            // 
            // newCtrlNToolStripMenuItem1
            // 
            newCtrlNToolStripMenuItem1.Name = "newCtrlNToolStripMenuItem1";
            newCtrlNToolStripMenuItem1.Size = new Size(352, 44);
            newCtrlNToolStripMenuItem1.Text = "New           Ctrl+N";
            newCtrlNToolStripMenuItem1.Click += newCtrlNToolStripMenuItem1_Click;
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(352, 44);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += openDataFileToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(352, 44);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // exitAltF4ToolStripMenuItem
            // 
            exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            exitAltF4ToolStripMenuItem.Size = new Size(352, 44);
            exitAltF4ToolStripMenuItem.Text = "Exit              Alt+F4";
            exitAltF4ToolStripMenuItem.Click += exitAltF4ToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(84, 36);
            helpToolStripMenuItem.Text = "Help";
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Location = new Point(751, 591);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(78, 32);
            lblClock.TabIndex = 9;
            lblClock.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1861, 675);
            Controls.Add(lblClock);
            Controls.Add(btnDel);
            Controls.Add(btnChange);
            Controls.Add(listTasks);
            Controls.Add(btnAdd);
            Controls.Add(txtTodo);
            Controls.Add(comboPrio);
            Controls.Add(datePicker);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private DateTimePicker datePicker;
        private ComboBox comboPrio;
        private TextBox txtTodo;
        private Button btnAdd;
        private ListBox listTasks;
        private Button btnChange;
        private Button btnDel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newCtrlNToolStripMenuItem;
        private ToolStripMenuItem newCtrlNToolStripMenuItem1;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer clockTimer;
        private Label lblClock;
        private ToolTip toolTip1;
    }
}
