create database LeanWork;

/

use LeanWork;

/

CREATE TABLE Carrinhos (
    CarrinhoId INT PRIMARY KEY IDENTITY(1,1),
	TotalItens INT NOT NULL,
	ValorTotal DECIMAL(10, 2) NOT NULL
);

/

CREATE TABLE Carrinho_Itens (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CarrinhoId INT NOT NULL,
    Produto VARCHAR(200) NOT NULL,
    Quantidade INT NOT NULL,
    PrecoUnitario DECIMAL(10, 2) NOT NULL,
    PrecoTotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CarrinhoId) REFERENCES Carrinhos(CarrinhoId),
);