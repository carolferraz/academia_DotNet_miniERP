create database miniERP;

create table produtos
(
	id integer primary key identity,
	nome varchar(50) not null,
	preco decimal,
	estoque integer,
	fk_fornecedor integer,
	foreign key (fk_fornecedor) references fornecedores(id)
);

create table clientes
(
	id integer primary key identity,
    nome varchar(100)
);

create table fornecedores (
    id integer primary key identity,
    nome varchar(100)
);

create table notas
(
    id integer primary key identity,
    emissao datetime,
	fk_cliente integer,
	fk_pedido integer,
    foreign key (fk_cliente) references clientes(id),
	foreign key (fk_pedido) references pedido(id)
);

create table pedido
(
    id integer primary key identity,
	fk_cliente integer,
	fk_produto integer,
    quantidade integer,
	totalItem decimal,
	emissao datetime,
    foreign key (fk_produto) references produtos(id),
	foreign key (fk_cliente) references clientes(id),
);

create login minierp with password='123456';
create user minierp from login minierp;
exec sp_addrolemember 'DB_DATAREADER', 'minierp';
exec sp_addrolemember 'DB_DATAWRITER', 'minierp';

insert into clientes values ('João Pedro');
insert into clientes values ('Luciana');


insert into fornecedores values ('Bic');
insert into fornecedores values ('Post-it');
insert into fornecedores values ('Tilibra');
insert into fornecedores values ('Faber Castel');

insert into produtos (nome, preco, estoque, fk_fornecedor) values ('Caderno 200pg', 22.50, 20, 3);
insert into produtos (nome, preco, estoque, fk_fornecedor) values ('Caneta azul', 1.50, 100, 1);
insert into produtos (nome, preco, estoque, fk_fornecedor) values ('Lápis de cor 24 cores', 57.99, 10, 4);
insert into produtos (nome, preco, estoque, fk_fornecedor) values ('Rolo papel pardo', 68.00, 3, 2);



select * from clientes;
select * from fornecedores;
select * from produtos;
select * from pedido;
select * from notas;

drop table pedido;
drop table notas;