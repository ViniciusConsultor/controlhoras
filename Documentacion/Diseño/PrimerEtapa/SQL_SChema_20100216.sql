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
  `RUT` VARCHAR(12) NULL DEFAULT NULL ,
  `Email` VARCHAR(50) NULL DEFAULT NULL ,
  `Direccion` VARCHAR(100) NULL DEFAULT NULL ,
  `DireccionDeCobro` VARCHAR(100) NULL DEFAULT NULL ,
  `Telefonos` VARCHAR(50) NULL DEFAULT NULL ,
  `Fax` VARCHAR(50) NULL DEFAULT NULL ,
  `FechaAlta` DATE NULL DEFAULT NULL ,
  `FechaBaja` DATE NULL DEFAULT NULL ,
  `MotivoBaja` VARCHAR(255) NULL DEFAULT NULL ,
  `Activo` TINYINT(1) NULL DEFAULT '1' ,
  PRIMARY KEY (`NumeroCliente`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE UNIQUE INDEX `Nombre` ON `trustdb`.`clientes` (`Nombre` ASC) ;


-- -----------------------------------------------------
-- Table `trustdb`.`tipocontratos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`tipocontratos` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`tipocontratos` (
  `Id` INT(11) NOT NULL ,
  `Descripcion` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`Id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE UNIQUE INDEX `Descripcion_UNIQUE` ON `trustdb`.`tipocontratos` (`Descripcion` ASC) ;


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
  CONSTRAINT `Id`
    FOREIGN KEY (`TipodeContrato` )
    REFERENCES `trustdb`.`tipocontratos` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE INDEX `Id` ON `trustdb`.`contratos` (`TipodeContrato` ASC) ;


-- -----------------------------------------------------
-- Table `trustdb`.`departamentos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`departamentos` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`departamentos` (
  `IdDepartamento` TINYINT(2) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`IdDepartamento`) )
ENGINE = InnoDB
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
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`empleados`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`empleados` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`empleados` (
  `IdEmpleado` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `Nombre` VARCHAR(50) NOT NULL ,
  `Apellido` VARCHAR(50) NOT NULL ,
  `Sexo` TINYINT(1) NULL DEFAULT NULL ,
  `IdTipoDocumento` TINYINT(4) NOT NULL ,
  `NumeroDocumento` VARCHAR(30) NOT NULL ,
  `IdDepartamento` TINYINT(2) NOT NULL DEFAULT '0' ,
  `Ciudad` VARCHAR(50) NULL DEFAULT NULL ,
  `IdBarrio` SMALLINT(5) UNSIGNED NOT NULL DEFAULT '0' ,
  `Direccion` VARCHAR(50) NULL DEFAULT NULL ,
  `EntreCalles` VARCHAR(100) NULL DEFAULT NULL ,
  `DireccionDeEncuentro` VARCHAR(100) NULL DEFAULT NULL ,
  `Telefonos` VARCHAR(50) NULL DEFAULT NULL ,
  `Celular` VARCHAR(50) NULL DEFAULT NULL ,
  `CelularenConvenio` VARCHAR(50) NULL DEFAULT NULL ,
  `EstadoCivil` ENUM('CASADO','SOLTERO','DIVORCIADO','VIUDO') NULL DEFAULT NULL ,
  `Email` VARCHAR(50) NULL DEFAULT NULL ,
  `pathFoto` VARCHAR(50) NULL DEFAULT NULL ,
  `Edad` TINYINT(2) NULL DEFAULT NULL ,
  `FechaNacimiento` DATE NULL DEFAULT NULL ,
  `LugarDeNacimiento` VARCHAR(50) NULL DEFAULT NULL ,
  `Nacionalidad` VARCHAR(50) NULL DEFAULT NULL ,
  `FechaIngreso` DATE NULL DEFAULT NULL ,
  `FechaVencimientoCarneDeSalud` DATE NULL DEFAULT NULL ,
  `IdMutualista` TINYINT(2) UNSIGNED NULL DEFAULT NULL ,
  `IdEmergenciaMedica` TINYINT(2) UNSIGNED NULL DEFAULT NULL ,
  `CantidadHijos` TINYINT(2) NULL DEFAULT NULL ,
  `TalleCamisa` FLOAT NULL DEFAULT NULL ,
  `TallePantalon` FLOAT NULL DEFAULT NULL ,
  `TalleZapatos` FLOAT NULL DEFAULT NULL ,
  `TalleCampera` FLOAT NULL DEFAULT NULL ,
  `FechaEgreso` DATE NULL DEFAULT NULL ,
  `MotivoEgreso` VARCHAR(100) NULL DEFAULT NULL ,
  `CapacitadoPortarArma` TINYINT(1) NULL DEFAULT '0' ,
  `EnServicioArmado` TINYINT(1) NULL DEFAULT '0' ,
  `Antecedentes` TINYINT(1) NULL DEFAULT '0' ,
  `ObservacionesAntecedentes` VARCHAR(255) NULL DEFAULT NULL ,
  `SueldoActual` DECIMAL(8,2) NULL DEFAULT NULL ,
  `IdBanco` TINYINT(2) UNSIGNED NULL DEFAULT NULL ,
  `NumeroCuenta` VARCHAR(20) NULL DEFAULT NULL ,
  `Observaciones` VARCHAR(255) NULL DEFAULT NULL ,
  `CAJ_Numero` VARCHAR(20) NULL DEFAULT NULL ,
  `CAJ_FechaEmision` DATE NULL DEFAULT NULL ,
  `CAJ_FechaEntrega` DATE NULL DEFAULT NULL ,
  `BPS_FechaAlta` DATE NULL DEFAULT NULL ,
  `BPS_FechaBaja` DATE NULL DEFAULT NULL ,
  `BPS_AcumulacionLaboral` TINYINT(2) UNSIGNED NULL DEFAULT NULL ,
  `FechaTestPsicologico` DATE NULL DEFAULT NULL ,
  `AntecedentesPolicialesoMilitares` TINYINT(1) NULL DEFAULT '0' ,
  `FechaIngresoPolicialoMilitar` DATE NULL DEFAULT NULL ,
  `FechaEgresoPolicialoMilitar` DATE NULL DEFAULT NULL ,
  `SubEscalafonPolicial` VARCHAR(30) NULL DEFAULT NULL ,
  `CombatienteMilitar` TINYINT(1) NULL DEFAULT '0' ,
  `RENAEMSE_FechaIngreso` DATE NULL DEFAULT NULL ,
  `RENAEMSE_NumeroAsunto` DATE NULL DEFAULT NULL ,
  PRIMARY KEY (`IdEmpleado`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE UNIQUE INDEX `IdTipoDocumento` ON `trustdb`.`empleados` (`IdTipoDocumento` ASC, `NumeroDocumento` ASC) ;


-- -----------------------------------------------------
-- Table `trustdb`.`eventoshistorialempleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`eventoshistorialempleado` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`eventoshistorialempleado` (
  `IdEventoHistorialEmpleado` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `IdEmpleado` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `FechaInicio` DATE NOT NULL ,
  `FechaFin` DATE NOT NULL ,
  `IdTipoEvento` INT(11) NULL DEFAULT NULL ,
  `Descripcion` VARCHAR(255) NULL DEFAULT NULL ,
  PRIMARY KEY (`IdEventoHistorialEmpleado`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `trustdb`.`extrasliquidacionempleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`extrasliquidacionempleado` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`extrasliquidacionempleado` (
  `IdExtrasLiquidacionEmpleado` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `IdEmpleado` MEDIUMINT(8) UNSIGNED NOT NULL ,
  `Fecha` DATE NOT NULL ,
  `Descripcion` VARCHAR(255) NOT NULL ,
  `Signo` ENUM('+','-') NOT NULL ,
  `Valor` FLOAT NOT NULL ,
  `Liquidado` TINYINT(1) NULL DEFAULT '0' ,
  `CantidadCuotas` TINYINT(2) UNSIGNED NULL DEFAULT '1' ,
  `CuotaActual` TINYINT(2) UNSIGNED NULL DEFAULT '1' ,
  PRIMARY KEY (`IdExtrasLiquidacionEmpleado`) ,
  CONSTRAINT `fk_IdEmpleado_Empleados_IdEmpleado`
    FOREIGN KEY (`IdEmpleado` )
    REFERENCES `trustdb`.`empleados` (`IdEmpleado` ))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE INDEX `fk_IdEmpleado_Empleados_IdEmpleado` ON `trustdb`.`extrasliquidacionempleado` (`IdEmpleado` ASC) ;


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
  CONSTRAINT `FK_Contratos`
    FOREIGN KEY (`IdContrato` )
    REFERENCES `trustdb`.`contratos` (`idContratos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE INDEX `FK_Contratos` ON `trustdb`.`lineashoras` (`IdContrato` ASC) ;


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
  CONSTRAINT `Contrato_HD`
    FOREIGN KEY (`IdContrato` )
    REFERENCES `trustdb`.`contratos` (`idContratos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `LineasHoras_HD`
    FOREIGN KEY (`NroLinea` )
    REFERENCES `trustdb`.`lineashoras` (`NroLinea` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE INDEX `LineasHoras_HD` ON `trustdb`.`horariodia` (`NroLinea` ASC) ;

CREATE INDEX `Contrato_HD` ON `trustdb`.`horariodia` (`IdContrato` ASC) ;


-- -----------------------------------------------------
-- Table `trustdb`.`mutualistas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `trustdb`.`mutualistas` ;

CREATE  TABLE IF NOT EXISTS `trustdb`.`mutualistas` (
  `IdMutualista` TINYINT(2) UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`IdMutualista`) )
ENGINE = InnoDB
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
  CONSTRAINT `fk_NumeroCliente_Clientes_NumeroCliente`
    FOREIGN KEY (`NumeroCliente` )
    REFERENCES `trustdb`.`clientes` (`NumeroCliente` ))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE INDEX `fk_NumeroCliente_Clientes_NumeroCliente` ON `trustdb`.`servicios` (`NumeroCliente` ASC) ;


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
AUTO_INCREMENT = 21
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
DEFAULT CHARACTER SET = latin1;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
