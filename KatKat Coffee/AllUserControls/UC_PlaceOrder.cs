using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

using KatKat_Coffee.DataObject;
using KatKat_Coffee.DataAccess;

namespace KatKat_Coffee.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        //function fn = new function();
        //String query;
        DataAccessLayer data = new DataAccessLayer();

        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            //query = "select name from items where category = '"+category+"'";
            List<Item> itemsList = data.getAllItemsFromCategory(category);
            showItemList(itemsList);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            // query = "select name from items where category = '" + category + "' and name like '"+txtSearch.Text+"%'";
            List<Item> itemList = data.searchItemFromCategory(category, txtSearch.Text);
            showItemList(itemList);
        }
        private void showItemList(List<Item> itemsList)
        {
            listBox1.Items.Clear();
            foreach (Item it in itemsList)
            {
                listBox1.Items.Add(it.name);
            }
        }
        //private void showItemList(String query)
        //{
        //    listBox1.Items.Clear();
        //    DataSet ds = fn.getData(query);

        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        //    }
        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            List<Item> itemsList = data.searchItems(text);
            // query = "select price from items where name = '"+text+"'";
            // DataSet ds = fn.getData(query);
            try
            {
                txtPrice.Text = itemsList[0].price.ToString();
            }
            catch
            {

            }
        }

        void ResQuantity()
        {
            this.txtQuantityUpDown.ValueChanged -= new EventHandler(txtQuantityUpDown_ValueChanged);

            this.txtQuantityUpDown.Value = 0;

            this.txtQuantityUpDown.ValueChanged += new EventHandler(txtQuantityUpDown_ValueChanged);
        }

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                if(txtItemName.Text =="" || txtPrice.Text =="")
                {
                    MessageBox.Show("Item is empty");
                    ResQuantity();
                }
                else
                {
                    Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
                    Int64 price = Int64.Parse(txtPrice.Text);
                    txtTotal.Text = (quan * price).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item is empty");
                txtQuantityUpDown.Value = 0;
            }

        }

        protected int n, total = 0;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView2.Rows.Add();
                guna2DataGridView2.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView2.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView2.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                guna2DataGridView2.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                txtItemName.Clear();
                txtPrice.Clear(); 
                label8TotalAmount.Text = total + " VND";
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ResQuantity();
            txtTotal.Clear();
        }

        int amount;
        int index;

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //amount = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
                index = e.RowIndex;
                //MessageBox.Show(amount.ToString());
            }
            catch
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.RowCount == 0)
            {
                total = 0;
                label8TotalAmount.Text = total + " VND";
            }
            else
            {
                try
                {
                    amount = int.Parse(guna2DataGridView2.Rows[index].Cells[3].Value.ToString());
                    total -= amount;
                    guna2DataGridView2.Rows.RemoveAt(index);
                    guna2DataGridView2.CurrentCell = null;
                    //guna2DataGridView2.Rows.RemoveAt(this.guna2DataGridView2.SelectedRows[0].Index);
                    label8TotalAmount.Text = total + " VND";
                    amount = 0;
                }
                catch
                {

                }

            }

            //if (guna2DataGridView2.Rows.Count == 0)
            //{
            //    total = 0;
            //    label8TotalAmount.Text = total + " VND";
            //}
            //else
            //{
            //    try
            //    {
            //        guna2DataGridView2.Rows.RemoveAt(this.guna2DataGridView2.SelectedRows[0].Index);
            //    }
            //    catch
            //    {

            //    }
            //    label8TotalAmount.Text = total + " VND";
            //    amount = 0;
            //    total -= amount;
            //}
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            Console.WriteLine(sqlFormattedDate+ " " + txtPrice.Text + " " + txtTotal.Text);
            Bill it = new Bill(0, int.Parse(label8TotalAmount.Text.Substring(0, label8TotalAmount.Text.Length - 3)), sqlFormattedDate);
            if (data.addBill(it))
                MessageBox.Show("You have to pay: " + total, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtItemName.Clear();
            txtPrice.Clear();
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date:{0}", DateTime.Now.Date);
            printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + label8TotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView2);
            total = 0;
            guna2DataGridView2.Rows.Clear();
            label8TotalAmount.Text = total + " VND";
        }

    }
}
