using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP06_192149
{
    public partial class Form1 : Form
    {

        #region Variaveis Globais
        int[] alturas = new int[50];
        String[] nomes = new string[50];
        int i, j, soma, div;
        int auxAlturas;
        string auxNames;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Load
        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
            Txt_Altura.Enabled = false;
            div = 0;
            soma = 0;
        }
        #endregion
        #region Close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar o Aplicativo?", "Fechar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No) {
                e.Cancel = true;
            }
        }
        #endregion
        #region Warning
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Lbl_Aviso.ForeColor != Color.Black)
            {
                Lbl_Aviso.ForeColor = Color.Black;
            }
            else {
                Lbl_Aviso.ForeColor = Color.Red;
            }
        }
        #endregion
        #region keyVerif
        private void keyVerif(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 8 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion
        #region Liberação de Campo
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Txt_Nome.Text != "")
            {
                Txt_Altura.Enabled = true;
            }
            else {
                Txt_Altura.Enabled = false;
            }
        }
        #endregion
        #region Validating Height
        private void Txt_Altura_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_Altura.Text != "")
            {
                if (i < 50)
                {

                    nomes[i] = Convert.ToString(Txt_Nome.Text);
                    alturas[i] = int.Parse(Txt_Altura.Text);
                    Lbx_Inseridos.Items.Add(Convert.ToString(nomes[i] + ": " + alturas[i]));
                    i++; div++;
                    Txt_Nome.Clear(); Txt_Nome.Focus();
                    Txt_Altura.Clear();
                }
                else {
                    nomes[50] = Convert.ToString(Txt_Nome.Text);
                    alturas[50] = int.Parse(Txt_Altura.Text);
                    Txt_Nome.Clear(); Txt_Nome.Enabled = false;
                    Txt_Altura.Clear(); Txt_Altura.Enabled = false;
                }
            }
        }
        #endregion
        #region Clean Button
        private void Menu_Limpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Limpar ?", "Limpar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                for (int c = 0; c < i; c++) {
                    nomes[c] = "";
                }
                for (int c = 0; c < i; c++)
                {
                    alturas[c] = 0;
                }
                Txt_Nome.Clear();
                Txt_Altura.Clear();
                Lbx_Inseridos.Items.Clear();
                Lbx_Ordenados.Items.Clear();
                Txt_Nome.Enabled = true;
                auxAlturas = 0;
                auxNames = "";
                i = 0;
                Lbl_Media.Text = "A média das alturas é: ";
            }
        }
        #endregion
        #region Media Button
        private void Menu_media_Click(object sender, EventArgs e)
        {
            try
            {
                    for (int c = 0; c <= div; c++)
                    {
                        soma += alturas[c];
                    }
                    Lbl_Media.Text = Convert.ToString("A média das alturas é: " + (soma / div));
                    soma = 0;
                    div = 0;
            }
            catch
            {
                MessageBox.Show("Não é possivel efetuar a solicitação sem informações", "Erro");
            }
        }
        #endregion
        #region Rol Button
        private void Menu_Rol_Click(object sender, EventArgs e)
        {
            try
            {
                Lbx_Ordenados.Items.Clear();
                int limit = i;
                for (i = 0; i <= limit - 1; i++)
                    for (j = i + 1; j <= limit; j++)
                        if (alturas[i] > alturas[j])
                        {
                            auxNames = nomes[i];
                            auxAlturas = alturas[i];

                            nomes[i] = nomes[j];
                            alturas[i] = alturas[j];

                            nomes[j] = auxNames;
                            alturas[j] = auxAlturas;
                        }
                for (int c = 1; c <= i; c++)
                {
                    Lbx_Ordenados.Items.Add(Convert.ToString(nomes[c] + ": " + alturas[c]));
                }
            }
            catch {
                MessageBox.Show("Não é possivel efetuar a solicitação sem informações", "Erro");
            }          
        }
        #endregion
        #region About Button
        private void Menu_Sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alexsander de Oliveira \nRA: 192149 \nCurso: Programação Visual e Games", "Criado por");
        }
        #endregion
    }
}
