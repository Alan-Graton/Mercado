CREATE TABLE TB_Produtos(
	Produto_ID INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(150) NOT NULL,
	Categoria VARCHAR(50) NOT NULL
) DROP TABLE TB_Produtos

CREATE TABLE TB_Pedidos(
	Pedido_ID INT IDENTITY PRIMARY KEY,
	NomeProduto VARCHAR(150) NOT NULL,
	CategoriaProduto VARCHAR(50) NOT NULL
)

-- Populando Tabela 'TB_Produtos'
INSERT INTO TB_Produtos VALUES('Pasta de Dente', 'Higiene')
INSERT INTO TB_Produtos VALUES('Cotonete', 'Higiene')

INSERT INTO TB_Produtos VALUES('Pão', 'Alimentação')

INSERT INTO TB_Produtos VALUES('Vinho', 'Bebida Alcoólica')
INSERT INTO TB_Produtos VALUES('Pinga', 'Bebida Alcoólica')
INSERT INTO TB_Produtos VALUES('Cachaça', 'Bebida Alcoólica')

INSERT INTO TB_Produtos VALUES('Brigadeiro', 'Doce')
INSERT INTO TB_Produtos VALUES('Beijinho', 'Doce')
INSERT INTO TB_Produtos VALUES('Sorvete', 'Doce')

INSERT INTO TB_Produtos VALUES('Pipoca', 'Salgado')
INSERT INTO TB_Produtos VALUES('Batata Lays', 'Salgado')
INSERT INTO TB_Produtos VALUES('Coxinha', 'Salgado')

-- Populando Tabela 'TB_Pedidos'
INSERT INTO TB_Pedidos VALUES('Escova de Dente', 'Higiene')
INSERT INTO TB_Pedidos VALUES('Sabonete Líquido', 'Higiene')

INSERT INTO TB_Pedidos VALUES('Pão', 'Alimentação')
INSERT INTO TB_Pedidos VALUES('Manteiga', 'Alimentação')
INSERT INTO TB_Pedidos VALUES('Mel', 'Alimentação')

SELECT * FROM TB_Produtos
SELECT * FROM TB_Pedidos

-- Procedure para CADASTRAR PRODUTOS
DROP PROCEDURE CadastrarProdutos
GO
CREATE PROCEDURE CadastrarProdutos(
	@Nome VARCHAR(150),
	@Categoria VARCHAR(50)
)

AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM TB_Produtos WHERE Nome = @Nome)
			BEGIN
				INSERT INTO TB_Produtos VALUES(@Nome, @Categoria)
			END
		ELSE
			SELECT 'Produto já havia sido Cadastrado ;-;' AS Retorno
	END
GO

-- Procedure para CADASTRAR PRODUTOS
DROP PROCEDURE RealizarPedidos
GO
CREATE PROCEDURE RealizarPedidos(
	@NomeProduto VARCHAR(150),
	@CategoriaProduto VARCHAR(50)
)

AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM TB_Pedidos WHERE NomeProduto = @NomeProduto)
			BEGIN
				INSERT INTO TB_Pedidos VALUES(@NomeProduto, @CategoriaProduto)
			END
		ELSE
			SELECT 'Pedido já havia sido feito ;-;' AS Retorno
	END
GO