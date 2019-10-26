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
            if (textUjHobbi.Text != "")
            {
                listBoxKedvencHobbi.Items.Add(textUjHobbi.Text);
                textUjHobbi.Text = "";
            }
        }

        private void ButtonMentes_Click(object sender, EventArgs e)
        {
            StreamWriter urlap = new StreamWriter("Urlap.txt", false, Encoding.UTF8);

            if (textNev.Text !="")
            {
                urlap.Write(textNev.Text +"; ");
            }
            else
            {
                MessageBox.Show("Nem adott meg nevet!");
            }
            if (textSzulDatum.Text != "")
            {
                urlap.Write(textSzulDatum.Text+"; ");
            }
            else
            {
                MessageBox.Show("Nem adott meg születési dátumot!");
            }
            if (radioButtonF.Checked==true)
            {
                urlap.Write("Férfi; ");
            }
            if (radioButtonN.Checked == true)
            {
                urlap.Write("Nő; ");
            }
            urlap.Write(listBoxKedvencHobbi.SelectedItem+"");
            urlap.Close();
        }

        private void ButtonBetoltes_Click(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("urlap.txt"))
            {
                string[] st = sor.Split(';');
                textNev.Text = st[0];
                textSzulDatum.Text = st[1];
                if ()
                {

                }
            }
        }
    }
}
