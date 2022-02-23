namespace Sistema_de_Atendimento
{
    partial class Form7
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
            System.Windows.Forms.Label nomepacienteLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label paLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label tempLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.rPDbdDataSet = new Sistema_de_Atendimento.RPDbdDataSet();
            this.tbpacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpacientesTableAdapter = new Sistema_de_Atendimento.RPDbdDataSetTableAdapters.TbpacientesTableAdapter();
            this.tableAdapterManager = new Sistema_de_Atendimento.RPDbdDataSetTableAdapters.TableAdapterManager();
            this.tbpacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbpacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbpacientesComboBox = new System.Windows.Forms.ComboBox();
            this.tbpacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpacientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpacientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpacientesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpacientesListBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.paTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            nomepacienteLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            paLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            tempLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rPDbdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingNavigator)).BeginInit();
            this.tbpacientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // nomepacienteLabel
            // 
            nomepacienteLabel.AutoSize = true;
            nomepacienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nomepacienteLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomepacienteLabel.Location = new System.Drawing.Point(12, 191);
            nomepacienteLabel.Name = "nomepacienteLabel";
            nomepacienteLabel.Size = new System.Drawing.Size(199, 25);
            nomepacienteLabel.TabIndex = 34;
            nomepacienteLabel.Text = "Nome do paciente:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            codigoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            codigoLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(12, 103);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(89, 25);
            codigoLabel.TabIndex = 35;
            codigoLabel.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(153, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 25);
            label1.TabIndex = 36;
            label1.Text = "Data de atendimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Consolas", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(387, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(254, 33);
            label2.TabIndex = 37;
            label2.Text = "Dados do Paciente";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(-4, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(1132, 23);
            label3.TabIndex = 38;
            label3.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(409, 191);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(221, 25);
            label4.TabIndex = 40;
            label4.Text = "Data de nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label5.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(669, 191);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 25);
            label5.TabIndex = 42;
            label5.Text = "Endereço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(911, 191);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 25);
            label6.TabIndex = 44;
            label6.Text = "Idade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label7.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(12, 287);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(144, 25);
            label7.TabIndex = 46;
            label7.Text = "Nome do pai:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label8.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(313, 287);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(144, 25);
            label8.TabIndex = 49;
            label8.Text = "Nome da mãe:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(-4, 374);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(1132, 23);
            label9.TabIndex = 50;
            label9.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // paLabel
            // 
            paLabel.AutoSize = true;
            paLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            paLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paLabel.Location = new System.Drawing.Point(12, 415);
            paLabel.Name = "paLabel";
            paLabel.Size = new System.Drawing.Size(56, 25);
            paLabel.TabIndex = 51;
            paLabel.Text = "P.A:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pesoLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.Location = new System.Drawing.Point(185, 415);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(67, 25);
            pesoLabel.TabIndex = 53;
            pesoLabel.Text = "Peso:";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tempLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempLabel.Location = new System.Drawing.Point(357, 418);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new System.Drawing.Size(144, 25);
            tempLabel.TabIndex = 54;
            tempLabel.Text = "Temperatura:";
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
            // tbpacientesBindingNavigator
            // 
            this.tbpacientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbpacientesBindingNavigator.BindingSource = this.tbpacientesBindingSource;
            this.tbpacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbpacientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbpacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbpacientesBindingNavigatorSaveItem});
            this.tbpacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbpacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbpacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbpacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbpacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbpacientesBindingNavigator.Name = "tbpacientesBindingNavigator";
            this.tbpacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbpacientesBindingNavigator.Size = new System.Drawing.Size(1148, 25);
            this.tbpacientesBindingNavigator.TabIndex = 0;
            this.tbpacientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbpacientesBindingNavigatorSaveItem
            // 
            this.tbpacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbpacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbpacientesBindingNavigatorSaveItem.Image")));
            this.tbpacientesBindingNavigatorSaveItem.Name = "tbpacientesBindingNavigatorSaveItem";
            this.tbpacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbpacientesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbpacientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbpacientesBindingNavigatorSaveItem_Click);
            // 
            // tbpacientesComboBox
            // 
            this.tbpacientesComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbpacientesComboBox.DataSource = this.tbpacientesBindingSource;
            this.tbpacientesComboBox.DisplayMember = "nomepaciente";
            this.tbpacientesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpacientesComboBox.FormattingEnabled = true;
            this.tbpacientesComboBox.ItemHeight = 20;
            this.tbpacientesComboBox.Location = new System.Drawing.Point(12, 236);
            this.tbpacientesComboBox.Name = "tbpacientesComboBox";
            this.tbpacientesComboBox.Size = new System.Drawing.Size(373, 28);
            this.tbpacientesComboBox.TabIndex = 1;
            this.tbpacientesComboBox.ValueMember = "nomepaciente";
            // 
            // tbpacientesBindingSource1
            // 
            this.tbpacientesBindingSource1.DataMember = "Tbpacientes";
            this.tbpacientesBindingSource1.DataSource = this.rPDbdDataSet;
            // 
            // tbpacientesBindingSource2
            // 
            this.tbpacientesBindingSource2.DataMember = "Tbpacientes";
            this.tbpacientesBindingSource2.DataSource = this.rPDbdDataSet;
            // 
            // tbpacientesBindingSource3
            // 
            this.tbpacientesBindingSource3.DataMember = "Tbpacientes";
            this.tbpacientesBindingSource3.DataSource = this.rPDbdDataSet;
            // 
            // tbpacientesBindingSource4
            // 
            this.tbpacientesBindingSource4.DataMember = "Tbpacientes";
            this.tbpacientesBindingSource4.DataSource = this.rPDbdDataSet;
            // 
            // tbpacientesListBox
            // 
            this.tbpacientesListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbpacientesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpacientesListBox.DataSource = this.tbpacientesBindingSource;
            this.tbpacientesListBox.DisplayMember = "codigo";
            this.tbpacientesListBox.Enabled = false;
            this.tbpacientesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpacientesListBox.FormattingEnabled = true;
            this.tbpacientesListBox.ItemHeight = 20;
            this.tbpacientesListBox.Location = new System.Drawing.Point(12, 146);
            this.tbpacientesListBox.Name = "tbpacientesListBox";
            this.tbpacientesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.tbpacientesListBox.Size = new System.Drawing.Size(89, 22);
            this.tbpacientesListBox.TabIndex = 38;
            this.tbpacientesListBox.ValueMember = "codigo";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DataSource = this.tbpacientesBindingSource;
            this.listBox1.DisplayMember = "dataatendimento";
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(153, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(232, 22);
            this.listBox1.TabIndex = 39;
            this.listBox1.ValueMember = "dataatendimento";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.DataSource = this.tbpacientesBindingSource;
            this.listBox2.DisplayMember = "datanasci";
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(409, 236);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(232, 22);
            this.listBox2.TabIndex = 41;
            this.listBox2.ValueMember = "datanasci";
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox3.DataSource = this.tbpacientesBindingSource;
            this.listBox3.DisplayMember = "endereco";
            this.listBox3.Enabled = false;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(669, 236);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(224, 22);
            this.listBox3.TabIndex = 43;
            this.listBox3.ValueMember = "endereco";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox4.DataSource = this.tbpacientesBindingSource;
            this.listBox4.DisplayMember = "idade";
            this.listBox4.Enabled = false;
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(911, 236);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Size = new System.Drawing.Size(125, 22);
            this.listBox4.TabIndex = 45;
            this.listBox4.ValueMember = "idade";
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox5.DataSource = this.tbpacientesBindingSource;
            this.listBox5.DisplayMember = "nomepai";
            this.listBox5.Enabled = false;
            this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 20;
            this.listBox5.Location = new System.Drawing.Point(12, 332);
            this.listBox5.Name = "listBox5";
            this.listBox5.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox5.Size = new System.Drawing.Size(273, 22);
            this.listBox5.TabIndex = 47;
            this.listBox5.ValueMember = "nomepai";
            // 
            // listBox6
            // 
            this.listBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox6.DataSource = this.tbpacientesBindingSource;
            this.listBox6.DisplayMember = "nomemae";
            this.listBox6.Enabled = false;
            this.listBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 20;
            this.listBox6.Location = new System.Drawing.Point(313, 332);
            this.listBox6.Name = "listBox6";
            this.listBox6.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox6.Size = new System.Drawing.Size(273, 22);
            this.listBox6.TabIndex = 51;
            this.listBox6.ValueMember = "nomemae";
            // 
            // paTextBox
            // 
            this.paTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "pa", true));
            this.paTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paTextBox.Location = new System.Drawing.Point(12, 459);
            this.paTextBox.Name = "paTextBox";
            this.paTextBox.Size = new System.Drawing.Size(100, 26);
            this.paTextBox.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "(pressão arterial)";
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pesoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "peso", true));
            this.pesoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTextBox.Location = new System.Drawing.Point(185, 459);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(100, 26);
            this.pesoTextBox.TabIndex = 54;
            // 
            // tempTextBox
            // 
            this.tempTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tempTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tempTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "temp", true));
            this.tempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTextBox.Location = new System.Drawing.Point(357, 459);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(100, 26);
            this.tempTextBox.TabIndex = 55;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1148, 510);
            this.Controls.Add(tempLabel);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(paLabel);
            this.Controls.Add(this.paTextBox);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(label7);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(label6);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbpacientesListBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(nomepacienteLabel);
            this.Controls.Add(this.tbpacientesComboBox);
            this.Controls.Add(this.tbpacientesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Editar dados";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPDbdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingNavigator)).EndInit();
            this.tbpacientesBindingNavigator.ResumeLayout(false);
            this.tbpacientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RPDbdDataSet rPDbdDataSet;
        private System.Windows.Forms.BindingSource tbpacientesBindingSource;
        private RPDbdDataSetTableAdapters.TbpacientesTableAdapter tbpacientesTableAdapter;
        private RPDbdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbpacientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbpacientesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox tbpacientesComboBox;
        private System.Windows.Forms.BindingSource tbpacientesBindingSource1;
        private System.Windows.Forms.BindingSource tbpacientesBindingSource2;
        private System.Windows.Forms.BindingSource tbpacientesBindingSource3;
        private System.Windows.Forms.BindingSource tbpacientesBindingSource4;
        private System.Windows.Forms.ListBox tbpacientesListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.TextBox paTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox tempTextBox;
    }
}