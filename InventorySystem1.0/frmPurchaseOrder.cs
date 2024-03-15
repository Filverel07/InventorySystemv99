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
    }
}
