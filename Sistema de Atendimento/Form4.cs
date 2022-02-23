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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPDbdDataSet.Tbpacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbpacientesTableAdapter.Fill(this.rPDbdDataSet.Tbpacientes);

        }

        private void tbpacientesBindingNavigator_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit(object sender, EventArgs e)
        {

            Form7 Editar = new Form7();
            Editar.ShowDialog();
        }
    }
}
