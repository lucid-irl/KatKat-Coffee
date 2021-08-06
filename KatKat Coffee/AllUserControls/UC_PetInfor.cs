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
    public partial class UC_PetInfor : UserControl
    {
        DataAccessLayer data = new DataAccessLayer();
        public UC_PetInfor()
        {
            InitializeComponent();
        }

        private void UC_PetInfor_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            //query = "select * from pets";
            //DataSet ds = fn.getData(query);

            List<Pet> listPets = data.getAllPets();
            guna2DataGridView1.DataSource = listPets;
        }

        private void txtSearchPet_TextChanged(object sender, EventArgs e)
        {
            //query = "select * from pets where name like '" + txtSearchPet.Text + "%'";
            //DataSet ds = fn.getData(query);
            List<Pet> listPets = data.searchPets(txtSearchPet.Text);
            guna2DataGridView1.DataSource = listPets;
        }
    }
}
