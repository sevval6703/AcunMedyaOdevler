namespace attiribute_odev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            btnKaydet = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            lblVeri = new Label();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(186, 70);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(186, 121);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(186, 173);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(52, 20);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Bolum";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(223, 236);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(291, 70);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(291, 121);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(291, 166);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 6;
            // 
            // lblVeri
            // 
            lblVeri.AutoSize = true;
            lblVeri.Location = new Point(186, 327);
            lblVeri.Name = "lblVeri";
            lblVeri.Size = new Size(101, 20);
            lblVeri.TabIndex = 7;
            lblVeri.Text = "Girilen Veriler:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVeri);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnKaydet);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private Button btnKaydet;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Label lblVeri;
    }
}
