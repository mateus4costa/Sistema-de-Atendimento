using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sistema_de_Atendimento
{
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();

        }

        private void tbpacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbpacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPDbdDataSet);

        }

        private void tbpacientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbpacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPDbdDataSet);

        }

        private void tbpacientesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tbpacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPDbdDataSet);

        }

        private void tbpacientesBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.tbpacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPDbdDataSet);

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPDbdDataSet.Tbpacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbpacientesTableAdapter.Fill(this.rPDbdDataSet.Tbpacientes);

        }
    }
}







