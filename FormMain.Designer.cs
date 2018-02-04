namespace Wachtwoordgenerator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.genereren = new Bunifu.Framework.UI.BunifuThinButton2();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.textbox2);
            this.bunifuGradientPanel1.Controls.Add(this.textbox1);
            this.bunifuGradientPanel1.Controls.Add(this.genereren);
            this.bunifuGradientPanel1.Controls.Add(this.listBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.WindowText;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(754, 434);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(611, 178);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(140, 22);
            this.textbox2.TabIndex = 4;
            this.textbox2.Text = "Wachtwoord komt hier";
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.textbox1.Location = new System.Drawing.Point(335, 149);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 22);
            this.textbox1.TabIndex = 3;
            this.textbox1.TextChanged += new System.EventHandler(this.textbox1_TextChanged);
            // 
            // genereren
            // 
            this.genereren.ActiveBorderThickness = 1;
            this.genereren.ActiveCornerRadius = 20;
            this.genereren.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.genereren.ActiveForecolor = System.Drawing.Color.Transparent;
            this.genereren.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.genereren.BackColor = System.Drawing.Color.Transparent;
            this.genereren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("genereren.BackgroundImage")));
            this.genereren.ButtonText = "Genereer";
            this.genereren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genereren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genereren.ForeColor = System.Drawing.Color.Black;
            this.genereren.IdleBorderThickness = 1;
            this.genereren.IdleCornerRadius = 20;
            this.genereren.IdleFillColor = System.Drawing.Color.Transparent;
            this.genereren.IdleForecolor = System.Drawing.Color.Black;
            this.genereren.IdleLineColor = System.Drawing.Color.Black;
            this.genereren.Location = new System.Drawing.Point(224, 206);
            this.genereren.Margin = new System.Windows.Forms.Padding(5);
            this.genereren.Name = "genereren";
            this.genereren.Size = new System.Drawing.Size(181, 41);
            this.genereren.TabIndex = 2;
            this.genereren.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.genereren.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(611, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 228);
            this.listBox1.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(207, 149);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(109, 22);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Type wat in:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(723, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 434);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textbox1;
        private Bunifu.Framework.UI.BunifuThinButton2 genereren;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox textbox2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}