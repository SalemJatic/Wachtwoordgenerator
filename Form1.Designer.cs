namespace Wachtwoord_generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Hoofdletter_checkbox = new System.Windows.Forms.CheckBox();
            this.Kleinenletters_checkbox = new System.Windows.Forms.CheckBox();
            this.Cijfer_checkbox = new System.Windows.Forms.CheckBox();
            this.Symbolen_checkbox = new System.Windows.Forms.CheckBox();
            this.Genereer_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.WachtwoordLengthList = new System.Windows.Forms.NumericUpDown();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.listbox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.WachtwoordLengthList)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(275, 167);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(229, 30);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Selecteer een getal!!";
            // 
            // Hoofdletter_checkbox
            // 
            this.Hoofdletter_checkbox.AutoSize = true;
            this.Hoofdletter_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.Hoofdletter_checkbox.Location = new System.Drawing.Point(378, 26);
            this.Hoofdletter_checkbox.Name = "Hoofdletter_checkbox";
            this.Hoofdletter_checkbox.Size = new System.Drawing.Size(107, 21);
            this.Hoofdletter_checkbox.TabIndex = 3;
            this.Hoofdletter_checkbox.Text = "Hoofdletters";
            this.Hoofdletter_checkbox.UseVisualStyleBackColor = false;
            // 
            // Kleinenletters_checkbox
            // 
            this.Kleinenletters_checkbox.AutoSize = true;
            this.Kleinenletters_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.Kleinenletters_checkbox.Location = new System.Drawing.Point(521, 26);
            this.Kleinenletters_checkbox.Name = "Kleinenletters_checkbox";
            this.Kleinenletters_checkbox.Size = new System.Drawing.Size(112, 21);
            this.Kleinenletters_checkbox.TabIndex = 4;
            this.Kleinenletters_checkbox.Text = "Kleinenleters";
            this.Kleinenletters_checkbox.UseVisualStyleBackColor = false;
            // 
            // Cijfer_checkbox
            // 
            this.Cijfer_checkbox.AutoSize = true;
            this.Cijfer_checkbox.Location = new System.Drawing.Point(378, 93);
            this.Cijfer_checkbox.Name = "Cijfer_checkbox";
            this.Cijfer_checkbox.Size = new System.Drawing.Size(69, 21);
            this.Cijfer_checkbox.TabIndex = 5;
            this.Cijfer_checkbox.Text = "Cijfers";
            this.Cijfer_checkbox.UseVisualStyleBackColor = true;
            // 
            // Symbolen_checkbox
            // 
            this.Symbolen_checkbox.AutoSize = true;
            this.Symbolen_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.Symbolen_checkbox.Location = new System.Drawing.Point(521, 93);
            this.Symbolen_checkbox.Name = "Symbolen_checkbox";
            this.Symbolen_checkbox.Size = new System.Drawing.Size(92, 21);
            this.Symbolen_checkbox.TabIndex = 6;
            this.Symbolen_checkbox.Text = "Symbolen";
            this.Symbolen_checkbox.UseVisualStyleBackColor = false;
            // 
            // Genereer_button
            // 
            this.Genereer_button.ActiveBorderThickness = 1;
            this.Genereer_button.ActiveCornerRadius = 20;
            this.Genereer_button.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Genereer_button.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Genereer_button.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Genereer_button.BackColor = System.Drawing.Color.Transparent;
            this.Genereer_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Genereer_button.BackgroundImage")));
            this.Genereer_button.ButtonText = "Genereer";
            this.Genereer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Genereer_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genereer_button.ForeColor = System.Drawing.Color.SeaGreen;
            this.Genereer_button.IdleBorderThickness = 1;
            this.Genereer_button.IdleCornerRadius = 20;
            this.Genereer_button.IdleFillColor = System.Drawing.Color.Transparent;
            this.Genereer_button.IdleForecolor = System.Drawing.Color.Black;
            this.Genereer_button.IdleLineColor = System.Drawing.Color.Black;
            this.Genereer_button.Location = new System.Drawing.Point(389, 224);
            this.Genereer_button.Margin = new System.Windows.Forms.Padding(5);
            this.Genereer_button.Name = "Genereer_button";
            this.Genereer_button.Size = new System.Drawing.Size(181, 41);
            this.Genereer_button.TabIndex = 7;
            this.Genereer_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Genereer_button.Click += new System.EventHandler(this.Genereer_button_Click);
            // 
            // WachtwoordLengthList
            // 
            this.WachtwoordLengthList.Location = new System.Drawing.Point(535, 175);
            this.WachtwoordLengthList.Name = "WachtwoordLengthList";
            this.WachtwoordLengthList.Size = new System.Drawing.Size(107, 22);
            this.WachtwoordLengthList.TabIndex = 8;
            this.WachtwoordLengthList.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Textbox1);
            this.bunifuGradientPanel1.Controls.Add(this.listbox1);
            this.bunifuGradientPanel1.Controls.Add(this.WachtwoordLengthList);
            this.bunifuGradientPanel1.Controls.Add(this.Genereer_button);
            this.bunifuGradientPanel1.Controls.Add(this.Symbolen_checkbox);
            this.bunifuGradientPanel1.Controls.Add(this.Cijfer_checkbox);
            this.bunifuGradientPanel1.Controls.Add(this.Kleinenletters_checkbox);
            this.bunifuGradientPanel1.Controls.Add(this.Hoofdletter_checkbox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(912, 529);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // Textbox1
            // 
            this.Textbox1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox1.Location = new System.Drawing.Point(352, 326);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(249, 32);
            this.Textbox1.TabIndex = 12;
            // 
            // listbox1
            // 
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 16;
            this.listbox1.Location = new System.Drawing.Point(752, 237);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(160, 292);
            this.listbox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_close);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WachtwoordLengthList)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.CheckBox Hoofdletter_checkbox;
        private System.Windows.Forms.CheckBox Kleinenletters_checkbox;
        private System.Windows.Forms.CheckBox Cijfer_checkbox;
        private System.Windows.Forms.CheckBox Symbolen_checkbox;
        private Bunifu.Framework.UI.BunifuThinButton2 Genereer_button;
        private System.Windows.Forms.NumericUpDown WachtwoordLengthList;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.TextBox Textbox1;
    }
}

