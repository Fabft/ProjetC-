-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 02 mai 2023 à 10:54
-- Version du serveur : 10.4.27-MariaDB
-- Version de PHP : 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bddaad`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `INSERT_ARTISTE` (IN `nom` VARCHAR(25) CHARSET utf8, IN `prenom` VARCHAR(25) CHARSET utf8, IN `description` TEXT CHARSET utf8, IN `image` VARCHAR(100) CHARSET utf8, IN `telephone` VARCHAR(10) CHARSET utf8, IN `mail` VARCHAR(50) CHARSET utf8, OUT `newid` INT)  DETERMINISTIC BEGIN

	INSERT INTO artiste(nomArt,prenomArt,descArt,imgArt,telArt,mailArt)VALUES (nom,prenom,description,image,telephone,mail);

	SELECT MAX(idArt)INTO newId FROM artiste;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `INSERT_CONTACT` (IN `nom` VARCHAR(50) CHARSET utf8, IN `prenom` VARCHAR(50) CHARSET utf8, IN `email` VARCHAR(50) CHARSET utf8, IN `objet` TEXT CHARSET utf8, IN `message` TEXT CHARSET utf8, OUT `newId` INT)   BEGIN

	INSERT INTO contact(nomContact,prenomContact,emailContact,objetContact,messageContact)VALUES
    (nom,prenom,email,objet,message);

	SELECT MAX(idContact)INTO newId FROM contact;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `INSERT_SPECTACLE` (IN `Titre` VARCHAR(30) CHARSET utf8, IN `Description` TEXT CHARSET utf8, IN `Tarif` INT(6), IN `Temps` VARCHAR(5) CHARSET utf8, IN `Image` VARCHAR(50) CHARSET utf8, IN `idArt` INT(50), OUT `newid` INT)  DETERMINISTIC BEGIN

	INSERT INTO spectacle(TitreSp,DescSp,TarifSp,TempsSp,ImgSp)VALUES (Titre,Description,Tarif,Temps,Image,IdArt);

	SELECT MAX(idSp)INTO newId FROM spectacle;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `artiste`
--

CREATE TABLE `artiste` (
  `idArt` int(5) NOT NULL,
  `nomArt` varchar(25) NOT NULL,
  `prenomArt` varchar(25) NOT NULL,
  `descArt` text DEFAULT NULL,
  `imgArt` varchar(100) DEFAULT NULL,
  `telArt` varchar(10) DEFAULT NULL,
  `mailArt` varchar(50) NOT NULL,
  `idCateg` int(5) DEFAULT NULL,
  `loginArt` varchar(20) NOT NULL,
  `mdpArt` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `artiste`
--

INSERT INTO `artiste` (`idArt`, `nomArt`, `prenomArt`, `descArt`, `imgArt`, `telArt`, `mailArt`, `idCateg`, `loginArt`, `mdpArt`) VALUES
(1, 'Diana', 'Higbee', 'Diana Higbee est une chanteuse lyrique (soprano), productrice et metteur en scène française.\n\nCréatrice du festival de musique, Musica Le Mans, elle est nommée ambassadrice de la ville du Mans en 20162.', 'diana.jpg', '0655889944', 'dianahigbee@hotmail.com', 2, 'diana', 'mdpdiana'),
(2, 'Coutable', 'Gaëtan', 'Musicien (violoniste)', 'gaetan.jpg', '0651575002', 'gaetancoutable@hotmail.com', 1, 'gaetan', 'mdpgaetan'),
(3, 'Baï', 'Lola ', 'Lola Baï est une chanteuse, qu\'elle explore sous différentes formes : chorale de variété, gospel, jazz, hip-hop, métal…', 'Lola.jpg', '0670341636', 'lola@lolabai.com', 2, 'lola', 'mdplola'),
(4, 'El Mago Mato', '', 'El mago Mato, (alias Filipe Matos) est un magicien, est né au Québec. Depuis son enfance, la magie le passionne. Il a débuté à l’âge de 9 ans. Autodidacte, il a apprit avec les livres. À 13 ans, il se lance dans son premier spectacle lors du Gala Méritas de son école !\r\n\r\nPar la suite, il a réalisé des spectacles chez des particuliers, des anniversaires pour enfants, dans des écoles, des lieux communautaires.', 'mago.jpg', '0247852369', 'elmagomato@hotmail.com', 4, 'mago', 'mdpmago'),
(5, 'Greory', 'Nicolas', 'Nicolas Greory est un pianiste originaire du Mans.', 'nico.jpg', '0687542136', 'nicolasgreory@gmail.com', 1, 'gregory', 'mdpgregory'),
(6, 'Reyes', 'Tomas', 'Tomas Reyes est un comédien argentin vivant au Mans.', 'tomas.jpg', '0638597562', 'tomasreyes@gmail.com', 5, 'tomas', 'mdptomas'),
(7, 'Ebongue', 'Wilfried', 'Wilfried Ebongue est un danseur sarthois, spécialisé dans le breakdance (danse urbaine acrobatique). Il puise son inspiration à Berlin où il s\'est expatrié en 2014 pour trouver son style.', 'wil.jpg', '0622331100', 'wilfriedebongue@gmail.com', 3, 'wilfried', 'mdpwilfried');

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `idCateg` int(11) NOT NULL,
  `NomCategArt` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`idCateg`, `NomCategArt`) VALUES
(1, 'Musique'),
(2, 'Chant'),
(3, 'Danse'),
(4, 'Magie'),
(5, 'Comédie');

-- --------------------------------------------------------

--
-- Structure de la table `contact`
--

CREATE TABLE `contact` (
  `idContact` int(11) NOT NULL,
  `nomContact` varchar(50) DEFAULT NULL,
  `prenomContact` varchar(50) DEFAULT NULL,
  `emailContact` varchar(50) DEFAULT NULL,
  `objetContact` text DEFAULT NULL,
  `messageContact` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Déchargement des données de la table `contact`
--

INSERT INTO `contact` (`idContact`, `nomContact`, `prenomContact`, `emailContact`, `objetContact`, `messageContact`) VALUES
(1, 'Martin', 'Dorian', 'm@gmail.com', 'Probleme avec l\'ajout d\'un spectacle', 'Bonjour, j\'ai un problème au niveau de l\'ajout d\'une page.');

-- --------------------------------------------------------

--
-- Structure de la table `public`
--

CREATE TABLE `public` (
  `idPublic` int(2) NOT NULL,
  `TypePublic` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `public`
--

INSERT INTO `public` (`idPublic`, `TypePublic`) VALUES
(1, 'Famille'),
(2, 'Enfant');

-- --------------------------------------------------------

--
-- Structure de la table `spectacle`
--

CREATE TABLE `spectacle` (
  `idSp` int(11) NOT NULL,
  `TitreSp` varchar(30) NOT NULL,
  `DescSp` text NOT NULL,
  `TarifSp` int(6) NOT NULL,
  `TempsSp` varchar(5) NOT NULL,
  `ImgSp` varchar(50) NOT NULL,
  `idArt` int(11) NOT NULL,
  `idPublic` int(2) NOT NULL,
  `idCateg` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `spectacle`
--

INSERT INTO `spectacle` (`idSp`, `TitreSp`, `DescSp`, `TarifSp`, `TempsSp`, `ImgSp`, `idArt`, `idPublic`, `idCateg`) VALUES
(1, 'Tour de magie', 'Spectacle de magie interprété par ElMagoMato intitulé \"Close to me\".\r\nAvec adresse, habilité et humour, il enchantera les amateurs de magie avec ses tours de cartes, mais il y aura aussi de surprenants tours de mentalisme qui décoifferont les plus sceptiques.', 20, '30min', 'SpMagie.jpg', 4, 2, 4),
(2, 'Spectacle de chant', 'Spectacle de musique classique intitulée \"Musica Classica\" interprétée par Diana Higbee. ', 50, '10min', 'SpChant.jpg', 1, 1, 2),
(3, 'Spectacle de musique', 'Spectacle de musique en solo réalisé par Gaëtan Coutable accompagné de son violon.', 30, '10min', 'SpMusicien.jpg', 2, 1, 1),
(4, 'Spectacle de comédie', 'Pièce autobiographique où le comédien Tomas Reyes rend hommage à Diego Maradona dans sa pièce intitulé \"Diego et moi\".', 40, '50min', 'SpComédie.jpg', 6, 1, 5),
(5, 'Danse artistique', 'Spectacle de breakdance en solo réalisé par Wilfried Ebongue.', 30, '20 mi', 'SpDanseur.jpg', 7, 1, 3),
(6, 'Spectacle lyrique', 'Spectacle lyrique en solo réalisé par Lola Baï accompagné de son piano et de sa guitare', 40, '20 mi', 'lyrique.jpg', 3, 1, 2),
(7, 'Spectacle de piano', 'Spectacle de musique en solo réalisé par Nicolas Greory accompagné de son piano.', 20, '1h', 'piano.jpg', 5, 1, 1);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `artiste`
--
ALTER TABLE `artiste`
  ADD PRIMARY KEY (`idArt`) USING BTREE;

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`idCateg`);

--
-- Index pour la table `contact`
--
ALTER TABLE `contact`
  ADD PRIMARY KEY (`idContact`);

--
-- Index pour la table `public`
--
ALTER TABLE `public`
  ADD PRIMARY KEY (`idPublic`);

--
-- Index pour la table `spectacle`
--
ALTER TABLE `spectacle`
  ADD PRIMARY KEY (`idSp`),
  ADD KEY `idArt` (`idArt`),
  ADD KEY `idPublic` (`idPublic`),
  ADD KEY `idCateg` (`idCateg`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `artiste`
--
ALTER TABLE `artiste`
  MODIFY `idArt` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `idCateg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `contact`
--
ALTER TABLE `contact`
  MODIFY `idContact` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `public`
--
ALTER TABLE `public`
  MODIFY `idPublic` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `spectacle`
--
ALTER TABLE `spectacle`
  MODIFY `idSp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `spectacle`
--
ALTER TABLE `spectacle`
  ADD CONSTRAINT `fkArtiste` FOREIGN KEY (`idArt`) REFERENCES `artiste` (`idArt`),
  ADD CONSTRAINT `fkPublic` FOREIGN KEY (`idPublic`) REFERENCES `public` (`idPublic`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
