%Leo la imagen
I = imread('macro.jpg');

%Paso a escala de grises
GRIS = rgb2gray(I);

%Reducir la resolucion de la imagen
I2 = imresize(I, 0.5);

%Muestro el histograma de la imagen en escala de grises
histograma = imhist(GRIS,256);

%Binariza a blanco y negro
nivel = 0.5; %Nivel entre 0 y 1
BW = im2bw(I,nivel);

%Muestro las figuras en una grafica
subplot(2,3,1), imshow(I), title('Original');
subplot(2,3,2), imshow(GRIS), title('Grises');
subplot(2,3,3), bar(histograma), title('Histograma');
subplot(2,3,4), imshow(BW), title('Blanco y Negro');
subplot(2,3,5), imshow(I2), title('Mitad resolucion');
