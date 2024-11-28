using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ToDoList : System.Web.UI.Page

    {
        private List<string> Tasks
        {
            get
            {
                return ViewState["Tasks"] as List<string> ?? new List<string>();
            }
            set
            {
                ViewState["Tasks"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tasks = new List<string>();
                UpdateTaskList();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string newTask = txtTask.Text;

            if (!string.IsNullOrEmpty(newTask))
            {
                Tasks.Add(newTask);
                UpdateTaskList();

                txtTask.Text = ""; 
                lblMessage.Text = "";
            }
            else
            {
                lblMessage.Text = "Task cannot be empty.";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0)
            {
                
                foreach (int index in lstTasks.GetSelectedIndices())
                {
                    Tasks[index] = null; 
                }

                Tasks.RemoveAll(task => task == null);
                UpdateTaskList();
            }
            else
            {
                lblMessage.Text = "Please select at least one task to delete.";
            }
        }

        protected void btnRemoveAll_Click(object sender, EventArgs e)
        {
            Tasks.Clear();
            UpdateTaskList();
        }

        private void UpdateTaskList()
        {
            lstTasks.Items.Clear();
            foreach (string task in Tasks)
            {
                lstTasks.Items.Add(task);
            }
        }
    }
}