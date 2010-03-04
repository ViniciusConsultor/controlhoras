SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
CREATE SCHEMA IF NOT EXISTS `trustdb` DEFAULT CHARACTER SET latin1 ;

-- -----------------------------------------------------
-- Table `trustdb`.`bancos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`bancos` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`bancos` (
  `IdBanco` TINYINT(2) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`IdBanco`) )
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`barrios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`barrios` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`barrios` (
  `IdBarrio` SMALLINT(5) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`IdBarrio`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`clientes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`clientes` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`clientes` (
  `NumeroCliente` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `Nombre` VARCHAR(100) NOT NULL ,
  `NombreFantasia` VARCHAR(100) NULL DEFAULT NULL ,
  `RUT` CHAR(15) NULL DEFAULT NULL ,
  `Email` VARCHAR(50) NULL DEFAULT NULL ,
  `Direccion` VARCHAR(100) NULL DEFAULT NULL ,
  `DireccionDeCobro` VARCHAR(100) NULL DEFAULT NULL ,
  `Telefonos` VARCHAR(50) NULL DEFAULT NULL ,
  `Fax` VARCHAR(50) NULL DEFAULT NULL ,
  `FechaAlta` DATE NULL DEFAULT NULL ,
  `FechaBaja` DATE NULL DEFAULT NULL ,
  `MotivoBaja` VARCHAR(255) NULL DEFAULT NULL ,
  `Activo` TINYINT(1) NULL DEFAULT '1' ,
  PRIMARY KEY (`NumeroCliente`) ,
  UNIQUE INDEX `Nombre` (`Nombre` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


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
  `CostoFijo` TINYINT(1) NOT NULL ,
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


-- -----------------------------------------------------
-- Table `trustdb`.`departamentos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`departamentos` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`departamentos` (
  `IdDepartamento` TINYINT(2) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`IdDepartamento`) )
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`emergenciasmedica`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`emergenciasmedica` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`emergenciasmedica` (
  `IdEmergenciaMedica` TINYINT(2) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`IdEmergenciaMedica`) )
ENGINE = InnoDB
AUTO_INCREMENT = 23
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`empleados`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`empleados` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`empleados` (
  `IdEmpleado` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `Nombre` VARCHAR(50) NOT NULL ,
  `Apellido` VARCHAR(50) NOT NULL ,
  `sexo` CHAR(1) NULL DEFAULT NULL ,
  `IdCargo` SMALLINT(6) NOT NULL DEFAULT '0' ,
  `IdTipoDocumento` TINYINT(4) NOT NULL ,
  `NumeroDocumento` VARCHAR(30) NOT NULL ,
  `IdDepartamento` TINYINT(2) NULL DEFAULT NULL ,
  `Ciudad` VARCHAR(50) NULL DEFAULT NULL ,
  `Barrio` VARCHAR(30) NULL DEFAULT '0' ,
  `Direccion` VARCHAR(50) NULL DEFAULT NULL ,
  `EntreCalles` VARCHAR(100) NULL DEFAULT NULL ,
  `CodigoPostal` VARCHAR(10) NULL DEFAULT NULL ,
  `DireccionDeEncuentro` VARCHAR(100) NULL DEFAULT NULL ,
  `Telefonos` VARCHAR(50) NULL DEFAULT NULL ,
  `Celular` VARCHAR(50) NULL DEFAULT NULL ,
  `CelularenConvenio` VARCHAR(50) NULL DEFAULT NULL ,
  `EstadoCivil` VARCHAR(11) NULL DEFAULT NULL ,
  `Email` VARCHAR(50) NULL DEFAULT NULL ,
  `Foto` BLOB NULL DEFAULT NULL ,
  `Edad` TINYINT(2) NULL DEFAULT NULL ,
  `FechaNacimiento` DATE NULL DEFAULT NULL ,
  `LugarDeNacimiento` VARCHAR(50) NULL DEFAULT NULL ,
  `Nacionalidad` VARCHAR(50) NULL DEFAULT NULL ,
  `FechaIngreso` DATE NULL DEFAULT NULL ,
  `FechaVencimientoCarneDeSalud` DATE NULL DEFAULT NULL ,
  `IdMutualista` TINYINT(2) UNSIGNED NULL DEFAULT NULL ,
  `IdEmergenciaMedica` TINYINT(2) UNSIGNED NULL DEFAULT NULL ,
  `CantidadMenoresACargo` TINYINT(2) NULL DEFAULT NULL ,
  `TalleCamisa` VARCHAR(4) NULL DEFAULT NULL ,
  `TallePantalon` VARCHAR(4) NULL DEFAULT NULL ,
  `TalleZapatos` TINYINT(2) NULL DEFAULT NULL ,
  `TalleCampera` VARCHAR(4) NULL DEFAULT NULL ,
  `FechaBaja` DATE NULL DEFAULT '0002-01-01' ,
  `MotivoBaja` VARCHAR(100) NULL DEFAULT NULL ,
  `CapacitadoPortarArma` TINYINT(1) NULL DEFAULT '0' ,
  `EnServicioArmado` TINYINT(1) NULL DEFAULT '0' ,
  `Antecedentes` TINYINT(1) NULL DEFAULT '0' ,
  `ObservacionesAntecedentes` VARCHAR(255) NULL DEFAULT NULL ,
  `SueldoActual` FLOAT NULL DEFAULT NULL ,
  `IdBanco` TINYINT(2) UNSIGNED NULL DEFAULT NULL ,
  `NumeroCuenta` VARCHAR(20) NULL DEFAULT NULL ,
  `Observaciones` VARCHAR(255) NULL DEFAULT NULL ,
  `CAJ_Numero` VARCHAR(20) NULL DEFAULT NULL ,
  `CAJ_FechaEmision` DATE NULL DEFAULT NULL ,
  `CAJ_FechaEntrega` DATE NULL DEFAULT NULL ,
  `BPS_FechaAlta` DATE NULL DEFAULT NULL ,
  `BPS_FechaBaja` DATE NULL DEFAULT NULL ,
  `BPS_AcumulacionLaboral` TINYINT(2) UNSIGNED NULL DEFAULT NULL ,
  `BPSEsBaja` TINYINT(1) NOT NULL DEFAULT '0' ,
  `FechaTestPsicologico` DATE NULL DEFAULT NULL ,
  `PolicialesoMilitar` TINYINT(1) NULL DEFAULT '0' ,
  `FechaIngresoPolicialoMilitar` DATE NULL DEFAULT NULL ,
  `FechaEgresoPolicialoMilitar` DATE NULL DEFAULT NULL ,
  `SubEscalafonPolicial` VARCHAR(30) NULL DEFAULT NULL ,
  `CombatienteMilitar` TINYINT(1) NULL DEFAULT '0' ,
  `RENAEMSE_FechaIngreso` DATE NULL DEFAULT NULL ,
  `RENAEMSE_NumeroAsunto` VARCHAR(20) NULL DEFAULT NULL ,
  `AntecedentesPolicialesOMilitares` TINYINT(1) NOT NULL DEFAULT '0' ,
  `EgresadoEmpresa` TINYINT(1) NOT NULL DEFAULT '0' ,
  `MTSSEsBaja` TINYINT(1) NOT NULL DEFAULT '0' ,
  `MTSS_FechaAlta` DATE NULL DEFAULT NULL ,
  `MTSS_FechaBaja` DATE NULL DEFAULT NULL ,
  `NoHabilitadoParaServicio` TINYINT(1) NOT NULL DEFAULT '0' ,
  `FechaPagoFinal` DATE NULL DEFAULT NULL ,
  `Activo` TINYINT(1) NOT NULL DEFAULT '0' ,
  PRIMARY KEY (`IdEmpleado`) ,
  UNIQUE INDEX `IdTipoDocumento` (`IdTipoDocumento` ASC, `NumeroDocumento` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`eventoshistorialempleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`eventoshistorialempleado` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`eventoshistorialempleado` (
  `IdEventoHistorialEmpleado` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `IdEmpleado` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `FechaInicio` DATE NOT NULL ,
  `FechaFin` DATE NOT NULL ,
  `IdTipoEvento` INT(11) NOT NULL ,
  `Descripcion` VARCHAR(255) NOT NULL ,
  `borrado` TINYINT(1) NOT NULL DEFAULT '0' ,
  PRIMARY KEY (`IdEventoHistorialEmpleado`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`extrasliquidacionempleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`extrasliquidacionempleado` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`extrasliquidacionempleado` (
  `idExtrasLiquidacionEmpleado` INT(11) UNSIGNED NOT NULL ,
  `IdEmpleado` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `Fecha` DATE NOT NULL ,
  `Descripcion` VARCHAR(255) NOT NULL ,
  `Signo` MEDIUMINT(9) NOT NULL DEFAULT '1' ,
  `Valor` FLOAT NOT NULL ,
  `Liquidado` TINYINT(1) NOT NULL DEFAULT '0' ,
  `CantidadCuotas` TINYINT(2) NOT NULL DEFAULT '1' ,
  `CuotaActual` TINYINT(2) NOT NULL DEFAULT '1' ,
  PRIMARY KEY (`IdEmpleado`, `idExtrasLiquidacionEmpleado`, `CuotaActual`) ,
  INDEX `fk_IdEmpleado_Empleados_IdEmpleado` (`IdEmpleado` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`lineashoras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`lineashoras` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`lineashoras` (
  `IdContrato` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `NroLinea` TINYINT(2) NOT NULL ,
  `Puesto` VARCHAR(50) NULL DEFAULT NULL ,
  `Armado` TINYINT(1) NOT NULL ,
  `Cantidad` TINYINT(3) NOT NULL ,
  `CantHsNormales` TINYINT(3) NULL DEFAULT NULL ,
  `CantHsExtras` TINYINT(3) NULL DEFAULT NULL ,
  `PrecioXHora` FLOAT NULL DEFAULT NULL ,
  PRIMARY KEY (`NroLinea`, `IdContrato`) ,
  INDEX `FK_Contratos` (`IdContrato` ASC) ,
  CONSTRAINT `FK_Contratos`
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
  INDEX `FK IdContrato HD` (`IdContrato` ASC) ,
  CONSTRAINT `FK IdContrato HD`
    FOREIGN KEY (`IdContrato` )
    REFERENCES `trustdb`.`lineashoras` (`IdContrato` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`mutualistas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`mutualistas` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`mutualistas` (
  `IdMutualista` TINYINT(2) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`IdMutualista`) )
ENGINE = InnoDB
AUTO_INCREMENT = 72
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`servicios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`servicios` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`servicios` (
  `NumeroServicio` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `NumeroCliente` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `Nombre` VARCHAR(100) NOT NULL ,
  `Direccion` VARCHAR(100) NULL DEFAULT NULL ,
  `Telefonos` VARCHAR(50) NULL DEFAULT NULL ,
  `PersonaContacto` VARCHAR(50) NULL DEFAULT NULL ,
  `Email` VARCHAR(50) NULL DEFAULT NULL ,
  `Celular` VARCHAR(50) NULL DEFAULT NULL ,
  `TareasAsignadas` VARCHAR(255) NULL DEFAULT NULL ,
  `CelularTrust` VARCHAR(50) NULL DEFAULT NULL ,
  `FechaAlta` DATE NULL DEFAULT NULL ,
  `FechaBaja` DATE NULL DEFAULT NULL ,
  `MotivoBaja` VARCHAR(255) NULL DEFAULT NULL ,
  `Activo` TINYINT(1) NULL DEFAULT '1' ,
  PRIMARY KEY (`NumeroServicio`, `NumeroCliente`) ,
  INDEX `fk_NumeroCliente_Clientes_NumeroCliente` (`NumeroCliente` ASC) ,
  CONSTRAINT `fk_NumeroCliente_Clientes_NumeroCliente`
    FOREIGN KEY (`NumeroCliente` )
    REFERENCES `trustdb`.`clientes` (`NumeroCliente` ))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`tipoempleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`tipoempleado` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`tipoempleado` (
  `IdTipoEmpleado` TINYINT(4) NOT NULL AUTO_INCREMENT ,
  `NombreTipo` VARCHAR(50) NOT NULL ,
  `Descripcion` VARCHAR(255) NULL DEFAULT NULL ,
  `CantidadHsComunes` FLOAT NOT NULL ,
  `Tipo` ENUM('MENSUAL','JORNALERO') NOT NULL DEFAULT 'JORNALERO' ,
  `Fulltime` TINYINT(1) NULL DEFAULT NULL ,
  `CobraHsExtras` TINYINT(1) NULL DEFAULT NULL ,
  PRIMARY KEY (`IdTipoEmpleado`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`tiposcargos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`tiposcargos` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`tiposcargos` (
  `IdCargo` MEDIUMINT(8) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(100) NOT NULL ,
  `Descripcion` VARCHAR(200) NULL DEFAULT NULL ,
  `CantidadHsComunes` TINYINT(2) NOT NULL DEFAULT '8' ,
  `TipoFacturacion` VARCHAR(10) NOT NULL DEFAULT 'JORNALERO' ,
  `Fulltime` TINYINT(1) NOT NULL DEFAULT '0' ,
  `CobraHsExtras` TINYINT(1) NOT NULL DEFAULT '1' ,
  `Activo` TINYINT(1) NOT NULL DEFAULT '0' ,
  PRIMARY KEY (`IdCargo`) )
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`tiposdocumento`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`tiposdocumento` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`tiposdocumento` (
  `IdTipoDocumento` TINYINT(1) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`IdTipoDocumento`) )
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`tiposeventohistorial`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`tiposeventohistorial` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`tiposeventohistorial` (
  `IdTipoEventoHistorial` SMALLINT(5) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(100) NOT NULL ,
  `Activo` SMALLINT(1) NOT NULL DEFAULT '0' ,
  PRIMARY KEY (`IdTipoEventoHistorial`) )
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = latin1;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
