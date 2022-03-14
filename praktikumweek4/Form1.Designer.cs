
namespace praktikumweek4
{
    partial class FormPenambahanData
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
            this.tBoxNama = new System.Windows.Forms.TextBox();
            this.tBoxAlamat = new System.Windows.Forms.TextBox();
            this.tBoxTelp = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTelp = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxNama
            // 
            this.tBoxNama.Location = new System.Drawing.Point(218, 103);
            this.tBoxNama.Name = "tBoxNama";
            this.tBoxNama.Size = new System.Drawing.Size(203, 27);
            this.tBoxNama.TabIndex = 0;
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.Location = new System.Drawing.Point(218, 163);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(203, 27);
            this.tBoxAlamat.TabIndex = 1;
            // 
            // tBoxTelp
            // 
            this.tBoxTelp.Location = new System.Drawing.Point(218, 215);
            this.tBoxTelp.Name = "tBoxTelp";
            this.tBoxTelp.Size = new System.Drawing.Size(203, 27);
            this.tBoxTelp.TabIndex = 2;
            this.tBoxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTelp_KeyPress);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(63, 106);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(52, 20);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "Nama:";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(63, 163);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(60, 20);
            this.labelAlamat.TabIndex = 4;
            this.labelAlamat.Text = "Alamat:";
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(71, 222);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(40, 20);
            this.labelTelp.TabIndex = 5;
            this.labelTelp.Text = "Telp:";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(147, 307);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(94, 29);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnLihatData
            // 
            this.btnLihatData.Location = new System.Drawing.Point(305, 307);
            this.btnLihatData.Name = "btnLihatData";
            this.btnLihatData.Size = new System.Drawing.Size(94, 29);
            this.btnLihatData.TabIndex = 7;
            this.btnLihatData.Text = "Lihat Data";
            this.btnLihatData.UseVisualStyleBackColor = true;
            this.btnLihatData.Click += new System.EventHandler(this.btnLihatData_Click);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLihatData);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.tBoxTelp);
            this.Controls.Add(this.tBoxAlamat);
            this.Controls.Add(this.tBoxNama);
            this.Name = "FormPenambahanData";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.FormPenambahanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxNama;
        private System.Windows.Forms.TextBox tBoxAlamat;
        private System.Windows.Forms.TextBox tBoxTelp;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelTelp;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnLihatData;
    }
}

