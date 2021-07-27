using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatKat_Coffee.AllUserControls
{
    public partial class UC_PetInfor : UserControl
    {
        function fn = new function();
        String query;

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
            query = "select * from pets";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchPet_TextChanged(object sender, EventArgs e)
        {
            query = "select * from pets where name like '" + txtSearchPet.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
