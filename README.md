# pg-pp4
Criação e visualização de uma cena 3D utilizando Unity e Blender.

<img src="https://i.ibb.co/fDFTpB1/cena.png" alt="Cena 3D em que um avião e um helicóptero voam na mesma direção."/>

## Especificações do Projeto
<p>Projeto desenvolvido para curso de Processsamento gráfico por:</p>

<ul>
  <li>
    Gustavo Barbosa Santos - <b>RA: 759474</b>
  </li>
  <li>
    Lucas Eduardo Pereira de Oliveira - <b>RA: 760928</b>
  </li>
</ul>

<p align = "justify">
  Foram utilizados de forma majoritária 2 softwares, o <a href="https://www.blender.org/download/" target="_blank"><i>Blender</i></a> em sua versão 2.93.5 para a modelagem dos objetos e a <a href="https://unity3d.com/pt/get-unity/download" target="_blank"><i>Unity</i></a> em sua versão 2020.3.21f1 para a disposição dos objetos na cena e criação de uma interação através de scripts na linguagem C#.
</p>

<p><b>Passos para abrir o projeto:</b></p>

<ol>
  <li>Realizar o download do último <i>release</i></li>
  <li>Extrair o código fonte do arquivo compactado</li>
  <li>Abrir a aplicação Unity</li>
  <li>Realizar a importação da pasta descompactada que contém o código fonte na Unity</li>
</ol>

## PP3

<ol>
  <li>Visualização de 2 objetos 3D, redimensionando e posicionando cada objeto individualmente no ambiente virtual</li>
  <li>Definição de pelo menos uma câmera</li>
</ol>

## PP4

<ol>
  <li>Inclusão de pelo menos três movimentos, sendo pelo menos um deles dependente de outro</li>
  <li>Definição de pelo menos duas câmeras</li>
  <li>Alteração da projeção de uma das câmeras</li>
  <li>Definição de interações que alteram câmeras e movimentos</li>
</ol>

## Interação

<p align = "justify">
  Visualização interativa da cena em 3D, para isso basta ativar o modo de jogo da Unity e utilizar as teclas <b>W A S D</b> do teclado para se movimentar através do ambiente e a manipulação do <b>eixo X</b> do mouse para rotacionar a câmera alterando assim o ângulo de visão da câmera. A interação foi baseada na movimentação de jogos <i>First Person Shooter (FPS)</i>. Também é possível durante o modo jogo alterar a projeção da câmera principal de perspectiva (inicial) para ortográfica utilizando a tecla <b>P</b> do teclado, assim como é possível mudar a visualização da cena alternarnando entre a câmera principal e a câmera secundária localizada no helicóptero com a tecla <b>C</b>.
</p>

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
