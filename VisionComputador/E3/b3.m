%Leo la imagen
I = imread('keyb.jpg');
%Paso a escala de grises
A = rgb2gray(I);

%Calculo el sobel vertical
bv = edge(A,'sobel','vertical');

%Calculo sobel horizontal
bh = edge(A,'sobel','horizontal');

%Calculo sobel 
bt = edge(A,'sobel','Sobel');

%Pintar imagenes
subplot(2,2,1), imshow(A), title('Imagen Original');
subplot(2,2,2), imshow(bv), title('Imagen Sobel vertical');
subplot(2,2,3), imshow(bh), title('Imagen Sobel horizontal');
subplot(2,2,4), imshow(bt), title('Imagen Sobel');

%Operador LoG
%Defino sigma y thresh
sigma = 1;
thresh = 0.05;
LoG = edge(A, 'log',thresh, sigma);
%Muestro el resultado
figure;
imshow(LoG);title('Operador LoG')
