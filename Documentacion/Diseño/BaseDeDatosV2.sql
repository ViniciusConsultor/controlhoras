/* Archivo de definicion del esquema de la Base de Datos 
Definiciones:
	- BOOLEAN: Los booleanos los manejamos como bool (sinonimo de tinyint(1) 0=false, 1=true).
		

*/
use trustdb;

-- Clientes
CREATE TABLE `Clientes` (                                          
  `NumeroCliente` mediumint unsigned NOT NULL,                                             
  `Nombre` varchar(100) NOT NULL,                                               
  `NombreFantasia` varchar(100) DEFAULT NULL,                                       
  `RUT` varchar(12) DEFAULT NULL,                                               
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
  UNIQUE KEY `Nombre` (`Nombre`),
) ENGINE=InnoDB DEFAULT CHARSET=latin1


-- Servicios
CREATE TABLE `Servicios` (                                        
  `NumeroServicio` mediumint unsigned NOT NULL,                                            
  `NumeroCliente` mediumint unsigned NOT NULL,                                             
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1

-- TipoEmpleado
-- El Tipo de TipoEmpleado puede ser Mensual o Jornalero. En caso de Mensual, se debe indicar si es fulltime y si cobra hs extras.

CREATE TABLE TipoEmpleado (
	IdTipoEmpleado tinyint NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NombreTipo varchar(50) NOT NULL,
	Descripcion	varchar(255),
	CantidadHsComunes float NOT NULL,
	Tipo enum('MENSUAL','JORNALERO') NOT NULL default 'JORNALERO',
	Fulltime tinyint(1) default null,  -- Solo para Tipo MENSUAL
	CobraHsExtras tinyint(1) default null -- Solo para Tipo MENSUAL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Departamentos
CREATE TABLE Departamentos (
	IdDepartamento tinyint(2) unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Nombre varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Barrios
CREATE TABLE Barrios (
	IdBarrio smallint unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Nombre varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Bancos
CREATE TABLE Bancos (
	IdBanco tinyint(2) unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Nombre varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
CREATE TABLE Mutualistas (
	IdMutualista tinyint(2) unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Nombre varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE EmergenciasMedica (
	IdEmergenciaMedica tinyint(2) unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Nombre varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE TiposDocumento (
	IdTipoDocumento tinyint(1) unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Nombre varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



-- Empleados

CREATE TABLE Empleados (
	IdEmpleado mediumint unsigned NOT NULL PRIMARY KEY,
	Nombre varchar (50) NOT NULL,
	Apellido varchar (50) NOT NULL,
	Sexo tinyint(1), -- 0=MASCULINO  - 1=FEMENINO
	IdTipoDocumento tinyint NOT NULL, -- FOREIGN KEY A CODIGUERA
	NumeroDocumento varchar(30) NOT NULL,
	IdDepartamento tinyint(2) NOT NULL DEFAULT 0, -- FOREIGN KEY A CODIGUERA
	Ciudad varchar(50),
	IdBarrio smallint unsigned NOT NULL DEFAULT 0, -- FOREIGN KEY A CODIGUERA
	Direccion varchar(50),
	EntreCalles varchar (100),
	DireccionDeEncuentro varchar(100),
	Telefonos varchar (50),
	Celular varchar(50),
	CelularenConvenio varchar(50),
	EstadoCivil enum ('CASADO','SOLTERO','DIVORCIADO','VIUDO'),
	Email varchar(50),
	pathFoto varchar(50),
	Edad tinyint(2),
	FechaNacimiento Date,
	LugarDeNacimiento varchar(50),
	Nacionalidad varchar(50),
	FechaIngreso Date,
	FechaVencimientoCarneDeSalud Date,
	IdMutualista tinyint(2) unsigned,  -- FOREIGN KEY A CODIGUERA
	IdEmergenciaMedica tinyint(2) unsigned, -- FOREIGN KEY A CODIGUERA
	CantidadHijos tinyint(2),
	TalleCamisa float(3,1), -- Si es numerico, puede ser char, S,M,L,XL,etc
	TallePantalon float(3,1), -- Si es numerico, puede ser char, S,M,L,XL,etc
	TalleZapatos float(3,1),
	TalleCampera float(3,1), -- Si es numerico, puede ser char, S,M,L,XL,etc
	FechaEgreso date DEFAULT NULL,
	MotivoEgreso varchar(100) DEFAULT NULL,
	CapacitadoPortarArma bool DEFAULT false,
	EnServicioArmado bool DEFAULT false,
	Antecedentes bool DEFAULT false,
	ObservacionesAntecedentes varchar (255),
	SueldoActual decimal(8,2),
	IdBanco tinyint(2) unsigned, -- FOREIGN KEY A CODIGUERA
	NumeroCuenta  varchar(20),
	Observaciones varchar(255),
	CAJ_Numero varchar(20),
	CAJ_FechaEmision date,
	CAJ_FechaEntrega date,
	BPS_FechaAlta date,
	BPS_FechaBaja date,
	BPS_AcumulacionLaboral tinyint(2) unsigned,
	FechaTestPsicologico date,
	AntecedentesPolicialesoMilitares bool default false,
	FechaIngresoPolicialoMilitar date,
	FechaEgresoPolicialoMilitar date,
	SubEscalafonPolicial varchar(30),
	CombatienteMilitar bool default false,
	RENAEMSE_FechaIngreso date,
	RENAEMSE_NumeroAsunto date,
	UNIQUE (IdTipoDocumento, NumeroDocumento)
--	CONSTRAINT fk_IdDepartamento_Departamentos_IdDepartamento FOREIGN KEY (IdDepartamento) REFERENCES Departamentos(IdDepartamento), 
--	CONSTRAINT fk_IdBarrio_Barrios_IdBarrio FOREIGN KEY (IdBarrio) REFERENCES Barrios(IdBarrios),
--	CONSTRAINT fk_IdBanco_Bancos_IdBanco FOREIGN KEY (IdBanco) REFERENCES Bancos(IdBanco), 
--	CONSTRAINT fk_IdMutualista_Mutualistas_IdMutualista FOREIGN KEY (IdMutualista) REFERENCES Mutualistas(IdMutualista), 
--	CONSTRAINT fk_IdEmergenciaMedica_EmergenciasMedica_IdEmergenciaMedica FOREIGN KEY (IdEmergenciaMedica) REFERENCES EmergenciasMedica(IdEmergenciaMedica),
--	CONSTRAINT fk_IdTipoDocumento_TiposDocumento_IdTipoDocumento FOREIGN KEY (IdTipoDocumento) REFERENCES TiposDocumento(IdTipoDocumento)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- ExtrasLiquidacionEmpleado
CREATE TABLE ExtrasLiquidacionEmpleado (
	IdExtrasLiquidacionEmpleado int(11) unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IdEmpleado mediumint unsigned NOT NULL,
	Fecha DATE NOT NULL,
	Descripcion varchar(255) NOT NULL,
	Signo enum('+','-') NOT NULL,
	Valor float(6,2) NOT NULL,
	Liquidado bool DEFAULT false,
	CantidadCuotas tinyint(2) unsigned DEFAULT 1,
	CuotaActual tinyint(2) unsigned DEFAULT 1,
	CONSTRAINT fk_IdEmpleado_Empleados_IdEmpleado FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
	
-- EventosHistorialEmpleado
CREATE TABLE EventosHistorialEmpleado (
	IdEventoHistorialEmpleado int(11) unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IdEmpleado mediumint unsigned NOT NULL,
	FechaInicio date NOT NULL,
	FechaFin date NOT NULL,
	IdTipoEvento int,
	Descripcion varchar(255),
--	CONSTRAINT fk_IdEmpleado_Empleados_IdEmpleado FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
--	CONSTRAINT fk_IdTipoEvento_TiposEvento_IdTipoEvento FOREIGN KEY (IdTipoEvento) REFERENCES TiposEvento(IdTipoEvento)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE  TABLE IF NOT EXISTS `trustdb`.`tipocontratos` (
  `Id` INT(11) NOT NULL ,
  `Descripcion` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`Id`) ,
  UNIQUE INDEX `Descripcion_UNIQUE` (`Descripcion` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


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



