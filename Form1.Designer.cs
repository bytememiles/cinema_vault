namespace CinemaVault
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showDbTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.showDbTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new CinemaVault.DatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showDbTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.showDbTableDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new JThinButton.JThinButton();
            this.btnEdit = new JThinButton.JThinButton();
            this.btnDel = new JThinButton.JThinButton();
            this.btnAbout = new JThinButton.JThinButton();
            this.searchBox = new JMetroTextBox.JMetroTextBox();
            this.sidePanel = new System.Windows.Forms.Button();
            this.titleBarDrag = new JDragControl.JDragControl(this.components);
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.btnHelp = new JThinButton.JThinButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.btnClearSearch = new JThinButton.JThinButton();
            this.titleLabelDrag = new JDragControl.JDragControl(this.components);
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.setApiKey = new System.Windows.Forms.Button();
            this.showDbTableTableAdapter = new CinemaVault.DatabaseDataSetTableAdapters.ShowDbTableTableAdapter();
            this.tableAdapterManager = new CinemaVault.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.apiKeySetup = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new CinemaVault.RoundButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowPoster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableBindingNavigator)).BeginInit();
            this.showDbTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // showDbTableBindingNavigator
            // 
            this.showDbTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.showDbTableBindingNavigator.BindingSource = this.showDbTableBindingSource;
            this.showDbTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.showDbTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.showDbTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.showDbTableBindingNavigatorSaveItem});
            this.showDbTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.showDbTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.showDbTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.showDbTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.showDbTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.showDbTableBindingNavigator.Name = "showDbTableBindingNavigator";
            this.showDbTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.showDbTableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.showDbTableBindingNavigator.TabIndex = 0;
            this.showDbTableBindingNavigator.Text = "bindingNavigator1";
            this.showDbTableBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // showDbTableBindingSource
            // 
            this.showDbTableBindingSource.DataMember = "ShowDbTable";
            this.showDbTableBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // showDbTableBindingNavigatorSaveItem
            // 
            this.showDbTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showDbTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("showDbTableBindingNavigatorSaveItem.Image")));
            this.showDbTableBindingNavigatorSaveItem.Name = "showDbTableBindingNavigatorSaveItem";
            this.showDbTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.showDbTableBindingNavigatorSaveItem.Text = "Save Data";
            this.showDbTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.ShowDbTableBindingNavigatorSaveItem_Click);
            // 
            // showDbTableDataGridView
            // 
            this.showDbTableDataGridView.AllowUserToAddRows = false;
            this.showDbTableDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.showDbTableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.showDbTableDataGridView.AutoGenerateColumns = false;
            this.showDbTableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.showDbTableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showDbTableDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showDbTableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.showDbTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDbTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.ShowPoster});
            this.showDbTableDataGridView.DataSource = this.showDbTableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showDbTableDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.showDbTableDataGridView.EnableHeadersVisualStyles = false;
            this.showDbTableDataGridView.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.showDbTableDataGridView.Location = new System.Drawing.Point(214, 138);
            this.showDbTableDataGridView.MaximumSize = new System.Drawing.Size(596, 348);
            this.showDbTableDataGridView.MultiSelect = false;
            this.showDbTableDataGridView.Name = "showDbTableDataGridView";
            this.showDbTableDataGridView.ReadOnly = true;
            this.showDbTableDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showDbTableDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.showDbTableDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDbTableDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.showDbTableDataGridView.RowTemplate.Height = 35;
            this.showDbTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDbTableDataGridView.ShowCellErrors = false;
            this.showDbTableDataGridView.ShowEditingIcon = false;
            this.showDbTableDataGridView.ShowRowErrors = false;
            this.showDbTableDataGridView.Size = new System.Drawing.Size(596, 348);
            this.showDbTableDataGridView.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Font_Size = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnAdd.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnAdd.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnAdd.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.LineThickness = 4;
            this.btnAdd.Location = new System.Drawing.Point(8, 138);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 87);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Tag = "";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.ButtonText = "Edit or View";
            this.btnEdit.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Font_Size = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnEdit.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnEdit.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnEdit.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.LineThickness = 4;
            this.btnEdit.Location = new System.Drawing.Point(8, 240);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(185, 87);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.btnDel.BorderRadius = 5;
            this.btnDel.ButtonText = "Delete";
            this.btnDel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Font_Size = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnDel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnDel.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnDel.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnDel.LineThickness = 4;
            this.btnDel.Location = new System.Drawing.Point(7, 342);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(185, 87);
            this.btnDel.TabIndex = 9;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnAbout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.btnAbout.BorderRadius = 5;
            this.btnAbout.ButtonText = "About";
            this.btnAbout.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font_Size = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnAbout.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnAbout.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnAbout.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnAbout.LineThickness = 4;
            this.btnAbout.Location = new System.Drawing.Point(8, 444);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(185, 42);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.searchBox.BorderRadius = 16;
            this.searchBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Font_Size = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColors = System.Drawing.Color.Gray;
            this.searchBox.IsPassword = false;
            this.searchBox.LineThickness = 3;
            this.searchBox.Location = new System.Drawing.Point(5, 40);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.MaxLength = 32767;
            this.searchBox.MouseOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.searchBox.Name = "searchBox";
            this.searchBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.OnFocusColor = System.Drawing.Color.Empty;
            this.searchBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.searchBox.ReadOnly = false;
            this.searchBox.Size = new System.Drawing.Size(159, 42);
            this.searchBox.TabIndex = 5;
            this.searchBox.TabStop = false;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.TextName = "Search";
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.sidePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sidePanel.Enabled = false;
            this.sidePanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(84)))), ((int)(((byte)(118)))));
            this.sidePanel.FlatAppearance.BorderSize = 4;
            this.sidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidePanel.Location = new System.Drawing.Point(0, 36);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 503);
            this.sidePanel.TabIndex = 11;
            this.sidePanel.UseVisualStyleBackColor = true;
            // 
            // titleBarDrag
            // 
            this.titleBarDrag.GetForm = this;
            this.titleBarDrag.TargetControl = this.titleBar;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.titleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleBar.ErrorImage = null;
            this.titleBar.InitialImage = null;
            this.titleBar.Location = new System.Drawing.Point(-9, -1);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(837, 37);
            this.titleBar.TabIndex = 12;
            this.titleBar.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnHelp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.btnHelp.BorderRadius = 5;
            this.btnHelp.ButtonText = "Help";
            this.btnHelp.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Font_Size = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnHelp.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnHelp.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnHelp.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnHelp.LineThickness = 4;
            this.btnHelp.Location = new System.Drawing.Point(8, 490);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(185, 42);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(383, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(78, 29);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Home";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnClearSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.btnClearSearch.BorderRadius = 5;
            this.btnClearSearch.ButtonText = "Clear Search";
            this.btnClearSearch.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Font_Size = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnClearSearch.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnClearSearch.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnClearSearch.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnClearSearch.LineThickness = 2;
            this.btnClearSearch.Location = new System.Drawing.Point(7, 83);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(185, 20);
            this.btnClearSearch.TabIndex = 20;
            this.btnClearSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // titleLabelDrag
            // 
            this.titleLabelDrag.GetForm = this;
            this.titleLabelDrag.TargetControl = this.titleLabel;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimize.Image = global::CinemaVault.Properties.Resources.MiniNormal;
            this.btnMinimize.Location = new System.Drawing.Point(741, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.BtnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.BtnMinimize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::CinemaVault.Properties.Resources.NormalClose;
            this.btnClose.Location = new System.Drawing.Point(785, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // setApiKey
            // 
            this.setApiKey.BackColor = System.Drawing.Color.Transparent;
            this.setApiKey.BackgroundImage = global::CinemaVault.Properties.Resources.key;
            this.setApiKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setApiKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.setApiKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.setApiKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.setApiKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setApiKey.Location = new System.Drawing.Point(785, 507);
            this.setApiKey.Name = "setApiKey";
            this.setApiKey.Size = new System.Drawing.Size(25, 25);
            this.setApiKey.TabIndex = 22;
            this.apiKeySetup.SetToolTip(this.setApiKey, "Allows you to configure your api key.");
            this.setApiKey.UseVisualStyleBackColor = false;
            this.setApiKey.Click += new System.EventHandler(this.SetApiKey_Click);
            // 
            // showDbTableTableAdapter
            // 
            this.showDbTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ShowDbTableTableAdapter = this.showDbTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CinemaVault.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // apiKeySetup
            // 
            this.apiKeySetup.AutoPopDelay = 5000;
            this.apiKeySetup.InitialDelay = 400;
            this.apiKeySetup.IsBalloon = true;
            this.apiKeySetup.ReshowDelay = 100;
            this.apiKeySetup.ToolTipTitle = "Configure Key:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::CinemaVault.Properties.Resources.smSearchIcon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.Location = new System.Drawing.Point(164, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 35);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ShowName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ShowGenre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ShowYear";
            this.dataGridViewTextBoxColumn7.HeaderText = "Year";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ShowRating";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 55;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ShowRecommend";
            this.dataGridViewTextBoxColumn5.HeaderText = "Recommend";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ShowDescription";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 175;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // ShowPoster
            // 
            this.ShowPoster.DataPropertyName = "ShowPoster";
            this.ShowPoster.HeaderText = "ShowPoster";
            this.ShowPoster.MaxInputLength = 200;
            this.ShowPoster.Name = "ShowPoster";
            this.ShowPoster.ReadOnly = true;
            this.ShowPoster.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowPoster.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(822, 540);
            this.Controls.Add(this.setApiKey);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.showDbTableDataGridView);
            this.Controls.Add(this.showDbTableBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableBindingNavigator)).EndInit();
            this.showDbTableBindingNavigator.ResumeLayout(false);
            this.showDbTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource showDbTableBindingSource;
        private DatabaseDataSetTableAdapters.ShowDbTableTableAdapter showDbTableTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator showDbTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton showDbTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView showDbTableDataGridView;
        private JThinButton.JThinButton btnAdd;
        private JThinButton.JThinButton btnEdit;
        private JThinButton.JThinButton btnDel;
        private JThinButton.JThinButton btnAbout;
        private System.Windows.Forms.Button sidePanel;
        private JDragControl.JDragControl titleBarDrag;
        private System.Windows.Forms.PictureBox titleBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private RoundButton btnSearch;
        private JMetroTextBox.JMetroTextBox searchBox;
        private JThinButton.JThinButton btnHelp;
        private System.Windows.Forms.Label titleLabel;
        private JThinButton.JThinButton btnClearSearch;
        private JDragControl.JDragControl titleLabelDrag;
        private System.Windows.Forms.Button setApiKey;
        private System.Windows.Forms.ToolTip apiKeySetup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowPoster;
    }
}

