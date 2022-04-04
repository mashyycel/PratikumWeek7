using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormQuizPanda : Form
    {
        public FormQuizPanda()
        {
            InitializeComponent();
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            
            txtBoxKalimat.Text = txtBoxKalimat.Text.ToUpper();
            txtBoxHuruf.Text = txtBoxHuruf.Text.ToUpper();
            txtMenjadi.Text = txtMenjadi.Text.ToUpper();
            
            
            string[] huruf = new string[]
            {"A","B","C","D","E","F","G","H","I","J","K","L","M","N",
                "O","P","Q","R","S","T","U","V","W","X","Y","Z"};
            string hurufYangInginDiubah = txtBoxHuruf.Text;
            string hurufDiubah = txtMenjadi.Text;
            int indexHurufYangInginDiubah = Array.IndexOf(huruf, hurufYangInginDiubah);
            int indexHurufDiubah = Array.IndexOf(huruf, hurufDiubah);
            int hasil = indexHurufYangInginDiubah - indexHurufDiubah;
            if (txtBoxKalimat.Text.Contains(txtBoxHuruf.Text))
            {
                foreach(char ch in txtBoxKalimat.Text)

                lblOutput.Text = txtBoxKalimat.Text.Replace(hurufYangInginDiubah, hurufDiubah);
            }

            
            

          


        }

       
    }
}
