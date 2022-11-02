create database CasoCerrado
go


use CasoCerrado
go


create table detectives

(
identificacion varchar (50) primary key not null,
nombres varchar (50) not null,
apellidos varchar (50) not null,
experiencia int not null,
tipocaso varchar (50) not null,
);
go

create proc listardetectives
as
select * from detectives order by identificacion
go


create proc buscardetective
@nombres varchar(50)
as
select identificacion,nombres,apellidos,experiencia,tipocaso from detectives where nombres like @nombres +'%'
go


create proc mantenimientodetectives

@identificacion varchar(50),
@nombres varchar(50),
@apellidos varchar(50),
@experiencia int,
@tipocaso varchar(50),
@accion varchar(50)output
as

if(@accion='1')
begin
insert into detectives(identificacion,nombres,apellidos,experiencia,tipocaso)
values(@identificacion,@nombres,@apellidos,@experiencia,@tipocaso)
set @accion ='se agregó el detective: ' +@identificacion
end

 else if(@accion='2')
begin 
update detectives set  identificacion=@identificacion,nombres=@nombres, apellidos=@apellidos,experiencia=@experiencia,tipocaso=@tipocaso where identificacion=@identificacion
end

else if(@accion='3')
begin
delete from detectives where identificacion=@identificacion
set @accion ='se eliminó el detective: ' +@identificacion
end
go






create table sospechosos

(

identificacion varchar (50)primary key not null,
nombres varchar (50)not null,
apellidos varchar (50)not null,
alias varchar (50)not null,
edad int not null,
noVivienda int not null,
localidad varchar (50) not null,
ciudad varchar (50) not null,
departamento varchar (50) not null,
pais varchar (50) not null,
descripcion varchar (50) not null,

);
go

create proc listarsospechosos
as
select * from sospechosos order by identificacion
go


create proc buscarsospechoso
@nombres varchar(50)
as
select identificacion,nombres,apellidos,alias,edad,noVivienda,localidad,ciudad,departamento,pais,descripcion from sospechosos where nombres like @nombres +'%'
go





create proc mantenimientosospechosos

@identificacion varchar(50),
@nombres varchar(50),
@apellidos varchar(50),
@alias varchar(50),
@edad int,
@noVivienda int,
@localidad varchar(50),
@ciudad varchar(50),
@departamento varchar(50),
@pais varchar(50),
@descripcion varchar(50),



@accion varchar(50)output
as

if(@accion='1')
begin
insert into sospechosos(identificacion,nombres,apellidos,alias,edad,noVivienda,localidad,ciudad,departamento,pais,descripcion)
values(@identificacion,@nombres,@apellidos,@alias,@edad,@noVivienda,@localidad,@ciudad,@departamento,@pais,@descripcion)
set @accion ='Se agregó el sospechoso: ' +@identificacion
end

 else if(@accion='2')
begin 
update sospechosos set  identificacion=@identificacion,nombres=@nombres, apellidos=@apellidos,alias=@alias,edad=@edad,noVivienda=@noVivienda,localidad=@localidad,ciudad=@ciudad,departamento=@departamento,pais=@pais,descripcion=@descripcion where identificacion=@identificacion
end

else if(@accion='3')
begin
delete from sospechosos where identificacion=@identificacion
set @accion ='Se eliminó el sospechoso: ' +@identificacion
end
go



