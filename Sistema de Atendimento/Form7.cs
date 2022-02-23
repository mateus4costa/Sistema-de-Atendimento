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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void tbpacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbpacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPDbdDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPDbdDataSet.Tbpacientes'. Você pode movê-la ou removê-la conforme necessário.
           

        }

        private void tbpacientesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
