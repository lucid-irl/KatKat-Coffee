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
    public partial class UC_UpdateItem : UserControl
    {
        function fn = new function();
        String query;
        DataAccessLayer data = new DataAccessLayer();

        public UC_UpdateItem()
        {
            InitializeComponent();
        }

        private void UC_UpdateItem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            //query = "select * from items";
            //DataSet ds = fn.getData(query);


            List<Item> itemList = data.getAllItems();
            // Console.WriteLine("here: " + itemList[0].category);
            guna2DataGridView1.DataSource = itemList;
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            //query = "select * from items where name like '"+txtSearchItem.Text+"%'";
            //DataSet ds = fn.getData(query);
            List<Item> itemList = data.searchItems(txtSearchItem.Text);
            guna2DataGridView1.DataSource = itemList;
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                txtCategory.Text = category;
                txtItemName.Text = name;
                txtPrice.Text = price.ToString();
            }
            catch { }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //query = "update items set name ='"+txtItemName.Text+"', category = '"+txtCategory.Text+"', price = '"+txtPrice.Text+"' where Id = '"+id+"'";
            //fn.setData(query);
            string name = this.txtItemName.Text;
            string category = txtCategory.Text.ToString();
            Int64 price;
            if (name == "" || category == "")
            {
                MessageBox.Show("There are one or more empty cells!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    price = Int64.Parse(txtPrice.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Price should be a number with value greater than 0");
                    return;
                }
                if (price < 0)
                {
                    MessageBox.Show("Price should be a number with value greater than 0");
                    return;
                }
                else
                {
                    Item it = new Item(id, name, category, price);

                    Console.WriteLine(txtCategory.Text + it.category + "end");
                    data.updateItem(it);
                    loadData();

                    txtCategory.ResetText();
                    txtItemName.Clear();
                    txtPrice.Clear();
                }
                //    Item it = new Item(id, txtItemName.Text, txtCategory.Text, Int64.Parse(txtPrice.Text));
                //data.updateItem(it);
                //loadData();

                //txtCategory.ResetText();
                //txtItemName.Clear();
                //txtPrice.Clear();
            }
        }
    }
}
