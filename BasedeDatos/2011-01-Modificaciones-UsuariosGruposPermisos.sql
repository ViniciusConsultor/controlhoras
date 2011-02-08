CREATE  TABLE `trustdb`.`PantallaWinForm` (
  `idPantallaWinForm` INT NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(45) NOT NULL ,
  `Descripcion` VARCHAR(100) NULL ,
  `Activo` TINYINT(1) NOT NULL DEFAULT 1 ,
  PRIMARY KEY (`idPantallaWinForm`) ,
  UNIQUE INDEX `Nombre_UNIQUE` (`Nombre` ASC) )
ENGINE = InnoDB;

CREATE  TABLE `trustdb`.`PermisoControl` (
  `idPermisoControl` INT NOT NULL AUTO_INCREMENT ,
  `NETType` VARCHAR(100) NOT NULL ,
  `Nombre` VARCHAR(45) NOT NULL ,
  `idPantallaWinForm` INT NOT NULL ,
  PRIMARY KEY (`idPermisoControl`) ,
  INDEX `IX_idPantallaWinForm_NETType_Nombre` (`idPantallaWinForm` ASC, `NETType` ASC, `Nombre` ASC) ,
  INDEX `FK_idPantallaWinForm` () ,
  CONSTRAINT `FK_idPantallaWinForm`
    FOREIGN KEY ()
    REFERENCES `trustdb`.`pantallawinform` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

	
CREATE  TABLE `trustdb`.`Usuarios` (
  `idUsuario` INT NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(100) NOT NULL ,
  `Apellido` VARCHAR(100) NOT NULL ,
  `UserName` VARCHAR(30) NOT NULL ,
  `Password` CHAR(32) NOT NULL ,
  `FechaCreacion` DATE NOT NULL ,
  `Activo` TINYINT(1) NOT NULL DEFAULT 1 ,
  PRIMARY KEY (`idUsuario`) ,
  INDEX `IX_UserName_Password` (`UserName` ASC, `Password` ASC) );
  
CREATE  TABLE `trustdb`.`Grupos` (
  `idGrupo` INT NOT NULL AUTO_INCREMENT ,
  `Nombre` VARCHAR(45) NOT NULL ,
  `Descripcion` VARCHAR(45) NOT NULL ,
  `Activo` TINYINT(1) NOT NULL ,
  PRIMARY KEY (`idGrupo`) );
  
CREATE  TABLE `trustdb`.`UsuariosGrupos` (
  `idUsuario` INT NOT NULL ,
  `idGrupo` INT NOT NULL ,
 PRIMARY KEY (`idUsuario`, `idGrupo`) );
 
  ALTER TABLE `trustdb`.`usuariosgrupos` 
  ADD CONSTRAINT `FK_Usuarios`
  FOREIGN KEY (`idUsuario` )
  REFERENCES `trustdb`.`usuarios` (`idUsuario` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION, 
  ADD CONSTRAINT `FK_Grupos`
  FOREIGN KEY (`idGrupo` )
  REFERENCES `trustdb`.`grupos` (`idGrupo` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;


CREATE TABLE `permisos` (
  `idPermiso` int(11) NOT NULL,
  `Usuario_OR_Grupo` char(1) NOT NULL DEFAULT 'G',
  `idControl` int(11) NOT NULL,
  `WinForm_OR_Control` char(1) NOT NULL DEFAULT 'W',
  `Activo` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

-- Indice Unique sobre UserName.
create unique index IX_U_UserName on Usuarios (UserName);

-- Indice Unique sobre IdPermiso,IdControl en Permisos
create index IX_U_IdPermiso_IdControl on permisos (idPermiso,idControl);