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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisocontrol`
--

LOCK TABLES `permisocontrol` WRITE;
/*!40000 ALTER TABLE `permisocontrol` DISABLE KEYS */;
INSERT INTO `permisocontrol` VALUES (8,'System.Windows.Forms.ToolStripButton','btnClientes',1),(11,'System.Windows.Forms.ToolStripButton','btnConsultas',1),(10,'System.Windows.Forms.ToolStripButton','btnControlDiario',1),(9,'System.Windows.Forms.ToolStripButton','btnEmpleados',1),(7,'System.Windows.Forms.ToolStripButton','btnEscalafon',1),(4,'System.Windows.Forms.ToolStripMenuItem','cambiarNumeroEmpleadoToolStripMenuItem',1),(1,'System.Windows.Forms.ToolStripMenuItem','clientesToolStripMenuItem',1),(2,'System.Windows.Forms.ToolStripMenuItem','codiguerasToolStripMenuItem',1),(13,'System.Windows.Forms.ToolStripMenuItem','empleadosToolStripMenuItem',1),(6,'System.Windows.Forms.ToolStripMenuItem','generarHorasDiariasToolStripMenuItem',1),(14,'System.Windows.Forms.ToolStripMenuItem','listaNegraToolStripMenuItem',1),(3,'System.Windows.Forms.ToolStripMenuItem','serviciosToolStripMenuItem',1),(5,'System.Windows.Forms.ToolStripMenuItem','sustituirEnEscalafonToolStripMenuItem',1),(12,'System.Windows.Forms.ToolStripMenuItem','usuariosToolStripMenuItem',1);
/*!40000 ALTER TABLE `permisocontrol` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2011-02-08  2:22:55
