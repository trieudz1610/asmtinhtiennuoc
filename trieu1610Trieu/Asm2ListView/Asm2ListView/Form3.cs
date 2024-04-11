using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Asm2ListView
{
    public partial class FCalculateWater : Form
    {
        
        public FCalculateWater()
        {
            InitializeComponent();
        }

        private void BttAdd_Click(object sender, EventArgs e)
        {
            string no = TxbNo.Text;
            string name = TxbName.Text;
            string phone = TxbPhone.Text;
            string address = TxbAddress.Text;
            string lastmonth = TxbLast.Text;
            string thismonth = TxbThis.Text;
            string typer = CbType.Text;

            ListViewItem item = new ListViewItem();

            item.Text = no;
            item.SubItems.Add(name);
            item.SubItems.Add(phone);
            item.SubItems.Add(address);
            item.SubItems.Add(lastmonth);
            item.SubItems.Add(thismonth);
            item.SubItems.Add(typer);


            LvWaterBill.Items.Add(item);

            string selectedText = CbType.Text;
            double This;
            double last;
            double.TryParse(lastmonth, out This);
            double.TryParse(thismonth, out last);
            //
            double price = 0;
            double consumption = last - This;
            if (selectedText == "Household customer")
            {
                if (consumption > 0 && consumption <= 10)
                {

                    price = consumption * 5.973;

                }
                else if (consumption > 10 && consumption <= 20)
                {
                    price = consumption * 7.052;
                }
                else if (consumption > 20 && consumption <= 30)
                {
                    price = consumption * 8.699;
                }
                else
                {
                    price = consumption * 15.929;
                }


            }
            else if (selectedText == "Administrative agency, public services")
            {
                price = consumption * 9.955;
            }
            else if (selectedText == "Production units")
            {
                price = consumption * 11.615;
            }
            else if (selectedText == "Business services")
            {
                price = consumption * 22.068;
            }

            else
            {
                MessageBox.Show("chosse right customer");
            }
            double VAT = price * 0.1;
            double Total = VAT + price;
            item.SubItems.Add(VAT + "");
            item.SubItems.Add(Total + "");

            BttEdit.Enabled = true;
            TxbNo.Text = null;
            TxbName.Text = null;
            TxbPhone.Text = null;
            TxbAddress.Text = null;
            TxbLast.Text = null;
            TxbThis.Text = null;
            CbType.SelectedIndex = -1;

        }


        private void BttEdit_Click(object sender, EventArgs e)
        {
            if (LvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem item = new ListViewItem(TxbNo.Text);
                item.Text = TxbNo.Text;
                item.SubItems.Add(TxbName.Text);
                item.SubItems.Add(TxbPhone.Text);
                item.SubItems.Add(TxbAddress.Text);
                item.SubItems.Add(TxbLast.Text);
                item.SubItems.Add(TxbThis.Text);
                item.SubItems.Add(CbType.Text);
                LvWaterBill.Items.Add(item);
                LvWaterBill.Items.Remove(LvWaterBill.SelectedItems[0]);
                string lastmonth = TxbLast.Text;
                string thismonth = TxbThis.Text;
                string selectedText = CbType.Text;
                double This;
                double last;
                double.TryParse(lastmonth, out This);
                double.TryParse(thismonth, out last);

                double price = 0;
                double consumption = last - This;
                if (selectedText == "Household customer")
                {

                    if (consumption > 0 && consumption <= 10)
                    {

                        price = consumption * 5.973;

                    }
                    else if (consumption > 10 && consumption <= 20)
                    {
                        price = consumption * 7.052;
                    }
                    else if (consumption > 20 && consumption <= 30)
                    {
                        price = consumption * 8.699;
                    }
                    else
                    {
                        price = consumption * 15.929;
                    }

                }
                else if (selectedText == "Administrative agency, public services")
                {
                    price = consumption * 9.955;
                }
                else if (selectedText == "Production units")
                {
                    price = consumption * 11.615;
                }
                else if (selectedText == "Business services")
                {
                    price = consumption * 22.068;
                }

                else
                {
                    MessageBox.Show("chosse right customer");
                }
                double VAT = price * 0.1;
                double Total = VAT + price;
                item.SubItems.Add(VAT + "");
                item.SubItems.Add(Total + "");
            }
            else
            {
                DialogResult edit = MessageBox.Show("Pls choose to edit!!!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BttEdit.Enabled = true;
            TxbNo.Text = null; 
            TxbName.Text = null;
            TxbPhone.Text = null;
            TxbAddress.Text = null;
            TxbLast.Text = null;
            TxbThis.Text = null;
            CbType.SelectedIndex = -1;
           
        }

        private void LvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem item = LvWaterBill.SelectedItems[0];
                //var item = LvWaterBill.SelectedItems[0];
                string no = item.SubItems[0].Text;
                string name = item.SubItems[1].Text;
                string phone = item.SubItems[2].Text;
                string address = item.SubItems[3].Text;
                string lastmonth = item.SubItems[4].Text;
                string thismonth = item.SubItems[5].Text;
                string typer = item.SubItems[6].Text;



                TxbNo.Text = no;
                TxbName.Text = name;
                TxbPhone.Text = phone;
                TxbAddress.Text = address;
                TxbLast.Text = lastmonth;
                TxbThis.Text = thismonth;
                CbType.Text = typer;

                BttEdit.Enabled = true;

            }
        }

        private void FCalculateWater_Load(object sender, EventArgs e)
        {
            LvWaterBill.FullRowSelect = true;
            LvWaterBill.Columns.Add("No", 50);
            LvWaterBill.Columns.Add("Name", 150);
            LvWaterBill.Columns.Add("Phone", 150);
            LvWaterBill.Columns.Add("Address", 150);
            LvWaterBill.Columns.Add("Last", 100);
            LvWaterBill.Columns.Add("This", 100);
            LvWaterBill.Columns.Add("TyperCustomer", 150);
            LvWaterBill.Columns.Add("VAT", 100);
            LvWaterBill.Columns.Add("Total", 100);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BttNew_Click(object sender, EventArgs e)
        {
            TxbNo.Text= string.Empty;
            TxbName.Text= string.Empty;
            TxbPhone.Text= string.Empty;
            TxbAddress.Text= string.Empty;
            TxbLast.Text= string.Empty;
            TxbThis.Text= string.Empty;
            CbType.Text= string.Empty;
        }

        private void BttDelete_Click(object sender, EventArgs e)
        {
            if (LvWaterBill.SelectedItems.Count > 0)
            {
                DialogResult delete = MessageBox.Show("Do u want to delete?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    LvWaterBill.Items.Remove(LvWaterBill.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Please choose data to delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
