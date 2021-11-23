
namespace CRUD_Mercado
{
    partial class Frm_Pedidos
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
            this.Btn_SalvarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NomeProduto_Pedido = new System.Windows.Forms.TextBox();
            this.Grid_Pedidos_Feitos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_VoltarCadastro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBX_CategoriaProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Pedidos_Feitos)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_SalvarPedido
            // 
            this.Btn_SalvarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_SalvarPedido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarPedido.Location = new System.Drawing.Point(8, 12);
            this.Btn_SalvarPedido.Name = "Btn_SalvarPedido";
            this.Btn_SalvarPedido.Size = new System.Drawing.Size(168, 190);
            this.Btn_SalvarPedido.TabIndex = 15;
            this.Btn_SalvarPedido.Text = "Salvar Pedido \'3\'";
            this.Btn_SalvarPedido.UseCompatibleTextRendering = true;
            this.Btn_SalvarPedido.UseVisualStyleBackColor = false;
            this.Btn_SalvarPedido.Click += new System.EventHandler(this.Btn_SalvarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome do Produto";
            // 
            // Txt_NomeProduto_Pedido
            // 
            this.Txt_NomeProduto_Pedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeProduto_Pedido.Location = new System.Drawing.Point(400, 37);
            this.Txt_NomeProduto_Pedido.Name = "Txt_NomeProduto_Pedido";
            this.Txt_NomeProduto_Pedido.Size = new System.Drawing.Size(188, 27);
            this.Txt_NomeProduto_Pedido.TabIndex = 11;
            // 
            // Grid_Pedidos_Feitos
            // 
            this.Grid_Pedidos_Feitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Pedidos_Feitos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_Pedidos_Feitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Pedidos_Feitos.Location = new System.Drawing.Point(15, 246);
            this.Grid_Pedidos_Feitos.Name = "Grid_Pedidos_Feitos";
            this.Grid_Pedidos_Feitos.Size = new System.Drawing.Size(773, 192);
            this.Grid_Pedidos_Feitos.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Produtos ";
            // 
            // Btn_VoltarCadastro
            // 
            this.Btn_VoltarCadastro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCadastro.Location = new System.Drawing.Point(620, 12);
            this.Btn_VoltarCadastro.Name = "Btn_VoltarCadastro";
            this.Btn_VoltarCadastro.Size = new System.Drawing.Size(168, 190);
            this.Btn_VoltarCadastro.TabIndex = 18;
            this.Btn_VoltarCadastro.Text = "Voltar para Cadastro ;-;";
            this.Btn_VoltarCadastro.UseCompatibleTextRendering = true;
            this.Btn_VoltarCadastro.UseVisualStyleBackColor = true;
            this.Btn_VoltarCadastro.Click += new System.EventHandler(this.Btn_VoltarCadastro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Categoria do Produto";
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
            this.ComboBX_CategoriaProduto.Location = new System.Drawing.Point(400, 79);
            this.ComboBX_CategoriaProduto.Name = "ComboBX_CategoriaProduto";
            this.ComboBX_CategoriaProduto.Size = new System.Drawing.Size(188, 29);
            this.ComboBX_CategoriaProduto.TabIndex = 20;
            // 
            // Frm_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBX_CategoriaProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_VoltarCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_Pedidos_Feitos);
            this.Controls.Add(this.Btn_SalvarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_NomeProduto_Pedido);
            this.Name = "Frm_Pedidos";
            this.Text = "Pedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Pedidos_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Pedidos_Feitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SalvarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_NomeProduto_Pedido;
        private System.Windows.Forms.DataGridView Grid_Pedidos_Feitos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_VoltarCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBX_CategoriaProduto;
    }
}