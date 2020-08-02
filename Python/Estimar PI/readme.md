# Calculo del número PI utilizando simulaciones de MonteCarlo
Se puede aproximar el nº PI utilizando simulaciones de Montecarlo, para ello se puede generar un circulo de radio 1 y meterlo dentro de un cuadrado de 2x2. Y lanzando agujas dentro del cuadrado, podemos ver cuantas han caido dentro del circulo.
## 1. Primero vamos a partir de las formulas necesaria:
* El area de un cuadrado es **Base * Altura**. En este caso es **2*2 = 4**.
* El área de un circulo es **PI * Radio^2**. En este caso es **PI*1^2 = PI**.

## 2. Ahora vamos a ver como calcular PI utilizando la estadistica.
Si lanzamos una cantidad N de agujas dentro del cuadrado se puede calcular la probabilidad de que la agujas caigan dentro del circulo, contando cuantas agujas de las que se ha tirado han caido dentro.  
Esta probabilidad es:   
* **Nº de agujas dentro del circulo / Nº agujas lanzadas.**  

Esta probabilidad tambien será igual a:  
* **Area del circulo / Area del cuadrado** => **(PI / 4)**  

Por tanto obtenemos:  
* **Probabilidad aguja dentro del circulo = PI / 4**  
* De la formula de arriba se deduce: **PI = Probabilidad aguja dentro del circulo * 4**