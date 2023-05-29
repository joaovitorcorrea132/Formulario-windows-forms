using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Trabalho1
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void Exit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("O cadastro será fechado");
            Application.Exit();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os dados foram salvos com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radio1,radio2,radio3,checkbox;
            //RADIO 1
            if ( modalidadeR1.Checked)
            {
                radio1 = "Graduação";
            }
            else
            {
                radio1 = "Colégio";
            }
            //RADIO 2
            if (AlunoR1.Checked)
            {
                radio2 = "Sim";
            }
            else
            {
                radio2 = "Não";
            }
            //RADIO 3
            if (trasnferidoR1.Checked)
            {
                radio3 = "Sim";
            }
            else
            {
                radio3 = "Não";
            }
            //CHECKBOX
            if (checkBox1.Checked)
            {
                checkbox = "1° Semestre";
            }
            else
            {
                checkbox = "2° Semestre";
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkbox = "1° e 2° Semestre";
            }



            MessageBox.Show(
                  "Matricula: " + boxMatricula.Text
         + "\n "+ "Nome: " + boxNome.Text
         + "\n" + "Endereço: " + adressBox.Text
         + "\n" + "Telefone: " + telBox.Text
         + "\n" + "E-mail: " + mailBox.Text
         + "\n" + "Curso: " + cursoBox.Text
         + "\n" + "Disciplinas: " + diciplinasBox.Text
         + "\n" + "Modalidade: " + radio1
         + "\n" + "Semestres: " + checkbox
         + "\n" + "Mensalidade: " + mensalidadeBox.Text
         + "\n" + "Pagamento: " + pagamentoBox.Text
         + "\n" + "Aluno novo: " + radio2
         + "\n" + "Transferido: " + radio3
         + "\n" + "Observações: " + obsBox.Text
                , "Informações cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
