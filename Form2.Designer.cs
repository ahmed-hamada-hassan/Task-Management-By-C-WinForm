namespace Tasks_Manger
{
    partial class frmManageYourTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.btnShowCheckedAllTask = new System.Windows.Forms.Button();
            this.btnRemoveAllTasks = new System.Windows.Forms.Button();
            this.btnCheckedAllTasks = new System.Windows.Forms.Button();
            this.btnUnCheckedAllTasks = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbPrecentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Location = new System.Drawing.Point(33, 104);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(220, 75);
            this.btnAddNewTask.TabIndex = 1;
            this.btnAddNewTask.Text = "Add New Task";
            this.btnAddNewTask.UseVisualStyleBackColor = true;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // btnShowCheckedAllTask
            // 
            this.btnShowCheckedAllTask.Location = new System.Drawing.Point(33, 392);
            this.btnShowCheckedAllTask.Name = "btnShowCheckedAllTask";
            this.btnShowCheckedAllTask.Size = new System.Drawing.Size(220, 75);
            this.btnShowCheckedAllTask.TabIndex = 2;
            this.btnShowCheckedAllTask.Text = "Show Checked Task";
            this.btnShowCheckedAllTask.UseVisualStyleBackColor = true;
            this.btnShowCheckedAllTask.Click += new System.EventHandler(this.btnShowCheckedAllTask_Click);
            // 
            // btnRemoveAllTasks
            // 
            this.btnRemoveAllTasks.Location = new System.Drawing.Point(316, 104);
            this.btnRemoveAllTasks.Name = "btnRemoveAllTasks";
            this.btnRemoveAllTasks.Size = new System.Drawing.Size(218, 71);
            this.btnRemoveAllTasks.TabIndex = 3;
            this.btnRemoveAllTasks.Text = "Remove Task";
            this.btnRemoveAllTasks.UseVisualStyleBackColor = true;
            this.btnRemoveAllTasks.Click += new System.EventHandler(this.btnRemoveAllTasks_Click);
            // 
            // btnCheckedAllTasks
            // 
            this.btnCheckedAllTasks.Location = new System.Drawing.Point(33, 248);
            this.btnCheckedAllTasks.Name = "btnCheckedAllTasks";
            this.btnCheckedAllTasks.Size = new System.Drawing.Size(220, 75);
            this.btnCheckedAllTasks.TabIndex = 4;
            this.btnCheckedAllTasks.Text = "Checked All Tasks";
            this.btnCheckedAllTasks.UseVisualStyleBackColor = true;
            this.btnCheckedAllTasks.Click += new System.EventHandler(this.btnCheckedAllTasks_Click);
            // 
            // btnUnCheckedAllTasks
            // 
            this.btnUnCheckedAllTasks.Location = new System.Drawing.Point(316, 248);
            this.btnUnCheckedAllTasks.Name = "btnUnCheckedAllTasks";
            this.btnUnCheckedAllTasks.Size = new System.Drawing.Size(218, 75);
            this.btnUnCheckedAllTasks.TabIndex = 5;
            this.btnUnCheckedAllTasks.Text = "UnChecked All Tasks";
            this.btnUnCheckedAllTasks.UseVisualStyleBackColor = true;
            this.btnUnCheckedAllTasks.Click += new System.EventHandler(this.btnUnCheckedAllTasks_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(597, 104);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(331, 357);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show UnChecked Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(597, 583);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 53);
            this.progressBar1.TabIndex = 7;
            // 
            // lbPrecentage
            // 
            this.lbPrecentage.BackColor = System.Drawing.Color.Transparent;
            this.lbPrecentage.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecentage.ForeColor = System.Drawing.Color.Red;
            this.lbPrecentage.Location = new System.Drawing.Point(597, 495);
            this.lbPrecentage.Name = "lbPrecentage";
            this.lbPrecentage.Size = new System.Drawing.Size(331, 53);
            this.lbPrecentage.TabIndex = 8;
            this.lbPrecentage.Text = "0%";
            this.lbPrecentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManageYourTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 668);
            this.Controls.Add(this.lbPrecentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnUnCheckedAllTasks);
            this.Controls.Add(this.btnCheckedAllTasks);
            this.Controls.Add(this.btnRemoveAllTasks);
            this.Controls.Add(this.btnShowCheckedAllTask);
            this.Controls.Add(this.btnAddNewTask);
            this.Name = "frmManageYourTasks";
            this.Text = "Manage Your Task";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.Button btnShowCheckedAllTask;
        private System.Windows.Forms.Button btnRemoveAllTasks;
        private System.Windows.Forms.Button btnCheckedAllTasks;
        private System.Windows.Forms.Button btnUnCheckedAllTasks;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbPrecentage;
    }
}