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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btn_impr(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 100, 400);
            e.Graphics.DrawImage(pictureBox1.Image, 100,100, pictureBox1.Width, pictureBox1.Height);

            
        }
    }
}
