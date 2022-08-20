--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------DATABASE CREATION-------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 
CREATE DATABASE BUSTOYOU
Use	BUSTOYOU


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------- CHOFER ----------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE CHOFER
(
ID int primary key IDENTITY (0,1),
NOMBRE Nvarchar (30),
Apellido Nvarchar (50),
BirthFecha Nvarchar (15),
Cedula Nvarchar (15)
)

-------------------------------------------------------- View ----------------------------------------------------------------------------------------------------------


Create view vwDatosChofer
as
select
C.ID as Codigo,
C.NOMBRE as Nombre,
C.Apellido as Apellido,
C.BirthFecha as 'F. Nacimiento',
C.Cedula as Cedula

from CHOFER C

-------------------------------------------------------- Selects ----------------------------------------------------------------------------------------------------------

Select * from CHOFER
Select * From vwDatosChofer

-------------------------------------------------------- Store procedures ------------------------------------------------------------------------------------------------

CREATE Proc regChof 
@NOMBRE Nvarchar (30),
@Apellido Nvarchar (50),
@BirthFecha Nvarchar (15),
@Cedula Nvarchar (15)
As
insert into vwDatosChofer values
(@NOMBRE, @Apellido, @BirthFecha, @Cedula)
GO

Create Proc readChof 
@Buscar Nvarchar (30)
as
Select * From vwDatosChofer
Where Nombre Like @Buscar + '%'
Go

Create Proc updateChof
@ID int,
@NOMBRE Nvarchar (30),
@Apellido Nvarchar (50),
@BirthFecha Nvarchar (15),
@Cedula Nvarchar (15)
As
Update CHOFER set NOMBRE = @NOMBRE, Apellido = @Apellido, BirthFecha =  @BirthFecha, Cedula = @Cedula
Where ID = @ID

Create Proc deletChof
@ID int	
As 
Delete  CHOFER Where ID = @ID
Go

create proc TrunChof
as
Truncate table CHOFER

-------------------------------------------------------- Execution ----------------------------------------------------------------------------------------------------------

exec regChof 'Yan', 'Yan', '1975-3-2', '902902232'
exec readChof 'Oto'
exec updateChof 2, 'Gerardo', 'Livano', '1974-6-2', '9022'
exec deletChof 1

-------------------------------------------------------- Drops ----------------------------------------------------------------------------------------------------------

Drop table CHOFER

Drop view vwDatosChofer

Drop Proc regChof

Drop Proc readChof

Drop Proc updateChof

Drop Proc deletChof

Drop Proc TrunChof

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------- Autobus ---------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE Bus
(
PLACA Nvarchar (20) primary key,
MARCA Nvarchar (30),
MODELO Nvarchar (50),
COLOR Nvarchar (15),
YIAR Nvarchar (15)
)

-------------------------------------------------------- View ----------------------------------------------------------------------------------------------------------


Create view vwDatosBus
as
select
B.PLACA as Placa,
B.MARCA as Marca,
B.MODELO as  Modelo,
B.COLOR as Color,
B.YIAR as 'Año'

from Bus B

-------------------------------------------------------- Selects ----------------------------------------------------------------------------------------------------------

Select * From vwDatosBus

-------------------------------------------------------- Store procedures ------------------------------------------------------------------------------------------------

CREATE Proc regBus 
@PLACA Nvarchar (20),
@MARCA Nvarchar (30),
@MODELO Nvarchar (50),
@COLOR Nvarchar (15),
@YIAR varchar (15)
As
insert into Bus values
(@PLACA, @MARCA, @MODELO, @COLOR, @YIAR)
GO

Create Proc readBus
@Buscar Nvarchar (30)
as
Select * From vwDatosBus
Where Placa Like @Buscar + '%'
Go

Create Proc readBusM
@Buscar Nvarchar (30)
as
Select * From vwDatosBus
Where Marca Like @Buscar + '%'
Go

Create Proc updateBus
@PLACA Nvarchar (20),
@MARCA Nvarchar (30),
@MODELO Nvarchar (50),
@COLOR Nvarchar (15),
@YIAR Nvarchar (15)
As
Update Bus set MARCA  = @MARCA ,
			   MODELO = @MODELO,
			   COLOR  = @COLOR ,
			   YIAR   = @YIAR 
Where  PLACA = @Placa
Go

Create Proc deletBus
@Placa nvarchar	(20)
As 
Delete  Bus Where PLACA = @Placa
Go

-------------------------------------------------------- Execution ----------------------------------------------------------------------------------------------------------

exec regBus '392226', 'Hyundai', 'Sonata', 'Plateado', '2010'
exec readBus '392226'
exec readBusM 'Toyota'
exec updateBus 'A 392214', 'Toyota', 'Corolla', 'Negro', '2002'
exec deletBus '392226'

-------------------------------------------------------- Drops ----------------------------------------------------------------------------------------------------------

Drop table Bus

Drop view vwDatosBus
				 
Drop Proc regBus

Drop Proc readBus

Drop Proc updateBus

Drop Proc deletBus


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------- RUTAS -----------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE Ruta
(
ID int primary key IDENTITY (0,1),
RUTA Nvarchar (50),
Distance Nvarchar(10)	
)    

-------------------------------------------------------- View ----------------------------------------------------------------------------------------------------------


Create view vwDatosRuta
as
Select 
R.ID as ID,
R.RUTA as Ruta,
R.Distance as Distancia
from Ruta R

-------------------------------------------------------- Selects ----------------------------------------------------------------------------------------------------------

Select * From vwDatosRuta

-------------------------------------------------------- Store procedures ------------------------------------------------------------------------------------------------

CREATE Proc regRuta
@Ruta Nvarchar(50),
@Distance Nvarchar (10)
As
insert into Ruta values
(@Ruta, @Distance)
GO

Create Proc readRuta
@Buscar Nvarchar (30)
as
Select * From vwDatosRuta
Where Ruta Like @Buscar + '%'
Go

Create Proc updateRuta
@ID int,
@Ruta Nvarchar (50),
@Distance Nvarchar (10)
As
Update Ruta set RUTA = @Ruta, Distance = @Distance
Where  ID = @ID
Go

Create Proc deletRuta
@ID int
As 
Delete Ruta Where ID = @ID
Go

-------------------------------------------------------- Execution ----------------------------------------------------------------------------------------------------------

exec regRuta 'Villa Mella', '36 km'
exec readRuta'Los Minas'
exec updateRuta 1, 'Los Minas - Duarte', '20 km'
exec deletRuta 1

-------------------------------------------------------- Drops ----------------------------------------------------------------------------------------------------------

Drop table Ruta

Drop view vwDatosRuta
				 
Drop Proc regRuta

Drop Proc readRuta

Drop Proc updateRuta

Drop Proc deletRuta

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------- Asignaciones ----------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------


CREATE TABLE VIAJE
(
Id INT identity (1,1) PRIMARY KEY, 
ID_CHOFER INT NOT NULL,
ID_BUS NVARCHAR (20) NOT NULL,
ID_RUTA INT  NOT NULL
)

-------------------------------------------------------- View ----------------------------------------------------------------------------------------------------------


Create view vwDatosViajes
as
Select
v.ID as ID,
Chof.Nombre as 'Conductor',
v.ID_BUS as Bus,
rut.RUTA as 'Nombre Ruta'

from VIAJE V
inner join vwDatosChofer Chof on Chof.Codigo = V.ID_CHOFER
inner join vwDatosRuta rut on rut.ID = v.ID_RUTA
inner join Bus b on b.PLACA = V.ID_BUS


-------------------------------------------------------- SELECTS ----------------------------------------------------------------------------------------------------------

select * from VIAJE
select * from vwDatosViajes

-------------------------------------------------------- Store Procedure ---------------------------------------------------------------------------------------------------

CREATE Proc regviaje
@ID_CHOFER INT,
@ID_BUS NVARCHAR(20),
@ID_RUTA INT
As
insert into VIAJE values
(@ID_CHOFER, @ID_BUS, @ID_RUTA)
GO

Create Proc readVIAJES
@Buscar Nvarchar (30)
as
Select * From vwDatosViajes
Where Conductor Like @Buscar + '%'
Go

Create Proc updateVIAJE
@ID int,
@ID_CHOFER INT,
@ID_BUS NVARCHAR(20),
@ID_RUTA INT
As
Update VIAJE set ID_CHOFER = @ID_CHOFER, ID_BUS = @ID_BUS, ID_RUTA = @ID_RUTA
Where  ID = @ID
Go

Create Proc deletViaje
@ID int
As 
Delete VIAJE Where ID = @ID
Go

Create proc ShowChofer
AS
Select ID, NOMBRE From CHOFER
Go

Create proc ShowBus
AS
Select PLACA, MARCA, MODELO From Bus
Go

Create proc ShowRuta
AS
Select ID, Ruta From Ruta
Go
-------------------------------------------------------- Execution ----------------------------------------------------------------------------------------------------------

exec regviaje 2, 'A 392214', 2
exec readVIAJES 'Oto'
exec updateVIAJE 2, 2, 'A 392214', 1
exec deletViaje 3
exec ShowChofer
exec ShowBus
exec ShowRuta

-------------------------------------------------------- Drops ----------------------------------------------------------------------------------------------------------

Drop table VIAJE

Drop view vwDatosViajes
				 
Drop Proc regviaje

Drop Proc readVIAJES

Drop Proc updateVIAJE

Drop Proc deletViaje

-------------------------------------------------------- Universal select -------------------------------------------------------------------------------------------------
	select * FROM CHOFER
	select * from Bus
	select * from Ruta
