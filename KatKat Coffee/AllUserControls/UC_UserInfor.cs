using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KatKat_Coffee.DataAccess;
using KatKat_Coffee.DataObject;

namespace KatKat_Coffee.AllUserControls
{
    public partial class UC_UserInfor : UserControl
    {
        function fn = new function();
        String query;
        DataAccessLayer data = new DataAccessLayer();

        public UC_UserInfor()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            List<User> listUser = data.getAllUserInfor();
            guna2DataGridView1.DataSource = listUser;
        }

        private void UC_UserInfor_Load(object sender, EventArgs e)
        {
            loadData();
        }
        
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                String username = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                String password = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String name = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                String gender = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                int age = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                String role = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                txtUserName.Text = username;
                txtPass.Text = password;
                txtName.Text = name;
                txtGender.Text = gender;
                txtAge.Text = age.ToString();
                txtRole.Text = role;
            }
            catch { }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text;
            string password = txtPass.Text;
            string name = txtName.Text;
            string gender = txtGender.Text;
            Int64 age;
            string role = txtRole.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("There are one or more empty cells!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    age = Int64.Parse(txtAge.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Age should be a number with value greater than 0");
                    return;
                }
                if (age < 0)
                {
                    MessageBox.Show("Age should be a number with value greater than 0");
                    return;
                }
                else
                {
                    User it = new User(id, username, password, name, gender, age, role);

                    Console.WriteLine(txtRole.Text + it.role + "end");
                    data.updateUser(it);
                    loadData();
                    clearAll();
                }
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" ||
                txtPass.Text == "" ||
                txtName.Text == "" ||
                txtGender.Text == "" ||
                txtAge.Text == "" ||
                txtRole.Text == "")
            {
                MessageBox.Show("There are one or more empty cells!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User it = new User(0, txtUserName.Text, txtPass.Text, txtName.Text, txtGender.Text, int.Parse(txtAge.Text), txtRole.Text);
                if (data.addMember(it))
                    MessageBox.Show("Add new Staff successfully!");
                clearAll();
                loadData();
            }
        }
        public void clearAll()
        {
            txtUserName.Clear();
            txtPass.Clear();
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtAge.Clear();
            txtRole.SelectedIndex = -1;
        }

        private void btnAddMember_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            data.deleteUser(id);
            loadData();
            clearAll();
        }
    }
}
