namespace TugasTiga1
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
            this.lblNim = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblNimIsi = new System.Windows.Forms.Label();
            this.lblNamaIsi = new System.Windows.Forms.Label();
            this.lblKelasIsi = new System.Windows.Forms.Label();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnKosong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(50, 47);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(27, 13);
            this.lblNim.TabIndex = 1;
            this.lblNim.Text = "NIM";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(50, 79);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(50, 116);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(33, 13);
            this.lblKelas.TabIndex = 1;
            this.lblKelas.Text = "Kelas";
            // 
            // lblNimIsi
            // 
            this.lblNimIsi.AutoSize = true;
            this.lblNimIsi.Location = new System.Drawing.Point(89, 47);
            this.lblNimIsi.Name = "lblNimIsi";
            this.lblNimIsi.Size = new System.Drawing.Size(67, 13);
            this.lblNimIsi.TabIndex = 1;
            this.lblNimIsi.Text = ": 18.11.2354";
            // 
            // lblNamaIsi
            // 
            this.lblNamaIsi.AutoSize = true;
            this.lblNamaIsi.Location = new System.Drawing.Point(89, 79);
            this.lblNamaIsi.Name = "lblNamaIsi";
            this.lblNamaIsi.Size = new System.Drawing.Size(66, 13);
            this.lblNamaIsi.TabIndex = 1;
            this.lblNamaIsi.Text = ": CHANDRA";
            // 
            // lblKelasIsi
            // 
            this.lblKelasIsi.AutoSize = true;
            this.lblKelasIsi.Location = new System.Drawing.Point(89, 116);
            this.lblKelasIsi.Name = "lblKelasIsi";
            this.lblKelasIsi.Size = new System.Drawing.Size(50, 13);
            this.lblKelasIsi.TabIndex = 1;
            this.lblKelasIsi.Text = ": S1-IF08";
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(58, 184);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 2;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnKosong
            // 
            this.btnKosong.Location = new System.Drawing.Point(202, 184);
            this.btnKosong.Name = "btnKosong";
            this.btnKosong.Size = new System.Drawing.Size(75, 23);
            this.btnKosong.TabIndex = 2;
            this.btnKosong.Text = "Kosongkan";
            this.btnKosong.UseVisualStyleBackColor = true;
            this.btnKosong.Click += new System.EventHandler(this.btnKosong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 260);
            this.Controls.Add(this.btnKosong);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblKelasIsi);
            this.Controls.Add(this.lblNamaIsi);
            this.Controls.Add(this.lblNimIsi);
            this.Controls.Add(this.lblNim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblNimIsi;
        private System.Windows.Forms.Label lblNamaIsi;
        private System.Windows.Forms.Label lblKelasIsi;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnKosong;
    }
}

