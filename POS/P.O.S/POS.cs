using System;
using System.Data;
using System.Windows.Forms;
using Methods;

namespace Bill_System
{
    public partial class POS : Form
    {
        Library dll = new Library();
        DataTable dt1,dt2;
        int total = 0;
        int[] price = { 53, 20, 113, 89, 76, 44, 23, 98 };
        public POS()  
        {
            InitializeComponent();
            dt1 = new DataTable();
            dt2 = new DataTable();
            DataColumn d1 = new DataColumn("Product Name");
            DataColumn d2 = new DataColumn("Quantity");
            DataColumn d3 = new DataColumn("Rate");
            DataColumn d4 = new DataColumn("Total Price");
            DataColumn d5 = new DataColumn("Product Name");
            DataColumn d6 = new DataColumn("Quantity");
            DataColumn d7 = new DataColumn("Rate");
            DataColumn d8 = new DataColumn("Total Price");
            dt1.Columns.Add(d1);
            dt1.Columns.Add(d2);
            dt1.Columns.Add(d3);
            dt1.Columns.Add(d4);
            dt2.Columns.Add(d5);
            dt2.Columns.Add(d6);
            dt2.Columns.Add(d7);
            dt2.Columns.Add(d8);
            DataRow dr1 = dt1.NewRow();
            DataRow dr2 = dt2.NewRow();
            CartView.DataSource = dt1;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox.Text == "Rice")
                {
                    priceTxt.Text = price[0].ToString();
                }
                else if (listBox.Text == "Chips")
                {
                    priceTxt.Text = price[1].ToString();
                }
                else if (listBox.Text == "Drinks")
                {
                    priceTxt.Text = price[2].ToString();
                }
                else if (listBox.Text == "Sugar")
                {
                    priceTxt.Text = price[3].ToString();
                }
                else if (listBox.Text == "Flour")
                {
                    priceTxt.Text = price[4].ToString();
                }
                else if (listBox.Text == "Candy")
                {
                    priceTxt.Text = price[5].ToString();
                }
                else if (listBox.Text == "Toys")
                {
                    priceTxt.Text = price[6].ToString();
                }
                else if (listBox.Text == "Cooking Oil")
                {
                    priceTxt.Text = price[7].ToString();
                }

            }
            catch (Exception)
            {}
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = dt1.NewRow();
            DataRow dr2 = dt2.NewRow();
            dr[0] = listBox.Text;
            dr[1] = qtyTxt.Text;
            dr[2] = priceTxt.Text;
            dr[3] = (int.Parse(qtyTxt.Text) * int.Parse(priceTxt.Text)).ToString();
            dt1.Rows.Add(dr);
            CartView.DataSource = dt1;
            dr2[0] = listBox.Text;
            dr2[1] = qtyTxt.Text;
            dr2[2] = priceTxt.Text;
            dr2[3] = (int.Parse(qtyTxt.Text) * int.Parse(priceTxt.Text)).ToString();
            dt2.Rows.Add(dr2);
            total += int.Parse(dr2[3].ToString());
            listBox.Text = null;
            qtyTxt.Clear();
            priceTxt.Clear();
        }

        private void ClearCart_Btn_Click(object sender, EventArgs e)
        {
            dt1.Rows.Clear();
        }

        private void ChkOut_Btn_Click(object sender, EventArgs e)
        {
            label6.Text= "Receipt No. " +dll.Counter().ToString();
            
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
        }

        private void qtyTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Load(object sender, EventArgs e)
        {

        }
    }
}
