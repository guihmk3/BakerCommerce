namespace BakerCommerce
{
    partial class FormComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComandas));
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.lblComandaInfo = new System.Windows.Forms.Label();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.btnContinuarInfo = new System.Windows.Forms.Button();
            this.lblQuebralinha = new System.Windows.Forms.Label();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.lblComandaLanc = new System.Windows.Forms.Label();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lblProdutoLanc = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblLancamentodecmd = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(172, 40);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(109, 47);
            this.txbComanda.TabIndex = 0;
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(172, 100);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(109, 47);
            this.txbCodProduto.TabIndex = 1;
            // 
            // lblComandaInfo
            // 
            this.lblComandaInfo.AutoSize = true;
            this.lblComandaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaInfo.Location = new System.Drawing.Point(6, 40);
            this.lblComandaInfo.Name = "lblComandaInfo";
            this.lblComandaInfo.Size = new System.Drawing.Size(169, 31);
            this.lblComandaInfo.TabIndex = 2;
            this.lblComandaInfo.Text = "COMANDA:";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(-3, 100);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(174, 29);
            this.lblCodProduto.TabIndex = 3;
            this.lblCodProduto.Text = "Cód. Produto:";
            // 
            // btnContinuarInfo
            // 
            this.btnContinuarInfo.Location = new System.Drawing.Point(43, 153);
            this.btnContinuarInfo.Name = "btnContinuarInfo";
            this.btnContinuarInfo.Size = new System.Drawing.Size(201, 52);
            this.btnContinuarInfo.TabIndex = 4;
            this.btnContinuarInfo.Text = "CONTINUAR";
            this.btnContinuarInfo.UseVisualStyleBackColor = true;
            this.btnContinuarInfo.Click += new System.EventHandler(this.btnContinuarInfo_Click);
            // 
            // lblQuebralinha
            // 
            this.lblQuebralinha.AutoSize = true;
            this.lblQuebralinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuebralinha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblQuebralinha.Location = new System.Drawing.Point(1, 330);
            this.lblQuebralinha.Name = "lblQuebralinha";
            this.lblQuebralinha.Size = new System.Drawing.Size(299, 25);
            this.lblQuebralinha.TabIndex = 5;
            this.lblQuebralinha.Text = "-----------------------------------------";
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblComandaInfo);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.btnContinuarInfo);
            this.grbInformacoes.Controls.Add(this.lblCodProduto);
            this.grbInformacoes.Controls.Add(this.txbCodProduto);
            this.grbInformacoes.Location = new System.Drawing.Point(6, 98);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(287, 229);
            this.grbInformacoes.TabIndex = 6;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.lblComandaLanc);
            this.grbLancamento.Controls.Add(this.txbProduto);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.lblProdutoLanc);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Location = new System.Drawing.Point(6, 358);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(287, 229);
            this.grbLancamento.TabIndex = 7;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // lblComandaLanc
            // 
            this.lblComandaLanc.AutoSize = true;
            this.lblComandaLanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaLanc.Location = new System.Drawing.Point(46, 49);
            this.lblComandaLanc.Name = "lblComandaLanc";
            this.lblComandaLanc.Size = new System.Drawing.Size(125, 31);
            this.lblComandaLanc.TabIndex = 2;
            this.lblComandaLanc.Text = "Produto:";
            // 
            // txbProduto
            // 
            this.txbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(181, 40);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(100, 47);
            this.txbProduto.TabIndex = 0;
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(43, 153);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(201, 52);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lblProdutoLanc
            // 
            this.lblProdutoLanc.AutoSize = true;
            this.lblProdutoLanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLanc.Location = new System.Drawing.Point(3, 100);
            this.lblProdutoLanc.Name = "lblProdutoLanc";
            this.lblProdutoLanc.Size = new System.Drawing.Size(173, 31);
            this.lblProdutoLanc.TabIndex = 3;
            this.lblProdutoLanc.Text = "Quantidade:";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(181, 93);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 47);
            this.txbQuantidade.TabIndex = 1;
            // 
            // lblLancamentodecmd
            // 
            this.lblLancamentodecmd.AutoSize = true;
            this.lblLancamentodecmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamentodecmd.Location = new System.Drawing.Point(264, 30);
            this.lblLancamentodecmd.Name = "lblLancamentodecmd";
            this.lblLancamentodecmd.Size = new System.Drawing.Size(425, 37);
            this.lblLancamentodecmd.TabIndex = 8;
            this.lblLancamentodecmd.Text = "Lançamento de Comandas";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(317, 107);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(521, 480);
            this.dgvProdutos.TabIndex = 9;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.codparapicturebox;
            this.pictureBox1.Location = new System.Drawing.Point(695, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(850, 663);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblLancamentodecmd);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.lblQuebralinha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandas";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Label lblComandaInfo;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Button btnContinuarInfo;
        private System.Windows.Forms.Label lblQuebralinha;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Label lblComandaLanc;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label lblProdutoLanc;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblLancamentodecmd;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}