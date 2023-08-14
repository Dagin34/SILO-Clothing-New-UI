using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Olis_Knitting_New_UI.UserControls
{
    public partial class ItemPage : UserControl
    {
        //.. Initialization of Global Variables


        public ItemPage()
        {
            InitializeComponent();
        }

        private void ItemPage_Load(object sender, EventArgs e)
        {
            ItemCount.Start();
            TableUpdater.Start();
            UpdateTable();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //.. Search Function
            if (SearchBy.SelectedIndex < 0)
            {
                MessageBox.Show("Nothing Selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Insert a valid value before searching", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (SearchBy.SelectedIndex == 0)
            {
                string type = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchItem(0, type).Tables["All"];
            }
            else if (SearchBy.SelectedIndex == 1)
            {
                string color = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchItem(1, color).Tables["All"];
            }
            else if (SearchBy.SelectedIndex == 2)
            {
                string color = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchItem(2, color).Tables["All"];
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            TableUpdater.Stop();
        }

        private void ItemCount_Tick(object sender, EventArgs e)
        {
            ThirdLayer tl = new ThirdLayer();
            ItemNo.Text = tl.ItemCount().ToString();
        }

        private void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtType.Clear();
            txtColor.Clear();
            sizeCombo.SelectedIndex = 2;
            txtQuantity.Text = 1.ToString();
            txtPrice.Clear();
            txtName.Focus();
        }

        private void UpdateTable()
        {
            ThirdLayer tl = new ThirdLayer();
            dgv.DataSource = tl.GetAllItems().Tables["All"];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                SearchButton.PerformClick();
                txtSearch.Focus();
            }
            else
            {
                UpdateTable();
            }
        }

        private void TableUpdater_Tick(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            TableUpdater.Start();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtType.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtColor.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                sizeCombo.SelectedItem = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtQuantity.Text = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPrice.Text = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Item Name First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.BorderColor = Color.FromArgb(43, 43, 43);
                txtName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtType.Text))
            {
                txtType.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Type of CLothing First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.BorderColor = Color.FromArgb(43, 43, 43);
                txtType.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtColor.Text))
            {
                txtColor.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Color First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtColor.BorderColor = Color.FromArgb(43, 43, 43);
                txtColor.Focus();
                return;
            }
            if (sizeCombo.SelectedIndex < 0)
            {
                sizeCombo.BorderColor = Color.Red;
                MessageBox.Show("Please choose Size First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sizeCombo.BorderColor = Color.FromArgb(43, 43, 43);
                sizeCombo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Price First", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.BorderColor = Color.FromArgb(43, 43, 43);
                txtPrice.Focus();
                return;
            }


            //int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string type = txtType.Text;
            string color = txtColor.Text;
            string size = sizeCombo.SelectedItem.ToString();
            int quan = int.Parse(txtQuantity.Text);
            int price = int.Parse(txtPrice.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.insertItems(name, type, color, size, quan, price);
            UpdateTable();
            Clear();
        }

        private void updateItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                txtId.BorderColor = Color.Red;
                MessageBox.Show("Please select the item you want to update from the table on the right.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.BorderColor = Color.FromArgb(43, 43, 43);
                return;
            }
            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Item Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.BorderColor = Color.FromArgb(43, 43, 43);
                txtName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtType.Text))
            {
                txtType.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Type of CLothing First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.BorderColor = Color.FromArgb(43, 43, 43);
                txtType.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtColor.Text))
            {
                txtColor.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Color First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtColor.BorderColor = Color.FromArgb(43, 43, 43);
                txtColor.Focus();
                return;
            }
            if (sizeCombo.SelectedIndex < 0)
            {
                sizeCombo.BorderColor = Color.Red;
                MessageBox.Show("Please choose Size First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sizeCombo.BorderColor = Color.FromArgb(43, 43, 43);
                sizeCombo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Price First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.BorderColor = Color.FromArgb(43, 43, 43);
                txtPrice.Focus();
                return;
            }


            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string type = txtType.Text;
            string color = txtColor.Text;
            string size = sizeCombo.SelectedItem.ToString();
            int quan = int.Parse(txtQuantity.Text);
            int price = int.Parse(txtPrice.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.updateItems(id, name, type, color, size, quan, price);
            UpdateTable();
            Clear();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                txtId.BorderColor = Color.Red;
                MessageBox.Show("Please select the item you want to delete from the table on the right.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.BorderColor = Color.FromArgb(43, 43, 43);
                return;
            }


            int id = int.Parse(txtId.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.deleteItem(id);
            UpdateTable();
            Clear();
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
