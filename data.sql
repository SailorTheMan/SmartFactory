-- MySQL dump 10.16  Distrib 10.1.26-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: db
-- ------------------------------------------------------
-- Server version	10.1.26-MariaDB-0+deb9u1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Информация о сотрудниках_Сотрудники с регисрацией`
--

DROP TABLE IF EXISTS `Информация о сотрудниках_Сотрудники с регисрацией`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Информация о сотрудниках_Сотрудники с регисрацией` (
  `ФИО` varchar(29) DEFAULT NULL,
  `Возраст` varchar(4) DEFAULT NULL,
  `Пол` varchar(1) DEFAULT NULL,
  `Должность` varchar(24) DEFAULT NULL,
  `Почта` varchar(30) DEFAULT NULL,
  `Стаж` varchar(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Информация о сотрудниках_Сотрудники с регисрацией`
--

LOCK TABLES `Информация о сотрудниках_Сотрудники с регисрацией` WRITE;
/*!40000 ALTER TABLE `Информация о сотрудниках_Сотрудники с регисрацией` DISABLE KEYS */;
INSERT INTO `Информация о сотрудниках_Сотрудники с регисрацией` VALUES ('Вагров Ярослав Владиславович','45.0','М','Администратор систем','irra1990romashka@yandex.ru','12.0'),('Галиаскарова Берта Игоревна','38.0','Ж','Инженер по автоматизации','mishkatop1998@yandex.ru','8.0'),('Гремпель Феликс Александрович','37.0','М','Инженер по автоматизации','dmitrykuashvili@yandex.ru','6.0'),('Ионова Виктория Владиленовна','42.0','Ж','Начальник склада','pogozhevalex@yandex.ru','15.0'),('Клима Евгения Геннадиевна','41.0','Ж','Начальник HR-отдела','kireevanatoliykireev@yandex.ru','12.0'),('Краснобаев Глеб Глебович','46.0','М','Рабочий склада','aleksej.yustus@yandex.ru','7.0'),('Мартынов Семен Андреевич','37.0','М','Администратор систем','dimaperlomutrov@yandex.ru','10.0'),('Решетников Петр Валериевич','42.0','М','Администратор систем','kirillboec13121998@yandex.ru','18.0'),('Соломина Галина Даниловна','46.0','Ж','Офисный рабочий','vikastoprocentov1995@yandex.ru','14.0'),('Соломина Светлана Андреевна','46.0','Ж','Офисный рабочий','andreyforever1212@yandex.ru','14.0'),('Степан Алексеевич Фицнер','65.0','М','Генеральный директор','vyacheslavnosovnosov@yandex.ru','35.0'),('Игорь Викторович Разгуляхин','47.0','М','Исполнительный директор','andreibusikov@yandex.ru','21.0'),('Тимур Фаридович Алимжанур','51.0','М','Ведущий инженер','dmitry.kondov@yandex.ru','22.0'),('Евгений Геннадьевич Крец','45.0','М','Начальник безопасности','archervarlamov@yandex.ru','16.0'),('','','','','',''),('','','','','',''),('','','','','',''),('','','','','',''),('','','','','','');
/*!40000 ALTER TABLE `Информация о сотрудниках_Сотрудники с регисрацией` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-22 15:20:24
