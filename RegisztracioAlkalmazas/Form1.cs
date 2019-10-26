using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class formRegisztracio : Form
    {
        public formRegisztracio()
        {
            InitializeComponent();
        }

        private void ButtonHozzaAad_Click(object sender, EventArgs e)
        {
            listBoxKedvencHobbi.Items.Add(textUjHobbi.Text);
            textUjHobbi.Text = "";
        }

        private void ButtonMentes_Click(object sender, EventArgs e)
        {
            StreamWriter urlap = new StreamWriter("Urlap.txt", false, Encoding.UTF8);

            if (textNev.Text !="")
            {
                urlap.Write(textNev.Text);
            }
            else
            {
                MessageBox.Show("Nem adott meg nevet!");
            }
            if (textSzulDatum.Text != "")
            {
                urlap.Write(textSzulDatum.Text);
            }
            else
            {
                MessageBox.Show("Nem adott meg születési dátumot!");
            }

        }
    }
}
