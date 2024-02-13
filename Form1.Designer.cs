namespace phonebook
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
            lblAdSoyad = new Label();
            lblTelefon = new Label();
            txt_AdSoyad = new TextBox();
            txt_Tel = new TextBox();
            btn_Ekle = new Button();
            btn_Kaydet = new Button();
            btn_Duzelt = new Button();
            btn_Sil = new Button();
            listbox_AdSoyad = new ListBox();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(53, 28);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(76, 20);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(53, 78);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(61, 20);
            lblTelefon.TabIndex = 0;
            lblTelefon.Text = "Telefon:";
            // 
            // txt_AdSoyad
            // 
            txt_AdSoyad.Location = new Point(134, 25);
            txt_AdSoyad.Name = "txt_AdSoyad";
            txt_AdSoyad.Size = new Size(125, 27);
            txt_AdSoyad.TabIndex = 1;
            // 
            // txt_Tel
            // 
            txt_Tel.Location = new Point(134, 78);
            txt_Tel.Name = "txt_Tel";
            txt_Tel.Size = new Size(125, 27);
            txt_Tel.TabIndex = 1;
            // 
            // btn_Ekle
            // 
            btn_Ekle.Location = new Point(132, 152);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(94, 29);
            btn_Ekle.TabIndex = 2;
            btn_Ekle.Text = "Ekle";
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // btn_Kaydet
            // 
            btn_Kaydet.Location = new Point(290, 152);
            btn_Kaydet.Name = "btn_Kaydet";
            btn_Kaydet.Size = new Size(94, 29);
            btn_Kaydet.TabIndex = 2;
            btn_Kaydet.Text = "Kaydet";
            btn_Kaydet.UseVisualStyleBackColor = true;
            btn_Kaydet.Click += btn_Kaydet_Click;
            // 
            // btn_Duzelt
            // 
            btn_Duzelt.Location = new Point(132, 237);
            btn_Duzelt.Name = "btn_Duzelt";
            btn_Duzelt.Size = new Size(94, 29);
            btn_Duzelt.TabIndex = 2;
            btn_Duzelt.Text = "Düzelt";
            btn_Duzelt.UseVisualStyleBackColor = true;
            btn_Duzelt.Click += btn_Duzelt_Click;
            // 
            // btn_Sil
            // 
            btn_Sil.Location = new Point(290, 237);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(94, 29);
            btn_Sil.TabIndex = 2;
            btn_Sil.Text = "Sil";
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += btn_Sil_Click;
            // 
            // listbox_AdSoyad
            // 
            listbox_AdSoyad.FormattingEnabled = true;
            listbox_AdSoyad.Location = new Point(531, 28);
            listbox_AdSoyad.Name = "listbox_AdSoyad";
            listbox_AdSoyad.Size = new Size(222, 284);
            listbox_AdSoyad.TabIndex = 3;
            listbox_AdSoyad.SelectedIndexChanged += listbox_AdSoyad_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listbox_AdSoyad);
            Controls.Add(btn_Sil);
            Controls.Add(btn_Duzelt);
            Controls.Add(btn_Kaydet);
            Controls.Add(btn_Ekle);
            Controls.Add(txt_Tel);
            Controls.Add(txt_AdSoyad);
            Controls.Add(lblTelefon);
            Controls.Add(lblAdSoyad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdSoyad;
        private Label lblTelefon;
        private TextBox txt_AdSoyad;
        private TextBox txt_Tel;
        private Button btn_Ekle;
        private Button btn_Kaydet;
        private Button btn_Duzelt;
        private Button btn_Sil;
        private ListBox listbox_AdSoyad;
    }
}
