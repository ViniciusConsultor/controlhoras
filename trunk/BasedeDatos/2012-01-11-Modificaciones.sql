CREATE TABLE `logevento` (  `Id` bigint(20) NOT NULL AUTO_INCREMENT,  `Fecha` datetime NOT NULL,  `Username` varchar(30) NOT NULL,  `Evento` varchar(100) DEFAULT NULL,  `Descripcion` varchar(1000) NOT NULL,  `PCHostname` varchar(50) NOT NULL,  PRIMARY KEY (`Id`))
