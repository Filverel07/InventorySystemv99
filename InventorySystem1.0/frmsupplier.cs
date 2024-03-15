using InventorySystem1._0.Includes;
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
    public partial class frmsupplier : Form
    {
        public frmsupplier()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void frmsupplier_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }
        private void lbl_id_TextChanged(object sender, EventArgs e)
        {
            if (lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveSupplier.Enabled = true;
            }
            else
            {
                btn_saveSupplier.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_saveSupplier_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_Mobile.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO `tblsuplier`(`FIRSTNAME`, `LASTNAME`, `MOBILE`, `TYPE`) "
                     + "values('" + txt_FirstName.Text + "','" + txt_LastName.Text
                     + "','" + txt_Mobile.Text + "','" + cbo_type_supplier.Text + "')";
                config.Execute_CUD(sql, "Unable to saved", "Data has been saved in the database.");
                frmsupplier_Load(sender, e);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_Mobile.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "update user set FIRSTNAME = '" + txt_FirstName.Text + "',LASTNAME= '" + txt_LastName.Text
                          + "', '" + txt_Mobile.Text + "',type= '" + cbo_type_supplier.Text
                          + "' where ID = " + lbl_id.Text;
                config.Execute_CUD(sql, "Unable to update", "Data has been updated in the database.");
                frmsupplier_Load(sender, e);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "delete from tblsuplier where ID = '" + lbl_id.Text + "'";
            config.Execute_CUD(sql, "unable to delete", "Data has been deleted in the database");
            frmsupplier_Load(sender, e);

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "id";

            cbo_type_supplier.Text = "SUPPLIER";

            config.Load_DTG("Select ID as 'id' ,FIRSTNAME as 'firstname',LASTNAME as 'lastname',TYPE as 'Type' From tblsuplier", dtg_listSupplier);
            dtg_listSupplier.Columns[0].Visible = false;

            if (lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveSupplier.Enabled = true;
            }
            else
            {
                btn_saveSupplier.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }

            funct.clearTxt(Panel1);


    }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_type_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtg_listSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dtg_listSupplier.CurrentRow.Cells[0].Value.ToString();
            txt_FirstName.Text = dtg_listSupplier.CurrentRow.Cells[1].Value.ToString();
            txt_LastName.Text = dtg_listSupplier.CurrentRow.Cells[2].Value.ToString();
            txt_Mobile.Text = dtg_listSupplier.CurrentRow.Cells[3].Value.ToString();
            cbo_type_supplier.Text = dtg_listSupplier.CurrentRow.Cells[4].Value.ToString();
        }

        private void txt_Mobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
