using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem1._0
{
    public partial class frmPurchaseOrder : Form
    {
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }
        public void SetItems(DataGridView itemsGridView)
        {
            listBoxItems.Items.Clear();

            foreach (DataGridViewRow row in itemsGridView.Rows)
            {
                string itemID = row.Cells["ITEMID"].Value.ToString();
                string itemName = row.Cells["NAME"].Value.ToString();
                listBoxItems.Items.Add($"{itemID}: {itemName}");
            }
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseOrderGridView.Rows.Clear();

            // Add each item from listBoxItems as separate rows in PurchaseOrderGridView
            foreach (string selectedItem in listBoxItems.Items)
            {
                // Split each item into itemID and itemName
                string[] parts = selectedItem.Split(':');
                string itemID = parts[0].Trim();
                string itemName = parts[1].Trim();

                // Add a new row to PurchaseOrderGridView with itemID and itemName
                PurchaseOrderGridView.Rows.Add(itemID, itemName);
            }
        }

        private void PurchaseOrderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmItems itemsForm = new frmItems();
            itemsForm.Show();
            this.Close();
        }
    }
}
