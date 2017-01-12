-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: assetmanagement
-- ------------------------------------------------------
-- Server version	5.1.63-community

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
-- Table structure for table `assets`
--

DROP TABLE IF EXISTS `assets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `assets` (
  `AssetId` int(11) NOT NULL AUTO_INCREMENT,
  `AssetType` varchar(45) DEFAULT NULL,
  `AssetDescription` varchar(200) DEFAULT NULL,
  `SerialNumber` varchar(45) DEFAULT NULL,
  `Barcode` varchar(45) DEFAULT NULL,
  `Quantity` varchar(45) DEFAULT NULL,
  `Manufacturer` varchar(45) DEFAULT NULL,
  `Model` varchar(45) DEFAULT NULL,
  `Category` varchar(45) DEFAULT NULL,
  `Condition` varchar(45) DEFAULT NULL,
  `Location` varchar(45) DEFAULT NULL,
  `Department` varchar(45) DEFAULT NULL,
  `DateAcquired` varchar(45) DEFAULT NULL,
  `InService` varchar(45) DEFAULT NULL,
  `Supplier` varchar(45) DEFAULT NULL,
  `Notes` varchar(200) DEFAULT NULL,
  `AddedBy` varchar(45) DEFAULT NULL,
  `DateAdded` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`AssetId`)
) ENGINE=InnoDB AUTO_INCREMENT=124 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assets`
--

LOCK TABLES `assets` WRITE;
/*!40000 ALTER TABLE `assets` DISABLE KEYS */;
INSERT INTO `assets` VALUES (121,'asdahf','daga','2315','241','23','adfad','asdf','sdafhgf','jkgsfadg','xczvn','wrqwr','12/13/16','12/13/16','gdhc','hsfh','sasdf','12/13/16'),(122,'dsdsd','asdsad','sadas','sadsdsds','sadsdsd','sd','dd','asdsd','asad','asdasd','sdasd','12/15/16','12/15/16','sdqwd','asdsadsad','asdsa','12/15/16'),(123,'sdsdsad','adsd','sdsad','dsadsd','sadsad','dasdsadsad','ds','sdd','dsadasd','dsad','asdasd','sdasd','sad','dasd','sads','sdsd','asdasd');
/*!40000 ALTER TABLE `assets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `idcategories` int(11) NOT NULL AUTO_INCREMENT,
  `category` varchar(45) DEFAULT NULL,
  `assettype` varchar(45) DEFAULT NULL,
  `prefix` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idcategories`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Electronic Devices','Monitor','EM'),(2,'Electronic Devices','Laptop','EL'),(3,'Electronic Devices','Printer','EP'),(4,'Electronic Devices','Smartphone','ES'),(5,'Accessories','Mouse','AM'),(6,'Accessories','Keyboard','AK'),(7,'Accessories','Headphones','AH'),(8,'Accessories','DVD Writer','AD'),(9,'Accessories','Speaker','AS'),(10,'Components','RAM','CR'),(11,'Components','Graphic Card','CG'),(12,'Components','Motherboard','CM'),(13,'Components','Processor','CP');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) CHARACTER SET latin1 COLLATE latin1_bin DEFAULT NULL,
  `pass` varchar(50) CHARACTER SET latin1 COLLATE latin1_bin DEFAULT NULL,
  `fn` varchar(45) DEFAULT NULL,
  `mn` varchar(45) DEFAULT NULL,
  `ln` varchar(45) DEFAULT NULL,
  `position` varchar(45) DEFAULT NULL,
  `department` varchar(45) DEFAULT NULL,
  `userLevel` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'paupua','paupua','Jeanne','Banzon','Pua','Sof Eng','IT','Admin',NULL),(2,'kyle','kyle','Kyle',NULL,NULL,NULL,NULL,'Custodian',NULL),(3,'eds','eds','Edcel',NULL,NULL,NULL,NULL,'Admin',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-01-12 14:40:16
