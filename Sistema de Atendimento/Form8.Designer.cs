namespace Sistema_de_Atendimento
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nomepacienteLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label tempLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label paLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label medicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.tbpacientesTableAdapter = new Sistema_de_Atendimento.RPDbdDataSetTableAdapters.TbpacientesTableAdapter();
            this.tableAdapterManager = new Sistema_de_Atendimento.RPDbdDataSetTableAdapters.TableAdapterManager();
            this.tbpacientesListBox = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbpacientesComboBox = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.medicoTextBox = new System.Windows.Forms.TextBox();
            this.rPDbdDataSet = new Sistema_de_Atendimento.RPDbdDataSet();
            this.tbpacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbpacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nomepacienteLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tempLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            paLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            medicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rPDbdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            codigoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            codigoLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(12, 48);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(89, 25);
            codigoLabel.TabIndex = 39;
            codigoLabel.Text = "Código:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label5.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(12, 132);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 25);
            label5.TabIndex = 44;
            label5.Text = "Endereço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(137, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 25);
            label1.TabIndex = 46;
            label1.Text = "Data de atendimento:";
            // 
            // nomepacienteLabel
            // 
            nomepacienteLabel.AutoSize = true;
            nomepacienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nomepacienteLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomepacienteLabel.Location = new System.Drawing.Point(255, 132);
            nomepacienteLabel.Name = "nomepacienteLabel";
            nomepacienteLabel.Size = new System.Drawing.Size(199, 25);
            nomepacienteLabel.TabIndex = 49;
            nomepacienteLabel.Text = "Nome do paciente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(389, 48);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(221, 25);
            label4.TabIndex = 50;
            label4.Text = "Data de nascimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(641, 48);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 25);
            label6.TabIndex = 52;
            label6.Text = "Idade:";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tempLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempLabel.Location = new System.Drawing.Point(947, 127);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new System.Drawing.Size(144, 25);
            tempLabel.TabIndex = 60;
            tempLabel.Text = "Temperatura:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pesoLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.Location = new System.Drawing.Point(825, 129);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(67, 25);
            pesoLabel.TabIndex = 58;
            pesoLabel.Text = "Peso:";
            // 
            // paLabel
            // 
            paLabel.AutoSize = true;
            paLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            paLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paLabel.Location = new System.Drawing.Point(652, 129);
            paLabel.Name = "paLabel";
            paLabel.Size = new System.Drawing.Size(56, 25);
            paLabel.TabIndex = 56;
            paLabel.Text = "P.A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(-16, 202);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(1132, 23);
            label3.TabIndex = 64;
            label3.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // medicoLabel
            // 
            medicoLabel.AutoSize = true;
            medicoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            medicoLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medicoLabel.Location = new System.Drawing.Point(825, 48);
            medicoLabel.Name = "medicoLabel";
            medicoLabel.Size = new System.Drawing.Size(89, 25);
            medicoLabel.TabIndex = 64;
            medicoLabel.Text = "Médico:";
            // 
            // tbpacientesTableAdapter
            // 
            this.tbpacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TbpacientesTableAdapter = this.tbpacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sistema_de_Atendimento.RPDbdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbpacientesListBox
            // 
            this.tbpacientesListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbpacientesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpacientesListBox.DisplayMember = "codigo";
            this.tbpacientesListBox.Enabled = false;
            this.tbpacientesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpacientesListBox.FormattingEnabled = true;
            this.tbpacientesListBox.ItemHeight = 20;
            this.tbpacientesListBox.Location = new System.Drawing.Point(12, 91);
            this.tbpacientesListBox.Name = "tbpacientesListBox";
            this.tbpacientesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.tbpacientesListBox.Size = new System.Drawing.Size(89, 22);
            this.tbpacientesListBox.TabIndex = 40;
            this.tbpacientesListBox.ValueMember = "codigo";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox3.DisplayMember = "endereco";
            this.listBox3.Enabled = false;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(12, 177);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(224, 22);
            this.listBox3.TabIndex = 45;
            this.listBox3.ValueMember = "endereco";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DisplayMember = "dataatendimento";
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(137, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(232, 22);
            this.listBox1.TabIndex = 47;
            this.listBox1.ValueMember = "dataatendimento";
            // 
            // tbpacientesComboBox
            // 
            this.tbpacientesComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbpacientesComboBox.DisplayMember = "nomepaciente";
            this.tbpacientesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpacientesComboBox.FormattingEnabled = true;
            this.tbpacientesComboBox.ItemHeight = 20;
            this.tbpacientesComboBox.Location = new System.Drawing.Point(255, 171);
            this.tbpacientesComboBox.Name = "tbpacientesComboBox";
            this.tbpacientesComboBox.Size = new System.Drawing.Size(373, 28);
            this.tbpacientesComboBox.TabIndex = 48;
            this.tbpacientesComboBox.ValueMember = "nomepaciente";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.DisplayMember = "datanasci";
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(389, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(232, 22);
            this.listBox2.TabIndex = 51;
            this.listBox2.ValueMember = "datanasci";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox4.DisplayMember = "idade";
            this.listBox4.Enabled = false;
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(641, 91);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Size = new System.Drawing.Size(125, 22);
            this.listBox4.TabIndex = 53;
            this.listBox4.ValueMember = "idade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(712, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "(pressão arterial)";
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox5.DisplayMember = "pa";
            this.listBox5.Enabled = false;
            this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 20;
            this.listBox5.Location = new System.Drawing.Point(652, 177);
            this.listBox5.Name = "listBox5";
            this.listBox5.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox5.Size = new System.Drawing.Size(98, 22);
            this.listBox5.TabIndex = 61;
            this.listBox5.ValueMember = "pa";
            // 
            // listBox6
            // 
            this.listBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox6.DisplayMember = "peso";
            this.listBox6.Enabled = false;
            this.listBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 20;
            this.listBox6.Location = new System.Drawing.Point(825, 177);
            this.listBox6.Name = "listBox6";
            this.listBox6.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox6.Size = new System.Drawing.Size(98, 22);
            this.listBox6.TabIndex = 62;
            this.listBox6.ValueMember = "peso";
            // 
            // listBox7
            // 
            this.listBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox7.DisplayMember = "temp";
            this.listBox7.Enabled = false;
            this.listBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 20;
            this.listBox7.Location = new System.Drawing.Point(947, 177);
            this.listBox7.Name = "listBox7";
            this.listBox7.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox7.Size = new System.Drawing.Size(98, 22);
            this.listBox7.TabIndex = 63;
            this.listBox7.ValueMember = "temp";
            // 
            // medicoTextBox
            // 
            this.medicoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.medicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.medicoTextBox.Location = new System.Drawing.Point(823, 91);
            this.medicoTextBox.Name = "medicoTextBox";
            this.medicoTextBox.Size = new System.Drawing.Size(268, 21);
            this.medicoTextBox.TabIndex = 65;
            // 
            // rPDbdDataSet
            // 
            this.rPDbdDataSet.DataSetName = "RPDbdDataSet";
            this.rPDbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpacientesBindingSource
            // 
            this.tbpacientesBindingSource.DataMember = "Tbpacientes";
            this.tbpacientesBindingSource.DataSource = this.rPDbdDataSet;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(47, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 93);
            this.button1.TabIndex = 66;
            this.button1.Text = "Atestado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.receitabtn);
            // 
            // tbpacientesBindingSource1
            // 
            this.tbpacientesBindingSource1.DataMember = "Tbpacientes";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1099, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(medicoLabel);
            this.Controls.Add(this.medicoTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(tempLabel);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(paLabel);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(label6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(label4);
            this.Controls.Add(nomepacienteLabel);
            this.Controls.Add(this.tbpacientesComboBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(label5);
            this.Controls.Add(this.tbpacientesListBox);
            this.Controls.Add(codigoLabel);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPDbdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RPDbdDataSetTableAdapters.TbpacientesTableAdapter tbpacientesTableAdapter;
        private RPDbdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbpacientesBindingSource1;
        private System.Windows.Forms.ListBox tbpacientesListBox;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox tbpacientesComboBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.TextBox medicoTextBox;
        private RPDbdDataSet rPDbdDataSet;
        private System.Windows.Forms.BindingSource tbpacientesBindingSource;
        private System.Windows.Forms.Button button1;
    }
}