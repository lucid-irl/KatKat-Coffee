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
    public partial class UC_Remove : UserControl
    {
        function fn = new function();
        String query;

        public UC_Remove()
        {
            InitializeComponent();
        }

        private void UC_Remove_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "delete from items where Id = '" + id + "'";
            fn.setData(query);
            loadData();
        }

        private void UC_Remove_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
