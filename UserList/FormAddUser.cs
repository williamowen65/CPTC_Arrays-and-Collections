using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UserList; 

namespace UserList
{
    public partial class FormAddUsers : Form
    {
        private ListBox listBoxUsers; // Added missing semicolon

        public FormAddUsers(ListBox listBoxUsers)
        {
            InitializeComponent();
            this.listBoxUsers = listBoxUsers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtUserName.Focus();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text; // Assuming there is a TextBox named txtUserName
            if (!string.IsNullOrEmpty(userName))
            {
                File.AppendAllText("users.txt", userName + Environment.NewLine);
                listBoxUsers.Items.Add(userName);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a user name.");
            }
        }
    }
}
