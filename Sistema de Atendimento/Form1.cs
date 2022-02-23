using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Atendimento
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void emp_Click(object sender, EventArgs e)
        {
            Form2 Empresa = new Form2();
            Empresa.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void emp_Click2(object sender, EventArgs e)
        {
            Registro Registro = new Registro();
            Registro.ShowDialog();
        }

        private void emp_Click4(object sender, EventArgs e)
        {
            Form5 Recepcao = new Form5();
            Recepcao.ShowDialog();
        }

        private void emp_Click5(object sender, EventArgs e)
        {
            Form4 Paciente = new Form4();
            Paciente.ShowDialog();
        }

        private void emp_Click6(object sender, EventArgs e)
        {
            Form8 Medico = new Form8();
            Medico.ShowDialog();
        }
    }
}
