using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks_Manger
{
    public partial class Form3 : Form
    {

        public enum EnMode
        {
            Add,
            Remove
        }

        private EnMode CurrentMode;
        private frmManageYourTasks MainForm;
        public Form3(frmManageYourTasks frm, EnMode Mode, List<string> Tasks = null)
        {
            InitializeComponent();

            CurrentMode = Mode;
            MainForm = frm;

            if (Mode == EnMode.Add)
            {
                tbTaskName.Visible = true;
                btnAddTask.Visible = true;

                comboBox1.Visible = false;
                btnRemoveTask.Visible = false;
            }
            else if (Mode == EnMode.Remove)
            {
                tbTaskName.Visible = false;
                btnAddTask.Visible = false;

                btnRemoveTask.Visible = true;
                btnRemoveTask.Visible = true;
            }

            if (Tasks != null)
            {
                comboBox1.Items.AddRange(Tasks.ToArray());
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string TaskName = tbTaskName.Text.Trim();

            if(!string.IsNullOrEmpty(TaskName))
            {
                MainForm.AddTasks(TaskName);
                MainForm.UpdateProgressBar();
                this.Close();
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem !=null)
            {
                string TaskName = comboBox1.SelectedItem.ToString();
                MainForm.RemoveTask(TaskName);
                MainForm.UpdateProgressBar();
                this.Close();
            }
        }
    }
}
