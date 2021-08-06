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
    public partial class UC_AddItem : UserControl
    {
        DataAccessLayer data = new DataAccessLayer();

        public UC_AddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //query = "insert into items (name, category, price) values ('" + txtitemname.text + "','" + txtcategory.text + "','" + txtprice.text + "')";
            //fn.setdata(query);

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
                    Item it = new Item(0, name, category, price);
                
                    Console.WriteLine(txtCategory.Text + it.category + "end");
                    if (data.addItem(it))
                        MessageBox.Show("Add new item successfully!");
                }

            }

            //Item it = new Item(0, txtItemName.Text, txtCategory.Text.ToString(), Int64.Parse(txtPrice.Text));

            //Console.WriteLine(txtCategory.Text + it.category + "end");
            //if (data.addItem(it))
            //    MessageBox.Show("Add new item successfully!");
            //clearAll();
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
