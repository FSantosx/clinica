-- Criação da Base de dados
DECLARE @dbname nvarchar(128)
SET @dbname = N'Clinicadb'


IF EXISTS (SELECT * FROM master.dbo.sysdatabases WHERE NAME = @dbname)
	DROP DATABASE Clinicadb
	PRINT 'DB DROPED'
GO

CREATE DATABASE Clinicadb
GO

-- Criação dos Schemas

CREATE SCHEMA ADMINISTRADOR
	AUTHORIZATION dbo
go

CREATE SCHEMA FUNCIONARIO
	AUTHORIZATION dbo
go

CREATE SCHEMA CLIENTE
	AUTHORIZATION dbo
go

CREATE SCHEMA ATENDIMENTO
	AUTHORIZATION dbo
go

CREATE SCHEMA PRODUTO
	AUTHORIZATION dbo
go

-- Criação das tabelas

CREATE TABLE FUNCIONARIO.Enfermeiro (
	idEnf int IDENTITY(1,1) PRIMARY KEY,
	status varchar(20)
)

CREATE TABLE ATENDIMENTO.Exame (
	idExame int IDENTITY(001,1) PRIMARY KEY,
	dataExa datetime DEFAULT GETDATE(),
	dataRetorno datetime DEFAULT GETDATE()
)

CREATE TABLE ATENDIMENTO.Guia (
	idGuia INT IDENTITY (001,1) PRIMARY KEY,
	idExame int,
	motivoGuia VARCHAR(50) DEFAULT ('N/D'),
	especialista VARCHAR(50) DEFAULT ('Clínico Geral')
)

CREATE TABLE CLIENTE.Paciente(
	idPaciente INT IDENTITY (001,1) PRIMARY KEY,
	idFicha INT,
	nomePaciente VARCHAR(75),
	necessidade VARCHAR(100),
	convenio VARCHAR(50),
	situacao VARCHAR(50)
)

CREATE TABLE CLIENTE.Ficha(
	idFicha INT IDENTITY(001,1) PRIMARY KEY,
	telContato VARCHAR(20),
	telPessoal VARCHAR(20),
	dataNascimento DATE,
	cpfPac VARCHAR(15),
	rgPac VARCHAR(15),
	sexo VARCHAR(20),
	naturalidade VARCHAR(50),
	endereco VARCHAR(100),
	numero INT,
	estado varchar(50),
	cidade varchar(50),
	estadoCivil varchar(20),
	nomePai varchar(75),
	nomeMae varchar(75),
	bairro varchar(50),
	complemento varchar(90) DEFAULT('Não possui complemento'),
	email varchar(90),
	obs varchar(100) DEFAULT ('Nenhuma observação'),
	imagemPac varbinary(max)
)

CREATE TABLE FUNCIONARIO.Medico (
	idMed int IDENTITY (100, 1) PRIMARY KEY,
	idConsulta int,
	idExame int,
	especializacao varchar(50),
	horarioMed time,
	statusMed varchar(20),
	FOREIGN KEY(idExame) references FUNCIONARIO.Exame(idExame),
	FOREIGN KEY(idConsulta) references FUNCIONARIO.Consulta(idConsulta)
)

CREATE TABLE FUNCIONARIO.Funcionario (
	idFunc INT IDENTITY(100, 1) PRIMARY KEY,
	idMed int,
	idEnf int,
	nomeFun VARCHAR(75),
	rgFun varchar(15),
	cpfFun varchar(15),
	imgFun varbinary(20),
	statusFun varchar(20),
	FOREIGN KEY(idEnf) references FUNCIONARIO.Enfermeiro(idEnf),
	FOREIGN KEY(idMed) references FUNCIONARIO.Medico(idMed)
)

