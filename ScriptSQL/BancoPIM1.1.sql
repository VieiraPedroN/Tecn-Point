/*Caso tudo dê errado*/
DROP TABLE Usuarios;
DROP TABLE Chamados;
DROP TABLE Jornada;
DROP TABLE Modulo;
DROP TABLE Conversa;

/* Criação das tabelas */
/*Tabela usuários*/
CREATE TABLE Usuarios (
	id_Usuario SERIAL PRIMARY KEY,
	Nome VARCHAR(45),
	Email VARCHAR(45) UNIQUE,
	Senha VARCHAR(45),
	tipo_Usuario VARCHAR(15),
	CONSTRAINT tipo_usuario_check CHECK (
		tipo_usuario IN ('Funcionário', 'Cliente')
	)	
);

/*Tabela chamados*/
CREATE TABLE Chamados (
	id_Chamado SERIAL PRIMARY KEY,
	Titulo VARCHAR(45),
	Descricao TEXT,
	Status VARCHAR(10),
	Prioridade VARCHAR(5),
	CONSTRAINT prioridade_chamado_check CHECK (
		Prioridade IN ('Baixa', 'Média', 'Alta')
	),
	CONSTRAINT status_chamado_check CHECK (
		Status IN ('Aberto', 'Pendente', 'Resolvido')
	),
	fk_idCliente INT,
	fk_idFuncionario INT,
	fk_idJornada INT,
	fk_idModulo INT,
	FOREIGN KEY (fk_idCliente) REFERENCES Usuarios(id_Usuario),
	FOREIGN KEY (fk_idFuncionario) REFERENCES Usuarios(id_Usuario),
	FOREIGN KEY (fk_idJornada) REFERENCES Jornada(id_Jornada),
	FOREIGN KEY (fk_idModulo) REFERENCES Modulo(id_Modulo)
);

/*Tabela jornada*/
CREATE TABLE Jornada (
	id_Jornada SERIAL PRIMARY KEY,
	jornada VARCHAR(25),
	CONSTRAINT jornada_check CHECK (
		jornada IN ('Financeiro', 'Marketing', 'Recursos Humanos', 'Jurídico') 
	)
);

/*Tabela módulo*/
CREATE TABLE Modulo (
	id_Modulo SERIAL PRIMARY KEY,
	modulo VARCHAR(25),
	CONSTRAINT modulo_check CHECK (
		modulo IN ('Hardware', 'Software', 'Rede')
	) 
);

/*Tabela conversas*/
CREATE TABLE Conversa (
	id_Conversa SERIAL PRIMARY KEY,
	Mensagem VARCHAR(250),
	fk_idChamado INT,
	fk_idRemetente INT,
	Data_Hora TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	FOREIGN KEY (fk_idRemetente) REFERENCES Usuarios(id_Usuario),
	FOREIGN KEY (fk_idChamado) REFERENCES Chamados(id_Chamado)	
);

/*Inserção de valores nas tabelas*/
/*usuários*/
INSERT INTO Usuarios (Nome, Email, Senha, tipo_Usuario)
VALUES 
	('teste', 'testefunc@gmail.com', 'teste', 'Funcionário'),
	('Danilo Alves da Silva', 'danalvessilva@gmail.com.br', 'dan163', 'Funcionário'),
	('Michael do Valle', 'valledomichael@gmail.com', 'senhamaisforte', 'Cliente'),
	('Leonardo Miranda', 'leomiranda@gmail.com', 'sanheforte', 'Funcionário'),
	('Aroldo Carlos', 'caroldo@gmail.com', '99008760', 'Cliente');

/*chamados*/
INSERT INTO Chamados (Titulo, Descricao, Status, Prioridade, fk_idCliente, fk_idFuncionario, fk_idJornada, fk_idModulo)
VALUES
	('Instabilidade na internet', 'Estou a um tempao tentando trabalhar, mas a internet não está colaborando', 'Aberto', 'Baixa', 3, 1, 3, 3),
	('Problema com Monitor', 'Meu monitor está falhando, acredito que seja problema no cabo HDMI!', 'Aberto', 'Baixa', 3, 4, 2, 1);

/*jornada*/
INSERT INTO Jornada (jornada)
VALUES 
	('Marketing'),
	('Financeiro'),
	('Recursos Humanos');

/*módulo*/
INSERT INTO Modulo (modulo)
VALUES 
	('Hardware'),
	('Software'),
	('Rede');

/*conversas*/
INSERT INTO Conversa (Mensagem, fk_idRemetente, fk_idChamado)
VALUES 
	('Nós sabemos', 4, 2),
	('Sou um cliente chato!!', 3, 2),
	('Bom dia, minha internet ainda está muito ruim!', 3, 1),
	('Olá bom dia, como está a situação da internet?', 1, 1),
	('Deu certo?', 1, 1),
	('Minha internet ainda não voltou!', 3, 1), 
	('Caso ainda não tenha voltado, desative a internet do seu dispositivo e ligue novamente', 1, 1);

/*Consultas*/

SELECT * FROM Usuarios;
SELECT * FROM Chamados;
SELECT * FROM Jornada;
SELECT * FROM Modulo;
SELECT * FROM Conversa;

/*Consulta usuário*/
/*COnsulta usuário pelo E-mail e pela Senha*/
SELECT id_Usuario,
	   Nome,
	   Email,
	   Senha,
	   tipo_Usuario
FROM Usuarios WHERE Email == @RecebeEmail AND Senha == @RecebeSenha;

/*Consultas Chamados*/
SELECT Titulo,
		Descricao,
		Status,
		Prioridade
FROM Chamados
WHERE fk_idCliente = @idUsuario;

/*Consulta conversa enviada pelo usuário 3 no chamado 2*/
SELECT u.Nome,
		c.Mensagem,	
		c.fk_idRemetente,
		c.Data_Hora
FROM Conversa c
JOIN
	Usuarios u ON c.fk_idRemetente = u.id_Usuario
WHERE 
	c.fk_idRemetente = 3 AND c.fk_idChamado = 2
ORDER BY c.Data_hora;

SELECT Mensagem,
		fk_idRemetente,
		fk_idChamado
FROM Conversa c
JOIN 
	Usuarios u ON c.fk_idRemetente = u.id_Usuario
WHERE 
	u.tipo_Usuario = 'Cliente';
	
/*Consulta nome do atendente e título do chamado que lhe foi atribuído*/
SELECT
    u.Nome,
    c.Titulo
FROM
    Chamados c
JOIN
    Usuarios u ON c.fk_idFuncionario = u.id_Usuario
WHERE
    u.tipo_Usuario = 'Funcionário';

/*Seleciona nomes e chamados dos clientes*/
SELECT 
	u.Nome,
	c.Titulo,
	c.Descricao,
	c.Status
FROM 
	Usuarios u
LEFT JOIN
	Chamados c ON u.id_Usuario = c.fk_idCliente
WHERE
	u.tipo_Usuario = 'Cliente';

/*Consulta o nome e a mensagem do solicitante (testar com mias solcitantes e com mais usuários)*/
SELECT 
	u.Nome, 
	c.Mensagem
FROM
	Usuarios u 
JOIN 
	Conversa c ON c.fk_idRemetente = u.id_Usuario
WHERE 
	u.tipo_Usuario = 'Cliente';