
namespace CRUD_Mercado
{
    partial class CadastroProdutos
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
            this.Btn_CadastrarProduto = new System.Windows.Forms.Button();
            this.Grid_Listagem_Produtos = new System.Windows.Forms.DataGridView();
            this.Txt_NomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBX_CategoriaProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_FazerPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Listagem_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CadastrarProduto
            // 
            this.Btn_CadastrarProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CadastrarProduto.Location = new System.Drawing.Point(12, 368);
            this.Btn_CadastrarProduto.Name = "Btn_CadastrarProduto";
            this.Btn_CadastrarProduto.Size = new System.Drawing.Size(776, 70);
            this.Btn_CadastrarProduto.TabIndex = 0;
            this.Btn_CadastrarProduto.Text = "Cadastrar Produto";
            this.Btn_CadastrarProduto.UseCompatibleTextRendering = true;
            this.Btn_CadastrarProduto.UseVisualStyleBackColor = true;
            this.Btn_CadastrarProduto.Click += new System.EventHandler(this.Btn_CadastrarProduto_Click);
            // 
            // Grid_Listagem_Produtos
            // 
            this.Grid_Listagem_Produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Listagem_Produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid_Listagem_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Listagem_Produtos.Location = new System.Drawing.Point(206, 125);
            this.Grid_Listagem_Produtos.Name = "Grid_Listagem_Produtos";
            this.Grid_Listagem_Produtos.Size = new System.Drawing.Size(388, 237);
            this.Grid_Listagem_Produtos.TabIndex = 2;
            // 
            // Txt_NomeProduto
            // 
            this.Txt_NomeProduto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeProduto.Location = new System.Drawing.Point(306, 41);
            this.Txt_NomeProduto.Name = "Txt_NomeProduto";
            this.Txt_NomeProduto.Size = new System.Drawing.Size(188, 27);
            this.Txt_NomeProduto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Produto";
            // 
            // ComboBX_CategoriaProduto
            // 
            this.ComboBX_CategoriaProduto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBX_CategoriaProduto.FormattingEnabled = true;
            this.ComboBX_CategoriaProduto.Items.AddRange(new object[] {
            "Higiene",
            "Alimentação",
            "Bebida Alcoólica",
            "Doce",
            "Salgado"});
            this.ComboBX_CategoriaProduto.Location = new System.Drawing.Point(306, 90);
            this.ComboBX_CategoriaProduto.Name = "ComboBX_CategoriaProduto";
            this.ComboBX_CategoriaProduto.Size = new System.Drawing.Size(188, 29);
            this.ComboBX_CategoriaProduto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento do Produto";
            // 
            // Btn_FazerPedido
            // 
            this.Btn_FazerPedido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FazerPedido.Location = new System.Drawing.Point(582, 21);
            this.Btn_FazerPedido.Name = "Btn_FazerPedido";
            this.Btn_FazerPedido.Size = new System.Drawing.Size(206, 53);
            this.Btn_FazerPedido.TabIndex = 7;
            this.Btn_FazerPedido.Text = "Fazer Pedido";
            this.Btn_FazerPedido.UseCompatibleTextRendering = true;
            this.Btn_FazerPedido.UseVisualStyleBackColor = true;
            this.Btn_FazerPedido.Click += new System.EventHandler(this.Btn_FazerPedido_Click);
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_FazerPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBX_CategoriaProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_NomeProduto);
            this.Controls.Add(this.Grid_Listagem_Produtos);
            this.Controls.Add(this.Btn_CadastrarProduto);
            this.Name = "CadastroProdutos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Listagem_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CadastrarProduto;
        private System.Windows.Forms.DataGridView Grid_Listagem_Produtos;
        private System.Windows.Forms.TextBox Txt_NomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBX_CategoriaProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_FazerPedido;
    }
}

