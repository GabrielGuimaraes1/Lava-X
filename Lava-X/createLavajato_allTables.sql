CREATE TABLE pessoa (
	pessoa_id int NOT NULL,
	nome varchar(20) NOT NULL,
	sobrenome varchar(50) NOT NULL,
	cpf_cnpj varchar(11) NOT NULL,
	rua varchar(50),
	numero int,
	telefone varchar(11) NOT NULL,
	dataCadastro datetime NOT NULL,
	tipo varchar NOT NULL,
	PRIMARY KEY (pessoa_id)
)

CREATE TABLE servico (
	servico_id int NOT NULL,
	nome varchar NOT NULL,
	preço float NOT NULL,
	PRIMARY KEY (servico_id)
)

CREATE TABLE veiculo (
	veiculo_id int NOT NULL,
	placa varchar(7) NOT NULL UNIQUE,
	marca varchar(20) NOT NULL,
	modelo varchar(20) NOT NULL,
	cor varchar(20) NOT NULL,
	cliente_id int UNIQUE,
	PRIMARY KEY (veiculo_id),
	FOREIGN KEY (cliente_id) REFERENCES pessoa(pessoa_id)
)

CREATE TABLE funcionario (
	funcionario_id int NOT NULL,
	pessoa_id int NOT NULL,
	PRIMARY KEY (funcionario_id),
	FOREIGN KEY (pessoa_id) REFERENCES pessoa(pessoa_id)
)

CREATE TABLE ordem_de_servico (
	os_id int NOT NULL,
	num_os int NOT NULL,
	data_ini datetime NOT NULL,
	data_fim datetime NOT NULL,
	status varchar NOT NULL,
	veiculo_id int NOT NULL,
	cliente_id int NOT NULL,
	funcionario_id int NOT NULL,
	servico_id int NOT NULL,
	PRIMARY KEY (os_id),
	FOREIGN KEY (veiculo_id) REFERENCES veiculo(veiculo_id),
	FOREIGN KEY (cliente_id) REFERENCES pessoa(pessoa_id),
	FOREIGN KEY (funcionario_id) REFERENCES funcionario(funcionario_id),
	FOREIGN KEY (os_id) REFERENCES ordem_de_servico(os_id),
	FOREIGN KEY (servico_id) REFERENCES servico(servico_id)
)

CREATE TABLE osXservico (
	os_id int NOT NULL,
	servico_id int NOT NULL,
	PRIMARY KEY (os_id)
)

CREATE TABLE cliente (
	cliente_id int NOT NULL,
	pessoa_id int NOT NULL,
	PRIMARY KEY (cliente_id),
	FOREIGN KEY (pessoa_id) REFERENCES pessoa(pessoa_id)
)


