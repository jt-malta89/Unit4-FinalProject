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

            //MessageBox.Show(new Operations().getproductByBarcode(Convert.ToInt32(this.txtProductBarcode.Text)).ItemDescription);
        }

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

        private void updateProductsInOrderView()
        {
            this.dataGridOrderProducts.DataSource = null;
            this.dataGridOrderProducts.DataSource = orderProductsList;
            this.dataGridOrderProducts.Update();
            this.dataGridOrderProducts.Refresh();

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (this.orderProductsList.Count == 0)
            {
                MessageBox.Show("Please select some products to create an order");                
            }
            else
            {
                Order order = new Order();
                order.OrderID = new Random().Next(30000000);
                order.PharmacyID = (int)((DataRowView)(this.comboPharmacies.SelectedItem))["PharmacyID"];
                order.StaffIDCard = 1234;
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
                
                MessageBox.Show("Order with ID " + order.OrderID + " inserted");
                updateProductsInOrderView();

                //clear the list and refresh the dataGrid so user can start a new order
                this.orderProductsList.Clear();
                updateProductsInOrderView();
               
            }
            
        }

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
                    MessageBox.Show("Select a whole row to delete product from your order");
                }
            }

        }

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


           // updateProductsInOrderView(); 
            
        }

        private void dataGridOrderProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
