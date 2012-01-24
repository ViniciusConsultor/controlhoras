/* Version 0.4.4.12
CREATE TABLE `logevento` (  `Id` bigint(20) NOT NULL AUTO_INCREMENT,  `Fecha` datetime NOT NULL,  `Username` varchar(30) NOT NULL,  `Evento` varchar(100) DEFAULT NULL,  `Descripcion` varchar(1000) NOT NULL,  `PCHostname` varchar(50) NOT NULL,  PRIMARY KEY (`Id`))
*/
/* Version 0.4.4.15 */
CREATE TABLE `listanegraservicio` (  `NumeroCliente` mediumint(8) unsigned NOT NULL,  `NumeroServicio` mediumint(8) unsigned NOT NULL,  `NroEmpleado` mediumint(8) unsigned NOT NULL,  PRIMARY KEY (`NumeroCliente`,`NumeroServicio`,`NroEmpleado`));
alter table listanegraservicio add foreign key (NumeroCliente,NumeroServicio) references servicios(NumeroCliente, NumeroServicio);
alter table listanegraservicio add foreign key (NroEmpleado) references empleados(NroEmpleado);
