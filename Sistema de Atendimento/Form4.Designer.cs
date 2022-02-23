namespace Sistema_de_Atendimento
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            this.tbpacientesDataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataatendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.rPDbdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingNavigator)).BeginInit();
            this.tbpacientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tbpacientesBindingNavigatorSaveItem,
            this.toolStripButton2});
            this.tbpacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbpacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbpacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbpacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbpacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbpacientesBindingNavigator.Name = "tbpacientesBindingNavigator";
            this.tbpacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbpacientesBindingNavigator.Size = new System.Drawing.Size(934, 25);
            this.tbpacientesBindingNavigator.TabIndex = 0;
            this.tbpacientesBindingNavigator.Text = "bindingNavigator1";
            this.tbpacientesBindingNavigator.Click += new System.EventHandler(this.tbpacientesBindingNavigator_Click);
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
            // tbpacientesDataGridView
            // 
            this.tbpacientesDataGridView.AutoGenerateColumns = false;
            this.tbpacientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpacientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbpacientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.dataatendimento,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.tipo,
            this.dataGridViewTextBoxColumn3});
            this.tbpacientesDataGridView.DataSource = this.tbpacientesBindingSource;
            this.tbpacientesDataGridView.Location = new System.Drawing.Point(0, 28);
            this.tbpacientesDataGridView.Name = "tbpacientesDataGridView";
            this.tbpacientesDataGridView.Size = new System.Drawing.Size(934, 460);
            this.tbpacientesDataGridView.TabIndex = 2;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código:";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // dataatendimento
            // 
            this.dataatendimento.DataPropertyName = "dataatendimento";
            this.dataatendimento.HeaderText = "Data de atendimento:";
            this.dataatendimento.Name = "dataatendimento";
            this.dataatendimento.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nomepaciente";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nome do Paciente:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "idade";
            this.dataGridViewTextBoxColumn10.HeaderText = "Idade:";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo:";
            this.tipo.Name = "tipo";
            this.tipo.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "destino";
            this.dataGridViewTextBoxColumn3.HeaderText = "Destino:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.btn_edit);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 493);
            this.Controls.Add(this.tbpacientesDataGridView);
            this.Controls.Add(this.tbpacientesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPDbdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesBindingNavigator)).EndInit();
            this.tbpacientesBindingNavigator.ResumeLayout(false);
            this.tbpacientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpacientesDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView tbpacientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataatendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}