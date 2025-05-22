/* Criação das tabelas */
/*Tabela usuários*/
CREATE TABLE Usuarios (
	id_Usuario SERIAL PRIMARY KEY,
	Nome VARCHAR(100) NOT NULL,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(100) NOT NULL,
	tipo_Usuario VARCHAR(15) NOT NULL,
	CONSTRAINT tipo_usuario_check CHECK (
		tipo_usuario IN ('Funcionário', 'Cliente')
	)	
);

/*Tabela chamados*/
CREATE TABLE Chamados (
	id_Chamado SERIAL PRIMARY KEY,
	Titulo VARCHAR(100) NOT NULL,
	Descricao TEXT NOT NULL,
	Status VARCHAR(15) NOT NULL,
	Prioridade VARCHAR(5) NOT NULL,
	CONSTRAINT prioridade_chamado_check CHECK (
		Prioridade IN ('Baixa', 'Média', 'Alta')
	),
	CONSTRAINT status_chamado_check CHECK (
		Status IN ('Aberto', 'Em andamento', 'Pendente', 'Resolvido')
	),
	fk_idCliente INT NOT NULL,
	fk_idFuncionario INT NOT NULL,
	fk_idJornada INT NOT NULL,
	fk_idModulo INT NOT NULL,
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
		jornada IN ('Financeiro', 'Marketing', 'Recursos Humanos') 
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
	Mensagem TEXT,
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
	('Suporte Tech', 'techsolution@gmail.com', 'techs', 'Funcionário'),
	('Admin', 'adminlardossonhos@gmail.com', 'adminlar', 'Funcionário'),
	('Danilo Alves', 'danalves@gmail.com.br', 'dan163', 'Funcionário'),
	('Michael Valle', 'vallemichael@gmail.com', 'vallem908', 'Cliente'),
	('Leonardo Souza', 'leosouza@gmail.com', 'leopigarro', 'Funcionário'),
	('Aroldo Carlos', 'caroldo@gmail.com', '99008760', 'Cliente'),	
	('Jonas Cruz', 'jcruz@gmail.com', 'cruz321', 'Funcionário');
	

/*chamados*/
INSERT INTO Chamados (Titulo, Descricao, Status, Prioridade, fk_idCliente, fk_idFuncionario, fk_idJornada, fk_idModulo)
VALUES
	('Instabilidade na internet', 'Estou a um tempao tentando trabalhar, mas a internet não está colaborando', 'Aberto', 'Baixa', 7, 1, 3, 3),
	('Problema com Monitor', 'Meu monitor está falhando, acredito que seja problema no cabo HDMI!', 'Aberto', 'Baixa', 5, 1, 2, 1);

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

/*Consultas*/
SELECT * FROM Usuarios;
SELECT * FROM Chamados;
SELECT * FROM Jornada;
SELECT * FROM Modulo;
SELECT * FROM Conversa;

DROP TABLE Usuarios;
DROP TABLE Chamados;
DROP TABLE Jornada;
DROP TABLE Modulo;
DROP TABLE Conversa;
