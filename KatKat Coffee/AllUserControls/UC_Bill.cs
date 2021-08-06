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
    public partial class UC_Bill : UserControl
    {
        DataAccessLayer data = new DataAccessLayer();

        public UC_Bill()
        {
            InitializeComponent();
        }
        
        
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadData()
        {
            List<Bill> listBill = data.getAllBill();
            guna2DataGridView1.DataSource = listBill;
            txtAm.Text = data.getAmount().ToString();
        }

        private void UC_Bill_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
