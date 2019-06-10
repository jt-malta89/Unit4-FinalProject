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
using DGVPrinterHelper;

namespace PharmaceuticalMS
{
    public partial class OrdersForm : Form
    {
        private ArrayList orderProductsList = new ArrayList();
        //Call methods found in operations
        public Operations opr = new Operations();

        public OrdersForm()
        {
            InitializeComponent();
        }
        //Load data in data grid view & get combo box details when form opens 
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.getOrders();
            dgvOrders.DataSource = dt;

            this.comboPharmacies.DataSource = new Operations().getPharmacy();
            this.comboPharmacies.DisplayMember = "Name";
            this.comboPharmacies.Refresh();

            this.comboProducts.DataSource = new Operations().getItems();
            this.comboProducts.DisplayMember = "ItemName";
            this.comboProducts.Refresh();
        }

        private void comboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.comboProducts.SelectedItem;
            txtProductBarcode.Text = drv["Barcode"].ToString();
            numericUpDownQuantity.Minimum = 0;
            numericUpDownQuantity.Maximum = Convert.ToInt32(drv["Quantity"].ToString());
            numericUpDownQuantity.Value = Convert.ToInt32(drv["Quantity"].ToString());
            txtProductDescription.Text = drv["ItemDescription"].ToString();
        }
        //Add button will add products to the data grid view
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderProduct orderProduct = new OrderProduct();
            orderProduct.barcode = Convert.ToInt32(this.txtProductBarcode.Text.Trim());
            orderProduct.productName = this.comboProducts.Text;
            orderProduct.quantity = (int)this.numericUpDownQuantity.Value;
            
            bool found = false;

            foreach (OrderProduct op in this.orderProductsList)
            {
                if (op.barcode == orderProduct.barcode)
                {
                    found = true;
                }
            }
            if (found)
            {
                MessageBox.Show("Item already in order. Please modify quantity if required"); 
            }
            else
            {
                orderProductsList.Add(orderProduct);
                updateProductsInOrderView();
            }  
        }
        //Method to update products data grid view
        private void updateProductsInOrderView()
        {
            this.dataGridOrderProducts.DataSource = null;
            this.dataGridOrderProducts.DataSource = orderProductsList;
            this.dataGridOrderProducts.Update();
            this.dataGridOrderProducts.Refresh();
        }
        //Save order button that save items selected in the data grid view also print document
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (this.orderProductsList.Count == 0)
            {
                MessageBox.Show("Please select some products to create an order");
            }
            else
            {
                Order order = new Order();
                order.OrderID = Convert.ToInt32(txtOrderID.Text);
                order.PharmacyID = (int)((DataRowView)(this.comboPharmacies.SelectedItem))["PharmacyID"];
                order.date = DateTime.Now;

                Operations dbOperations = new Operations();

                dbOperations.insertOrder(order);

                foreach(OrderProduct op in this.orderProductsList)
                {
                    op.orderId = order.OrderID;
                    dbOperations.insertOrderProduct(op);

                    Products productToUpdate = dbOperations.getproductByBarcode(op.barcode);
                    productToUpdate.Quantity = productToUpdate.Quantity - op.quantity;
                    dbOperations.editproduct(productToUpdate);
                }
                this.StripStatusDisplay.Text = "Order ID " + order.OrderID + " created";
                updateProductsInOrderView();

                DGVPrinter printer = new DGVPrinter();
                printer.Title = "\r\n\r\n\r\n Mother Earth Pharmacy Ltd.";
                printer.SubTitle = "Telephone: 21186949";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintDataGridView(dataGridOrderProducts);
           
                DataTable dt = new DataTable();
                dt = opr.getOrders();
                dgvOrders.DataSource = dt;
                //clear the list and refresh the dataGrid so user can start a new order
                this.orderProductsList.Clear();
                updateProductsInOrderView();
            }
            
        }
        //Delete products from the data grid view
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows 
                = this.dataGridOrderProducts.SelectedRows;
           
            if (selectedRows.Count > 0)
            {
                foreach(DataGridViewRow dgvr in selectedRows)
                {
                    OrderProduct selectedOrderProduct = (OrderProduct)dgvr.DataBoundItem;

                    OrderProduct toRemove = null;

                    foreach(OrderProduct op in this.orderProductsList)
                    {
                        if (op.barcode == selectedOrderProduct.barcode)
                        {
                            toRemove = op;
                            break;
                        }
                    }
                    if (toRemove != null)
                    {
                        this.orderProductsList.Remove(toRemove);
                    }
                }
                updateProductsInOrderView();
            }
            else
            {
                if (this.orderProductsList.Count > 0)
                {
                    MessageBox.Show("Select row to delete product from order");
                }
            }

        }
        //The numeric up down will change the product quantity in data grid view
        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            foreach (OrderProduct op in this.orderProductsList)
            {
                if (Convert.ToString(op.barcode) == this.txtProductBarcode.Text.Trim())
                {
                    op.quantity = (int)this.numericUpDownQuantity.Value; 
                }
            }
            this.dataGridOrderProducts.Update();
            this.dataGridOrderProducts.Refresh();
        }
        //The text box only accept number
        private void txtOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter only Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }
    }
}
