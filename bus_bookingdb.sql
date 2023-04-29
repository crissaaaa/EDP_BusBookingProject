-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: bus_bookingdb
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booking` (
  `bookingID` int NOT NULL AUTO_INCREMENT,
  `schedID` int DEFAULT NULL,
  `customerID` int DEFAULT NULL,
  `no_of_seats` int DEFAULT NULL,
  `fare_amount` double DEFAULT NULL,
  `total_amount` double DEFAULT NULL COMMENT '= (fare_amount * no_of_seats)',
  `booking_date` date DEFAULT NULL,
  `userID` int DEFAULT NULL,
  PRIMARY KEY (`bookingID`),
  KEY `userID_idx09213` (`userID`),
  KEY `pamount_idx` (`total_amount`),
  KEY `cID_idx12345678_idx` (`customerID`),
  KEY `tsID_idx_idx` (`schedID`),
  CONSTRAINT `cID_idx12345678` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `customerID` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `schedID` FOREIGN KEY (`schedID`) REFERENCES `travel_sched` (`schedID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `tsID_idx` FOREIGN KEY (`schedID`) REFERENCES `travel_sched` (`schedID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `userID_idx` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `userID_idx09213` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=511 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booking`
--

LOCK TABLES `booking` WRITE;
/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
INSERT INTO `booking` VALUES (1,1,1,5,1000,5000,'2023-03-24',1),(2,2,2,1,800,800,'2023-02-21',2),(3,3,3,1,1000,1000,'2023-02-23',3),(4,4,4,1,999,999,'2023-03-30',4),(5,5,5,4,850,3400,'2023-02-24',5),(6,6,6,3,550,1650,'2023-02-27',6),(7,7,7,5,500,2500,'2023-02-27',7),(8,8,8,4,800,3200,'2023-02-28',8),(9,9,9,1,999,999,'2023-04-01',9),(10,10,10,1,888,888,'2023-03-30',10),(70,70,70,6,800,4800,'2024-04-18',1),(100,100,100,1,799,799,'2023-04-25',5),(102,102,102,3,600,1800,'2023-04-26',2),(103,103,103,1,500,500,'2023-04-26',1),(104,104,104,1,999,999,'2023-04-26',9),(105,105,105,2,1000,1000,'2023-04-26',7),(111,111,111,1,799,799,'2023-04-25',1),(180,180,180,1,899,899,'2023-04-18',1),(201,201,201,5,1000,5000,'2023-04-25',2),(202,202,202,3,600,1800,'2023-04-26',3),(203,203,203,1,500,500,'2023-04-26',4),(204,204,204,1,999,999,'2023-04-26',5),(205,205,205,2,1000,2000,'2023-04-27',6),(207,207,207,3,799,2397,'2023-04-29',8),(208,208,208,1,500,500,'2023-04-30',9),(209,209,209,5,700,3500,'2023-05-01',10),(210,210,210,2,850,1700,'2023-05-02',10),(265,265,265,1,799,799,'2023-04-28',1),(500,500,500,1,799,799,'2023-04-25',1),(501,501,501,5,1000,5000,'2023-04-25',2),(502,502,502,3,600,1800,'2023-04-26',3),(503,503,503,1,500,500,'2023-04-26',4),(504,504,504,1,999,999,'2023-04-26',5),(505,505,505,2,1000,2000,'2023-04-27',6),(506,506,506,4,800,3200,'2023-04-28',7),(507,507,507,3,799,2397,'2023-04-29',8),(508,508,508,1,500,500,'2023-04-30',9),(509,509,509,5,700,3500,'2023-05-01',10),(510,510,510,2,850,1700,'2023-05-02',10);
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bus`
--

DROP TABLE IF EXISTS `bus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bus` (
  `busID` int NOT NULL AUTO_INCREMENT,
  `bus_platenum` varchar(10) NOT NULL,
  `bus_type` int NOT NULL COMMENT '1 = Aircon\n2 = Non-aircon',
  `capacity` int NOT NULL,
  `userID` int DEFAULT NULL,
  `driverID` int DEFAULT NULL,
  PRIMARY KEY (`busID`),
  KEY `userID_idx` (`userID`),
  KEY `driver_id_idx` (`driverID`),
  CONSTRAINT `driver_id` FOREIGN KEY (`driverID`) REFERENCES `driver` (`driverID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `userID_idx2` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=501 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bus`
--

LOCK TABLES `bus` WRITE;
/*!40000 ALTER TABLE `bus` DISABLE KEYS */;
INSERT INTO `bus` VALUES (1,'AHG 154',1,100,1,1),(2,'EAV 289',2,100,2,2),(3,'ABV 451',1,100,3,3),(4,'AFC 101',2,100,4,4),(5,'EDT 642',2,100,5,5),(6,'EVS 433',2,100,6,6),(7,'FTH 555',2,100,7,7),(8,'THS 157',2,100,8,8),(9,'ABCD 4567',2,75,9,9),(10,'XYZ 143',1,100,10,10),(11,'AVS 567',1,90,1,11),(12,'XYZ 987',1,80,2,12),(180,'ABC 123',1,90,10,180),(265,'ABC 765',1,80,10,180),(300,'XYZ 1234',1,90,1,265);
/*!40000 ALTER TABLE `bus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `bustype`
--

DROP TABLE IF EXISTS `bustype`;
/*!50001 DROP VIEW IF EXISTS `bustype`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `bustype` AS SELECT 
 1 AS `busID`,
 1 AS `bus_platenum`,
 1 AS `bus_type`,
 1 AS `capacity`,
 1 AS `userID`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customerID` int NOT NULL AUTO_INCREMENT,
  `customer_name` varchar(50) DEFAULT NULL,
  `customer_contact` varchar(12) DEFAULT NULL,
  `customer_email` varchar(30) DEFAULT NULL,
  `customer_username` varchar(20) DEFAULT NULL,
  `password` longtext,
  `userID` int DEFAULT NULL,
  PRIMARY KEY (`customerID`),
  KEY `userID_idx` (`userID`),
  CONSTRAINT `uid_indx` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=511 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'KEI TSUKISHIMA','09511333260','tsukishima@email.com','kei','12345678',1),(2,'Hazel Guiverra','09101256114','hazelguiverra@gmail.com','Hazel','b7a2c3b25c9441b0a38d0a874ace268b',2),(3,'Ciara Mondragon','09483243891','ciara@gmail.com','Ciara','b7a2c3b25c9441b0a38d0a874ace268b',3),(4,'Shimizu Shisuki','09103352178','shisukishimizu@gmail.com','Shimizu','b7a2c3b25c9441b0a38d0a874ace268b',4),(5,'Park Chanyeol','09913458055','park.chanyeol@gmail.com','Chanyeol','b7a2c3b25c9441b0a38d0a874ace268b',5),(6,'Michiko Gomez','09104903598','michikogomez@gmail.com','Michiko','b7a2c3b25c9441b0a38d0a874ace268b',6),(7,'Kaori Oinuma','09485239480','kaori.oinuma@gmail.com','Kao','b7a2c3b25c9441b0a38d0a874ace268b',7),(8,'Hinata Shoyo','09511483588','shoyo.hinata@gmail.com','Hinata','b7a2c3b25c9441b0a38d0a874ace268b',8),(9,'Ruka','9123456789','ruka@gmail.com','ruka','123456',9),(10,'Maria Aperin','09123456788','mariaaperin@email.com','Maria','123456789',10),(12,'KEI TSUKISHIMA','09511333260','tsukishima@email.com','kei','12345678',1),(55,'Adelaida Aperin','9123147792','adelaida.aperin@gmail.com','Deli','6ebe76c9fb411be97b3b0d48b791a7c9',6),(60,'Adelaida Aperin','9123147792','adelaida.aperin@gmail.com','Deli','6ebe76c9fb411be97b3b0d48b791a7c9',6),(64,'Maria Aperin','9123147792','ma.aperin@gmail.com','Ria','6ebe76c9fb411be97b3b0d48b791a7c9',8),(70,'KEI TSUKISHIMA','09511333260','tsukishima@email.com','kei','12345678',1),(100,'Kei Tsukishima','9123456789','kei@gmail.com','kei','123456',5),(101,'Kageyama','9123456789','kageyama@gmail.com','kageyama','123456',6),(102,'Monkey D. Luffy','9123456789','monkey@gmail.com','monkey','123456',2),(103,'KEI TSUKISHIMA','09511333260','tsukishima@email.com','kei','12345678',1),(104,'Ruka','9123456789','ruka@gmail.com','ruka','123456',9),(105,'Kaori Oinuma','09485239480','kaori.oinuma@gmail.com','Kao','b7a2c3b25c9441b0a38d0a874ace268b',7),(106,'Haram','9123456789','haram@gmail.com','haram','123456',8),(107,'Ruka','9123456789','ruka@gmail.com','ruka','123456',9),(108,'Maria Aperin','09123456788','mariaaperin@email.com','Maria','123456789',10),(109,'Enami Asa','9123456789','enami@gmail.com','enami','123456',3),(110,'Chiquita','9123456789','chiquita@gmail.com','chiquita','123456',4),(111,'KEI TSUKISHIMA','09511333260','tsukishima@email.com','kei','12345678',1),(150,'Maria Aperin','09123456788','mariaaperin@email.com','Maria','123456789',10),(160,'KEI TSUKISHIMA','09511333260','tsukishima@email.com','kei','12345678',1),(180,'Crissa Olavario','09511333260','crissaolavario@gmail.com','Cris','crissa',9),(201,'Alliah Advincula','9123456789','alliah@gmail.com','allia','12345678',2),(202,'Maria Aperin','9123456789','maria@gmail.com','maria','12345678',3),(203,'Hans Hendrix','9123456789','hans@gmail.com','hans','12345678',4),(204,'Isaiah Jayden Santiago','9123456789','isaiah@gmail.com','isaia','12345678',5),(205,'Kythe Rye Santiago','9123456789','kythe@gmail.com','kythe','12345678',6),(206,'Kaori Oinuma','09485239480','kaori.oinuma@gmail.com','Kao','b7a2c3b25c9441b0a38d0a874ace268b',7),(207,'Angela Manuel','9123456789','angela@gmail.com','angel','12345678',8),(208,'Kyline Villaflor','9123456789','kyline@gmail.com','kylin','12345678',9),(209,'Jaycee Bea','9123456789','jaycee@gmail.com','jayce','12345678',10),(210,'Jed Caleb Cacha','9123456789','jed@gmail.com','jed','12345678',10),(250,'KEI TSUKISHIMA','09511333260','tsukishima@email.com','kei','12345678',1),(265,'Hinata Shoyo','09123147792','hinatashoyo@email.com','hinata','123456789',1),(500,'Queenly Aperin','9123456789','queenly@gmail.com','queen','12345678',1),(501,'Alliah Advincula','9123456789','alliah@gmail.com','allia','12345678',2),(502,'Maria Aperin','9123456789','maria@gmail.com','maria','12345678',3),(503,'Hans Hendrix','9123456789','hans@gmail.com','hans','12345678',4),(504,'Isaiah Jayden Santiago','9123456789','isaiah@gmail.com','isaia','12345678',5),(505,'Kythe Rye Santiago','9123456789','kythe@gmail.com','kythe','12345678',6),(506,'Kaildrich Formentera','9123456789','kaildrich@gmail.com','kaild','12345678',7),(507,'Angela Manuel','9123456789','angela@gmail.com','angel','12345678',8),(508,'Kyline Villaflor','9123456789','kyline@gmail.com','kylin','12345678',9),(509,'Jaycee Bea','9123456789','jaycee@gmail.com','jayce','12345678',10),(510,'Jed Caleb Cacha','9123456789','jed@gmail.com','jed','12345678',10);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `driver`
--

DROP TABLE IF EXISTS `driver`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `driver` (
  `driverID` int NOT NULL AUTO_INCREMENT,
  `driver_name` varchar(50) DEFAULT NULL,
  `driver_contact` varchar(12) DEFAULT NULL,
  `userID` int DEFAULT NULL,
  PRIMARY KEY (`driverID`),
  KEY `userID_idx` (`userID`),
  CONSTRAINT `userID` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=506 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `driver`
--

LOCK TABLES `driver` WRITE;
/*!40000 ALTER TABLE `driver` DISABLE KEYS */;
INSERT INTO `driver` VALUES (1,'Francisco Santos','09123479485',1),(2,'Sugawara Minato','09378347874',2),(3,'Isaac Monasterio','09123984997',3),(4,'JOHN DELA CRUZ','09489727957',4),(5,'Gary Velasco','09103843782',5),(6,'Randy Reyes','09919384954',6),(7,'Peter Hidalgo','09378884357',7),(8,'Marvin Aperin','09647382598',8),(9,'Jayden Santiago','09178474955',9),(10,'Kei Tsukishima','09103487953',10),(11,'Jose','09123456789',1),(12,'Oikawa','09123456789',2),(180,'Hinata Shoyo','09123456789',10),(265,'Juan Dela Cruz','09123456789',10),(500,'Edgardo Caluag','9123456789',1),(501,'Sajid Abrique','9123456789',2),(502,'Gavin Perez','9123456789',3),(503,'Kurt Pajarillo','9123456789',4),(504,'Khalix Cuevas','9123456789',5),(505,'Earon Lopez','9123456789',6);
/*!40000 ALTER TABLE `driver` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `driver_customer`
--

DROP TABLE IF EXISTS `driver_customer`;
/*!50001 DROP VIEW IF EXISTS `driver_customer`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `driver_customer` AS SELECT 
 1 AS `driver_name`,
 1 AS `driver_contact`,
 1 AS `customer_name`,
 1 AS `customer_contact`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `non-aircon_bustype`
--

DROP TABLE IF EXISTS `non-aircon_bustype`;
/*!50001 DROP VIEW IF EXISTS `non-aircon_bustype`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `non-aircon_bustype` AS SELECT 
 1 AS `busID`,
 1 AS `bus_platenum`,
 1 AS `bus_type`,
 1 AS `capacity`,
 1 AS `customerID`,
 1 AS `customer_name`,
 1 AS `customer_contact`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `non-airconbus`
--

DROP TABLE IF EXISTS `non-airconbus`;
/*!50001 DROP VIEW IF EXISTS `non-airconbus`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `non-airconbus` AS SELECT 
 1 AS `busID`,
 1 AS `bus_platenum`,
 1 AS `bus_type`,
 1 AS `capacity`,
 1 AS `userID`,
 1 AS `customer_name`,
 1 AS `customer_contact`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `paymentID` int NOT NULL AUTO_INCREMENT,
  `bookingID` int DEFAULT NULL,
  `paid_amount` double DEFAULT NULL,
  `payment_date` date DEFAULT NULL,
  `userID` int DEFAULT NULL,
  PRIMARY KEY (`paymentID`),
  KEY `bID` (`bookingID`),
  KEY `u_ID_idx` (`userID`),
  CONSTRAINT `u_ID` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `userID_idx1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=511 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,1,2000,'2023-02-20',1),(2,2,800,'2023-02-21',2),(3,3,2000,'2023-02-23',3),(4,4,1700,'2023-02-23',4),(5,5,3400,'2023-02-24',5),(6,6,1650,'2023-02-27',6),(8,8,3200,'2023-02-28',8),(9,9,2550,'2023-02-28',9),(10,10,1000,'2023-03-01',10),(65,65,2001,'2023-04-17',4),(70,70,4800,'2024-04-18',1),(85,85,799,'2023-04-18',4),(106,106,999,'2023-04-16',10),(180,180,899,'2023-04-14',1),(200,200,799,'2023-04-25',1),(201,201,5000,'2023-04-25',2),(202,202,1800,'2023-04-26',3),(203,203,500,'2023-04-26',4),(204,204,999,'2023-04-26',5),(205,205,2000,'2023-04-27',6),(206,206,3200,'2023-04-28',7),(207,207,2397,'2023-04-29',8),(208,208,500,'2023-04-30',9),(209,209,3500,'2023-05-01',10),(210,210,1700,'2023-05-02',10),(265,265,999,'2023-04-15',10),(500,500,799,'2023-04-25',1),(501,501,5000,'2023-04-25',2),(502,502,1800,'2023-04-26',3),(503,503,500,'2023-04-26',4),(504,504,999,'2023-04-26',5),(505,505,2000,'2023-04-27',6),(506,506,3200,'2023-04-28',7),(507,507,2397,'2023-04-29',8),(508,508,500,'2023-04-30',9),(509,509,3500,'2023-05-01',10),(510,510,1700,'2023-05-02',10);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `totalpayment`
--

DROP TABLE IF EXISTS `totalpayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `totalpayment` (
  `user_ID` int NOT NULL,
  `total` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `totalpayment`
--

LOCK TABLES `totalpayment` WRITE;
/*!40000 ALTER TABLE `totalpayment` DISABLE KEYS */;
INSERT INTO `totalpayment` VALUES (1,9297),(2,10800),(3,5600),(4,7500),(5,5398),(6,5650),(7,9900),(8,7994),(9,3550),(10,13398);
/*!40000 ALTER TABLE `totalpayment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `travel_sched`
--

DROP TABLE IF EXISTS `travel_sched`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `travel_sched` (
  `schedID` int NOT NULL AUTO_INCREMENT,
  `busID` int DEFAULT NULL,
  `starting_pt` varchar(50) NOT NULL,
  `destination` varchar(50) NOT NULL,
  `sched_date` date NOT NULL,
  `sched_time` time DEFAULT NULL,
  `userID` int DEFAULT NULL,
  `bookingID` int DEFAULT NULL,
  PRIMARY KEY (`schedID`),
  KEY `busID_idx` (`busID`),
  KEY `userID_idx` (`userID`),
  KEY `bookingID_idx` (`bookingID`),
  CONSTRAINT `busID` FOREIGN KEY (`busID`) REFERENCES `bus` (`busID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `travelID` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=511 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `travel_sched`
--

LOCK TABLES `travel_sched` WRITE;
/*!40000 ALTER TABLE `travel_sched` DISABLE KEYS */;
INSERT INTO `travel_sched` VALUES (1,1,'Tabaco','PTIX','2023-02-20','04:00:00',1,1),(2,2,'Legazpi','Pasay','2023-02-22','05:00:00',2,2),(3,3,'Pasay','Tabaco','2023-02-25','08:00:00',3,3),(4,4,'Cubao','Bacacay','2023-04-16','09:00:00',4,4),(5,5,'PTIX','Tabaco','2023-02-25','07:59:00',5,5),(6,6,'Legazpi','Sorsogon','2023-02-28','03:30:00',6,6),(7,7,'Cavite','Tabaco','2023-04-30','13:00:00',7,7),(8,8,'Legazpi','Turbina','2023-03-01','02:00:00',8,8),(9,9,'Pasay','Tabaco','2023-03-01','12:00:00',9,9),(10,10,'Pasay','Tabaco','2023-03-01','12:30:00',10,10),(65,3,'Cubao','Tabaco','2023-04-15','05:00:00',4,65),(70,5,'Legazpi','Dasmarinas, Cavite','2023-04-18','17:00:00',1,70),(100,1,'Legazpi','Pasay','2023-04-17','04:00:00',5,100),(101,2,'Legazpi','Pasay','2023-04-17','05:00:00',6,101),(102,3,'Legazpi','Pasay','2023-04-18','06:00:00',2,102),(103,4,'Legazpi','Pasay','2023-04-18','07:00:00',1,103),(104,5,'Legazpi','Pasay','2023-04-19','08:00:00',9,104),(105,6,'Legazpi','Pasay','2023-04-19','09:00:00',7,105),(106,7,'Legazpi','Pasay','2023-04-20','10:00:00',8,106),(107,8,'Legazpi','Pasay','2023-04-20','11:00:00',9,107),(108,9,'Legazpi','Pasay','2023-04-21','12:00:00',10,108),(110,4,'Legazpi','Pasay','2023-04-22','14:00:00',4,110),(111,4,'Legazpi','Cavite','2023-04-30','05:30:00',1,111),(180,1,'Legazpi','Pasay','2023-04-20','15:30:00',1,180),(200,1,'Pasay','Legazpi','2023-04-17','04:00:00',1,200),(201,2,'Legazpi','Pasay','2023-04-17','05:00:00',2,201),(202,3,'Legazpi','Pasay','2023-04-18','06:00:00',3,202),(203,4,'Legazpi','Pasay','2023-04-18','07:00:00',4,203),(204,5,'Legazpi','Pasay','2023-04-19','08:00:00',5,204),(205,6,'Legazpi','Pasay','2023-04-19','09:00:00',6,205),(207,8,'Legazpi','Pasay','2023-04-20','11:00:00',8,207),(208,9,'Legazpi','Pasay','2023-04-21','12:00:00',9,208),(209,10,'Legazpi','Pasay','2023-04-21','13:00:00',10,209),(210,4,'Legazpi','Pasay','2023-04-22','14:00:00',10,210),(250,10,'Legazpi','Laguna','2023-04-25','13:30:00',1,250),(265,2,'Cavite','Pasay','2023-04-18','17:30:00',10,265),(500,1,'Legazpi','Pasay','2023-04-17','04:00:00',1,500),(501,2,'Legazpi','Pasay','2023-04-17','05:00:00',2,501),(502,3,'Legazpi','Pasay','2023-04-18','06:00:00',3,502),(503,4,'Legazpi','Pasay','2023-04-18','07:00:00',4,503),(504,5,'Legazpi','Pasay','2023-04-19','08:00:00',5,504),(505,6,'Legazpi','Pasay','2023-04-19','09:00:00',6,505),(506,7,'Legazpi','Pasay','2023-04-20','10:00:00',7,506),(507,8,'Legazpi','Pasay','2023-04-20','11:00:00',8,507),(508,9,'Legazpi','Pasay','2023-04-21','12:00:00',9,508),(509,10,'Legazpi','Pasay','2023-04-21','13:00:00',10,509),(510,4,'Legazpi','Pasay','2023-04-22','14:00:00',10,510);
/*!40000 ALTER TABLE `travel_sched` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `userID` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `contact` varchar(12) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `username` varchar(20) DEFAULT NULL,
  `password` longtext,
  `acc_status` varchar(10) DEFAULT NULL COMMENT '1= Active \\n0 = Not Active',
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=507 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Juan Dela Cruz','09122333412','juandelacruz@gmail.com','Juan','550e1bafe077ff0b0b67f4e32f29d751','1'),(2,'Robert Reyes','09234155901','robertreyes@gmail.com','Robert','550e1bafe077ff0b0b67f4e32f29d751','1'),(3,'Hannah Ocampo','09611444250','hannahocampo@gmail.com','Hannah','550e1bafe077ff0b0b67f4e32f29d751','1'),(4,'Maria Natividad','09123498912','marianatividad@gmail.com','Maria','550e1bafe077ff0b0b67f4e32f29d751','1'),(5,'Naruto Uzamaki','09511333260','uzamakinaruto@email.com','naruto','64fa1fb463fa5a377557e9de9c48d200','1'),(6,'Hanson Smith','09918233215','hansonsmith@gmail.com','Hanson','550e1bafe077ff0b0b67f4e32f29d751','1'),(7,'Johny Jones','09511333249','johnyjones@gmail.com','Johny','550e1bafe077ff0b0b67f4e32f29d751','1'),(8,'Cristy Fermin','09104456713','cristyfermin@gmail.com','Cristy','550e1bafe077ff0b0b67f4e32f29d751','1'),(9,'Francis Manalo','09481234567','francismanalo@gmail.com','Francis','550e1bafe077ff0b0b67f4e32f29d751','1'),(10,'Jansen Aquino','09918484518','jansenaquino@gmail.com','Jansen','550e1bafe077ff0b0b67f4e32f29d751','1'),(11,'Crissa Olavario','09511222406','crissa@gmail.com','crissa','c91ae4d742d24311780f6894b6fd2669','1'),(180,'CRISSA OLAVARIO','09123456789','crissa@gmail.com','crissa','123456789','1'),(265,'Madison ','09123147792','madison@gmail.com','mad','b25fe981a8e4d2b00e2c02dc2381b37cddbcf451ba9f21055d6ab039','1'),(500,'Crissa Olavario','9123456789','crissa@gmail.com','crissa','12345','1'),(501,'Mitzi Oringo','9123456789','mitzi@gmail.com','mitzi','12345','1'),(502,'Faye Buban','9123456789','faye@gmail.com','faye','12345','1'),(503,'Monica Ferrel','9123456789','monica@gmail.com','monica','12345','1'),(504,'Ash Ramos','9123456789','ash@gmail.com','ash','12345','1'),(505,'Cecille Cervantes ','9123456789','cecille@gmail.com','ces','12345','1'),(506,'Juan Dela Cruz','09122333412','juandelacruz@gmail.com','Juan','e3cc7e0f15ac25faa632776607030a68c9775090ff8e6243004c449c','1');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_login`
--

DROP TABLE IF EXISTS `users_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users_login` (
  `username` varchar(10) NOT NULL,
  `password` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_login`
--

LOCK TABLES `users_login` WRITE;
/*!40000 ALTER TABLE `users_login` DISABLE KEYS */;
INSERT INTO `users_login` VALUES ('admin','21232f297a57a5a743894a0e4a801fc3'),('guest','084e0343a0486ff05530df6c705c8bb4'),('admin','admin'),('guest','guest'),('crissa','crissa'),('lili','lili'),('maria','maria'),('tetia','tetia'),('hinata','hinata'),('kei','kei'),('robin','robin'),('nami','nami'),('admin','admin'),('guest','guest'),('crissa','crissa'),('lili','lili'),('maria','maria'),('tetia','tetia'),('hinata','hinata'),('kei','kei'),('robin','robin'),('nami','nami');
/*!40000 ALTER TABLE `users_login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `yourview`
--

DROP TABLE IF EXISTS `yourview`;
/*!50001 DROP VIEW IF EXISTS `yourview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `yourview` AS SELECT 
 1 AS `driver_name`,
 1 AS `driver_contact`,
 1 AS `customer_name`,
 1 AS `customer_contact`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `bustype`
--

/*!50001 DROP VIEW IF EXISTS `bustype`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `bustype` AS select `bus`.`busID` AS `busID`,`bus`.`bus_platenum` AS `bus_platenum`,`bus`.`bus_type` AS `bus_type`,`bus`.`capacity` AS `capacity`,`bus`.`userID` AS `userID` from `bus` where (`bus`.`bus_type` = '2') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `driver_customer`
--

/*!50001 DROP VIEW IF EXISTS `driver_customer`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `driver_customer` AS select `driver`.`driver_name` AS `driver_name`,`driver`.`driver_contact` AS `driver_contact`,`customer`.`customer_name` AS `customer_name`,`customer`.`customer_contact` AS `customer_contact` from (`driver` join `customer`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `non-aircon_bustype`
--

/*!50001 DROP VIEW IF EXISTS `non-aircon_bustype`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `non-aircon_bustype` AS select `bus`.`busID` AS `busID`,`bus`.`bus_platenum` AS `bus_platenum`,`bus`.`bus_type` AS `bus_type`,`bus`.`capacity` AS `capacity`,`customer`.`customerID` AS `customerID`,`customer`.`customer_name` AS `customer_name`,`customer`.`customer_contact` AS `customer_contact` from (`bus` join `customer`) where ((`bus`.`bus_type` = '2') and (`customer`.`customerID` <> '1')) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `non-airconbus`
--

/*!50001 DROP VIEW IF EXISTS `non-airconbus`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `non-airconbus` AS select `bus`.`busID` AS `busID`,`bus`.`bus_platenum` AS `bus_platenum`,`bus`.`bus_type` AS `bus_type`,`bus`.`capacity` AS `capacity`,`bus`.`userID` AS `userID`,`customer`.`customer_name` AS `customer_name`,`customer`.`customer_contact` AS `customer_contact` from (`bus` join `customer`) where (`bus`.`bus_type` = '2') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `yourview`
--

/*!50001 DROP VIEW IF EXISTS `yourview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `yourview` AS select `driver`.`driver_name` AS `driver_name`,`driver`.`driver_contact` AS `driver_contact`,`customer`.`customer_name` AS `customer_name`,`customer`.`customer_contact` AS `customer_contact` from (`driver` join `customer` on((`driver`.`driver_name` = `customer`.`customer_name`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-29 12:22:49
