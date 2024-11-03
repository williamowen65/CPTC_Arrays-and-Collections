namespace UserList
{


    public partial class FormMain : Form
    {
        private int currentSelectedIndex = -1; // Add this field to track the selected index

        public FormMain()
        {
            InitializeComponent();
        }

        static string[] ReadNamesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllLines(filePath);
            }
            else
            {
                return Array.Empty<string>();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //FormDeleteUser formDeleteUser = new FormDeleteUser();
            //formDeleteUser.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the currentSelectedIndex whenever the selection changes
            currentSelectedIndex = listBoxUsers.SelectedIndex;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAddUsers formAddUsers = new FormAddUsers(listBoxUsers);
            formAddUsers.ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //FormEditUser formEditUser = new FormEditUser();
            //formEditUser.ShowDialog();
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            var names = ReadNamesFromFile("users.txt");
            foreach (var name in names)
            {
                listBoxUsers.Items.Add(name);
            }
        }

        private void btnProcessUser_Click(object sender, EventArgs e)
        {
            FormProcessUsers formProcessUsers = new FormProcessUsers();
            formProcessUsers.ShowDialog();
        }
    }
}
