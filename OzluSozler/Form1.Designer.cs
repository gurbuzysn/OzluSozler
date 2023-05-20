namespace OzluSozler
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSoz = new TextBox();
            txtYazar = new TextBox();
            nudDerece = new NumericUpDown();
            btnEkle = new Button();
            lstSozler = new ListBox();
            label4 = new Label();
            txtAra = new TextBox();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDerece).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 0;
            label1.Text = "Söz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 0;
            label2.Text = "Yazar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 0;
            label3.Text = "Derece:";
            // 
            // txtSoz
            // 
            txtSoz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSoz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoz.Location = new Point(85, 6);
            txtSoz.Name = "txtSoz";
            txtSoz.Size = new Size(980, 29);
            txtSoz.TabIndex = 1;
            // 
            // txtYazar
            // 
            txtYazar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtYazar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtYazar.Location = new Point(85, 41);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(980, 29);
            txtYazar.TabIndex = 1;
            // 
            // nudDerece
            // 
            nudDerece.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudDerece.Location = new Point(85, 76);
            nudDerece.Name = "nudDerece";
            nudDerece.Size = new Size(80, 29);
            nudDerece.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(184, 97);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(329, 50);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstSozler
            // 
            lstSozler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstSozler.DisplayMember = "Ozet";
            lstSozler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstSozler.FormattingEnabled = true;
            lstSozler.ItemHeight = 21;
            lstSozler.Location = new Point(12, 153);
            lstSozler.Name = "lstSozler";
            lstSozler.Size = new Size(1053, 508);
            lstSozler.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(835, 112);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 0;
            label4.Text = "Ara:";
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAra.Location = new Point(900, 109);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(165, 29);
            txtAra.TabIndex = 1;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Location = new Point(727, 97);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(93, 50);
            btnSil.TabIndex = 3;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 667);
            Controls.Add(lstSozler);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(nudDerece);
            Controls.Add(txtAra);
            Controls.Add(txtYazar);
            Controls.Add(txtSoz);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Özlü Sözler";
            TransparencyKey = Color.DarkGreen;
            ((System.ComponentModel.ISupportInitialize)nudDerece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSoz;
        private TextBox txtYazar;
        private NumericUpDown nudDerece;
        private Button btnEkle;
        private ListBox lstSozler;
        private Label label4;
        private TextBox txtAra;
        private Button btnSil;
    }
}