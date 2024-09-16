using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasirajah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMakanan.Items.Add("Paket Ayam Goreng");
            cbMakanan.Items.Add("Nasi Goreng");
            cbMakanan.Items.Add("Ayam Geprek");
            cbMakanan.Items.Add("Tumis Kangkung");
            cbMakanan.Items.Add("Salad Sayur");
            cbMinuman.Items.Add("Kopi Hitam");
            cbMinuman.Items.Add("Jus Strawberry");
            cbMinuman.Items.Add("Esteh Manis");
            cbMinuman.Items.Add("Jus Mangga");
            cbMinuman.Items.Add("Es Kelapa Muda");
        }

        private void cbMakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;

            pilih = cbMakanan.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txtHargaMakanan.Text = "50000";
                    Total();
                    break;
                case 1:
                    txtHargaMakanan.Text = "36000";
                    Total();
                    break;
                case 2:
                    txtHargaMakanan.Text = "25000";
                    Total();
                    break;
                case 3:
                    txtHargaMakanan.Text = "24000";
                    Total();
                    break;
                case 4:
                    txtHargaMakanan.Text = "20000";
                    Total();
                    break;
                default:
                    txtHargaMakanan.Text = "0";
                    break;
            }
        }

        private void cbMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cbMinuman.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txtHargaMinuman.Text = "20000";
                    Total();
                    break;
                case 1:
                    txtHargaMinuman.Text = "15000";
                    Total();
                    break;
                case 2:
                    txtHargaMinuman.Text = "20000";
                    Total();
                    break;
                case 3:
                    txtHargaMinuman.Text = "16000";
                    Total();
                    break;
                case 4:
                    txtHargaMinuman.Text = "17000";
                    Total();
                    break;
                default:
                    txtHargaMinuman.Text = "0";
                    break;
            }
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            if (txtBayar.Text == "" || txtBayar.Text == " ")
            {
                txtBayar.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(txtBayar.Text);
                int b = Convert.ToInt32(txtTotal.Text);
                int kembali = 0;
                kembali = a - b;
                txtKembali.Text = Convert.ToString(kembali);
            }
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btProses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("========================" +
                "\n\tWarung Jawa" +
                "\n\tKasir: " + txtNamaKasir.Text +
                "\n========================" +
                "\nPesan : " +
                "\n" + cbMakanan.Text + "tRp. " + txtHargaMakanan.Text +
                "\n" + cbMinuman.Text + "tRp. " + txtHargaMinuman.Text +
                "\n========================" +
                "\nTotal\t\t: Rp. " + txtTotal.Text +
                "\nBayar\t\t: Rp. " + txtBayar.Text +
                "\nKembali\t\t: Rp. " + txtKembali.Text
                );
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cbMakanan.Text = "";
            cbMinuman.Text = "";
            txtHargaMakanan.Text = "0";
            txtHargaMinuman.Text = "0";
            txtTotal.Text = "0";
            txtBayar.Text = "0";
            txtKembali.Text = "0";
            txtNamaKasir.Clear();
        }

        public void Total()
        {
            int total, hargaMakanan, hargaMinuman = 0;
            hargaMakanan = Convert.ToInt32(txtHargaMakanan.Text);
            hargaMinuman = Convert.ToInt32(txtHargaMinuman.Text);
            total = hargaMinuman + hargaMinuman;
            txtTotal.Text = Convert.ToString(total);
        }
    }
}
