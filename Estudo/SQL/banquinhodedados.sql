CREATE DATABASE IF NOT EXISTS DesenvolvimentoJogos;
USE DesenvolvimentoJogos;

-- Tabela de jogadores
CREATE TABLE Jogadores (
    id_jogador INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    email VARCHAR(50) UNIQUE NOT NULL,
    data_cadastro DATE DEFAULT CURRENT_DATE
);

-- Tabela de jogos
CREATE TABLE Jogos (
    id_jogo INT AUTO_INCREMENT PRIMARY KEY,
    nome_jogo VARCHAR(50) NOT NULL,
    genero VARCHAR(30),
    data_lancamento DATE
);

-- Tabela de pontuações
CREATE TABLE Pontuacoes (
    id_pontuacao INT AUTO_INCREMENT PRIMARY KEY,
    id_jogador INT,
    id_jogo INT,
    pontos INT NOT NULL,
    data_pontuacao DATE DEFAULT CURRENT_DATE,
    FOREIGN KEY (id_jogador) REFERENCES Jogadores(id_jogador),
    FOREIGN KEY (id_jogo) REFERENCES Jogos(id_jogo)
);

CREATE TABLE AuditoriaPontuacao (
  id INT NOT NULL AUTO_INCREMENT KEY,
  antiga_pontuacao INT,
  nova_pontuacao INT,
  data_alteracao DATETIME DEFAULT CURRENT_TIMESTAMP,
  id_pontuacao INT,
  id_jogador INT,
  id_jogo INT,
  FOREIGN KEY (id_pontuacao) REFERENCES Pontuacoes(id_pontuacao),
  FOREIGN KEY (id_jogador) REFERENCES Jogadores(id_jogador),
  FOREIGN KEY (id_jogo) REFERENCES Jogos(id_jogo)
);

-- TRIGGERS

DELIMITER $$

CREATE TRIGGER trAlteracaoPontuacao
AFTER UPDATE ON Pontuacoes
FOR EACH ROW 
BEGIN
  INSERT INTO AuditoriaPontuacao (
    id_pontuacao, id_jogador, id_jogo, 
    antiga_pontuacao, nova_pontuacao, data_alteracao
  )
  VALUES (
    OLD.id_pontuacao, OLD.id_jogador, OLD.id_jogo,
    OLD.pontos, NEW.pontos, NOW()
  );
END$$

DELIMITER ;
-- Inserindo alguns jogadores
INSERT INTO Jogadores (nome, email) VALUES
    ('nome falso', '@email.com'),
    ('nome falso', '@email.com'),
    ('nome falso', '@email.com');

-- Inserindo alguns jogos
INSERT INTO Jogos (nome_jogo, genero, data_lancamento) VALUES
    ('Space Adventure', 'Aventura', '2024-01-10'),
    ('Battle Royale', 'FPS', '2023-06-15'),
    ('Puzzle Master', 'Quebra-Cabeça', '2022-09-01');

-- Inserindo algumas pontuações
INSERT INTO Pontuacoes (id_jogador, id_jogo, pontos) VALUES
    (1, 1, 1500),
    (2, 1, 1800),
    (1, 2, 2000),
    (3, 2, 1700),
    (2, 3, 1200),
    (3, 3, 1300);
    
UPDATE Pontuacoes
SET pontos = 1550
WHERE id_pontuacao = 1;

SELECT * FROM AuditoriaPontuacao;


