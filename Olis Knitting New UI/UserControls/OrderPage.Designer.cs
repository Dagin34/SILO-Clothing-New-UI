namespace Olis_Knitting_New_UI.UserControls
{
    partial class OrderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableUpdater = new System.Windows.Forms.Timer(this.components);
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtCustId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtOrderId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBy = new Guna.UI.WinForms.GunaComboBox();
            this.SearchButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtItemId = new Guna.UI.WinForms.GunaTextBox();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.ClearButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.notPaid = new Guna.UI.WinForms.GunaRadioButton();
            this.paid = new Guna.UI.WinForms.GunaRadioButton();
            this.progressCombo = new Guna.UI.WinForms.GunaComboBox();
            this.statusCombo = new Guna.UI.WinForms.GunaComboBox();
            this.deliveryDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.orderDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.txtLocation = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.updateEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dgvCustomers = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.choiceLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusChecker = new Guna.UI.WinForms.GunaComboBox();
            this.progressChecker = new Guna.UI.WinForms.GunaComboBox();
            this.RenameButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contactLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.chooseCustomer = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableUpdater
            // 
            this.TableUpdater.Interval = 3000;
            this.TableUpdater.Tick += new System.EventHandler(this.TableUpdater_Tick);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel5.Location = new System.Drawing.Point(21, 233);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(110, 26);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Delivery Date";
            // 
            // txtCustId
            // 
            this.txtCustId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtCustId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtCustId.BorderSize = 1;
            this.txtCustId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustId.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtCustId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtCustId.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtCustId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(136, 108);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.PasswordChar = '\0';
            this.txtCustId.SelectedText = "";
            this.txtCustId.Size = new System.Drawing.Size(268, 34);
            this.txtCustId.TabIndex = 2;
            this.txtCustId.TextOffsetX = 5;
            this.txtCustId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_Only_Key_Press);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel2.Location = new System.Drawing.Point(22, 113);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(105, 26);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Customer Id";
            // 
            // txtOrderId
            // 
            this.txtOrderId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtOrderId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtOrderId.BorderSize = 1;
            this.txtOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderId.Enabled = false;
            this.txtOrderId.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtOrderId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtOrderId.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtOrderId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(136, 68);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.PasswordChar = '\0';
            this.txtOrderId.SelectedText = "";
            this.txtOrderId.Size = new System.Drawing.Size(268, 34);
            this.txtOrderId.TabIndex = 1;
            this.txtOrderId.TextOffsetX = 5;
            this.txtOrderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_Only_Key_Press);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel1.Location = new System.Drawing.Point(22, 73);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(73, 26);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Order Id";
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
            this.panel1.Size = new System.Drawing.Size(1232, 58);
            this.panel1.TabIndex = 15;
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
            "Search By Customer Name",
            "Search By Item Type"});
            this.SearchBy.Location = new System.Drawing.Point(617, 9);
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
            this.SearchButton.Location = new System.Drawing.Point(1179, 7);
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
            this.txtSearch.LineSize = 1;
            this.txtSearch.Location = new System.Drawing.Point(876, 9);
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
            this.label1.Size = new System.Drawing.Size(110, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // saveEmployee
            // 
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
            this.saveEmployee.Location = new System.Drawing.Point(27, 551);
            this.saveEmployee.Name = "saveEmployee";
            this.saveEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.saveEmployee.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.saveEmployee.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.saveEmployee.OnHoverImage = null;
            this.saveEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.saveEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.saveEmployee.Size = new System.Drawing.Size(186, 38);
            this.saveEmployee.TabIndex = 8;
            this.saveEmployee.Text = "Place Order";
            this.saveEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveEmployee.Click += new System.EventHandler(this.saveOrder_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel4.Location = new System.Drawing.Point(22, 193);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(94, 26);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Order Date";
            // 
            // txtItemId
            // 
            this.txtItemId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtItemId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtItemId.BorderSize = 1;
            this.txtItemId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemId.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtItemId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtItemId.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtItemId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemId.Location = new System.Drawing.Point(136, 148);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.PasswordChar = '\0';
            this.txtItemId.SelectedText = "";
            this.txtItemId.Size = new System.Drawing.Size(268, 34);
            this.txtItemId.TabIndex = 3;
            this.txtItemId.TextOffsetX = 5;
            this.txtItemId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_Only_Key_Press);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.Location = new System.Drawing.Point(26, 119);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1179, 555);
            this.dgv.TabIndex = 17;
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
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Silver;
            this.dgv.ThemeStyle.RowsStyle.Height = 25;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.MouseEnter += new System.EventHandler(this.dgv_MouseEnter);
            this.dgv.MouseLeave += new System.EventHandler(this.dgv_MouseLeave);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.ClearButton);
            this.gunaGroupBox1.Controls.Add(this.notPaid);
            this.gunaGroupBox1.Controls.Add(this.paid);
            this.gunaGroupBox1.Controls.Add(this.progressCombo);
            this.gunaGroupBox1.Controls.Add(this.statusCombo);
            this.gunaGroupBox1.Controls.Add(this.deliveryDate);
            this.gunaGroupBox1.Controls.Add(this.orderDate);
            this.gunaGroupBox1.Controls.Add(this.txtQuantity);
            this.gunaGroupBox1.Controls.Add(this.txtLocation);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel10);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel11);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel12);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel14);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.updateEmployee);
            this.gunaGroupBox1.Controls.Add(this.deleteEmployee);
            this.gunaGroupBox1.Controls.Add(this.saveEmployee);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.txtItemId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.txtCustId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.txtOrderId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(26, 685);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(430, 669);
            this.gunaGroupBox1.TabIndex = 16;
            this.gunaGroupBox1.Text = "Place Orders";
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
            this.ClearButton.Location = new System.Drawing.Point(305, 517);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClearButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClearButton.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.ClearButton.OnHoverImage = null;
            this.ClearButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ClearButton.OnPressedColor = System.Drawing.Color.Black;
            this.ClearButton.Size = new System.Drawing.Size(97, 28);
            this.ClearButton.TabIndex = 30;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // notPaid
            // 
            this.notPaid.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.notPaid.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.notPaid.CheckedOnColor = System.Drawing.Color.Gold;
            this.notPaid.FillColor = System.Drawing.Color.White;
            this.notPaid.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notPaid.Location = new System.Drawing.Point(243, 435);
            this.notPaid.Name = "notPaid";
            this.notPaid.Size = new System.Drawing.Size(93, 22);
            this.notPaid.TabIndex = 29;
            this.notPaid.Text = "  Not Paid";
            // 
            // paid
            // 
            this.paid.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.paid.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.paid.CheckedOnColor = System.Drawing.Color.Gold;
            this.paid.FillColor = System.Drawing.Color.White;
            this.paid.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid.Location = new System.Drawing.Point(137, 435);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(67, 22);
            this.paid.TabIndex = 29;
            this.paid.Text = "  Paid";
            // 
            // progressCombo
            // 
            this.progressCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.progressCombo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.progressCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.progressCombo.BorderSize = 1;
            this.progressCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.progressCombo.DropDownHeight = 500;
            this.progressCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.progressCombo.FocusedColor = System.Drawing.Color.Empty;
            this.progressCombo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.progressCombo.FormattingEnabled = true;
            this.progressCombo.IntegralHeight = false;
            this.progressCombo.ItemHeight = 28;
            this.progressCombo.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.progressCombo.Location = new System.Drawing.Point(137, 348);
            this.progressCombo.Name = "progressCombo";
            this.progressCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressCombo.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressCombo.Size = new System.Drawing.Size(266, 34);
            this.progressCombo.StartIndex = 2;
            this.progressCombo.TabIndex = 28;
            // 
            // statusCombo
            // 
            this.statusCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.statusCombo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.statusCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.statusCombo.BorderSize = 1;
            this.statusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusCombo.DropDownHeight = 500;
            this.statusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCombo.FocusedColor = System.Drawing.Color.Empty;
            this.statusCombo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.IntegralHeight = false;
            this.statusCombo.ItemHeight = 28;
            this.statusCombo.Items.AddRange(new object[] {
            "Pending",
            "Finished",
            "Delivered"});
            this.statusCombo.Location = new System.Drawing.Point(136, 308);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusCombo.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusCombo.Size = new System.Drawing.Size(266, 34);
            this.statusCombo.StartIndex = 2;
            this.statusCombo.TabIndex = 27;
            // 
            // deliveryDate
            // 
            this.deliveryDate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.deliveryDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.deliveryDate.BorderSize = 1;
            this.deliveryDate.CustomFormat = null;
            this.deliveryDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.deliveryDate.FocusedColor = System.Drawing.Color.DarkGray;
            this.deliveryDate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDate.ForeColor = System.Drawing.Color.DarkGray;
            this.deliveryDate.Location = new System.Drawing.Point(136, 228);
            this.deliveryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.deliveryDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.deliveryDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.deliveryDate.OnHoverForeColor = System.Drawing.Color.Silver;
            this.deliveryDate.OnPressedColor = System.Drawing.Color.Black;
            this.deliveryDate.Size = new System.Drawing.Size(268, 34);
            this.deliveryDate.TabIndex = 26;
            this.deliveryDate.Text = "Sunday, August 6, 2023";
            this.deliveryDate.Value = new System.DateTime(2023, 8, 6, 17, 31, 44, 0);
            // 
            // orderDate
            // 
            this.orderDate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.orderDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.orderDate.BorderSize = 1;
            this.orderDate.CustomFormat = null;
            this.orderDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.orderDate.FocusedColor = System.Drawing.Color.DarkGray;
            this.orderDate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.ForeColor = System.Drawing.Color.DarkGray;
            this.orderDate.Location = new System.Drawing.Point(136, 188);
            this.orderDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.orderDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.orderDate.Name = "orderDate";
            this.orderDate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.orderDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.orderDate.OnHoverForeColor = System.Drawing.Color.Silver;
            this.orderDate.OnPressedColor = System.Drawing.Color.Black;
            this.orderDate.Size = new System.Drawing.Size(268, 34);
            this.orderDate.TabIndex = 25;
            this.orderDate.Text = "Sunday, August 6, 2023";
            this.orderDate.Value = new System.DateTime(2023, 8, 6, 17, 31, 44, 0);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtQuantity.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(137, 388);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(266, 34);
            this.txtQuantity.TabIndex = 21;
            this.txtQuantity.TextOffsetX = 5;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_Only_Key_Press);
            // 
            // txtLocation
            // 
            this.txtLocation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.txtLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtLocation.BorderSize = 1;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtLocation.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.txtLocation.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(137, 268);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(266, 34);
            this.txtLocation.TabIndex = 18;
            this.txtLocation.TextOffsetX = 5;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel10.Location = new System.Drawing.Point(21, 434);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(95, 26);
            this.gunaLabel10.TabIndex = 17;
            this.gunaLabel10.Text = "Paid or Not";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel11.Location = new System.Drawing.Point(22, 394);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(76, 26);
            this.gunaLabel11.TabIndex = 16;
            this.gunaLabel11.Text = "Quantity";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel12.Location = new System.Drawing.Point(22, 354);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(78, 26);
            this.gunaLabel12.TabIndex = 15;
            this.gunaLabel12.Text = "Progress";
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel13.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel13.Location = new System.Drawing.Point(22, 314);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(59, 26);
            this.gunaLabel13.TabIndex = 14;
            this.gunaLabel13.Text = "Status";
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel14.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel14.Location = new System.Drawing.Point(22, 274);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(76, 26);
            this.gunaLabel14.TabIndex = 13;
            this.gunaLabel14.Text = "Location";
            // 
            // updateEmployee
            // 
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
            this.updateEmployee.Location = new System.Drawing.Point(226, 551);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.updateEmployee.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.updateEmployee.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.updateEmployee.OnHoverImage = null;
            this.updateEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.updateEmployee.Size = new System.Drawing.Size(177, 38);
            this.updateEmployee.TabIndex = 9;
            this.updateEmployee.Text = "Update Order";
            this.updateEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateEmployee.Click += new System.EventHandler(this.updateOrder_Click);
            // 
            // deleteEmployee
            // 
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
            this.deleteEmployee.Location = new System.Drawing.Point(27, 595);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.deleteEmployee.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.deleteEmployee.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.deleteEmployee.OnHoverImage = null;
            this.deleteEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.deleteEmployee.Size = new System.Drawing.Size(377, 38);
            this.deleteEmployee.TabIndex = 10;
            this.deleteEmployee.Text = "Delete Order";
            this.deleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel3.Location = new System.Drawing.Point(22, 153);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(63, 26);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Item Id";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomers.ColumnHeadersHeight = 35;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvCustomers.Location = new System.Drawing.Point(473, 873);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(732, 481);
            this.dgvCustomers.TabIndex = 18;
            this.dgvCustomers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCustomers.ThemeStyle.ReadOnly = true;
            this.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Silver;
            this.dgvCustomers.ThemeStyle.RowsStyle.Height = 25;
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.MouseEnter += new System.EventHandler(this.dgv_MouseEnter);
            this.dgvCustomers.MouseLeave += new System.EventHandler(this.dgv_MouseLeave);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(172)))), ((int)(((byte)(192)))));
            this.gunaLabel6.Location = new System.Drawing.Point(517, 3);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(204, 22);
            this.gunaLabel6.TabIndex = 13;
            this.gunaLabel6.Text = "Powered By Dagmawi Napoleon";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.choiceLabel);
            this.panel2.Location = new System.Drawing.Point(473, 834);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 38);
            this.panel2.TabIndex = 20;
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLabel.ForeColor = System.Drawing.Color.Silver;
            this.choiceLabel.Location = new System.Drawing.Point(300, 6);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(132, 26);
            this.choiceLabel.TabIndex = 22;
            this.choiceLabel.Text = "Customer Table";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel9.Location = new System.Drawing.Point(535, 6);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(108, 26);
            this.gunaLabel9.TabIndex = 23;
            this.gunaLabel9.Text = "Orders Table";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.gunaLabel9);
            this.panel4.Location = new System.Drawing.Point(27, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1178, 38);
            this.panel4.TabIndex = 24;
            // 
            // statusChecker
            // 
            this.statusChecker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.statusChecker.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.statusChecker.BorderColor = System.Drawing.Color.Black;
            this.statusChecker.BorderSize = 1;
            this.statusChecker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusChecker.DropDownHeight = 108;
            this.statusChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusChecker.FocusedColor = System.Drawing.Color.Empty;
            this.statusChecker.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusChecker.ForeColor = System.Drawing.Color.DarkGray;
            this.statusChecker.FormattingEnabled = true;
            this.statusChecker.IntegralHeight = false;
            this.statusChecker.ItemHeight = 34;
            this.statusChecker.Items.AddRange(new object[] {
            "Status: All ",
            "Pending",
            "Finished",
            "Delivered"});
            this.statusChecker.Location = new System.Drawing.Point(472, 685);
            this.statusChecker.Name = "statusChecker";
            this.statusChecker.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusChecker.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusChecker.Size = new System.Drawing.Size(219, 40);
            this.statusChecker.StartIndex = 0;
            this.statusChecker.TabIndex = 25;
            this.statusChecker.SelectedIndexChanged += new System.EventHandler(this.progressChecker_SelectedIndexChanged);
            this.statusChecker.SelectionChangeCommitted += new System.EventHandler(this.progressChecker_SelectionChangeCommitted);
            // 
            // progressChecker
            // 
            this.progressChecker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressChecker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.progressChecker.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.progressChecker.BorderColor = System.Drawing.Color.Black;
            this.progressChecker.BorderSize = 1;
            this.progressChecker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.progressChecker.DropDownHeight = 108;
            this.progressChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.progressChecker.FocusedColor = System.Drawing.Color.Empty;
            this.progressChecker.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressChecker.ForeColor = System.Drawing.Color.DarkGray;
            this.progressChecker.FormattingEnabled = true;
            this.progressChecker.IntegralHeight = false;
            this.progressChecker.ItemHeight = 34;
            this.progressChecker.Items.AddRange(new object[] {
            "Progress: All",
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.progressChecker.Location = new System.Drawing.Point(740, 685);
            this.progressChecker.Name = "progressChecker";
            this.progressChecker.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressChecker.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressChecker.Size = new System.Drawing.Size(219, 40);
            this.progressChecker.StartIndex = 0;
            this.progressChecker.TabIndex = 26;
            this.progressChecker.SelectedIndexChanged += new System.EventHandler(this.progressChecker_SelectedIndexChanged);
            this.progressChecker.SelectionChangeCommitted += new System.EventHandler(this.progressChecker_SelectionChangeCommitted);
            // 
            // RenameButton
            // 
            this.RenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameButton.AnimationHoverSpeed = 0.07F;
            this.RenameButton.AnimationSpeed = 0.03F;
            this.RenameButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.RenameButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RenameButton.BorderSize = 1;
            this.RenameButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.RenameButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.RenameButton.CheckedForeColor = System.Drawing.Color.White;
            this.RenameButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("RenameButton.CheckedImage")));
            this.RenameButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.RenameButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RenameButton.FocusedColor = System.Drawing.Color.Empty;
            this.RenameButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameButton.ForeColor = System.Drawing.Color.LightGray;
            this.RenameButton.Image = null;
            this.RenameButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RenameButton.ImageSize = new System.Drawing.Size(30, 30);
            this.RenameButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RenameButton.Location = new System.Drawing.Point(1003, 685);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.RenameButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.RenameButton.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.RenameButton.OnHoverImage = null;
            this.RenameButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RenameButton.OnPressedColor = System.Drawing.Color.Black;
            this.RenameButton.Size = new System.Drawing.Size(202, 40);
            this.RenameButton.TabIndex = 29;
            this.RenameButton.Text = "Draft Reminder";
            this.RenameButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.contactLabel);
            this.panel5.Controls.Add(this.gunaLabel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 1396);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1232, 27);
            this.panel5.TabIndex = 30;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(172)))), ((int)(((byte)(192)))));
            this.contactLabel.Location = new System.Drawing.Point(1093, 3);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(136, 22);
            this.contactLabel.TabIndex = 13;
            this.contactLabel.Text = "Contact Information";
            this.contactLabel.Click += new System.EventHandler(this.ContactLabel_Click);
            this.contactLabel.MouseEnter += new System.EventHandler(this.ContactLabel_MouseEnter);
            this.contactLabel.MouseLeave += new System.EventHandler(this.contactLabel_MouseLeave);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.LightGray;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(473, 753);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(338, 40);
            this.gunaAdvenceButton1.TabIndex = 29;
            this.gunaAdvenceButton1.Text = "Choose Item";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.chooseItem_Click);
            // 
            // chooseCustomer
            // 
            this.chooseCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseCustomer.AnimationHoverSpeed = 0.07F;
            this.chooseCustomer.AnimationSpeed = 0.03F;
            this.chooseCustomer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.chooseCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.chooseCustomer.BorderSize = 1;
            this.chooseCustomer.CheckedBaseColor = System.Drawing.Color.Gray;
            this.chooseCustomer.CheckedBorderColor = System.Drawing.Color.Black;
            this.chooseCustomer.CheckedForeColor = System.Drawing.Color.White;
            this.chooseCustomer.CheckedImage = ((System.Drawing.Image)(resources.GetObject("chooseCustomer.CheckedImage")));
            this.chooseCustomer.CheckedLineColor = System.Drawing.Color.DimGray;
            this.chooseCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.chooseCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.chooseCustomer.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCustomer.ForeColor = System.Drawing.Color.LightGray;
            this.chooseCustomer.Image = null;
            this.chooseCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.chooseCustomer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.chooseCustomer.Location = new System.Drawing.Point(867, 753);
            this.chooseCustomer.Name = "chooseCustomer";
            this.chooseCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.chooseCustomer.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.chooseCustomer.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.chooseCustomer.OnHoverImage = null;
            this.chooseCustomer.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.chooseCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.chooseCustomer.Size = new System.Drawing.Size(338, 40);
            this.chooseCustomer.TabIndex = 29;
            this.chooseCustomer.Text = "Choose Customer";
            this.chooseCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseCustomer.Click += new System.EventHandler(this.chooseCustomer_Click);
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.AutoSize = true;
            this.gunaLabel16.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.gunaLabel16.Location = new System.Drawing.Point(517, 1368);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(0, 22);
            this.gunaLabel16.TabIndex = 13;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.gunaLabel16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.chooseCustomer);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.progressChecker);
            this.Controls.Add(this.statusChecker);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "OrderPage";
            this.Size = new System.Drawing.Size(1232, 1423);
            this.Load += new System.EventHandler(this.OrderPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TableUpdater;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtCustId;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtOrderId;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox SearchBy;
        private Guna.UI.WinForms.GunaAdvenceButton SearchButton;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton saveEmployee;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtItemId;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaAdvenceButton updateEmployee;
        private Guna.UI.WinForms.GunaAdvenceButton deleteEmployee;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDataGridView dgvCustomers;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel choiceLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaTextBox txtLocation;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaDateTimePicker deliveryDate;
        private Guna.UI.WinForms.GunaDateTimePicker orderDate;
        private Guna.UI.WinForms.GunaComboBox progressCombo;
        private Guna.UI.WinForms.GunaComboBox statusCombo;
        private Guna.UI.WinForms.GunaComboBox statusChecker;
        private Guna.UI.WinForms.GunaComboBox progressChecker;
        private Guna.UI.WinForms.GunaAdvenceButton RenameButton;
        private Guna.UI.WinForms.GunaRadioButton paid;
        private Guna.UI.WinForms.GunaRadioButton notPaid;
        private Guna.UI.WinForms.GunaAdvenceButton ClearButton;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaLabel contactLabel;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton chooseCustomer;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
    }
}
