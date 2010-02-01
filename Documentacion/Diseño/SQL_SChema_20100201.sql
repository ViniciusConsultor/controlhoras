-- MySQL dump 10.13  Distrib 5.1.41, for Win32 (ia32)
--
-- Host: localhost    Database: trustdb
-- ------------------------------------------------------
-- Server version	5.1.41-community-log

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

CREATE SCHEMA IF NOT EXISTS `trustdb` DEFAULT CHARACTER SET latin1 ;

use trustdb;

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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
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
  `Email` varchar(50) DEFAULT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `DireccionDeCobro` varchar(100) DEFAULT NULL,
  `Telefonos` varchar(50) DEFAULT NULL,
  `Fax` varchar(50) DEFAULT NULL,
  `FechaAlta` date DEFAULT NULL,
  `FechaBaja` date DEFAULT NULL,
  `MotivoBaja` varchar(255) DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`NumeroCliente`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;


-- -----------------------------------------------------
-- Table `trustdb`.`tipocontratos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`tipocontratos` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`tipocontratos` (
  `Id` INT(11) NOT NULL ,
  `Descripcion` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`Id`) ,
  UNIQUE INDEX `Descripcion_UNIQUE` (`Descripcion` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;





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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;


-- -----------------------------------------------------

-- Table `trustdb`.`contratos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`contratos` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`contratos` (
  `idContratos` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `FechaIni` DATE NULL DEFAULT NULL ,
  `FechaFin` DATE NULL DEFAULT NULL ,
  `Ajuste` VARCHAR(255) NULL DEFAULT NULL ,
  `Observaciones` VARCHAR(255) NULL DEFAULT NULL ,
  `Costo_Fijo?` TINYINT(1) NOT NULL ,
  `Costo` FLOAT NULL DEFAULT NULL ,
  `TipodeContrato` INT(11) NOT NULL ,
  `HorasExtras` TINYINT(1) NOT NULL ,
  `TotHorasNormales` MEDIUMINT(9) NULL DEFAULT NULL ,
  `TotHorasExtras` MEDIUMINT(9) NULL DEFAULT NULL ,
  `TotVigilantes` MEDIUMINT(9) NULL DEFAULT NULL ,
  `Puntual` TINYINT(1) NULL DEFAULT NULL ,
  `PlanillaTrust` TINYINT(1) NULL DEFAULT NULL ,
  `DescPerfil` VARCHAR(255) NULL DEFAULT NULL ,
  PRIMARY KEY (`idContratos`) ,
  INDEX `Id` (`TipodeContrato` ASC) ,
  CONSTRAINT `Id`
    FOREIGN KEY (`TipodeContrato` )
    REFERENCES `trustdb`.`tipocontratos` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleados` (
  `IdEmpleado` mediumint(8) unsigned NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `sexo` char(1) NOT NULL,
  `IdTipoDocumento` tinyint(4) NOT NULL,
  `NumeroDocumento` varchar(30) NOT NULL,
  `IdDepartamento` tinyint(2) NOT NULL DEFAULT '0',
  `Ciudad` varchar(50) DEFAULT NULL,
  `Barrio` varchar(30) DEFAULT '0',
  `Direccion` varchar(50) DEFAULT NULL,
  `EntreCalles` varchar(100) DEFAULT NULL,
  `DireccionDeEncuentro` varchar(100) DEFAULT NULL,
  `Telefonos` varchar(50) DEFAULT NULL,
  `Celular` varchar(50) DEFAULT NULL,
  `CelularenConvenio` varchar(50) DEFAULT NULL,
  `EstadoCivil` varchar(11) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Foto` blob,
  `Edad` tinyint(2) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `LugarDeNacimiento` varchar(50) DEFAULT NULL,
  `Nacionalidad` varchar(50) DEFAULT NULL,
  `FechaIngreso` date DEFAULT NULL,
  `FechaVencimientoCarneDeSalud` date DEFAULT NULL,
  `IdMutualista` tinyint(2) unsigned DEFAULT NULL,
  `IdEmergenciaMedica` tinyint(2) unsigned DEFAULT NULL,
  `CantidadHijos` tinyint(2) DEFAULT NULL,
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
  `SueldoActual` float(8,2) DEFAULT NULL,
  `IdBanco` tinyint(2) unsigned DEFAULT NULL,
  `NumeroCuenta` varchar(20) DEFAULT NULL,
  `Observaciones` varchar(255) DEFAULT NULL,
  `CAJ_Numero` varchar(20) DEFAULT NULL,
  `CAJ_FechaEmision` date DEFAULT NULL,
  `CAJ_FechaEntrega` date DEFAULT NULL,
  `BPS_FechaAlta` date DEFAULT NULL,
  `BPS_FechaBaja` date DEFAULT NULL,
  `BPS_AcumulacionLaboral` tinyint(2) unsigned DEFAULT NULL,
  `FechaTestPsicologico` date DEFAULT NULL,
  `PolicialesoMilitar` tinyint(1) DEFAULT '0',
  `FechaIngresoPolicialoMilitar` date DEFAULT NULL,
  `FechaEgresoPolicialoMilitar` date DEFAULT NULL,
  `SubEscalafonPolicial` varchar(30) DEFAULT NULL,
  `CombatienteMilitar` tinyint(1) DEFAULT '0',
  `RENAEMSE_FechaIngreso` date DEFAULT NULL,
  `RENAEMSE_NumeroAsunto` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdEmpleado`),
  UNIQUE KEY `IdTipoDocumento` (`IdTipoDocumento`,`NumeroDocumento`)
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
  `IdTipoEvento` int(11) DEFAULT NULL,
  `Descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IdEventoHistorialEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;


-- -----------------------------------------------------
-- Table `trustdb`.`lineashoras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`lineashoras` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`lineashoras` (
  `IdContrato` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `NroLinea` TINYINT(2) NOT NULL ,
  `Puesto` VARCHAR(50) NULL DEFAULT NULL ,
  `Armado?` TINYINT(1) NOT NULL ,
  `Cantidad` TINYINT(3) NOT NULL ,
  `CantHsNormales` TINYINT(3) NULL DEFAULT NULL ,
  `CantHsExtras` TINYINT(3) NULL DEFAULT NULL ,
  `PrecioXHora` FLOAT NULL DEFAULT NULL ,
  PRIMARY KEY (`NroLinea`, `IdContrato`) ,
  INDEX `C_LC` (`IdContrato` ASC) ,
  CONSTRAINT `C_LC`
    FOREIGN KEY (`IdContrato` )
    REFERENCES `trustdb`.`contratos` (`idContratos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`horariodia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`horariodia` ;



CREATE  TABLE IF NOT EXISTS `trustdb`.`horariodia` (
  `IdContrato` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `NroLinea` TINYINT(2) NOT NULL ,
  `Dia` VARCHAR(10) NOT NULL ,
  `HoraIni` VARCHAR(10) NOT NULL ,
  `HoraFin` VARCHAR(10) NOT NULL ,
  PRIMARY KEY (`IdContrato`, `NroLinea`, `Dia`) ,
  INDEX `LineasHoras_HD` (`NroLinea` ASC) ,
  INDEX `Contrato_HD` (`IdContrato` ASC) ,
  CONSTRAINT `LineasHoras_HD`
    FOREIGN KEY (`NroLinea` )
    REFERENCES `trustdb`.`lineashoras` (`NroLinea` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Contrato_HD`
    FOREIGN KEY (`IdContrato` )
    REFERENCES `trustdb`.`contratos` (`idContratos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;



--
-- Table structure for table `extrasliquidacionempleado`
--
DROP TABLE IF EXISTS `extrasliquidacionempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `extrasliquidacionempleado` (
  `IdExtrasLiquidacionEmpleado` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `IdEmpleado` mediumint(8) unsigned NOT NULL,
  `Fecha` date NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Signo` enum('SUMA','RESTA') NOT NULL,
  `Valor` float NOT NULL,
  `Liquidado` tinyint(1) DEFAULT '0',
  `CantidadCuotas` tinyint(2) unsigned DEFAULT '1',
  `CuotaActual` tinyint(2) unsigned DEFAULT '1',
  PRIMARY KEY (`IdExtrasLiquidacionEmpleado`),
  KEY `fk_IdEmpleado_Empleados_IdEmpleado` (`IdEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
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
  `Email` varchar(50) DEFAULT NULL,
  `Celular` varchar(50) DEFAULT NULL,
  `TareasAsignadas` varchar(255) DEFAULT NULL,
  `CelularTrust` varchar(50) DEFAULT NULL,
  `FechaAlta` date DEFAULT NULL,
  `FechaBaja` date DEFAULT NULL,
  `MotivoBaja` varchar(255) DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`NumeroServicio`,`NumeroCliente`),
  UNIQUE KEY `Nombre` (`Nombre`),
  KEY `fk_NumeroCliente_Clientes_NumeroCliente` (`NumeroCliente`),
  CONSTRAINT `fk_NumeroCliente_Clientes_NumeroCliente` FOREIGN KEY (`NumeroCliente`) REFERENCES `clientes` (`NumeroCliente`)
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
-- Table structure for table `tiposdocumento`
--

DROP TABLE IF EXISTS `tiposdocumento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposdocumento` (
  `IdTipoDocumento` tinyint(1) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdTipoDocumento`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2010-02-01  3:02:50