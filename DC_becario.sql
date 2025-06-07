
CREATE DATABASE DBecario_Hernandez
 go
 
USE Dbecario_Hernandez
go

 CREATE TABLE t_reclamos 
 (
	 idReclamo INT IDENTITY(1,1) PRIMARY KEY,
	 nombreProveedor VARCHAR(50) NOT NULL,
	 direccionProveedor VARCHAR(100) NOT NULL,
	 nombresConsumidor VARCHAR(50) NOT NULL,
	 apellidosConsumidor VARCHAR(50) NOT NULL,
	 DUI VARCHAR(10) NOT NULL,
	dettalleReclamo VARCHAR(250) NOT NULL,
	montoReclamado DECIMAL(18,2) NULL,
	telefono VARCHAR(10) NULL,
	fechaIngrese DATETIME NOT NULL
 )

INSERT INTO t_reclamos 
(nombreProveedor, direccionProveedor, nombresConsumidor, apellidosConsumidor, DUI, dettalleReclamo, montoReclamado, telefono, fechaIngrese)
VALUES 
('Proveedor A', 'Calle Principal #123', 'Carlos', 'Hernández', '01234567-8', 'Producto defectuoso al momento de la entrega', 30.50, '77778888', GETDATE()),
('Proveedor B', 'Av. Los Olivos #45', 'María', 'Gómez', '12345678-9', 'Servicio no prestado según contrato', 27.00, '75551234', GETDATE()),
('Proveedor C', 'Col. Jardines #89', 'José', 'Martínez', '98765432-1', 'Entrega incompleta de productos', 45.75, '70112233', GETDATE()),
('Proveedor D', 'Calle El Rosario #17', 'Ana', 'López', '10293847-6', 'Producto con empaque dañado', 18.00, '77223344', GETDATE()),
('Proveedor E', 'Pasaje Las Flores #10', 'David', 'Ruiz', '56473829-5', 'Demora en la entrega', 22.50, '78889900', GETDATE());
