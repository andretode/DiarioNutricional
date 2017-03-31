namespace DiarioNutricional
{
    partial class Form1
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
            this.dgwInformacoesNutricionais = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxFiltroAlimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwPorcoesDoDia = new System.Windows.Forms.DataGridView();
            this.porcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantidadeEmGramasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantEnergiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantCarboidratosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantProteinasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantGordurasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInformacoesNutricionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPorcoesDoDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwInformacoesNutricionais
            // 
            this.dgwInformacoesNutricionais.AllowUserToAddRows = false;
            this.dgwInformacoesNutricionais.AllowUserToDeleteRows = false;
            this.dgwInformacoesNutricionais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwInformacoesNutricionais.AutoGenerateColumns = false;
            this.dgwInformacoesNutricionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInformacoesNutricionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgwInformacoesNutricionais.DataSource = this.alimentoBindingSource;
            this.dgwInformacoesNutricionais.Location = new System.Drawing.Point(12, 38);
            this.dgwInformacoesNutricionais.Name = "dgwInformacoesNutricionais";
            this.dgwInformacoesNutricionais.ReadOnly = true;
            this.dgwInformacoesNutricionais.Size = new System.Drawing.Size(725, 190);
            this.dgwInformacoesNutricionais.TabIndex = 0;
            this.dgwInformacoesNutricionais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInformacoesNutricionais_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EnergiaKcal";
            this.dataGridViewTextBoxColumn2.HeaderText = "Energia (kcal)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProteinasEmGramas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Proteinas (g)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CarboidratosEmGramas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Carboidrat. (g)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GordurasEmGramas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gorduras (g)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // alimentoBindingSource
            // 
            this.alimentoBindingSource.DataSource = typeof(DiarioNutricional.Model.Alimento);
            // 
            // textBoxFiltroAlimento
            // 
            this.textBoxFiltroAlimento.Location = new System.Drawing.Point(111, 12);
            this.textBoxFiltroAlimento.Name = "textBoxFiltroAlimento";
            this.textBoxFiltroAlimento.Size = new System.Drawing.Size(210, 20);
            this.textBoxFiltroAlimento.TabIndex = 1;
            this.textBoxFiltroAlimento.TextChanged += new System.EventHandler(this.textBoxFiltroAlimento_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por Alimento";
            // 
            // dgwPorcoesDoDia
            // 
            this.dgwPorcoesDoDia.AllowUserToAddRows = false;
            this.dgwPorcoesDoDia.AutoGenerateColumns = false;
            this.dgwPorcoesDoDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPorcoesDoDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantidadeEmGramasDataGridViewTextBoxColumn,
            this.DescricaoAlimento,
            this.quantEnergiaDataGridViewTextBoxColumn,
            this.quantCarboidratosDataGridViewTextBoxColumn,
            this.quantProteinasDataGridViewTextBoxColumn,
            this.quantGordurasDataGridViewTextBoxColumn});
            this.dgwPorcoesDoDia.DataSource = this.porcaoBindingSource;
            this.dgwPorcoesDoDia.Location = new System.Drawing.Point(12, 273);
            this.dgwPorcoesDoDia.Name = "dgwPorcoesDoDia";
            this.dgwPorcoesDoDia.Size = new System.Drawing.Size(725, 198);
            this.dgwPorcoesDoDia.TabIndex = 3;
            // 
            // porcaoBindingSource
            // 
            this.porcaoBindingSource.DataSource = typeof(DiarioNutricional.Model.Porcao);
            // 
            // quantidadeEmGramasDataGridViewTextBoxColumn
            // 
            this.quantidadeEmGramasDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeEmGramas";
            this.quantidadeEmGramasDataGridViewTextBoxColumn.HeaderText = "QuantidadeEmGramas";
            this.quantidadeEmGramasDataGridViewTextBoxColumn.Name = "quantidadeEmGramasDataGridViewTextBoxColumn";
            // 
            // DescricaoAlimento
            // 
            this.DescricaoAlimento.DataPropertyName = "DescricaoAlimento";
            this.DescricaoAlimento.HeaderText = "Alimento";
            this.DescricaoAlimento.Name = "DescricaoAlimento";
            this.DescricaoAlimento.ReadOnly = true;
            // 
            // quantEnergiaDataGridViewTextBoxColumn
            // 
            this.quantEnergiaDataGridViewTextBoxColumn.DataPropertyName = "QuantEnergia";
            this.quantEnergiaDataGridViewTextBoxColumn.HeaderText = "QuantEnergia";
            this.quantEnergiaDataGridViewTextBoxColumn.Name = "quantEnergiaDataGridViewTextBoxColumn";
            this.quantEnergiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantCarboidratosDataGridViewTextBoxColumn
            // 
            this.quantCarboidratosDataGridViewTextBoxColumn.DataPropertyName = "QuantCarboidratos";
            this.quantCarboidratosDataGridViewTextBoxColumn.HeaderText = "QuantCarboidratos";
            this.quantCarboidratosDataGridViewTextBoxColumn.Name = "quantCarboidratosDataGridViewTextBoxColumn";
            this.quantCarboidratosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantProteinasDataGridViewTextBoxColumn
            // 
            this.quantProteinasDataGridViewTextBoxColumn.DataPropertyName = "QuantProteinas";
            this.quantProteinasDataGridViewTextBoxColumn.HeaderText = "QuantProteinas";
            this.quantProteinasDataGridViewTextBoxColumn.Name = "quantProteinasDataGridViewTextBoxColumn";
            this.quantProteinasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantGordurasDataGridViewTextBoxColumn
            // 
            this.quantGordurasDataGridViewTextBoxColumn.DataPropertyName = "QuantGorduras";
            this.quantGordurasDataGridViewTextBoxColumn.HeaderText = "QuantGorduras";
            this.quantGordurasDataGridViewTextBoxColumn.Name = "quantGordurasDataGridViewTextBoxColumn";
            this.quantGordurasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 525);
            this.Controls.Add(this.dgwPorcoesDoDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltroAlimento);
            this.Controls.Add(this.dgwInformacoesNutricionais);
            this.Name = "Form1";
            this.Text = "Diário Nutricional";
            ((System.ComponentModel.ISupportInitialize)(this.dgwInformacoesNutricionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPorcoesDoDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwInformacoesNutricionais;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaKcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinasEmGramasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carboidratosEmGramasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gordurasEmGramasDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxFiltroAlimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwPorcoesDoDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeRefeicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alimentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource porcaoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEmGramasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantEnergiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantCarboidratosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantProteinasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantGordurasDataGridViewTextBoxColumn;
    }
}

