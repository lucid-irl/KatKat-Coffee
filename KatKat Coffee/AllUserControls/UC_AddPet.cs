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
    public partial class UC_AddPet : UserControl
    {
        DataAccessLayer data = new DataAccessLayer();

        public UC_AddPet()
        {
            InitializeComponent();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            //query = "insert into pets (name, color, species, gender, owner) values ('" + txtPetName.Text + "','" + txtColor.Text + "','" + txtSpecies.Text + "', '"+txtGender.Text+"', '"+txtOwner.Text+"')";
            //fn.setData(query);
            if (txtPetName.Text == "" ||
                txtColor.Text == ""||
                txtSpecies.Text ==""||
                txtGender.Text ==""||
                txtOwner.Text == "")
            {
                MessageBox.Show("There are one or more empty cells!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pet it = new Pet(0, txtPetName.Text, txtColor.Text, txtSpecies.Text, txtGender.Text, txtOwner.Text);
                if (data.addPet(it))
                    MessageBox.Show("Add new pet successfully!");
                clearAll();
            }
            
        }

        public void clearAll()
        {
            txtPetName.Clear();
            txtColor.Clear();
            txtSpecies.SelectedIndex = -1;
            txtGender.SelectedIndex = -1;
            txtOwner.Clear();
        }

        private void UC_AddPet_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
