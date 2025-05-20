using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks_Manger
{
    public partial class frmManageYourTasks : Form
    {
        public frmManageYourTasks()
        {
            InitializeComponent();
        }

        public void AddTasks(string Task)
        {
            checkedListBox1.Items.Add(Task);
        }

        public void RemoveTask(string Task)
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString()==Task)
                {
                    checkedListBox1.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnShowCheckedAllTask_Click(object sender, EventArgs e)
        {
            for(int i=0;i<checkedListBox1.CheckedItems.Count;i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            }
        }

        private void btnCheckedAllTasks_Click(object sender, EventArgs e)
        {
            for(int i=0;i<checkedListBox1.Items.Count;i++)
            {
                checkedListBox1.SetItemChecked(i,true);
            }

            UpdateProgressBar();
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this,Form3.EnMode.Add);
            frm3.ShowDialog();
            UpdateProgressBar();
        }

        private void btnRemoveAllTasks_Click(object sender, EventArgs e)
        {
            List<string>Tasks = new List<string>();
            
            foreach(var item in checkedListBox1.Items)
            {
                Tasks.Add(item.ToString());
            }

            Form3 frm3 = new Form3(this,Form3.EnMode.Remove,Tasks);
            frm3.ShowDialog();

            UpdateProgressBar();
        }

        private void btnUnCheckedAllTasks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            UpdateProgressBar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (!checkedListBox1.GetItemChecked(i))
                {
                    MessageBox.Show(checkedListBox1.Items[i].ToString());
                }
            }
        }

        public void UpdateProgressBar()
        {
            int NumberOfTaskes = checkedListBox1.Items.Count;
            int CheckedTasks = checkedListBox1.CheckedItems.Count;

            if(NumberOfTaskes==0)
            {
                progressBar1.Value = 0;
                lbPrecentage.Text = lbPrecentage.Text;
                return;
            }

            int Percentage = (int)(((float)CheckedTasks / (float)NumberOfTaskes) * 100);

            if (Percentage > 100) Percentage = 100;
            if (Percentage < 0) Percentage = 0;

            progressBar1.Value = Percentage;
            lbPrecentage.Text = $"{Percentage}%";
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
                {
                UpdateProgressBar();

                });
        }
    }
}
