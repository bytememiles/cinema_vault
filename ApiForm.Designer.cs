
namespace CinemaVault
{
    partial class ApiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApiForm));
            this.infoLabel = new System.Windows.Forms.Label();
            this.apiTextBox = new JMetroTextBox.JMetroTextBox();
            this.btnFinish = new JThinButton.JThinButton();
            this.showCurrentKey = new System.Windows.Forms.Label();
            this.resetKey = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.goToLink = new System.Windows.Forms.LinkLabel();
            this.titleBarDrag = new JDragControl.JDragControl(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleLabelDrag = new JDragControl.JDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(3, 40);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(565, 79);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // apiTextBox
            // 
            this.apiTextBox.BackColor = System.Drawing.Color.Transparent;
            this.apiTextBox.BorderColor = System.Drawing.Color.Empty;
            this.apiTextBox.BorderRadius = 15;
            this.apiTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.apiTextBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiTextBox.Font_Size = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiTextBox.ForeColors = System.Drawing.Color.Gray;
            this.apiTextBox.IsPassword = false;
            this.apiTextBox.LineThickness = 2;
            this.apiTextBox.Location = new System.Drawing.Point(203, 148);
            this.apiTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apiTextBox.MaxLength = 32767;
            this.apiTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.apiTextBox.Name = "apiTextBox";
            this.apiTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.apiTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.apiTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.apiTextBox.ReadOnly = false;
            this.apiTextBox.Size = new System.Drawing.Size(138, 39);
            this.apiTextBox.TabIndex = 1;
            this.apiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apiTextBox.TextName = "Insert Key";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFinish.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(60)))), ((int)(((byte)(162)))));
            this.btnFinish.BorderRadius = 5;
            this.btnFinish.ButtonText = "Finish";
            this.btnFinish.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Font_Size = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnFinish.HoverBackground = System.Drawing.Color.White;
            this.btnFinish.HoverBorder = System.Drawing.Color.Empty;
            this.btnFinish.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnFinish.LineThickness = 2;
            this.btnFinish.Location = new System.Drawing.Point(341, 154);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(56, 30);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // showCurrentKey
            // 
            this.showCurrentKey.AutoSize = true;
            this.showCurrentKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showCurrentKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCurrentKey.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCurrentKey.ForeColor = System.Drawing.Color.White;
            this.showCurrentKey.Location = new System.Drawing.Point(203, 195);
            this.showCurrentKey.Name = "showCurrentKey";
            this.showCurrentKey.Size = new System.Drawing.Size(142, 19);
            this.showCurrentKey.TabIndex = 3;
            this.showCurrentKey.Text = "Show Current Key?";
            this.showCurrentKey.Click += new System.EventHandler(this.showCurrentKey_Click);
            this.showCurrentKey.MouseEnter += new System.EventHandler(this.showCurrentKey_MouseEnter);
            this.showCurrentKey.MouseLeave += new System.EventHandler(this.showCurrentKey_MouseLeave);
            // 
            // resetKey
            // 
            this.resetKey.AutoSize = true;
            this.resetKey.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetKey.ForeColor = System.Drawing.Color.White;
            this.resetKey.Location = new System.Drawing.Point(230, 230);
            this.resetKey.Name = "resetKey";
            this.resetKey.Size = new System.Drawing.Size(86, 19);
            this.resetKey.TabIndex = 4;
            this.resetKey.Text = "Reset Key?";
            this.resetKey.Click += new System.EventHandler(this.resetKey_Click);
            this.resetKey.MouseEnter += new System.EventHandler(this.resetKey_MouseEnter);
            this.resetKey.MouseLeave += new System.EventHandler(this.resetKey_MouseLeave);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.titleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleBar.ErrorImage = null;
            this.titleBar.InitialImage = null;
            this.titleBar.Location = new System.Drawing.Point(-9, -3);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(598, 37);
            this.titleBar.TabIndex = 21;
            this.titleBar.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::CinemaVault.Properties.Resources.NormalClose;
            this.btnClose.Location = new System.Drawing.Point(531, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 22;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimize.Image = global::CinemaVault.Properties.Resources.MiniNormal;
            this.btnMinimize.Location = new System.Drawing.Point(486, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 23;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // goToLink
            // 
            this.goToLink.AutoSize = true;
            this.goToLink.BackColor = System.Drawing.Color.Transparent;
            this.goToLink.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLink.ForeColor = System.Drawing.Color.White;
            this.goToLink.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.goToLink.Location = new System.Drawing.Point(199, 124);
            this.goToLink.Margin = new System.Windows.Forms.Padding(0);
            this.goToLink.Name = "goToLink";
            this.goToLink.Size = new System.Drawing.Size(155, 19);
            this.goToLink.TabIndex = 24;
            this.goToLink.TabStop = true;
            this.goToLink.Text = "Click here to go now!";
            this.goToLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goToLink_LinkClicked);
            // 
            // titleBarDrag
            // 
            this.titleBarDrag.GetForm = this;
            this.titleBarDrag.TargetControl = this.titleBar;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(236, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(95, 29);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "Get Key";
            // 
            // titleLabelDrag
            // 
            this.titleLabelDrag.GetForm = this;
            this.titleLabelDrag.TargetControl = this.titleLabel;
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(570, 262);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.goToLink);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.resetKey);
            this.Controls.Add(this.showCurrentKey);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.apiTextBox);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApiForm";
            this.Text = "ApiForm";
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private JMetroTextBox.JMetroTextBox apiTextBox;
        private JThinButton.JThinButton btnFinish;
        private System.Windows.Forms.Label showCurrentKey;
        private System.Windows.Forms.Label resetKey;
        private System.Windows.Forms.PictureBox titleBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.LinkLabel goToLink;
        private JDragControl.JDragControl titleBarDrag;
        private System.Windows.Forms.Label titleLabel;
        private JDragControl.JDragControl titleLabelDrag;
    }
}