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
    public partial class UC_AddItem : UserControl
    {
        function fn = new function();
        String query;


        public UC_AddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name, category, price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "','" + txtPrice.Text + "')";
            fn.setData(query);
            clearAll();
        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_AddItem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
