namespace DiarioNutricional
{
    partial class FormQuantidade
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
            this.campoQuantidade = new System.Windows.Forms.NumericUpDown();
            this.labelDescricaoAlimento = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.campoTipoRefeicao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.campoQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // campoQuantidade
            // 
            this.campoQuantidade.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.campoQuantidade.Location = new System.Drawing.Point(26, 25);
            this.campoQuantidade.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.campoQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campoQuantidade.Name = "campoQuantidade";
            this.campoQuantidade.Size = new System.Drawing.Size(79, 20);
            this.campoQuantidade.TabIndex = 0;
            this.campoQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDescricaoAlimento
            // 
            this.labelDescricaoAlimento.AutoSize = true;
            this.labelDescricaoAlimento.Location = new System.Drawing.Point(23, 9);
            this.labelDescricaoAlimento.Name = "labelDescricaoAlimento";
            this.labelDescricaoAlimento.Size = new System.Drawing.Size(35, 13);
            this.labelDescricaoAlimento.TabIndex = 1;
            this.labelDescricaoAlimento.Text = "label1";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(26, 103);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            // 
            // campoTipoRefeicao
            // 
            this.campoTipoRefeicao.FormattingEnabled = true;
            this.campoTipoRefeicao.Location = new System.Drawing.Point(26, 65);
            this.campoTipoRefeicao.Name = "campoTipoRefeicao";
            this.campoTipoRefeicao.Size = new System.Drawing.Size(121, 21);
            this.campoTipoRefeicao.TabIndex = 3;
            // 
            // FormQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 161);
            this.Controls.Add(this.campoTipoRefeicao);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelDescricaoAlimento);
            this.Controls.Add(this.campoQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQuantidade";
            this.Text = "Quantidade";
            this.Load += new System.EventHandler(this.FormQuantidade_Load);
            this.Shown += new System.EventHandler(this.FormQuantidade_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.campoQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown campoQuantidade;
        private System.Windows.Forms.Label labelDescricaoAlimento;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.ComboBox campoTipoRefeicao;
    }
}