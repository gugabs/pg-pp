# pg-pp3
Criação e visualização de uma cena 3D utilizando Unity e Blender.

<img src="https://i.ibb.co/fDFTpB1/cena.png" alt="Cena 3D em que um avião e um helicóptero voam na mesma direção."/>

## Especificações do Projeto
<p>
  Projeto desenvolvido para curso de Processsamento gráfico por:
  <ul>
    <li>
      Gustavo Barbosa Santos, <b>RA:759474</b>
    </li>
    <li>
      Lucas Eduardo Pereira de Oliveira, <b>RA:760928</b>
    </li>
  </ul>
</p>

<p align = "justify">
  Foram utilizados de forma majoritária 2 softwares, o <a href="https://www.blender.org/download/" target="_blank"><i>Blender</i></a> em sua versão 2.93.5 para a modelagem dos objetos e a <a href="https://unity3d.com/pt/get-unity/download" target="_blank"><i>Unity</i></a> em sua versão 2018.4.28f1 para a disposição dos objetos na cena e criação de uma interação através de scripts na linguagem C#.
</p>

## Interação

Visualização interativa da cena em 3D, para isso basta ativar o modo de jogo da Unity e utilizar as teclas `W` `A` `S` `D` do teclado para se movimentar através do ambiente e a manipulação do `eixo X` do mouse para rotacionar a câmera alterando assim o ângulo de visão da câmera. A interação foi baseada na movimentação de jogos <i>First Person Shooter (FPS)</i>.

## Principais Características

<p align = "justify">
  Criamos dois objetos, um avião e um helicóptero, no avião utilizamos uma malha geométrica tetraédrica, e no helicóptero usamos a malha mista.
</p>
<p align = "justify">
  Para modelagem utilizamos <i>Constructive Solid Geometry (CSG)</i>, em ambos os objetos partimos de objetos geométrico e fomos os modificando para obter o formato que desejávamos, no caso do helicóptero partes como corpo e hélices foi partindo de um cubo, já o esqui e as partes de conexão com as hélices vieram de cilindros, e a parte de “vidro” originou de uma esfera, no caso do avião ele todo foi gerado a partir de um cubo com exceção das turbinas que foram geradas por cilindros.
</p>
<p align = "justify">
  Utilizamos para criar os objetos o <i>Blender</i> e para criar a cena o <i>Unity</i> e em ambos escolhemos utilizar o sistema de coordenadas de Mundo ou Cena, o <i>World Coordinate System (WCS)</i>, pois além do fato dele ser o padrão nas duas ferramentas que usamos, era o que melhor se encaixava no nosso objetivo.
</p>
<p align = "justify">
  Na composição da cena queríamos manter a naturalidade dos objetos, então para isso escolhemos a Projeção Perspectiva, então construímos com ambos os objetos de frente para câmera mas com pontos de fuga diferentes, para parecer que estão em direções diferentes, além disso aplicamos dois pontos de luz para melhorar a visualização dos objetos, outro motivo para utilizar este tipo de projeção é para não perder a perspectiva de tamanho ao se comparar um avião com um helicóptero.
</p>
