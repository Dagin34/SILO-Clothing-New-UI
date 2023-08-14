using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olis_Knitting_New_UI.UserControls
{
    public partial class EmployeePage : UserControl
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            EmployeeCount.Start();
            TableUpdater.Start();
            UpdateTable();
        }

        private void UpdateTable()
        {
            ThirdLayer tl = new ThirdLayer();
            dgv.DataSource = tl.GetAllEmployees().Tables["All"];
        }

        private void EmployeeCount_Tick(object sender, EventArgs e)
        {
            ThirdLayer tl = new ThirdLayer();
            EmpCount.Text = tl.EmployeeCount().ToString();
        }

        private void TableUpdater_Tick(object sender, EventArgs e)
        {
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
                string name = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchEmployee(0, -1, name).Tables["All"];
            }
            else if (SearchBy.SelectedIndex == 1)
            {
                int yarn = int.Parse(txtSearch.Text);
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchEmployee(1, yarn, "").Tables["All"];
            }
            else if (SearchBy.SelectedIndex == 2)
            {
                string number = txtSearch.Text;
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.SearchEmployee(2, -1, number).Tables["All"];
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            TableUpdater.Stop();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            TableUpdater.Start();
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNumber.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                yarnCount.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
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

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '+'))
            {
                e.Handled = true;
            }
        }

        private void Clear()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNumber.Clear();
            yarnCount.Clear();
            txtFirstName.Focus();
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void saveEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert First Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.BorderColor = Color.FromArgb(43, 43, 43);
                txtFirstName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Last Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.BorderColor = Color.FromArgb(43, 43, 43);
                txtLastName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNumber.Text))
            {
                txtNumber.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Phone Number First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.BorderColor = Color.FromArgb(43, 43, 43);
                txtNumber.Focus();
                return;
            }
            if (int.Parse(yarnCount.Text) < 0)
            {
                yarnCount.BorderColor = Color.Red;
                MessageBox.Show("Please Insert A Valid Yarn Value.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yarnCount.BorderColor = Color.FromArgb(43, 43, 43);
                yarnCount.Focus();
                return;
            }

            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string phoneNumber = txtNumber.Text;
            int yarn = int.Parse(yarnCount.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.insertEmployee(firstname, lastname, phoneNumber, yarn);
            UpdateTable();
            Clear();
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                txtId.BorderColor = Color.Red;
                MessageBox.Show("Please select the Employee you want to update from the table on the right.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.BorderColor = Color.FromArgb(43, 43, 43);
                return;
            }
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert First Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.BorderColor = Color.FromArgb(43, 43, 43);
                txtFirstName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Last Name First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.BorderColor = Color.FromArgb(43, 43, 43);
                txtLastName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNumber.Text))
            {
                txtNumber.BorderColor = Color.Red;
                MessageBox.Show("Please Insert Phone Number First.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.BorderColor = Color.FromArgb(43, 43, 43);
                txtNumber.Focus();
                return;
            }
            if (int.Parse(yarnCount.Text) < 0)
            {
                yarnCount.BorderColor = Color.Red;
                MessageBox.Show("Please Insert A Valid Yarn Value.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yarnCount.BorderColor = Color.FromArgb(43, 43, 43);
                yarnCount.Focus();
                return;
            }

            int id = int.Parse(txtId.Text);
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string phoneNumber = txtNumber.Text;
            int yarn = int.Parse(yarnCount.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.updateEmployee(id, firstname, lastname, phoneNumber, yarn);
            UpdateTable();
            Clear();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                txtId.BorderColor = Color.Red;
                MessageBox.Show("Please select the Employee you want to delete from the table on the right.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.BorderColor = Color.FromArgb(43, 43, 43);
                return;
            }

            int id = int.Parse(txtId.Text);

            ThirdLayer tl = new ThirdLayer();
            tl.deleteEmployee(id);
            UpdateTable();
            Clear();
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
