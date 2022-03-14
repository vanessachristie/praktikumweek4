
namespace praktikumweek4
{
    partial class FormTampilanData
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
            this.tBoxNama2 = new System.Windows.Forms.TextBox();
            this.tBoxAlamat2 = new System.Windows.Forms.TextBox();
            this.tBoxTelp2 = new System.Windows.Forms.TextBox();
            this.labelNama2 = new System.Windows.Forms.Label();
            this.labelAlamat2 = new System.Windows.Forms.Label();
            this.labelTelp2 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxNama2
            // 
            this.tBoxNama2.Location = new System.Drawing.Point(188, 82);
            this.tBoxNama2.Name = "tBoxNama2";
            this.tBoxNama2.Size = new System.Drawing.Size(186, 27);
            this.tBoxNama2.TabIndex = 0;
            // 
            // tBoxAlamat2
            // 
            this.tBoxAlamat2.Location = new System.Drawing.Point(188, 159);
            this.tBoxAlamat2.Name = "tBoxAlamat2";
            this.tBoxAlamat2.Size = new System.Drawing.Size(186, 27);
            this.tBoxAlamat2.TabIndex = 1;
            // 
            // tBoxTelp2
            // 
            this.tBoxTelp2.Location = new System.Drawing.Point(188, 244);
            this.tBoxTelp2.Name = "tBoxTelp2";
            this.tBoxTelp2.Size = new System.Drawing.Size(186, 27);
            this.tBoxTelp2.TabIndex = 2;
            // 
            // labelNama2
            // 
            this.labelNama2.AutoSize = true;
            this.labelNama2.Location = new System.Drawing.Point(84, 82);
            this.labelNama2.Name = "labelNama2";
            this.labelNama2.Size = new System.Drawing.Size(52, 20);
            this.labelNama2.TabIndex = 3;
            this.labelNama2.Text = "Nama:";
            // 
            // labelAlamat2
            // 
            this.labelAlamat2.AutoSize = true;
            this.labelAlamat2.Location = new System.Drawing.Point(84, 159);
            this.labelAlamat2.Name = "labelAlamat2";
            this.labelAlamat2.Size = new System.Drawing.Size(60, 20);
            this.labelAlamat2.TabIndex = 4;
            this.labelAlamat2.Text = "Alamat:";
            // 
            // labelTelp2
            // 
            this.labelTelp2.AutoSize = true;
            this.labelTelp2.Location = new System.Drawing.Point(84, 245);
            this.labelTelp2.Name = "labelTelp2";
            this.labelTelp2.Size = new System.Drawing.Size(40, 20);
            this.labelTelp2.TabIndex = 5;
            this.labelTelp2.Text = "Telp:";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(100, 331);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(94, 29);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(219, 331);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Prev Data";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(348, 331);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next Data";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.labelTelp2);
            this.Controls.Add(this.labelAlamat2);
            this.Controls.Add(this.labelNama2);
            this.Controls.Add(this.tBoxTelp2);
            this.Controls.Add(this.tBoxAlamat2);
            this.Controls.Add(this.tBoxNama2);
            this.Name = "FormTampilanData";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.FormTampilanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxNama2;
        private System.Windows.Forms.TextBox tBoxAlamat2;
        private System.Windows.Forms.TextBox tBoxTelp2;
        private System.Windows.Forms.Label labelNama2;
        private System.Windows.Forms.Label labelAlamat2;
        private System.Windows.Forms.Label labelTelp2;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}