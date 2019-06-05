using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace PharmaceuticalMS
{
    public partial class OrdersForm : Form
    {
        private ArrayList orderProductsList = new ArrayList();

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            //empty any products in the list when the form loads
            //this.orderProductsList.Clear();

            this.comboPharmacies.DataSource = new Operations().viewStaff();
            this.comboPharmacies.DisplayMember = "Name";
            this.comboPharmacies.Refresh();

            this.comboProducts.DataSource = new Operations().getItems();
            this.comboProducts.DisplayMember = "ItemName";
            this.comboProducts.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(this.comboPharmacies.SelectedItem.GetType().ToString());
            //MessageBox.Show(((DataRowView)this.comboPharmacies.SelectedItem)["IDCard"].ToString());
        }

        private void comboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.comboProducts.SelectedItem;
            txtProductBarcode.Text = drv["BarcodeID"].ToString();
            txtProductQuantity.Text = drv["Quantity"].ToString();
            txtProductDescription.Text = drv["ItemDescription"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderProduct orderProduct = new OrderProduct();
            orderProduct.barccode = this.txtProductBarcode.Text;
            orderProduct.quantity = Convert.ToInt32(this.txtProductQuantity.Text);
            orderProductsList.Add(orderProduct);

            MessageBox.Show("There are " + orderProductsList.Count + " items");
            
            this.dataGridOrderProducts.DataSource = orderProductsList;

            this.dataGridOrderProducts.Refresh();

        }
    }
}
