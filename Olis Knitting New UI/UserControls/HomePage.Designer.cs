namespace Olis_Knitting_New_UI.UserControls
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBy = new Guna.UI.WinForms.GunaComboBox();
            this.SearchButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.groupBox = new Guna.UI.WinForms.GunaGroupBox();
            this.ClearButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.updateItem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteItem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.saveItem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.employeeId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.orderId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.CommissionId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TableUpdater = new System.Windows.Forms.Timer(this.components);
            this.popupPanel = new System.Windows.Forms.Panel();
            this.dgv2 = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvLabel = new Guna.UI.WinForms.GunaLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chooseEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.chooseOrder = new Guna.UI.WinForms.GunaAdvenceButton();
            this.returnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox.SuspendLayout();
            this.popupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.SearchBy);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 58);
            this.panel1.TabIndex = 16;
            // 
            // SearchBy
            // 
            this.SearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SearchBy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SearchBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            "Search By Order Name",
            "Search By Employee Name",
            "Search By Customer Name"});
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
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.LightGray;
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.LineColor = System.Drawing.Color.Gray;
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
            this.label1.Size = new System.Drawing.Size(101, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.Location = new System.Drawing.Point(498, 80);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(719, 625);
            this.dgv.TabIndex = 18;
            this.dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Silver;
            this.dgv.ThemeStyle.RowsStyle.Height = 25;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.groupBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.groupBox.Controls.Add(this.ClearButton);
            this.groupBox.Controls.Add(this.updateItem);
            this.groupBox.Controls.Add(this.deleteItem);
            this.groupBox.Controls.Add(this.saveItem);
            this.groupBox.Controls.Add(this.employeeId);
            this.groupBox.Controls.Add(this.gunaLabel3);
            this.groupBox.Controls.Add(this.orderId);
            this.groupBox.Controls.Add(this.gunaLabel2);
            this.groupBox.Controls.Add(this.CommissionId);
            this.groupBox.Controls.Add(this.gunaLabel1);
            this.groupBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.groupBox.LineTop = 40;
            this.groupBox.Location = new System.Drawing.Point(21, 80);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(449, 452);
            this.groupBox.TabIndex = 17;
            this.groupBox.Text = "Assign Employee";
            this.groupBox.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // ClearButton
            // 
            this.ClearButton.AnimationHoverSpeed = 0.07F;
            this.ClearButton.AnimationSpeed = 0.03F;
            this.ClearButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
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
            this.ClearButton.ForeColor = System.Drawing.Color.LightGray;
            this.ClearButton.Image = null;
            this.ClearButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ClearButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ClearButton.Location = new System.Drawing.Point(333, 320);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClearButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
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
            // updateItem
            // 
            this.updateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateItem.AnimationHoverSpeed = 0.07F;
            this.updateItem.AnimationSpeed = 0.03F;
            this.updateItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.updateItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.updateItem.BorderSize = 1;
            this.updateItem.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updateItem.CheckedBorderColor = System.Drawing.Color.Black;
            this.updateItem.CheckedForeColor = System.Drawing.Color.White;
            this.updateItem.CheckedImage = ((System.Drawing.Image)(resources.GetObject("updateItem.CheckedImage")));
            this.updateItem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updateItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateItem.FocusedColor = System.Drawing.Color.Empty;
            this.updateItem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItem.ForeColor = System.Drawing.Color.LightGray;
            this.updateItem.Image = null;
            this.updateItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateItem.ImageSize = new System.Drawing.Size(30, 30);
            this.updateItem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateItem.Location = new System.Drawing.Point(237, 354);
            this.updateItem.Name = "updateItem";
            this.updateItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.updateItem.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.updateItem.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.updateItem.OnHoverImage = null;
            this.updateItem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateItem.OnPressedColor = System.Drawing.Color.Black;
            this.updateItem.Size = new System.Drawing.Size(193, 38);
            this.updateItem.TabIndex = 9;
            this.updateItem.Text = "Update Comission";
            this.updateItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteItem.AnimationHoverSpeed = 0.07F;
            this.deleteItem.AnimationSpeed = 0.03F;
            this.deleteItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.deleteItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.deleteItem.BorderSize = 1;
            this.deleteItem.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deleteItem.CheckedBorderColor = System.Drawing.Color.Black;
            this.deleteItem.CheckedForeColor = System.Drawing.Color.White;
            this.deleteItem.CheckedImage = ((System.Drawing.Image)(resources.GetObject("deleteItem.CheckedImage")));
            this.deleteItem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteItem.FocusedColor = System.Drawing.Color.Empty;
            this.deleteItem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.ForeColor = System.Drawing.Color.LightGray;
            this.deleteItem.Image = null;
            this.deleteItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteItem.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteItem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteItem.Location = new System.Drawing.Point(29, 398);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.deleteItem.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.deleteItem.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.deleteItem.OnHoverImage = null;
            this.deleteItem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteItem.OnPressedColor = System.Drawing.Color.Black;
            this.deleteItem.Size = new System.Drawing.Size(401, 38);
            this.deleteItem.TabIndex = 10;
            this.deleteItem.Text = "Delete Comission";
            this.deleteItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // saveItem
            // 
            this.saveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveItem.AnimationHoverSpeed = 0.07F;
            this.saveItem.AnimationSpeed = 0.03F;
            this.saveItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.saveItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveItem.BorderSize = 1;
            this.saveItem.CheckedBaseColor = System.Drawing.Color.Gray;
            this.saveItem.CheckedBorderColor = System.Drawing.Color.Black;
            this.saveItem.CheckedForeColor = System.Drawing.Color.White;
            this.saveItem.CheckedImage = ((System.Drawing.Image)(resources.GetObject("saveItem.CheckedImage")));
            this.saveItem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.saveItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveItem.FocusedColor = System.Drawing.Color.Empty;
            this.saveItem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItem.ForeColor = System.Drawing.Color.LightGray;
            this.saveItem.Image = null;
            this.saveItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveItem.ImageSize = new System.Drawing.Size(30, 30);
            this.saveItem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.saveItem.Location = new System.Drawing.Point(29, 354);
            this.saveItem.Name = "saveItem";
            this.saveItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveItem.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.saveItem.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.saveItem.OnHoverImage = null;
            this.saveItem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.saveItem.OnPressedColor = System.Drawing.Color.Black;
            this.saveItem.Size = new System.Drawing.Size(202, 38);
            this.saveItem.TabIndex = 8;
            this.saveItem.Text = "Assign Employee";
            this.saveItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // employeeId
            // 
            this.employeeId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.employeeId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.employeeId.BorderSize = 1;
            this.employeeId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeId.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.employeeId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.employeeId.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.employeeId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeId.Location = new System.Drawing.Point(137, 138);
            this.employeeId.Name = "employeeId";
            this.employeeId.PasswordChar = '\0';
            this.employeeId.SelectedText = "";
            this.employeeId.Size = new System.Drawing.Size(293, 34);
            this.employeeId.TabIndex = 3;
            this.employeeId.TextOffsetX = 5;
            this.employeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Commission_KeyPress);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel3.Location = new System.Drawing.Point(24, 143);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(103, 26);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Employee Id";
            // 
            // orderId
            // 
            this.orderId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.orderId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.orderId.BorderSize = 1;
            this.orderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderId.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.orderId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.orderId.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.orderId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.Location = new System.Drawing.Point(137, 98);
            this.orderId.Name = "orderId";
            this.orderId.PasswordChar = '\0';
            this.orderId.SelectedText = "";
            this.orderId.Size = new System.Drawing.Size(293, 34);
            this.orderId.TabIndex = 2;
            this.orderId.TextOffsetX = 5;
            this.orderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Commission_KeyPress);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel2.Location = new System.Drawing.Point(24, 103);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(73, 26);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Order Id";
            // 
            // CommissionId
            // 
            this.CommissionId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CommissionId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.CommissionId.BorderSize = 1;
            this.CommissionId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommissionId.Enabled = false;
            this.CommissionId.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CommissionId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.CommissionId.FocusedForeColor = System.Drawing.Color.DarkGray;
            this.CommissionId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommissionId.Location = new System.Drawing.Point(137, 58);
            this.CommissionId.Name = "CommissionId";
            this.CommissionId.PasswordChar = '\0';
            this.CommissionId.SelectedText = "";
            this.CommissionId.Size = new System.Drawing.Size(293, 34);
            this.CommissionId.TabIndex = 1;
            this.CommissionId.TextOffsetX = 5;
            this.CommissionId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Commission_KeyPress);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel1.Location = new System.Drawing.Point(24, 63);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(111, 26);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Comission Id";
            // 
            // TableUpdater
            // 
            this.TableUpdater.Interval = 3000;
            // 
            // popupPanel
            // 
            this.popupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popupPanel.Controls.Add(this.panel4);
            this.popupPanel.Controls.Add(this.dgv2);
            this.popupPanel.Controls.Add(this.returnBack);
            this.popupPanel.Location = new System.Drawing.Point(6, 1590);
            this.popupPanel.Name = "popupPanel";
            this.popupPanel.Size = new System.Drawing.Size(1243, 855);
            this.popupPanel.TabIndex = 19;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv2.ColumnHeadersHeight = 35;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgv2.EnableHeadersVisualStyles = false;
            this.dgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv2.Location = new System.Drawing.Point(18, 53);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(1196, 472);
            this.dgv2.TabIndex = 19;
            this.dgv2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgv2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgv2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgv2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv2.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv2.ThemeStyle.ReadOnly = true;
            this.dgv2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgv2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Silver;
            this.dgv2.ThemeStyle.RowsStyle.Height = 25;
            this.dgv2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.dgv2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellClick);
            // 
            // dgvLabel
            // 
            this.dgvLabel.AutoSize = true;
            this.dgvLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLabel.ForeColor = System.Drawing.Color.Silver;
            this.dgvLabel.Location = new System.Drawing.Point(535, 7);
            this.dgvLabel.Name = "dgvLabel";
            this.dgvLabel.Size = new System.Drawing.Size(108, 26);
            this.dgvLabel.TabIndex = 23;
            this.dgvLabel.Text = "Orders Table";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel4.Controls.Add(this.dgvLabel);
            this.panel4.Location = new System.Drawing.Point(18, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1196, 38);
            this.panel4.TabIndex = 25;
            // 
            // chooseEmployee
            // 
            this.chooseEmployee.AnimationHoverSpeed = 0.07F;
            this.chooseEmployee.AnimationSpeed = 0.03F;
            this.chooseEmployee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.chooseEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.chooseEmployee.BorderSize = 1;
            this.chooseEmployee.CheckedBaseColor = System.Drawing.Color.Gray;
            this.chooseEmployee.CheckedBorderColor = System.Drawing.Color.Black;
            this.chooseEmployee.CheckedForeColor = System.Drawing.Color.White;
            this.chooseEmployee.CheckedImage = ((System.Drawing.Image)(resources.GetObject("chooseEmployee.CheckedImage")));
            this.chooseEmployee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.chooseEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.chooseEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.chooseEmployee.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseEmployee.ForeColor = System.Drawing.Color.LightGray;
            this.chooseEmployee.Image = null;
            this.chooseEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.chooseEmployee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.chooseEmployee.Location = new System.Drawing.Point(21, 607);
            this.chooseEmployee.Name = "chooseEmployee";
            this.chooseEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.chooseEmployee.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.chooseEmployee.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.chooseEmployee.OnHoverImage = null;
            this.chooseEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.chooseEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.chooseEmployee.Size = new System.Drawing.Size(449, 43);
            this.chooseEmployee.TabIndex = 10;
            this.chooseEmployee.Text = "Choose Employee";
            this.chooseEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseEmployee.Click += new System.EventHandler(this.chooseEmployee_Click);
            // 
            // chooseOrder
            // 
            this.chooseOrder.AnimationHoverSpeed = 0.07F;
            this.chooseOrder.AnimationSpeed = 0.03F;
            this.chooseOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.chooseOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.chooseOrder.BorderSize = 1;
            this.chooseOrder.CheckedBaseColor = System.Drawing.Color.Gray;
            this.chooseOrder.CheckedBorderColor = System.Drawing.Color.Black;
            this.chooseOrder.CheckedForeColor = System.Drawing.Color.White;
            this.chooseOrder.CheckedImage = ((System.Drawing.Image)(resources.GetObject("chooseOrder.CheckedImage")));
            this.chooseOrder.CheckedLineColor = System.Drawing.Color.DimGray;
            this.chooseOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.chooseOrder.FocusedColor = System.Drawing.Color.Empty;
            this.chooseOrder.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseOrder.ForeColor = System.Drawing.Color.LightGray;
            this.chooseOrder.Image = null;
            this.chooseOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseOrder.ImageSize = new System.Drawing.Size(30, 30);
            this.chooseOrder.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.chooseOrder.Location = new System.Drawing.Point(21, 662);
            this.chooseOrder.Name = "chooseOrder";
            this.chooseOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.chooseOrder.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.chooseOrder.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.chooseOrder.OnHoverImage = null;
            this.chooseOrder.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.chooseOrder.OnPressedColor = System.Drawing.Color.Black;
            this.chooseOrder.Size = new System.Drawing.Size(449, 43);
            this.chooseOrder.TabIndex = 10;
            this.chooseOrder.Text = "Choose Order";
            this.chooseOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseOrder.Click += new System.EventHandler(this.chooseOrder_Click);
            // 
            // returnBack
            // 
            this.returnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnBack.AnimationHoverSpeed = 0.07F;
            this.returnBack.AnimationSpeed = 0.03F;
            this.returnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.returnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.returnBack.BorderSize = 1;
            this.returnBack.CheckedBaseColor = System.Drawing.Color.Gray;
            this.returnBack.CheckedBorderColor = System.Drawing.Color.Black;
            this.returnBack.CheckedForeColor = System.Drawing.Color.White;
            this.returnBack.CheckedImage = ((System.Drawing.Image)(resources.GetObject("returnBack.CheckedImage")));
            this.returnBack.CheckedLineColor = System.Drawing.Color.DimGray;
            this.returnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.returnBack.FocusedColor = System.Drawing.Color.Empty;
            this.returnBack.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBack.ForeColor = System.Drawing.Color.LightGray;
            this.returnBack.Image = null;
            this.returnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.returnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.returnBack.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.returnBack.Location = new System.Drawing.Point(765, 551);
            this.returnBack.Name = "returnBack";
            this.returnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.returnBack.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.returnBack.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.returnBack.OnHoverImage = null;
            this.returnBack.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.returnBack.OnPressedColor = System.Drawing.Color.Black;
            this.returnBack.Size = new System.Drawing.Size(449, 48);
            this.returnBack.TabIndex = 10;
            this.returnBack.Text = "Return Back";
            this.returnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.returnBack.Click += new System.EventHandler(this.returnBack_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.popupPanel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.chooseOrder);
            this.Controls.Add(this.chooseEmployee);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1249, 2448);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.popupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox SearchBy;
        private Guna.UI.WinForms.GunaAdvenceButton SearchButton;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaGroupBox groupBox;
        private Guna.UI.WinForms.GunaAdvenceButton ClearButton;
        private Guna.UI.WinForms.GunaAdvenceButton updateItem;
        private Guna.UI.WinForms.GunaAdvenceButton deleteItem;
        private Guna.UI.WinForms.GunaAdvenceButton saveItem;
        private Guna.UI.WinForms.GunaTextBox employeeId;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox orderId;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox CommissionId;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer TableUpdater;
        private System.Windows.Forms.Panel popupPanel;
        private Guna.UI.WinForms.GunaDataGridView dgv2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaLabel dgvLabel;
        private Guna.UI.WinForms.GunaAdvenceButton chooseEmployee;
        private Guna.UI.WinForms.GunaAdvenceButton chooseOrder;
        private Guna.UI.WinForms.GunaAdvenceButton returnBack;
    }
}
