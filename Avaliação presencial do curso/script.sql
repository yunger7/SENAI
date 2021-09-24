CREATE DATABASE techman;

USE techman;

CREATE TABLE perfis(
  id_perfil INT NOT NULL AUTO_INCREMENT,
  perfil VARCHAR(25) NOT NULL,
  PRIMARY KEY (id_perfil)
);

INSERT INTO
  `perfis` (`id_perfil`, `perfil`)
VALUES
  (1, 'Comum'),
  (2, 'Administrador'),
  (3, 'Tecnico'),
  (4, 'Gerente');

CREATE TABLE equipamentos(
  id_equipamento INT NOT NULL AUTO_INCREMENT,
  equipamento VARCHAR(150) NOT NULL,
  imagem VARCHAR(100) NOT NULL,
  descricao VARCHAR(200) NOT NULL,
  ativo INT NOT NULL,
  data DATETIME NOT NULL,
  PRIMARY KEY (id_equipamento)
);

INSERT INTO
  `equipamentos` (
    `id_equipamento`,
    `equipamento`,
    `imagem`,
    `descricao`,
    `ativo`,
    `data`
  )
VALUES
  (
    1,
    'Torno Mecanico 500mm Modelo BV20L 220V - TTM520 - Tander',
    'Torno_Mecanico_500mm.png',
    'O Torno Mecanico Tander TTM520 e uma ferramenta utilizada por varios profissionais na confeccao e acabamento de inumeras pecas metalicas, tais como: eixos, polias, pinos, roscas, pecas cilindricas internas e externas, cones, esferas, entre outros. 
Este torno vem com motor monofesico de 220V e 550W de potencia, o que lhe confere maior torque e vida util, menor consumo de energia e baixo indice de manutencao. 
Possui interruptor magnetico com a funcao de travagem de emergencia, rotacao frente/reversa e a funcao de protecao ao torno e aos componentes eletricos.',
    1,
    '2019-10-01 14:54:20'
  ),
  (
    2,
    'Processador Intel Core i9-7920X Skylake, Cache 16.5MB, 2.9GHz (4.3GHz Max Turbo), LGA 2066 - BX80673I97920X',
    'Intel_Core_i9.png',
    'Com esse processador inovador e incrivel voce desfruta ao maximo o verdadeiro potencial do seu computador e desfruta da mais pura velocidade. Maximize o seu desempenho seja trabalhando, jogando, navegando ou assistindo o seu filme preferido, com esse processador voce pode tudo!',
    1,
    '2019-10-01 15:00:20'
  ),
  (
    3,
    'Monitor, Dell, U2518D, UltraSharp, Preto e Suporte em Aluminio, 25',
    'Monitor_Dell.png',
    'De vida ao seu trabalho com uma tela de 25 polegadas quase sem bordas que conta com detalhes em cores vividas e consistentes gracas a tecnologia hdr, resolucao qhd e angulo de visao ultra-amplo. Aumente sua performance com os recursos dell display manager, dell easy arrange e trabalhe confortavelmente graca a um suporte totalmente ajustavel e recurso confortview.',
    0,
    '2018-10-01 10:00:20'
  ),
  (
    4,
    'Mouse Gamer Razer Deathadder Essential optico 5 Botoes 4G 6.400 DPI',
    'Mouse_Razer.png',
    'Nada melhor do que um mouse gamer com tecnologia de ponta para qualificar seus comandos e aprimorar suas jogadas nos games. Com este Mouse Gamer Razer, sua atuacao nas batalhas gamers serao ainda mais bem-sucedidas, com desempenho acima da media e desenvoltura arrasadora, que vai deixar seus oponentes impressionados. O mouse Razer Deathadder Essential tem sensor optico de 6400 DPI de 4G, 5 botoes, design moderno e ergonomico, especialmente projetado para jogadores destros, e uma empunhadura lateral emborrachada que garante mais firmeza ao manuseio do equipamento, melhorando as respostas obtidas pelos players. O mouse Razer ainda oferece ajuste de sensibilidade, pezinhos Ultraslick silenciosos, cabo ultra resistente de fibra trancada e Modo Always-On, que mantem o mouse ligado mesmo quando o equipamento estiver inativo. E um mouse gamer Razer para ninguem botar defeito, com todas as funcoes e especificacoes tecnicas que voce precisa para ter mais produtividade nos jogos. O Razer Deathadder Essential e realmente essencial e ainda tem o diferencial de estar habilitado para Razer Synapse 3 e de ser compativel com PC e Mac, com porta USB. Conheca o modelo e faca um investimento seguro!',
    1,
    '2017-10-01 09:00:20'
  ),
  (
    5,
    'All-in-One Media Keyboard',
    'Teclado_Microsoft.png',
    'O All-in-One Media Keyboard e o dispositivo ideal para sua sala ou home office. Com teclado em tamanho natural e trackpad multitoque integrado, e possivel digitar, passar o dedo, arrastar, fazer zoom e clicar facilmente. O teclado com teclas de atalho de media personalizaveis permite que a Web e suas musicas, fotos e filmes favoritos estejam a seu alcance. O teclado tambem tem um design resistente, portanto, nao e necessario se preocupar com esbarroes, quedas ou derramamentos comuns. O All-in-One Media Keyboard e tudo o que voca precisa para digitar confortavelmente e navegar sem esforco.',
    0,
    '2017-10-01 13:00:00'
  );

CREATE TABLE usuarios(
  id_usuario INT NOT NULL AUTO_INCREMENT,
  senha VARCHAR(50) NOT NULL,
  fk_id_perfil INT NOT NULL,
  PRIMARY KEY (id_usuario),
  FOREIGN KEY (fk_id_perfil) REFERENCES perfis(id_perfil)
);

INSERT INTO
  `usuarios` (`id_usuario`, `senha`, `fk_id_perfil`)
VALUES
  (1, '111111', 1),
  (2, '212121', 2),
  (3, '414141', 4),
  (4, '313131', 3);

CREATE TABLE comentarios(
  id_comentario INT NOT NULL AUTO_INCREMENT,
  comentario VARCHAR(200) NOT NULL,
  data DATETIME NOT NULL,
  fk_id_equipamento INT NOT NULL,
  fk_id_perfil INT NOT NULL,
  PRIMARY KEY (id_comentario),
  FOREIGN KEY (fk_id_equipamento) REFERENCES equipamentos(id_equipamento),
  FOREIGN KEY (fk_id_perfil) REFERENCES perfis(id_perfil)
);

INSERT INTO
  `comentarios` (
    `id_comentario`,
    `comentario`,
    `data`,
    `fk_id_equipamento`,
    `fk_id_perfil`
  )
VALUES
  (
    1,
    'Devera fazer o download do aplicativo da razer para alterar a cor do mouse.',
    '2020-09-07 18:00:00',
    4,
    4
  ),
  (
    2,
    'Problema de aquecimento no processador apos 1 ano de uso.',
    '2020-05-04 07:30:00',
    2,
    2
  );