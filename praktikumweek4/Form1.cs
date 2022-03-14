using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikumweek4
{
    public partial class FormPenambahanData : Form
    {
        public FormPenambahanData()
        {
            InitializeComponent();
        }
        public static string[,] Data = new string[10, 3];
        public static int hitungData = 0;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (hitungData == 10)
            {
                MessageBox.Show("data telah penuh!");
            }
            else
            {
                Data[hitungData, 0] = tBoxNama.Text;
                Data[hitungData, 1] = tBoxAlamat.Text;
                Data[hitungData, 2] = tBoxTelp.Text;
                hitungData++;
            }
        }

        private void btnLihatData_Click(object sender, EventArgs e)
        {

            FormTampilanData form2 = new FormTampilanData();
            form2.ShowDialog();
            this.Hide();

        }

        private void FormPenambahanData_Load(object sender, EventArgs e)
        {
           

        }

        private void tBoxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char nomorTelp = e.KeyChar;
            if (!Char.IsDigit(nomorTelp) && nomorTelp != 8)
            {
                e.Handled = true;
            }
        }
    }
}
