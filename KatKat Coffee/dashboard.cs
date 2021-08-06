using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatKat_Coffee
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        public dashboard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItem.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
                btnAddPet.Hide();
                btnPetInfor.Hide();
                btnUser.Hide();
                btnBill.Hide();
            }

            else if (user == "Admin")
            {
                btnAddItem.Show();
                btnUpdate.Show();
                btnRemove.Show();
                btnAddPet.Show();
                btnPetInfor.Show();
                btnUser.Show();
                btnBill.Show();
            }
            else if(user == "Staff")
            {
                btnAddItem.Show();
                btnAddPet.Show();
                btnPetInfor.Show();
                btnBill.Show();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            uC_AddItem1.Visible = true;
            uC_AddItem1.BringToFront();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItem1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItem1.Visible = false;
            uC_Remove1.Visible = false;
            uC_AddPet1.Visible = false;
            uC_PetInfor1.Visible = false;
            uC_Bill1.Visible = false;
            uC_UserInfor1.Visible = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItem1.Visible = true;
            uC_UpdateItem1.loadData();
            uC_UpdateItem1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_Remove1.Visible = true;
            uC_Remove1.loadData();
            uC_Remove1.BringToFront();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            uC_AddPet1.Visible = true;
            uC_AddPet1.BringToFront();
        }

        private void btnPetInfor_Click(object sender, EventArgs e)
        {
            uC_PetInfor1.Visible = true;
            uC_PetInfor1.loadData();
            uC_PetInfor1.BringToFront();
        }

<<<<<<< HEAD
        private void btnUser_Click(object sender, EventArgs e)
        {
            uC_UserInfor1.Visible = true;
            uC_UserInfor1.loadData();
            uC_UserInfor1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            uC_Bill1.Visible = true;
            //btnBill.loadData();
            uC_Bill1.BringToFront();
=======
        private void uC_PetInfor1_Load(object sender, EventArgs e)
        {

>>>>>>> 90496fa0563ae290561fdbc584741b6160674b1e
        }
    }
}
