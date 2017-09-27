
use Presupuesto

create table Presupuesto (

IdPresupuesto int primary key not null,
Fecha datetime not null,
Descripcion varchar(50) not null,
Monto float not null
)


Insert into Presupuesto (IdPresupuesto,Fecha,Descripcion,Monto)
values('1','27/9/17','Gastos','500')

Select * from Presupuesto