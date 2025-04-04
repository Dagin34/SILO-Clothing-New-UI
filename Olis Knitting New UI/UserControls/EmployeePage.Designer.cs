﻿namespace Olis_Knitting_New_UI.UserControls
{
    partial class EmployeePage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBy = new Guna.UI.WinForms.GunaComboBox();
            this.SearchButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.saveEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtLastName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.EmpCount = new Guna.UI.WinForms.GunaLabel();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.ClearButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.salaryTxt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.yarnCount = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtFirstName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.EmployeeCount = new System.Windows.Forms.Timer(this.components);
            this.TableUpdater = new System.Windows.Forms.Timer(this.components);
            this.contactLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.SearchBy);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 58);
            this.panel1.TabIndex = 11;
            // 
            // SearchBy
            // 
            this.SearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.SearchBy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.SearchBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.SearchBy.BorderSize = 1;
            this.SearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SearchBy.DropDownHeight = 108;
            this.SearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBy.FocusedColor = System.Drawing.Color.Empty;
            this.SearchBy.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBy.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchBy.FormattingEnabled = true;
            this.SearchBy.IntegralHeight = false;
            this.SearchBy.ItemHeight = 34;
            this.SearchBy.Items.AddRange(new object[] {
            "Search By Name",
            "Search By Yarn Count",
            "Search By Number"});
            this.SearchBy.Location = new System.Drawing.Point(634, 9);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchBy.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBy.Size = new System.Drawing.Size(236, 40);
            this.SearchBy.StartIndex = 0;
            this.SearchBy.TabIndex = 4;
            this.SearchBy.SelectedIndexChanged += new System.EventHandler(this.SearchBy_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.AnimationHoverSpeed = 0.07F;
            this.SearchButton.AnimationSpeed = 0.03F;
            this.SearchButton.BaseColor = System.Drawing.Color.Transparent;
            this.SearchButton.BorderColor = System.Drawing.Color.Black;
            this.SearchButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SearchButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchButton.CheckedForeColor = System.Drawing.Color.White;
            this.SearchButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.CheckedImage")));
            this.SearchButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchButton.FocusedColor = System.Drawing.Color.Empty;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Image = global::Olis_Knitting_New_UI.Properties.Resources.icons8_search_48px;
            this.SearchButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchButton.ImageSize = new System.Drawing.Size(30, 30);
            this.SearchButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchButton.Location = new System.Drawing.Point(1196, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.SearchButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchButton.OnHoverImage = null;
            this.SearchButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchButton.OnPressedColor = System.Drawing.Color.Black;
            this.SearchButton.Size = new System.Drawing.Size(45, 45);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtSearch.LineSize = 2;
            this.txtSearch.Location = new System.Drawing.Point(893, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(297, 41);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextOffsetX = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // updateEmployee
            // 
            this.updateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateEmployee.AnimationHoverSpeed = 0.07F;
            this.updateEmployee.AnimationSpeed = 0.03F;
            this.updateEmployee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.updateEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.updateEmployee.BorderSize = 1;
            this.updateEmployee.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updateEmployee.CheckedBorderColor = System.Drawing.Color.Black;
            this.updateEmployee.CheckedForeColor = System.Drawing.Color.White;
            this.updateEmployee.CheckedImage = ((System.Drawing.Image)(resources.GetObject("updateEmployee.CheckedImage")));
            this.updateEmployee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updateEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.updateEmployee.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployee.ForeColor = System.Drawing.Color.Silver;
            this.updateEmployee.Image = null;
            this.updateEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.updateEmployee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateEmployee.Location = new System.Drawing.Point(231, 354);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.updateEmployee.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.updateEmployee.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.updateEmployee.OnHoverImage = null;
            this.updateEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.updateEmployee.Size = new System.Drawing.Size(193, 38);
            this.updateEmployee.TabIndex = 9;
            this.updateEmployee.Text = "Update Employee";
            this.updateEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEmployee.AnimationHoverSpeed = 0.07F;
            this.deleteEmployee.AnimationSpeed = 0.03F;
            this.deleteEmployee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.deleteEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.deleteEmployee.BorderSize = 1;
            this.deleteEmployee.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deleteEmployee.CheckedBorderColor = System.Drawing.Color.Black;
            this.deleteEmployee.CheckedForeColor = System.Drawing.Color.White;
            this.deleteEmployee.CheckedImage = ((System.Drawing.Image)(resources.GetObject("deleteEmployee.CheckedImage")));
            this.deleteEmployee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.deleteEmployee.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployee.ForeColor = System.Drawing.Color.Silver;
            this.deleteEmployee.Image = null;
            this.deleteEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteEmployee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteEmployee.Location = new System.Drawing.Point(23, 398);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.deleteEmployee.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.deleteEmployee.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.deleteEmployee.OnHoverImage = null;
            this.deleteEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.deleteEmployee.Size = new System.Drawing.Size(401, 38);
            this.deleteEmployee.TabIndex = 10;
            this.deleteEmployee.Text = "Delete Employee";
            this.deleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // saveEmployee
            // 
            this.saveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEmployee.AnimationHoverSpeed = 0.07F;
            this.saveEmployee.AnimationSpeed = 0.03F;
            this.saveEmployee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.saveEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveEmployee.BorderSize = 1;
            this.saveEmployee.CheckedBaseColor = System.Drawing.Color.Gray;
            this.saveEmployee.CheckedBorderColor = System.Drawing.Color.Black;
            this.saveEmployee.CheckedForeColor = System.Drawing.Color.White;
            this.saveEmployee.CheckedImage = ((System.Drawing.Image)(resources.GetObject("saveEmployee.CheckedImage")));
            this.saveEmployee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.saveEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.saveEmployee.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEmployee.ForeColor = System.Drawing.Color.Silver;
            this.saveEmployee.Image = null;
            this.saveEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.saveEmployee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.saveEmployee.Location = new System.Drawing.Point(23, 354);
            this.saveEmployee.Name = "saveEmployee";
            this.saveEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.saveEmployee.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.saveEmployee.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.saveEmployee.OnHoverImage = null;
            this.saveEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.saveEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.saveEmployee.Size = new System.Drawing.Size(202, 38);
            this.saveEmployee.TabIndex = 8;
            this.saveEmployee.Text = "Add Employee";
            this.saveEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveEmployee.Click += new System.EventHandler(this.saveEmployee_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtNumber.BorderSize = 1;
            this.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumber.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtNumber.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtNumber.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(131, 178);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PasswordChar = '\0';
            this.txtNumber.SelectedText = "";
            this.txtNumber.Size = new System.Drawing.Size(293, 34);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.TextOffsetX = 5;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel4.Location = new System.Drawing.Point(18, 183);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(73, 26);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Number";
            // 
            // txtLastName
            // 
            this.txtLastName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtLastName.BorderSize = 1;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtLastName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtLastName.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtLastName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(131, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(293, 34);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextOffsetX = 5;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel3.Location = new System.Drawing.Point(18, 143);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(90, 26);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Last Name";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.gunaPanel1.Controls.Add(this.panel2);
            this.gunaPanel1.Location = new System.Drawing.Point(26, 553);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(449, 142);
            this.gunaPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.gunaLabel8);
            this.panel2.Controls.Add(this.EmpCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 129);
            this.panel2.TabIndex = 0;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel8.Location = new System.Drawing.Point(7, 7);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(343, 42);
            this.gunaLabel8.TabIndex = 2;
            this.gunaLabel8.Text = "NUMBER OF EMPLOYEES ----";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmpCount
            // 
            this.EmpCount.AutoSize = true;
            this.EmpCount.Font = new System.Drawing.Font("Poppins", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpCount.ForeColor = System.Drawing.Color.Gold;
            this.EmpCount.Location = new System.Drawing.Point(26, 41);
            this.EmpCount.Name = "EmpCount";
            this.EmpCount.Size = new System.Drawing.Size(88, 113);
            this.EmpCount.TabIndex = 6;
            this.EmpCount.Text = "0";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.Location = new System.Drawing.Point(503, 82);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(719, 613);
            this.dgv.TabIndex = 13;
            this.dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Silver;
            this.dgv.ThemeStyle.RowsStyle.Height = 25;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.ClearButton);
            this.gunaGroupBox1.Controls.Add(this.salaryTxt);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.yarnCount);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.updateEmployee);
            this.gunaGroupBox1.Controls.Add(this.deleteEmployee);
            this.gunaGroupBox1.Controls.Add(this.saveEmployee);
            this.gunaGroupBox1.Controls.Add(this.txtNumber);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.txtLastName);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.txtFirstName);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.txtId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(26, 82);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(449, 452);
            this.gunaGroupBox1.TabIndex = 12;
            this.gunaGroupBox1.Text = "Add Employees";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // ClearButton
            // 
            this.ClearButton.AnimationHoverSpeed = 0.07F;
            this.ClearButton.AnimationSpeed = 0.03F;
            this.ClearButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClearButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClearButton.BorderSize = 1;
            this.ClearButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ClearButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ClearButton.CheckedForeColor = System.Drawing.Color.White;
            this.ClearButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ClearButton.CheckedImage")));
            this.ClearButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClearButton.FocusedColor = System.Drawing.Color.Empty;
            this.ClearButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Silver;
            this.ClearButton.Image = null;
            this.ClearButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ClearButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ClearButton.Location = new System.Drawing.Point(327, 320);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClearButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClearButton.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.ClearButton.OnHoverImage = null;
            this.ClearButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ClearButton.OnPressedColor = System.Drawing.Color.Black;
            this.ClearButton.Size = new System.Drawing.Size(97, 28);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // salaryTxt
            // 
            this.salaryTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.salaryTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.salaryTxt.BorderSize = 1;
            this.salaryTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salaryTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.salaryTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.salaryTxt.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.salaryTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTxt.Location = new System.Drawing.Point(131, 258);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.PasswordChar = '\0';
            this.salaryTxt.SelectedText = "";
            this.salaryTxt.Size = new System.Drawing.Size(293, 34);
            this.salaryTxt.TabIndex = 11;
            this.salaryTxt.TextOffsetX = 5;
            this.salaryTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel6.Location = new System.Drawing.Point(18, 263);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(59, 26);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "Salary";
            // 
            // yarnCount
            // 
            this.yarnCount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.yarnCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.yarnCount.BorderSize = 1;
            this.yarnCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yarnCount.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.yarnCount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.yarnCount.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.yarnCount.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yarnCount.Location = new System.Drawing.Point(130, 218);
            this.yarnCount.Name = "yarnCount";
            this.yarnCount.PasswordChar = '\0';
            this.yarnCount.SelectedText = "";
            this.yarnCount.Size = new System.Drawing.Size(293, 34);
            this.yarnCount.TabIndex = 11;
            this.yarnCount.TextOffsetX = 5;
            this.yarnCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel5.Location = new System.Drawing.Point(17, 223);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(98, 26);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Yarn Count";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtFirstName.BorderSize = 1;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtFirstName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtFirstName.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(131, 98);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(293, 34);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextOffsetX = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel2.Location = new System.Drawing.Point(18, 103);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(92, 26);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "First Name";
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtId.BorderSize = 1;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Enabled = false;
            this.txtId.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtId.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(131, 58);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(293, 34);
            this.txtId.TabIndex = 1;
            this.txtId.TextOffsetX = 5;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel1.Location = new System.Drawing.Point(18, 63);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(103, 26);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Employee Id";
            // 
            // EmployeeCount
            // 
            this.EmployeeCount.Interval = 500;
            this.EmployeeCount.Tick += new System.EventHandler(this.EmployeeCount_Tick);
            // 
            // TableUpdater
            // 
            this.TableUpdater.Interval = 6000;
            this.TableUpdater.Tick += new System.EventHandler(this.TableUpdater_Tick);
            // 
            // contactLabel
            // 
            this.contactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(172)))), ((int)(((byte)(192)))));
            this.contactLabel.Location = new System.Drawing.Point(1110, 3);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(136, 22);
            this.contactLabel.TabIndex = 13;
            this.contactLabel.Text = "Contact Information";
            this.contactLabel.Click += new System.EventHandler(this.ContactLabel_Click);
            this.contactLabel.MouseEnter += new System.EventHandler(this.ContactLabel_MouseEnter);
            this.contactLabel.MouseLeave += new System.EventHandler(this.contactLabel_MouseLeave);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(172)))), ((int)(((byte)(192)))));
            this.gunaLabel7.Location = new System.Drawing.Point(517, 3);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(204, 22);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "Powered By Dagmawi Napoleon";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.contactLabel);
            this.panel5.Controls.Add(this.gunaLabel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 712);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1249, 27);
            this.panel5.TabIndex = 32;
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "EmployeePage";
            this.Size = new System.Drawing.Size(1249, 739);
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox SearchBy;
        private Guna.UI.WinForms.GunaAdvenceButton SearchButton;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton updateEmployee;
        private Guna.UI.WinForms.GunaAdvenceButton deleteEmployee;
        private Guna.UI.WinForms.GunaAdvenceButton saveEmployee;
        private Guna.UI.WinForms.GunaTextBox txtNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtLastName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel EmpCount;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtFirstName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtId;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer EmployeeCount;
        private System.Windows.Forms.Timer TableUpdater;
        private Guna.UI.WinForms.GunaTextBox yarnCount;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaAdvenceButton ClearButton;
        private Guna.UI.WinForms.GunaTextBox salaryTxt;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel contactLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.Panel panel5;
    }
}
