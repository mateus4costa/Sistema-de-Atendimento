namespace Sistema_de_Atendimento
{
    partial class Registro
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
            System.Windows.Forms.Label codigopaciLabel;
            System.Windows.Forms.Label profissaoLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label nomepaiLabel;
            System.Windows.Forms.Label nomemaeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label datanasciLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            System.Windows.Forms.Label codigoLabel1;
            System.Windows.Forms.Label dataatendimentoLabel1;
            System.Windows.Forms.Label destinoLabel1;
            System.Windows.Forms.Label tipoLabel1;
            System.Windows.Forms.Label nomepacienteLabel1;
            this.rPDbdDataSet = new Sistema_de_Atendimento.RPDbdDataSet();
            this.tbpacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpacientesTableAdapter = new Sistema_de_Atendimento.RPDbdDataSetTableAdapters.TbpacientesTableAdapter();
            this.tableAdapterManager = new Sistema_de_Atendimento.RPDbdDataSetTableAdapters.TableAdapterManager();
            this.tbpacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbpacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox1 = new System.Windows.Forms.TextBox();
            this.dataatendimentoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.destinoComboBox1 = new System.Windows.Forms.ComboBox();
            this.tipoComboBox1 = new System.Windows.Forms.ComboBox();
            this.nomepacienteTextBox1 = new System.Windows.Forms.TextBox();
            this.datanasciDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.enderecoTextBox1 = new System.Windows.Forms.TextBox();
            this.nomepaiTextBox1 = new System.Windows.Forms.TextBox();
            this.nomemaeTextBox1 = new System.Windows.Forms.TextBox();
            this.idadeTextBox1 = new System.Windows.Forms.TextBox();
            this.profissaoTextBox1 = new System.Windows.Forms.TextBox();
            this.cartaosusTextBox = new System.Windows.Forms.TextBox();
            codigopaciLabel = new System.Windows.Forms.Label();
            profissaoLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            nomepaiLabel = new System.Windows.Forms.Label();
            nomemaeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            datanasciLabel = new System.Windows.Forms.Label();
            codigoLabel1 = new System.Windows.Forms.Label();
            dataatendimentoLabel1 = new System.Windows.Forms.Label();
            destinoLabel1 = new System.Windows.Forms.Label();
            tipoLabel1 = new System.Windows.Forms.Label();
            nomepacienteLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rPDbdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingNavigator)).BeginInit();
            this.tbpacientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigopaciLabel
            // 
            codigopaciLabel.AutoSize = true;
            codigopaciLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            codigopaciLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigopaciLabel.Location = new System.Drawing.Point(404, 408);
            codigopaciLabel.Name = "codigopaciLabel";
            codigopaciLabel.Size = new System.Drawing.Size(221, 25);
            codigopaciLabel.TabIndex = 47;
            codigopaciLabel.Text = "Código do paciente:";
            // 
            // profissaoLabel
            // 
            profissaoLabel.AutoSize = true;
            profissaoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            profissaoLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            profissaoLabel.Location = new System.Drawing.Point(128, 408);
            profissaoLabel.Name = "profissaoLabel";
            profissaoLabel.Size = new System.Drawing.Size(122, 25);
            profissaoLabel.TabIndex = 45;
            profissaoLabel.Text = "Profissao:";
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            idadeLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idadeLabel.Location = new System.Drawing.Point(12, 408);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(78, 25);
            idadeLabel.TabIndex = 43;
            idadeLabel.Text = "Idade:";
            // 
            // nomepaiLabel
            // 
            nomepaiLabel.AutoSize = true;
            nomepaiLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nomepaiLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomepaiLabel.Location = new System.Drawing.Point(536, 311);
            nomepaiLabel.Name = "nomepaiLabel";
            nomepaiLabel.Size = new System.Drawing.Size(144, 25);
            nomepaiLabel.TabIndex = 41;
            nomepaiLabel.Text = "Nome do pai:";
            // 
            // nomemaeLabel
            // 
            nomemaeLabel.AutoSize = true;
            nomemaeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nomemaeLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomemaeLabel.Location = new System.Drawing.Point(728, 311);
            nomemaeLabel.Name = "nomemaeLabel";
            nomemaeLabel.Size = new System.Drawing.Size(144, 25);
            nomemaeLabel.TabIndex = 39;
            nomemaeLabel.Text = "Nome da mãe:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            enderecoLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(12, 311);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(111, 25);
            enderecoLabel.TabIndex = 37;
            enderecoLabel.Text = "Endereço:";
            // 
            // datanasciLabel
            // 
            datanasciLabel.AutoSize = true;
            datanasciLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            datanasciLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datanasciLabel.Location = new System.Drawing.Point(536, 204);
            datanasciLabel.Name = "datanasciLabel";
            datanasciLabel.Size = new System.Drawing.Size(221, 25);
            datanasciLabel.TabIndex = 35;
            datanasciLabel.Text = "Data de nascimento:";
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
            this.tbpacientesBindingNavigator.Size = new System.Drawing.Size(924, 25);
            this.tbpacientesBindingNavigator.TabIndex = 49;
            this.tbpacientesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tbpacientesBindingNavigatorSaveItem
            // 
            this.tbpacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbpacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbpacientesBindingNavigatorSaveItem.Image")));
            this.tbpacientesBindingNavigatorSaveItem.Name = "tbpacientesBindingNavigatorSaveItem";
            this.tbpacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbpacientesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbpacientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbpacientesBindingNavigatorSaveItem_Click_3);
            // 
            // codigoLabel1
            // 
            codigoLabel1.AutoSize = true;
            codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            codigoLabel1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel1.Location = new System.Drawing.Point(12, 102);
            codigoLabel1.Name = "codigoLabel1";
            codigoLabel1.Size = new System.Drawing.Size(89, 25);
            codigoLabel1.TabIndex = 49;
            codigoLabel1.Text = "Código:";
            // 
            // codigoTextBox1
            // 
            this.codigoTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.codigoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "codigo", true));
            this.codigoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTextBox1.Location = new System.Drawing.Point(12, 150);
            this.codigoTextBox1.Name = "codigoTextBox1";
            this.codigoTextBox1.Size = new System.Drawing.Size(169, 26);
            this.codigoTextBox1.TabIndex = 50;
            // 
            // dataatendimentoLabel1
            // 
            dataatendimentoLabel1.AutoSize = true;
            dataatendimentoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataatendimentoLabel1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataatendimentoLabel1.Location = new System.Drawing.Point(198, 102);
            dataatendimentoLabel1.Name = "dataatendimentoLabel1";
            dataatendimentoLabel1.Size = new System.Drawing.Size(232, 25);
            dataatendimentoLabel1.TabIndex = 50;
            dataatendimentoLabel1.Text = "Data de atendimento:";
            // 
            // dataatendimentoDateTimePicker1
            // 
            this.dataatendimentoDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbpacientesBindingSource, "dataatendimento", true));
            this.dataatendimentoDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataatendimentoDateTimePicker1.Location = new System.Drawing.Point(198, 150);
            this.dataatendimentoDateTimePicker1.Name = "dataatendimentoDateTimePicker1";
            this.dataatendimentoDateTimePicker1.Size = new System.Drawing.Size(308, 26);
            this.dataatendimentoDateTimePicker1.TabIndex = 20;
            // 
            // destinoLabel1
            // 
            destinoLabel1.AutoSize = true;
            destinoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            destinoLabel1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            destinoLabel1.Location = new System.Drawing.Point(536, 102);
            destinoLabel1.Name = "destinoLabel1";
            destinoLabel1.Size = new System.Drawing.Size(100, 25);
            destinoLabel1.TabIndex = 51;
            destinoLabel1.Text = "Destino:";
            // 
            // destinoComboBox1
            // 
            this.destinoComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.destinoComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "destino", true));
            this.destinoComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinoComboBox1.FormattingEnabled = true;
            this.destinoComboBox1.Items.AddRange(new object[] {
            "Médico",
            "Clínico Geral",
            "Cirurgião",
            "Dermatologista",
            "Endocrinologista",
            "Gastroenterologista",
            "Geriatra"});
            this.destinoComboBox1.Location = new System.Drawing.Point(536, 148);
            this.destinoComboBox1.Name = "destinoComboBox1";
            this.destinoComboBox1.Size = new System.Drawing.Size(168, 28);
            this.destinoComboBox1.TabIndex = 52;
            // 
            // tipoLabel1
            // 
            tipoLabel1.AutoSize = true;
            tipoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tipoLabel1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel1.Location = new System.Drawing.Point(728, 102);
            tipoLabel1.Name = "tipoLabel1";
            tipoLabel1.Size = new System.Drawing.Size(67, 25);
            tipoLabel1.TabIndex = 52;
            tipoLabel1.Text = "Tipo:";
            // 
            // tipoComboBox1
            // 
            this.tipoComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tipoComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "tipo", true));
            this.tipoComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoComboBox1.FormattingEnabled = true;
            this.tipoComboBox1.Items.AddRange(new object[] {
            "Consulta Eletiva",
            "Emergência",
            "Urgência\t"});
            this.tipoComboBox1.Location = new System.Drawing.Point(728, 148);
            this.tipoComboBox1.Name = "tipoComboBox1";
            this.tipoComboBox1.Size = new System.Drawing.Size(168, 28);
            this.tipoComboBox1.TabIndex = 53;
            // 
            // nomepacienteLabel1
            // 
            nomepacienteLabel1.AutoSize = true;
            nomepacienteLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nomepacienteLabel1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomepacienteLabel1.Location = new System.Drawing.Point(12, 204);
            nomepacienteLabel1.Name = "nomepacienteLabel1";
            nomepacienteLabel1.Size = new System.Drawing.Size(199, 25);
            nomepacienteLabel1.TabIndex = 53;
            nomepacienteLabel1.Text = "Nome do paciente:";
            // 
            // nomepacienteTextBox1
            // 
            this.nomepacienteTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomepacienteTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomepacienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "nomepaciente", true));
            this.nomepacienteTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomepacienteTextBox1.Location = new System.Drawing.Point(12, 256);
            this.nomepacienteTextBox1.Name = "nomepacienteTextBox1";
            this.nomepacienteTextBox1.Size = new System.Drawing.Size(502, 26);
            this.nomepacienteTextBox1.TabIndex = 54;
            // 
            // datanasciDateTimePicker1
            // 
            this.datanasciDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbpacientesBindingSource, "datanasci", true));
            this.datanasciDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datanasciDateTimePicker1.Location = new System.Drawing.Point(536, 256);
            this.datanasciDateTimePicker1.Name = "datanasciDateTimePicker1";
            this.datanasciDateTimePicker1.Size = new System.Drawing.Size(360, 26);
            this.datanasciDateTimePicker1.TabIndex = 55;
            // 
            // enderecoTextBox1
            // 
            this.enderecoTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enderecoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "endereco", true));
            this.enderecoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox1.Location = new System.Drawing.Point(12, 360);
            this.enderecoTextBox1.Name = "enderecoTextBox1";
            this.enderecoTextBox1.Size = new System.Drawing.Size(502, 26);
            this.enderecoTextBox1.TabIndex = 56;
            // 
            // nomepaiTextBox1
            // 
            this.nomepaiTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomepaiTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomepaiTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "nomepai", true));
            this.nomepaiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomepaiTextBox1.Location = new System.Drawing.Point(536, 361);
            this.nomepaiTextBox1.Name = "nomepaiTextBox1";
            this.nomepaiTextBox1.Size = new System.Drawing.Size(168, 26);
            this.nomepaiTextBox1.TabIndex = 57;
            // 
            // nomemaeTextBox1
            // 
            this.nomemaeTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomemaeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomemaeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "nomemae", true));
            this.nomemaeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomemaeTextBox1.Location = new System.Drawing.Point(728, 361);
            this.nomemaeTextBox1.Name = "nomemaeTextBox1";
            this.nomemaeTextBox1.Size = new System.Drawing.Size(168, 26);
            this.nomemaeTextBox1.TabIndex = 58;
            // 
            // idadeTextBox1
            // 
            this.idadeTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.idadeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idadeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "idade", true));
            this.idadeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeTextBox1.Location = new System.Drawing.Point(12, 448);
            this.idadeTextBox1.Name = "idadeTextBox1";
            this.idadeTextBox1.Size = new System.Drawing.Size(89, 26);
            this.idadeTextBox1.TabIndex = 59;
            // 
            // profissaoTextBox1
            // 
            this.profissaoTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.profissaoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profissaoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "profissao", true));
            this.profissaoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profissaoTextBox1.Location = new System.Drawing.Point(128, 448);
            this.profissaoTextBox1.Name = "profissaoTextBox1";
            this.profissaoTextBox1.Size = new System.Drawing.Size(239, 26);
            this.profissaoTextBox1.TabIndex = 60;
            // 
            // cartaosusTextBox
            // 
            this.cartaosusTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cartaosusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartaosusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbpacientesBindingSource, "cartaosus", true));
            this.cartaosusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartaosusTextBox.Location = new System.Drawing.Point(404, 448);
            this.cartaosusTextBox.Name = "cartaosusTextBox";
            this.cartaosusTextBox.Size = new System.Drawing.Size(221, 26);
            this.cartaosusTextBox.TabIndex = 61;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(924, 502);
            this.Controls.Add(this.cartaosusTextBox);
            this.Controls.Add(this.profissaoTextBox1);
            this.Controls.Add(this.idadeTextBox1);
            this.Controls.Add(this.nomemaeTextBox1);
            this.Controls.Add(this.nomepaiTextBox1);
            this.Controls.Add(this.enderecoTextBox1);
            this.Controls.Add(this.datanasciDateTimePicker1);
            this.Controls.Add(nomepacienteLabel1);
            this.Controls.Add(this.nomepacienteTextBox1);
            this.Controls.Add(tipoLabel1);
            this.Controls.Add(this.tipoComboBox1);
            this.Controls.Add(destinoLabel1);
            this.Controls.Add(this.destinoComboBox1);
            this.Controls.Add(dataatendimentoLabel1);
            this.Controls.Add(this.dataatendimentoDateTimePicker1);
            this.Controls.Add(codigoLabel1);
            this.Controls.Add(this.codigoTextBox1);
            this.Controls.Add(this.tbpacientesBindingNavigator);
            this.Controls.Add(codigopaciLabel);
            this.Controls.Add(profissaoLabel);
            this.Controls.Add(idadeLabel);
            this.Controls.Add(nomepaiLabel);
            this.Controls.Add(nomemaeLabel);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(datanasciLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPDbdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingNavigator)).EndInit();
            this.tbpacientesBindingNavigator.ResumeLayout(false);
            this.tbpacientesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox codigoTextBox1;
        private System.Windows.Forms.DateTimePicker dataatendimentoDateTimePicker1;
        private System.Windows.Forms.ComboBox destinoComboBox1;
        private System.Windows.Forms.ComboBox tipoComboBox1;
        private System.Windows.Forms.TextBox nomepacienteTextBox1;
        private System.Windows.Forms.DateTimePicker datanasciDateTimePicker1;
        private System.Windows.Forms.TextBox enderecoTextBox1;
        private System.Windows.Forms.TextBox nomepaiTextBox1;
        private System.Windows.Forms.TextBox nomemaeTextBox1;
        private System.Windows.Forms.TextBox idadeTextBox1;
        private System.Windows.Forms.TextBox profissaoTextBox1;
        private System.Windows.Forms.TextBox cartaosusTextBox;
    }
}