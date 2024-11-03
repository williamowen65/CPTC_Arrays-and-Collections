namespace UserList
{
    partial class FormMain
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
            label1 = new Label();
            listBoxUsers = new ListBox();
            btnAddUser = new Button();
            button2 = new Button();
            button3 = new Button();
            btnProcessUser = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(91, 41);
            label1.TabIndex = 0;
            label1.Text = "Users";
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 41;
            listBoxUsers.Location = new Point(12, 75);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(415, 619);
            listBoxUsers.TabIndex = 1;
            listBoxUsers.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(433, 75);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(306, 58);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(433, 139);
            button2.Name = "button2";
            button2.Size = new Size(306, 58);
            button2.TabIndex = 3;
            button2.Text = "Edit User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEditUser_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 203);
            button3.Name = "button3";
            button3.Size = new Size(306, 58);
            button3.TabIndex = 4;
            button3.Text = "Remove User";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDeleteUser_Click;
            // 
            // btnProcessUser
            // 
            btnProcessUser.Location = new Point(433, 636);
            btnProcessUser.Name = "btnProcessUser";
            btnProcessUser.Size = new Size(306, 58);
            btnProcessUser.TabIndex = 5;
            btnProcessUser.Text = "Process Users";
            btnProcessUser.UseVisualStyleBackColor = true;
            btnProcessUser.Click += btnProcessUser_Click;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 727);
            Controls.Add(btnProcessUser);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAddUser);
            Controls.Add(listBoxUsers);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "User Admin Panel";
            Load += formMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxUsers;
        private Button btnAddUser;
        private Button button2;
        private Button button3;
        private Button btnProcessUser;
    }
}
