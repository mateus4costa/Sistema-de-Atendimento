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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void tbpacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbpacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPDbdDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPDbdDataSet.Tbpacientes'. Você pode movê-la ou removê-la conforme necessário.
           

        }

        private void receitabtn(object sender, EventArgs e)
        {
            Form9 Receita = new Form9();
            Receita.ShowDialog();
        }
    }
}
