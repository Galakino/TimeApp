-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 30-Set-2024 às 14:40
-- Versão do servidor: 5.7.11
-- PHP Version: 7.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `time`
--
CREATE DATABASE IF NOT EXISTS `time` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `time`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro`
--

DROP TABLE IF EXISTS `cadastro`;
CREATE TABLE IF NOT EXISTS `cadastro` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cadastro`
--

INSERT INTO `cadastro` (`id`, `nome`, `senha`, `sexo`) VALUES
(1, 'srthrsth', 'srth', 'M'),
(2, 'teste', 'teste', 'F'),
(3, '', '', 'M'),
(4, 'teste1', 'teste', 'F');

-- --------------------------------------------------------

--
-- Estrutura da tabela `dadosgerais`
--

DROP TABLE IF EXISTS `dadosgerais`;
CREATE TABLE IF NOT EXISTS `dadosgerais` (
  `NomeComp` varchar(100) NOT NULL,
  `NomeAbrev` varchar(50) NOT NULL,
  `DataFundacao` varchar(100) NOT NULL,
  `Estadio` varchar(100) NOT NULL,
  `CorOficial` varchar(50) NOT NULL,
  `Patrocinadores` varchar(500) NOT NULL,
  `CapacEstadio` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `dadosgerais`
--

INSERT INTO `dadosgerais` (`NomeComp`, `NomeAbrev`, `DataFundacao`, `Estadio`, `CorOficial`, `Patrocinadores`, `CapacEstadio`) VALUES
('Futbol Club Barcelona', 'FC Barcelona', '29/11/1899', 'Camp Nou Estadiun', 'Vermelho, Amarelo e Azul escuro', 'Atualmente são cinco empresas que estão associadas ao clube espanhol: a japonesa Rakuten, a americana Nike, a turca Beko e as espanholas Cupra e Asistencia Sanitaria.', '99.789 pessoas');

-- --------------------------------------------------------

--
-- Estrutura da tabela `historico`
--

DROP TABLE IF EXISTS `historico`;
CREATE TABLE IF NOT EXISTS `historico` (
  `TitulosConquist` varchar(100) NOT NULL,
  `ParticipacaoCompeticao` varchar(500) DEFAULT NULL,
  `Artilheiros` varchar(1000) NOT NULL,
  `MaioresVencedores` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `historico`
--

INSERT INTO `historico` (`TitulosConquist`, `ParticipacaoCompeticao`, `Artilheiros`, `MaioresVencedores`) VALUES
('ytjethte', 'rthtdh', 'wr6he', 'e6he5'),
('27 títulos', 'sem histórico', '99 partidas', '50 artilheiros');

-- --------------------------------------------------------

--
-- Estrutura da tabela `infocontato`
--

DROP TABLE IF EXISTS `infocontato`;
CREATE TABLE IF NOT EXISTS `infocontato` (
  `endereco` varchar(200) NOT NULL,
  `telefone` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `siteOficial` varchar(100) NOT NULL,
  `redesSociais` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `infocontato`
--

INSERT INTO `infocontato` (`endereco`, `telefone`, `email`, `siteOficial`, `redesSociais`) VALUES
('Av. Joan XXIII s/n 08028 Barcelona (Acces Nº 9)', '(+34) 902 1899 00', 'oab@fcbarcelona.cat', 'https://www.fcbarcelona.com/en/club/contact', '@fcbarcelona');

-- --------------------------------------------------------

--
-- Estrutura da tabela `infofinancas`
--

DROP TABLE IF EXISTS `infofinancas`;
CREATE TABLE IF NOT EXISTS `infofinancas` (
  `Receita` varchar(500) NOT NULL,
  `Despesa` varchar(500) DEFAULT NULL,
  `patriLiquid` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `infofinancas`
--

INSERT INTO `infofinancas` (`Receita`, `Despesa`, `patriLiquid`) VALUES
('rtbsrg', 'gaer', 'arege'),
('1,25 bilhões de euros', '440 milhões de euros', '810 milhões de euros');

-- --------------------------------------------------------

--
-- Estrutura da tabela `jogadores`
--

DROP TABLE IF EXISTS `jogadores`;
CREATE TABLE IF NOT EXISTS `jogadores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `idade` varchar(10) NOT NULL,
  `sexo` varchar(15) NOT NULL,
  `gols` varchar(100) NOT NULL,
  `data` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `jogadores`
--

INSERT INTO `jogadores` (`id`, `nome`, `idade`, `sexo`, `gols`, `data`) VALUES
(1, 'teste', '1', 'F', '1', '2024-09-04 10:38:21.448156'),
(2, 'sth', '4', 'M', '4', '2024-09-04 10:39:13.189562'),
(3, 'Junior', '17', 'M', '34', '2024-09-04'),
(4, 'Ronaldo Pikachu', '37', 'M', '100', '2024-09-04');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
