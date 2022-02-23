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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPDbdDataSet.Tbpacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbpacientesTableAdapter.Fill(this.rPDbdDataSet.Tbpacientes);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbpacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbpacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPDbdDataSet);

        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataatendimentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void destinoLabel_Click(object sender, EventArgs e)
        {

        }

        private void destinoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datanasciLabel_Click(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomemaeLabel_Click(object sender, EventArgs e)
        {

        }

        private void codigopaciLabel_Click(object sender, EventArgs e)
        {

        }

        private void tbpacientesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tbpacientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
