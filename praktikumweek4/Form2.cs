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
    public partial class FormTampilanData : Form
    {
        public FormTampilanData()
        {
            InitializeComponent();
        }
        int jumlah;
        public int dataSekarang = 0;
        public void Form2()
        {
            InitializeComponent();
            jumlah = FormPenambahanData.hitungData;
        }

        private void FormTampilanData_Load(object sender, EventArgs e)
        {
            show();
        }
        

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormPenambahanData form1 = new FormPenambahanData();
            form1.Show();
            this.Hide();
        }
        public void show()
        {
            tBoxNama2.Text = FormPenambahanData.Data[dataSekarang, 0];
            tBoxAlamat2.Text = FormPenambahanData.Data[dataSekarang, 1];
            tBoxTelp2.Text = FormPenambahanData.Data[dataSekarang, 2];
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (dataSekarang == 0)
            {
                MessageBox.Show("data sudah data pertama");
            }
            else
            {
                dataSekarang--;
                show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dataSekarang++;
            if (dataSekarang > 9|| dataSekarang>FormPenambahanData.hitungData-1)
            {
                MessageBox.Show("data sudah data terakhir");
                dataSekarang--;
            }

            else
            {
                show();
            }

        }
    }
}
