namespace VeriTabanı_Mimarisi
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
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.grpOgrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.Controls.Add(this.lblID);
            this.grpOgrenci.Controls.Add(this.lblNumara);
            this.grpOgrenci.Controls.Add(this.lblSoyad);
            this.grpOgrenci.Controls.Add(this.lblAd);
            this.grpOgrenci.Controls.Add(this.txtId);
            this.grpOgrenci.Controls.Add(this.txtNumara);
            this.grpOgrenci.Controls.Add(this.txtSoyad);
            this.grpOgrenci.Controls.Add(this.txtAd);
            this.grpOgrenci.Location = new System.Drawing.Point(12, 12);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Size = new System.Drawing.Size(299, 190);
            this.grpOgrenci.TabIndex = 0;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "Öğrenci";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 157);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID:";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(17, 119);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(53, 15);
            this.lblNumara.TabIndex = 5;
            this.lblNumara.Text = "Numara:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(17, 76);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(42, 15);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(17, 36);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 15);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(89, 154);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(117, 23);
            this.txtId.TabIndex = 2;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(89, 116);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(117, 23);
            this.txtNumara.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(89, 73);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(117, 23);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(89, 33);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(117, 23);
            this.txtAd.TabIndex = 0;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(204, 208);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(107, 23);
            this.btnGonder.TabIndex = 1;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 243);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.grpOgrenci);
            this.Name = "Form1";
            this.Text = "Ogrenci ";
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpOgrenci;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnGonder;
        private Label lblID;
        private TextBox txtId;
    }
}