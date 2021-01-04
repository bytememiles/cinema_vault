namespace CinemaVault
{
    partial class AddForm
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
            System.Windows.Forms.Label showNameLabel;
            System.Windows.Forms.Label showGenreLabel;
            System.Windows.Forms.Label showRatingLabel;
            System.Windows.Forms.Label showRecommendLabel;
            System.Windows.Forms.Label showDescriptionLabel;
            System.Windows.Forms.Label showYearLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
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
            this.showNameTextBox = new System.Windows.Forms.TextBox();
            this.showGenreComboBox = new System.Windows.Forms.ComboBox();
            this.showRatingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.showYearComboBox = new System.Windows.Forms.ComboBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.showPlot = new System.Windows.Forms.CheckBox();
            this.showDbTableTableAdapter = new CinemaVault.DatabaseDataSetTableAdapters.ShowDbTableTableAdapter();
            this.tableAdapterManager = new CinemaVault.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.jMetroTextBox1 = new JMetroTextBox.JMetroTextBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.jMetroTextBox2 = new JMetroTextBox.JMetroTextBox();
            this.jMetroTextBox3 = new JMetroTextBox.JMetroTextBox();
            this.showDescriptionTextBox1 = new JMetroTextBox.JMetroTextBox();
            this.btnSubmit = new JThinButton.JThinButton();
            this.btnCancel = new JThinButton.JThinButton();
            this.fetchImage = new JThinButton.JThinButton();
            this.titleBarDrag = new JDragControl.JDragControl(this.components);
            this.showDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleLabelDrag = new JDragControl.JDragControl(this.components);
            this.ratingToolTip = new System.Windows.Forms.ToolTip(this.components);
            showNameLabel = new System.Windows.Forms.Label();
            showGenreLabel = new System.Windows.Forms.Label();
            showRatingLabel = new System.Windows.Forms.Label();
            showRecommendLabel = new System.Windows.Forms.Label();
            showDescriptionLabel = new System.Windows.Forms.Label();
            showYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableBindingNavigator)).BeginInit();
            this.showDbTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRatingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // showNameLabel
            // 
            showNameLabel.AutoSize = true;
            showNameLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showNameLabel.ForeColor = System.Drawing.Color.White;
            showNameLabel.Location = new System.Drawing.Point(13, 50);
            showNameLabel.Name = "showNameLabel";
            showNameLabel.Size = new System.Drawing.Size(52, 23);
            showNameLabel.TabIndex = 1;
            showNameLabel.Text = "Title:";
            // 
            // showGenreLabel
            // 
            showGenreLabel.AutoSize = true;
            showGenreLabel.BackColor = System.Drawing.Color.Transparent;
            showGenreLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showGenreLabel.ForeColor = System.Drawing.Color.White;
            showGenreLabel.Location = new System.Drawing.Point(12, 98);
            showGenreLabel.Name = "showGenreLabel";
            showGenreLabel.Size = new System.Drawing.Size(64, 23);
            showGenreLabel.TabIndex = 3;
            showGenreLabel.Text = "Genre:";
            // 
            // showRatingLabel
            // 
            showRatingLabel.AutoSize = true;
            showRatingLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showRatingLabel.ForeColor = System.Drawing.Color.White;
            showRatingLabel.Location = new System.Drawing.Point(11, 209);
            showRatingLabel.Name = "showRatingLabel";
            showRatingLabel.Size = new System.Drawing.Size(69, 23);
            showRatingLabel.TabIndex = 5;
            showRatingLabel.Text = "Rating:";
            // 
            // showRecommendLabel
            // 
            showRecommendLabel.AutoSize = true;
            showRecommendLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showRecommendLabel.ForeColor = System.Drawing.Color.White;
            showRecommendLabel.Location = new System.Drawing.Point(12, 259);
            showRecommendLabel.Name = "showRecommendLabel";
            showRecommendLabel.Size = new System.Drawing.Size(215, 23);
            showRecommendLabel.TabIndex = 7;
            showRecommendLabel.Text = "Would you recommend?";
            // 
            // showDescriptionLabel
            // 
            showDescriptionLabel.AutoSize = true;
            showDescriptionLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showDescriptionLabel.ForeColor = System.Drawing.Color.White;
            showDescriptionLabel.Location = new System.Drawing.Point(13, 335);
            showDescriptionLabel.Name = "showDescriptionLabel";
            showDescriptionLabel.Size = new System.Drawing.Size(297, 23);
            showDescriptionLabel.TabIndex = 9;
            showDescriptionLabel.Text = "Plot and/or Additional comments:";
            // 
            // showYearLabel
            // 
            showYearLabel.AutoSize = true;
            showYearLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showYearLabel.ForeColor = System.Drawing.Color.White;
            showYearLabel.Location = new System.Drawing.Point(11, 152);
            showYearLabel.Name = "showYearLabel";
            showYearLabel.Size = new System.Drawing.Size(51, 23);
            showYearLabel.TabIndex = 13;
            showYearLabel.Text = "Year:";
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
            this.showDbTableBindingNavigator.Size = new System.Drawing.Size(653, 25);
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
            this.showDbTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.ShowDbTableBindingNavigatorSaveItem_Click_1);
            // 
            // showNameTextBox
            // 
            this.showNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showDbTableBindingSource, "ShowName", true));
            this.showNameTextBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNameTextBox.Location = new System.Drawing.Point(133, 48);
            this.showNameTextBox.Name = "showNameTextBox";
            this.showNameTextBox.Size = new System.Drawing.Size(169, 23);
            this.showNameTextBox.TabIndex = 2;
            this.showNameTextBox.TextChanged += new System.EventHandler(this.ShowNameTextBox_TextChanged);
            // 
            // showGenreComboBox
            // 
            this.showGenreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showDbTableBindingSource, "ShowGenre", true));
            this.showGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showGenreComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showGenreComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGenreComboBox.FormattingEnabled = true;
            this.showGenreComboBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animated",
            "Anime",
            "Anthology",
            "Cartoon",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Historical",
            "Horror",
            "Musical",
            "Romance",
            "Satire",
            "Science Fiction",
            "War",
            "Western"});
            this.showGenreComboBox.Location = new System.Drawing.Point(133, 99);
            this.showGenreComboBox.Name = "showGenreComboBox";
            this.showGenreComboBox.Size = new System.Drawing.Size(169, 27);
            this.showGenreComboBox.TabIndex = 4;
            // 
            // showRatingNumericUpDown
            // 
            this.showRatingNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showRatingNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.showDbTableBindingSource, "ShowRating", true));
            this.showRatingNumericUpDown.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRatingNumericUpDown.Location = new System.Drawing.Point(124, 208);
            this.showRatingNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.showRatingNumericUpDown.Name = "showRatingNumericUpDown";
            this.showRatingNumericUpDown.Size = new System.Drawing.Size(38, 26);
            this.showRatingNumericUpDown.TabIndex = 6;
            this.showRatingNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ratingToolTip.SetToolTip(this.showRatingNumericUpDown, "A 0 to 10 scale, 10 being the highest.");
            // 
            // yesRadio
            // 
            this.yesRadio.BackColor = System.Drawing.Color.Transparent;
            this.yesRadio.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.showDbTableBindingSource, "ShowRecommend", true));
            this.yesRadio.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.yesRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.yesRadio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.yesRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.yesRadio.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesRadio.ForeColor = System.Drawing.Color.Transparent;
            this.yesRadio.Location = new System.Drawing.Point(59, 287);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(61, 24);
            this.yesRadio.TabIndex = 8;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = false;
            // 
            // noRadio
            // 
            this.noRadio.BackColor = System.Drawing.Color.Transparent;
            this.noRadio.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.showDbTableBindingSource, "ShowRecommend", true));
            this.noRadio.FlatAppearance.BorderSize = 0;
            this.noRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.noRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.noRadio.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRadio.ForeColor = System.Drawing.Color.Transparent;
            this.noRadio.Location = new System.Drawing.Point(126, 287);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(54, 24);
            this.noRadio.TabIndex = 11;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = false;
            // 
            // showYearComboBox
            // 
            this.showYearComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showDbTableBindingSource, "ShowYear", true));
            this.showYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showYearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showYearComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showYearComboBox.FormattingEnabled = true;
            this.showYearComboBox.Location = new System.Drawing.Point(133, 151);
            this.showYearComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.showYearComboBox.Name = "showYearComboBox";
            this.showYearComboBox.Size = new System.Drawing.Size(69, 27);
            this.showYearComboBox.TabIndex = 14;
            this.showYearComboBox.TabStop = false;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Location = new System.Drawing.Point(411, 46);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(202, 265);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 16;
            this.imageBox.TabStop = false;
            // 
            // showPlot
            // 
            this.showPlot.AutoSize = true;
            this.showPlot.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPlot.ForeColor = System.Drawing.Color.White;
            this.showPlot.Location = new System.Drawing.Point(519, 331);
            this.showPlot.Name = "showPlot";
            this.showPlot.Size = new System.Drawing.Size(72, 27);
            this.showPlot.TabIndex = 18;
            this.showPlot.Text = "Plot?";
            this.showPlot.UseVisualStyleBackColor = true;
            this.showPlot.CheckedChanged += new System.EventHandler(this.ShowPlot_CheckedChanged);
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
            // jMetroTextBox1
            // 
            this.jMetroTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox1.BorderColor = System.Drawing.Color.Empty;
            this.jMetroTextBox1.BorderRadius = 15;
            this.jMetroTextBox1.FillColor = System.Drawing.Color.White;
            this.jMetroTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox1.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox1.ForeColors = System.Drawing.Color.Gray;
            this.jMetroTextBox1.IsPassword = false;
            this.jMetroTextBox1.LineThickness = 2;
            this.jMetroTextBox1.Location = new System.Drawing.Point(117, 39);
            this.jMetroTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMetroTextBox1.MaxLength = 32767;
            this.jMetroTextBox1.MouseOnHover = System.Drawing.Color.Empty;
            this.jMetroTextBox1.Name = "jMetroTextBox1";
            this.jMetroTextBox1.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox1.OnFocusColor = System.Drawing.Color.Empty;
            this.jMetroTextBox1.OnFocusFontColor = System.Drawing.Color.Empty;
            this.jMetroTextBox1.ReadOnly = true;
            this.jMetroTextBox1.Size = new System.Drawing.Size(200, 39);
            this.jMetroTextBox1.TabIndex = 19;
            this.jMetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMetroTextBox1.TextName = "";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimize.Image = global::CinemaVault.Properties.Resources.MiniNormal;
            this.btnMinimize.Location = new System.Drawing.Point(567, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 22;
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
            this.btnClose.Location = new System.Drawing.Point(611, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 21;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
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
            this.titleBar.TabIndex = 20;
            this.titleBar.TabStop = false;
            // 
            // jMetroTextBox2
            // 
            this.jMetroTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox2.BorderColor = System.Drawing.Color.Empty;
            this.jMetroTextBox2.BorderRadius = 15;
            this.jMetroTextBox2.FillColor = System.Drawing.SystemColors.Window;
            this.jMetroTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox2.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox2.ForeColors = System.Drawing.Color.Gray;
            this.jMetroTextBox2.IsPassword = false;
            this.jMetroTextBox2.LineThickness = 2;
            this.jMetroTextBox2.Location = new System.Drawing.Point(117, 91);
            this.jMetroTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMetroTextBox2.MaxLength = 32767;
            this.jMetroTextBox2.MouseOnHover = System.Drawing.Color.Empty;
            this.jMetroTextBox2.Name = "jMetroTextBox2";
            this.jMetroTextBox2.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox2.OnFocusColor = System.Drawing.Color.Empty;
            this.jMetroTextBox2.OnFocusFontColor = System.Drawing.Color.Empty;
            this.jMetroTextBox2.ReadOnly = true;
            this.jMetroTextBox2.Size = new System.Drawing.Size(200, 39);
            this.jMetroTextBox2.TabIndex = 23;
            this.jMetroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMetroTextBox2.TextName = "";
            // 
            // jMetroTextBox3
            // 
            this.jMetroTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox3.BorderColor = System.Drawing.Color.Empty;
            this.jMetroTextBox3.BorderRadius = 15;
            this.jMetroTextBox3.FillColor = System.Drawing.SystemColors.Window;
            this.jMetroTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox3.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox3.ForeColors = System.Drawing.Color.Gray;
            this.jMetroTextBox3.IsPassword = false;
            this.jMetroTextBox3.LineThickness = 2;
            this.jMetroTextBox3.Location = new System.Drawing.Point(117, 143);
            this.jMetroTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMetroTextBox3.MaxLength = 32767;
            this.jMetroTextBox3.MouseOnHover = System.Drawing.Color.Empty;
            this.jMetroTextBox3.Name = "jMetroTextBox3";
            this.jMetroTextBox3.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox3.OnFocusColor = System.Drawing.Color.Empty;
            this.jMetroTextBox3.OnFocusFontColor = System.Drawing.Color.Empty;
            this.jMetroTextBox3.ReadOnly = true;
            this.jMetroTextBox3.Size = new System.Drawing.Size(100, 39);
            this.jMetroTextBox3.TabIndex = 24;
            this.jMetroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMetroTextBox3.TextName = "";
            // 
            // showDescriptionTextBox1
            // 
            this.showDescriptionTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.showDescriptionTextBox1.BorderColor = System.Drawing.Color.Black;
            this.showDescriptionTextBox1.BorderRadius = 12;
            this.showDescriptionTextBox1.FillColor = System.Drawing.Color.White;
            this.showDescriptionTextBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDescriptionTextBox1.Font_Size = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDescriptionTextBox1.ForeColors = System.Drawing.Color.Gray;
            this.showDescriptionTextBox1.IsPassword = false;
            this.showDescriptionTextBox1.LineThickness = 2;
            this.showDescriptionTextBox1.Location = new System.Drawing.Point(10, 361);
            this.showDescriptionTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showDescriptionTextBox1.MaxLength = 32767;
            this.showDescriptionTextBox1.MouseOnHover = System.Drawing.Color.Empty;
            this.showDescriptionTextBox1.Name = "showDescriptionTextBox1";
            this.showDescriptionTextBox1.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.showDescriptionTextBox1.OnFocusColor = System.Drawing.Color.Empty;
            this.showDescriptionTextBox1.OnFocusFontColor = System.Drawing.Color.Empty;
            this.showDescriptionTextBox1.ReadOnly = true;
            this.showDescriptionTextBox1.Size = new System.Drawing.Size(603, 135);
            this.showDescriptionTextBox1.TabIndex = 25;
            this.showDescriptionTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.showDescriptionTextBox1.TextName = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.BorderRadius = 5;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Font_Size = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.HoverBackground = System.Drawing.Color.White;
            this.btnSubmit.HoverBorder = System.Drawing.Color.Empty;
            this.btnSubmit.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.LineThickness = 2;
            this.btnSubmit.Location = new System.Drawing.Point(185, 506);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnCancel.HoverBackground = System.Drawing.Color.White;
            this.btnCancel.HoverBorder = System.Drawing.Color.Empty;
            this.btnCancel.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.LineThickness = 2;
            this.btnCancel.Location = new System.Drawing.Point(389, 506);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // fetchImage
            // 
            this.fetchImage.BackColor = System.Drawing.Color.Transparent;
            this.fetchImage.BackgroundColor = System.Drawing.Color.Transparent;
            this.fetchImage.BorderColor = System.Drawing.SystemColors.Highlight;
            this.fetchImage.BorderRadius = 5;
            this.fetchImage.ButtonText = "Fetch Image";
            this.fetchImage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchImage.Font_Size = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchImage.ForeColors = System.Drawing.SystemColors.Highlight;
            this.fetchImage.HoverBackground = System.Drawing.Color.White;
            this.fetchImage.HoverBorder = System.Drawing.Color.Empty;
            this.fetchImage.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.fetchImage.LineThickness = 2;
            this.fetchImage.Location = new System.Drawing.Point(411, 332);
            this.fetchImage.Name = "fetchImage";
            this.fetchImage.Size = new System.Drawing.Size(87, 23);
            this.fetchImage.TabIndex = 28;
            this.fetchImage.Click += new System.EventHandler(this.FetchImage_Click);
            // 
            // titleBarDrag
            // 
            this.titleBarDrag.GetForm = this;
            this.titleBarDrag.TargetControl = this.titleBar;
            // 
            // showDescriptionTextBox
            // 
            this.showDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showDescriptionTextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDescriptionTextBox.Location = new System.Drawing.Point(16, 372);
            this.showDescriptionTextBox.Multiline = true;
            this.showDescriptionTextBox.Name = "showDescriptionTextBox";
            this.showDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showDescriptionTextBox.Size = new System.Drawing.Size(591, 116);
            this.showDescriptionTextBox.TabIndex = 29;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(294, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(57, 29);
            this.titleLabel.TabIndex = 30;
            this.titleLabel.Text = "Add";
            // 
            // titleLabelDrag
            // 
            this.titleLabelDrag.GetForm = this;
            this.titleLabelDrag.TargetControl = this.titleLabel;
            // 
            // ratingToolTip
            // 
            this.ratingToolTip.IsBalloon = true;
            this.ratingToolTip.ToolTipTitle = "Rating:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(653, 540);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.showDescriptionTextBox);
            this.Controls.Add(this.fetchImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.showDescriptionTextBox1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.showPlot);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(showYearLabel);
            this.Controls.Add(this.showYearComboBox);
            this.Controls.Add(this.noRadio);
            this.Controls.Add(showNameLabel);
            this.Controls.Add(this.showNameTextBox);
            this.Controls.Add(showGenreLabel);
            this.Controls.Add(this.showGenreComboBox);
            this.Controls.Add(showRatingLabel);
            this.Controls.Add(this.showRatingNumericUpDown);
            this.Controls.Add(showRecommendLabel);
            this.Controls.Add(this.yesRadio);
            this.Controls.Add(showDescriptionLabel);
            this.Controls.Add(this.jMetroTextBox1);
            this.Controls.Add(this.jMetroTextBox2);
            this.Controls.Add(this.jMetroTextBox3);
            this.Controls.Add(this.showDbTableBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableBindingNavigator)).EndInit();
            this.showDbTableBindingNavigator.ResumeLayout(false);
            this.showDbTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDbTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRatingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
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
        private System.Windows.Forms.TextBox showNameTextBox;
        private System.Windows.Forms.ComboBox showGenreComboBox;
        private System.Windows.Forms.NumericUpDown showRatingNumericUpDown;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.ComboBox showYearComboBox;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.CheckBox showPlot;
        private JMetroTextBox.JMetroTextBox jMetroTextBox1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox titleBar;
        private JMetroTextBox.JMetroTextBox jMetroTextBox2;
        private JMetroTextBox.JMetroTextBox jMetroTextBox3;
        private JMetroTextBox.JMetroTextBox showDescriptionTextBox1;
        private JThinButton.JThinButton btnSubmit;
        private JThinButton.JThinButton btnCancel;
        private JThinButton.JThinButton fetchImage;
        private JDragControl.JDragControl titleBarDrag;
        private System.Windows.Forms.TextBox showDescriptionTextBox;
        private System.Windows.Forms.Label titleLabel;
        private JDragControl.JDragControl titleLabelDrag;
        private System.Windows.Forms.ToolTip ratingToolTip;
    }
}