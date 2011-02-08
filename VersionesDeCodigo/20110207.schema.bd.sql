-- MySQL dump 10.13  Distrib 5.1.41, for Win32 (ia32)
--
-- Host: localhost    Database: trustdb
-- ------------------------------------------------------
-- Server version	5.1.41-community

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bancos`
--

DROP TABLE IF EXISTS `bancos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bancos` (
  `IdBanco` tinyint(2) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdBanco`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `barrios`
--

DROP TABLE IF EXISTS `barrios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `barrios` (
  `IdBarrio` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdBarrio`)
) ENGINE=InnoDB AUTO_INCREMENT=167 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ciudades`
--

DROP TABLE IF EXISTS `ciudades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ciudades` (
  `IdCiudades` tinyint(2) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdCiudades`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `NumeroCliente` mediumint(8) unsigned NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `NombreFantasia` varchar(100) DEFAULT NULL,
  `RUT` char(15) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `DireccionDeCobro` varchar(100) DEFAULT NULL,
  `Referencia` varchar(100) DEFAULT NULL,
  `Telefonos` varchar(50) DEFAULT NULL,
  `Fax` varchar(50) DEFAULT NULL,
  `FechaAlta` date DEFAULT NULL,
  `FechaBaja` date DEFAULT NULL,
  `MotivoBaja` varchar(255) DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  `NombrePersonaCobro` varchar(100) DEFAULT NULL,
  `DiaHoraCobro` varchar(150) DEFAULT NULL,
  `ContactoCobro` varchar(100) DEFAULT NULL,
  `TelefonosCobro` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`NumeroCliente`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `consultasclientes`
--

DROP TABLE IF EXISTS `consultasclientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consultasclientes` (
  `idConsultaCliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Descripcion` varchar(255) DEFAULT NULL,
  `Query` varchar(1500) NOT NULL,
  `Activo` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idConsultaCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `consultasempleados`
--

DROP TABLE IF EXISTS `consultasempleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consultasempleados` (
  `idConsultaEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Descripcion` varchar(500) DEFAULT NULL,
  `Query` varchar(1000) DEFAULT NULL,
  `Activo` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idConsultaEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `contratos`
--

DROP TABLE IF EXISTS `contratos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contratos` (
  `idContratos` mediumint(8) unsigned NOT NULL,
  `FechaIni` date DEFAULT NULL,
  `FechaFin` date DEFAULT NULL,
  `Ajuste` varchar(255) DEFAULT NULL,
  `Observaciones` varchar(255) DEFAULT NULL,
  `CostoFijo` tinyint(1) NOT NULL,
  `Costo` float DEFAULT NULL,
  `TipodeContrato` int(11) NOT NULL,
  `HorasExtras` tinyint(1) NOT NULL,
  `TotHorasNormales` mediumint(9) DEFAULT NULL,
  `TotHorasExtras` mediumint(9) DEFAULT NULL,
  `TotVigilantes` mediumint(9) DEFAULT NULL,
  `Puntual` tinyint(1) DEFAULT NULL,
  `PlanillaTrust` tinyint(1) DEFAULT NULL,
  `DescPerfil` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idContratos`),
  KEY `Id` (`TipodeContrato`),
  CONSTRAINT `Id` FOREIGN KEY (`TipodeContrato`) REFERENCES `tipocontratos` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cuotasextrasliquidacion`
--

DROP TABLE IF EXISTS `cuotasextrasliquidacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuotasextrasliquidacion` (
  `IdExtraLiquidacion` int(10) unsigned NOT NULL,
  `NumeroCuota` tinyint(2) NOT NULL DEFAULT '1',
  `ValorCuota` float NOT NULL,
  `Liquidado` tinyint(1) NOT NULL DEFAULT '0',
  `Fecha` date NOT NULL,
  PRIMARY KEY (`IdExtraLiquidacion`,`NumeroCuota`),
  CONSTRAINT `cuotasextrasliquidacion_ibfk_1` FOREIGN KEY (`IdExtraLiquidacion`) REFERENCES `extrasliquidacion` (`IdExtraLiquidacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamentos` (
  `IdDepartamento` tinyint(2) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdDepartamento`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `emergenciasmedica`
--

DROP TABLE IF EXISTS `emergenciasmedica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `emergenciasmedica` (
  `IdEmergenciaMedica` tinyint(2) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdEmergenciaMedica`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleados` (
  `NroEmpleado` mediumint(8) unsigned NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `sexo` char(1) DEFAULT NULL,
  `IdCargo` smallint(6) NOT NULL DEFAULT '0',
  `IdTipoDocumento` tinyint(4) NOT NULL,
  `NumeroDocumento` varchar(30) NOT NULL,
  `IdDepartamento` tinyint(2) DEFAULT NULL,
  `IdCiudad` tinyint(2) DEFAULT NULL,
  `IdBarrio` tinyint(2) DEFAULT NULL,
  `Ciudad` varchar(50) DEFAULT NULL,
  `Barrio` varchar(30) DEFAULT '0',
  `Direccion` varchar(50) DEFAULT NULL,
  `EntreCalles` varchar(100) DEFAULT NULL,
  `CodigoPostal` varchar(10) DEFAULT NULL,
  `DireccionDeEncuentro` varchar(100) DEFAULT NULL,
  `Telefonos` varchar(50) DEFAULT NULL,
  `Celular` varchar(50) DEFAULT NULL,
  `CelularenConvenio` varchar(50) DEFAULT NULL,
  `FechaEntregaCelular` date DEFAULT NULL,
  `EstadoCivil` varchar(11) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Foto` blob,
  `Edad` tinyint(2) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `LugarDeNacimiento` varchar(50) DEFAULT NULL,
  `FechaIngreso` date DEFAULT NULL,
  `FechaVencimientoCarneDeSalud` date DEFAULT NULL,
  `IdMutualista` tinyint(2) unsigned DEFAULT NULL,
  `IdEmergenciaMedica` tinyint(2) unsigned DEFAULT NULL,
  `CantidadMenoresACargo` tinyint(2) DEFAULT NULL,
  `TalleCamisa` varchar(4) DEFAULT NULL,
  `TallePantalon` varchar(4) DEFAULT NULL,
  `TalleZapatos` tinyint(2) DEFAULT NULL,
  `TalleCampera` varchar(4) DEFAULT NULL,
  `FechaBaja` date DEFAULT '0002-01-01',
  `MotivoBaja` varchar(100) DEFAULT NULL,
  `CapacitadoPortarArma` tinyint(1) DEFAULT '0',
  `EnServicioArmado` tinyint(1) DEFAULT '0',
  `Antecedentes` tinyint(1) DEFAULT '0',
  `ObservacionesAntecedentes` varchar(255) DEFAULT NULL,
  `ValorHora` float(8,2) DEFAULT NULL,
  `Turno` varchar(10) DEFAULT NULL,
  `ServicioActual` varchar(100) DEFAULT NULL,
  `Observaciones` varchar(255) DEFAULT NULL,
  `CAJ_Numero` varchar(20) DEFAULT NULL,
  `CAJ_FechaEmision` date DEFAULT NULL,
  `CAJ_FechaEntrega` date DEFAULT NULL,
  `BPS_FechaAlta` date DEFAULT NULL,
  `BPS_FechaBaja` date DEFAULT NULL,
  `BPS_AcumulacionLaboral` tinyint(2) unsigned DEFAULT NULL,
  `BPSEsBaja` tinyint(1) NOT NULL DEFAULT '0',
  `FechaTestPsicologico` date DEFAULT NULL,
  `ConstanciaDomicilio` tinyint(1) DEFAULT '0',
  `PolicialesoMilitar` tinyint(1) DEFAULT '0',
  `FechaIngresoPolicialoMilitar` date DEFAULT NULL,
  `FechaEgresoPolicialoMilitar` date DEFAULT NULL,
  `SubEscalafonPolicial` varchar(30) DEFAULT NULL,
  `CombatienteMilitar` tinyint(1) DEFAULT '0',
  `RENAEMSE_FechaIngreso` date DEFAULT NULL,
  `RENAEMSE_NumeroAsunto` varchar(20) DEFAULT NULL,
  `AntecedentesPolicialesOMilitares` tinyint(1) NOT NULL DEFAULT '0',
  `NoHabilitadoParaServicio` tinyint(1) NOT NULL DEFAULT '0',
  `Activo` tinyint(1) NOT NULL DEFAULT '0',
  `NivelEducativo` varchar(10) NOT NULL,
  `FechaPrevistaPago` date DEFAULT NULL,
  `FechaPagoEfectuado` date DEFAULT NULL,
  PRIMARY KEY (`NroEmpleado`),
  UNIQUE KEY `IdTipoDocumento` (`IdTipoDocumento`,`NumeroDocumento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `enteros`
--

DROP TABLE IF EXISTS `enteros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enteros` (
  `entero` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `escalafon`
--

DROP TABLE IF EXISTS `escalafon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `escalafon` (
  `IdEscalafon` int(11) unsigned NOT NULL,
  `IdContrato` mediumint(8) unsigned NOT NULL,
  `NumeroServicio` mediumint(8) unsigned NOT NULL,
  `NumeroCliente` mediumint(8) unsigned NOT NULL,
  `Cubierto` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdEscalafon`),
  UNIQUE KEY `IdContrato_UNIQUE` (`IdContrato`),
  KEY `ix_idEscalafon` (`IdEscalafon`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `escalafonempleado`
--

DROP TABLE IF EXISTS `escalafonempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `escalafonempleado` (
  `IdEscalafon` int(11) unsigned NOT NULL,
  `IdEscalafonEmpleado` int(11) unsigned NOT NULL,
  `CodigoPuesto` varchar(20) DEFAULT NULL,
  `HsLlamadaAntesHoraInicio` tinyint(2) NOT NULL DEFAULT '2',
  `ACargoDe` varchar(10) NOT NULL,
  `NroEmpleado` mediumint(8) unsigned NOT NULL,
  PRIMARY KEY (`IdEscalafon`,`IdEscalafonEmpleado`),
  KEY `FK_LineasEscalafon` (`IdEscalafon`),
  CONSTRAINT `escalafonempleado_ibfk_1` FOREIGN KEY (`IdEscalafon`) REFERENCES `escalafon` (`IdEscalafon`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `eventoshistorialempleado`
--

DROP TABLE IF EXISTS `eventoshistorialempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `eventoshistorialempleado` (
  `IdEventoHistorialEmpleado` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `IdEmpleado` mediumint(8) unsigned NOT NULL,
  `FechaInicio` date NOT NULL,
  `FechaFin` date NOT NULL,
  `IdTipoEvento` int(11) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `borrado` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdEventoHistorialEmpleado`),
  KEY `IX_IdEmpleadoFechaInicioFechaFin` (`IdEmpleado`,`FechaInicio`,`FechaFin`),
  CONSTRAINT `eventoshistorialempleado_ibfk_1` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`NroEmpleado`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `extrasliquidacion`
--

DROP TABLE IF EXISTS `extrasliquidacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `extrasliquidacion` (
  `IdExtraLiquidacion` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IdEmpleado` mediumint(8) unsigned NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Signo` mediumint(9) NOT NULL DEFAULT '1',
  `CuotaActual` tinyint(2) NOT NULL DEFAULT '1',
  `CantidadCuotas` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`IdExtraLiquidacion`),
  KEY `FK_Empleado` (`IdEmpleado`),
  CONSTRAINT `extrasliquidacion_ibfk_1` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`NroEmpleado`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `grupos`
--

DROP TABLE IF EXISTS `grupos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grupos` (
  `idGrupo` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  `Activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`idGrupo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `horariodia`
--

DROP TABLE IF EXISTS `horariodia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horariodia` (
  `IdContrato` mediumint(8) unsigned NOT NULL,
  `NroLinea` tinyint(2) NOT NULL,
  `Dia` varchar(10) NOT NULL,
  `HoraIni` varchar(10) NOT NULL,
  `HoraFin` varchar(10) NOT NULL,
  PRIMARY KEY (`IdContrato`,`NroLinea`,`Dia`),
  KEY `LineasHoras_HD` (`NroLinea`),
  KEY `Contrato_HD` (`IdContrato`),
  CONSTRAINT `FK_IdContratoNroLinea` FOREIGN KEY (`IdContrato`, `NroLinea`) REFERENCES `lineashoras` (`IdContrato`, `NroLinea`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `horarioescalafon`
--

DROP TABLE IF EXISTS `horarioescalafon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horarioescalafon` (
  `idEscalafon` int(11) unsigned NOT NULL,
  `idEscalafonEmpleado` int(11) unsigned NOT NULL,
  `dia` varchar(10) NOT NULL,
  `horaini` varchar(10) DEFAULT NULL,
  `horafin` varchar(10) DEFAULT NULL,
  `tipoDia` tinyint(2) unsigned DEFAULT NULL,
  `Solapa` tinyint(1) NOT NULL DEFAULT '0',
  `NroEmpleado` mediumint(8) unsigned NOT NULL,
  PRIMARY KEY (`idEscalafon`,`idEscalafonEmpleado`,`dia`),
  KEY `FK_horasEscalEmpleados` (`idEscalafon`,`idEscalafonEmpleado`),
  KEY `tipoDia` (`tipoDia`),
  KEY `FK_Empleado` (`NroEmpleado`),
  CONSTRAINT `horarioescalafon_ibfk_2` FOREIGN KEY (`NroEmpleado`) REFERENCES `empleados` (`NroEmpleado`) ON UPDATE CASCADE,
  CONSTRAINT `FK_horasEscalEmpleados` FOREIGN KEY (`idEscalafon`, `idEscalafonEmpleado`) REFERENCES `escalafonempleado` (`IdEscalafon`, `IdEscalafonEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `horarioescalafon_ibfk_1` FOREIGN KEY (`tipoDia`) REFERENCES `tiposdias` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `horasgeneradasescalafon`
--

DROP TABLE IF EXISTS `horasgeneradasescalafon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horasgeneradasescalafon` (
  `IdHorasGeneradasEscalafon` bigint(20) NOT NULL AUTO_INCREMENT,
  `NumeroCliente` mediumint(8) unsigned NOT NULL,
  `NumeroServicio` mediumint(8) unsigned NOT NULL,
  `NroEmpleado` mediumint(8) unsigned NOT NULL,
  `FechaCorrespondiente` date NOT NULL,
  `HoraEntrada` datetime NOT NULL,
  `HoraSalida` datetime NOT NULL,
  PRIMARY KEY (`IdHorasGeneradasEscalafon`),
  KEY `ix_NroEmpleado` (`NroEmpleado`) USING HASH,
  KEY `ix_CliServ` (`NumeroCliente`,`NumeroServicio`),
  CONSTRAINT `horasgeneradasescalafon_ibfk_2` FOREIGN KEY (`NumeroCliente`, `NumeroServicio`) REFERENCES `servicios` (`NumeroCliente`, `NumeroServicio`)
) ENGINE=InnoDB AUTO_INCREMENT=3105 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `lineashoras`
--

DROP TABLE IF EXISTS `lineashoras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lineashoras` (
  `IdContrato` mediumint(8) unsigned NOT NULL,
  `NroLinea` tinyint(2) NOT NULL,
  `Puesto` varchar(50) DEFAULT NULL,
  `Armado` tinyint(1) NOT NULL,
  `Cantidad` tinyint(3) NOT NULL,
  `CantHsNormales` tinyint(3) DEFAULT NULL,
  `CantHsExtras` tinyint(3) DEFAULT NULL,
  `PrecioXHora` float DEFAULT NULL,
  PRIMARY KEY (`NroLinea`,`IdContrato`),
  KEY `FK_Contratos` (`IdContrato`),
  CONSTRAINT `FK_Contratos` FOREIGN KEY (`IdContrato`) REFERENCES `contratos` (`idContratos`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `listanegra`
--

DROP TABLE IF EXISTS `listanegra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `listanegra` (
  `CI` varchar(30) NOT NULL,
  `Apellidos` varchar(50) DEFAULT NULL,
  `Nombres` varchar(50) DEFAULT NULL,
  `MotivoRechazo` varchar(100) NOT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  `FechaAlta` date DEFAULT NULL,
  `FechaBaja` date DEFAULT NULL,
  PRIMARY KEY (`CI`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `motivoscambiosdiarios`
--

DROP TABLE IF EXISTS `motivoscambiosdiarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `motivoscambiosdiarios` (
  `IdMotivoCambioDiario` int(11) NOT NULL AUTO_INCREMENT,
  `IdTipoMotivo` mediumint(8) unsigned NOT NULL,
  `FechaCambio` datetime NOT NULL,
  `Observaciones` varchar(1000) DEFAULT NULL,
  `NumeroCliente` mediumint(8) unsigned NOT NULL,
  `NumeroServicio` mediumint(8) unsigned NOT NULL,
  `NroEmpleado` mediumint(8) unsigned NOT NULL,
  `FechaCorresponde` date NOT NULL,
  PRIMARY KEY (`IdMotivoCambioDiario`),
  KEY `IdTipoMotivo` (`IdTipoMotivo`),
  KEY `NumeroCliente` (`NumeroCliente`,`NumeroServicio`),
  KEY `NroEmpleado` (`NroEmpleado`),
  CONSTRAINT `motivoscambiosdiarios_ibfk_4` FOREIGN KEY (`NroEmpleado`) REFERENCES `empleados` (`NroEmpleado`) ON UPDATE CASCADE,
  CONSTRAINT `motivoscambiosdiarios_ibfk_1` FOREIGN KEY (`IdTipoMotivo`) REFERENCES `tiposmotivocambiodiario` (`IdTipoMotivo`),
  CONSTRAINT `motivoscambiosdiarios_ibfk_2` FOREIGN KEY (`NumeroCliente`, `NumeroServicio`) REFERENCES `servicios` (`NumeroCliente`, `NumeroServicio`),
  CONSTRAINT `motivoscambiosdiarios_ibfk_3` FOREIGN KEY (`NroEmpleado`) REFERENCES `empleados` (`NroEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `mutualistas`
--

DROP TABLE IF EXISTS `mutualistas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mutualistas` (
  `IdMutualista` tinyint(2) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdMutualista`)
) ENGINE=InnoDB AUTO_INCREMENT=92 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pantallawinform`
--

DROP TABLE IF EXISTS `pantallawinform`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pantallawinform` (
  `idPantallaWinForm` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  `Activo` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idPantallaWinForm`),
  UNIQUE KEY `Nombre_UNIQUE` (`Nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `permisocontrol`
--

DROP TABLE IF EXISTS `permisocontrol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permisocontrol` (
  `idPermisoControl` int(11) NOT NULL AUTO_INCREMENT,
  `NETType` varchar(100) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `idPantallaWinForm` int(11) NOT NULL,
  PRIMARY KEY (`idPermisoControl`),
  KEY `IX_idPantallaWinForm_NETType_Nombre` (`idPantallaWinForm`,`NETType`,`Nombre`),
  CONSTRAINT `FK_idPantallaWinForm` FOREIGN KEY (`idPantallaWinForm`) REFERENCES `pantallawinform` (`idPantallaWinForm`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permisos` (
  `idPermiso` int(11) NOT NULL,
  `Usuario_OR_Grupo` char(1) NOT NULL DEFAULT 'G',
  `idControl` int(11) NOT NULL,
  `WinForm_OR_Control` char(1) NOT NULL DEFAULT 'W',
  `Activo` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idPermiso`,`idControl`,`Usuario_OR_Grupo`,`WinForm_OR_Control`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `servicios`
--

DROP TABLE IF EXISTS `servicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicios` (
  `NumeroServicio` mediumint(8) unsigned NOT NULL,
  `NumeroCliente` mediumint(8) unsigned NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `Telefonos` varchar(50) DEFAULT NULL,
  `PersonaContacto` varchar(50) DEFAULT NULL,
  `NombreCobrar` varchar(50) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Celular` varchar(50) DEFAULT NULL,
  `TareasAsignadas` varchar(255) DEFAULT NULL,
  `CelularTrust` varchar(50) DEFAULT NULL,
  `FechaAlta` date DEFAULT NULL,
  `FechaBaja` date DEFAULT NULL,
  `MotivoBaja` varchar(255) DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  `EntreCalles` varchar(150) DEFAULT NULL,
  `Observaciones` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`NumeroServicio`,`NumeroCliente`),
  KEY `fk_NumeroCliente_Clientes_NumeroCliente` (`NumeroCliente`),
  CONSTRAINT `fk_NumeroCliente_Clientes_NumeroCliente` FOREIGN KEY (`NumeroCliente`) REFERENCES `clientes` (`NumeroCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tipocontratos`
--

DROP TABLE IF EXISTS `tipocontratos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipocontratos` (
  `Id` int(11) NOT NULL,
  `Descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Descripcion_UNIQUE` (`Descripcion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tipoempleado`
--

DROP TABLE IF EXISTS `tipoempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoempleado` (
  `IdTipoEmpleado` tinyint(4) NOT NULL AUTO_INCREMENT,
  `NombreTipo` varchar(50) NOT NULL,
  `Descripcion` varchar(255) DEFAULT NULL,
  `CantidadHsComunes` float NOT NULL,
  `Tipo` enum('MENSUAL','JORNALERO') NOT NULL DEFAULT 'JORNALERO',
  `Fulltime` tinyint(1) DEFAULT NULL,
  `CobraHsExtras` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IdTipoEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tiposcargos`
--

DROP TABLE IF EXISTS `tiposcargos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposcargos` (
  `IdCargo` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Descripcion` varchar(200) DEFAULT NULL,
  `CantidadHsComunes` tinyint(2) NOT NULL DEFAULT '8',
  `TipoFacturacion` varchar(10) NOT NULL DEFAULT 'JORNALERO',
  `Fulltime` tinyint(1) NOT NULL DEFAULT '0',
  `CobraHsExtras` tinyint(1) NOT NULL DEFAULT '1',
  `Activo` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdCargo`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tiposdias`
--

DROP TABLE IF EXISTS `tiposdias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposdias` (
  `id` tinyint(2) unsigned NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tiposdocumento`
--

DROP TABLE IF EXISTS `tiposdocumento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposdocumento` (
  `IdTipoDocumento` tinyint(1) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdTipoDocumento`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tiposeventohistorial`
--

DROP TABLE IF EXISTS `tiposeventohistorial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposeventohistorial` (
  `IdTipoEventoHistorial` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Activo` smallint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdTipoEventoHistorial`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tiposmotivocambiodiario`
--

DROP TABLE IF EXISTS `tiposmotivocambiodiario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposmotivocambiodiario` (
  `IdTipoMotivo` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(255) NOT NULL,
  `Activo` smallint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdTipoMotivo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Apellido` varchar(100) NOT NULL,
  `UserName` varchar(30) NOT NULL,
  `Password` char(32) NOT NULL,
  `FechaCreacion` date NOT NULL,
  `Activo` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `IX_U_UserName` (`UserName`),
  KEY `IX_UserName_Password` (`UserName`,`Password`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuariosgrupos`
--

DROP TABLE IF EXISTS `usuariosgrupos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuariosgrupos` (
  `idUsuario` int(11) NOT NULL,
  `idGrupo` int(11) NOT NULL,
  PRIMARY KEY (`idUsuario`,`idGrupo`),
  KEY `FK_Grupos` (`idGrupo`),
  CONSTRAINT `FK_Grupos` FOREIGN KEY (`idGrupo`) REFERENCES `grupos` (`idGrupo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Usuarios` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2011-02-08  1:46:30
