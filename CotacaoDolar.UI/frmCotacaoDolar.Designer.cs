namespace CotacaoDolar.UI
{
    partial class frmCotacaoDolar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotacaoDolar));
            this.btnMostrarCotacaoDolar = new System.Windows.Forms.Button();
            this.cotacaoDolarDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCotacaoDolar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCotacaoDolarAtual = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cotacaoDolarDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotacaoDolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarCotacaoDolar
            // 
            this.btnMostrarCotacaoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCotacaoDolar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarCotacaoDolar.Image")));
            this.btnMostrarCotacaoDolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarCotacaoDolar.Location = new System.Drawing.Point(327, 101);
            this.btnMostrarCotacaoDolar.Name = "btnMostrarCotacaoDolar";
            this.btnMostrarCotacaoDolar.Size = new System.Drawing.Size(180, 55);
            this.btnMostrarCotacaoDolar.TabIndex = 0;
            this.btnMostrarCotacaoDolar.Text = "Mostrar cotação dólar";
            this.btnMostrarCotacaoDolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarCotacaoDolar.UseVisualStyleBackColor = true;
            this.btnMostrarCotacaoDolar.Click += new System.EventHandler(this.btnMostrarCotacaoDolar_Click);
            // 
            // cotacaoDolarDiaBindingSource
            // 
            this.cotacaoDolarDiaBindingSource.DataSource = typeof(ContacaoDolar.Domain.CotacaoDolarDia);
            // 
            // dgvCotacaoDolar
            // 
            this.dgvCotacaoDolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotacaoDolar.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCotacaoDolar.Location = new System.Drawing.Point(0, 0);
            this.dgvCotacaoDolar.Name = "dgvCotacaoDolar";
            this.dgvCotacaoDolar.Size = new System.Drawing.Size(318, 243);
            this.dgvCotacaoDolar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(324, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cotação do dolar atual é:";
            // 
            // lblCotacaoDolarAtual
            // 
            this.lblCotacaoDolarAtual.AutoSize = true;
            this.lblCotacaoDolarAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotacaoDolarAtual.ForeColor = System.Drawing.Color.Blue;
            this.lblCotacaoDolarAtual.Location = new System.Drawing.Point(359, 206);
            this.lblCotacaoDolarAtual.Name = "lblCotacaoDolarAtual";
            this.lblCotacaoDolarAtual.Size = new System.Drawing.Size(0, 31);
            this.lblCotacaoDolarAtual.TabIndex = 3;
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(430, 11);
            this.nudDias.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(42, 20);
            this.nudDias.TabIndex = 4;
            this.nudDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cotação do dolar de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "dias.";
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.lblCotacaoDolarAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCotacaoDolar);
            this.Controls.Add(this.btnMostrarCotacaoDolar);
            this.Name = "frmCotacaoDolar";
            this.Text = "Cotação Dolar";
            ((System.ComponentModel.ISupportInitialize)(this.cotacaoDolarDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotacaoDolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarCotacaoDolar;
        private System.Windows.Forms.BindingSource cotacaoDolarDiaBindingSource;
        private System.Windows.Forms.DataGridView dgvCotacaoDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCotacaoDolarAtual;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

