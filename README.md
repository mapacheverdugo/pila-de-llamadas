Lenguajes de programación - Trabajo computacional 2
========================================

## I. Funciones recursivas

Este proyecto busca desarrollar una aplicación que, sin usar variables globales, incluya funciones recursivas para:

### 1. Cambio a base 10

Convertir un entero no negativo n, expresado en una base entera b menor que 10, en su equivalente numérico en base 10. Comprobar con `n = 4210321` y `b = 5`.

### 2. Pirámide de esferas

Determinar la cantidad de bolas de acero necesarias para construir una pirámide de base cuadrada y n niveles, de modo que en su cima haya una bola apoyada sobre otras cuatro, las cuales estén apoyadas sobre otras nueve, las cuales estén apoyadas sobres otras dieciséis, y asi sucesivamente. Comprobar con `n = 9`

### 3. Nodos de un bi-árbol

Determinar el número de nodos de un bi-árbol binario, el cual se define como

`N(i, j) = N(i-1, j) + 1 + N(i, j-1)` si `i >= 1` y `j >= 1`

`N(0, j) = N(i, 0) = 1` si `i = 0` ó `j = 0`

Comprobar con `i = 4` y `j = 4`.

### 4. Grupos de personas

Obtener la cantidad total de grupos diferentes de k personas que es posible formar con n personas, está dado por la recurrencia:

`0` si `k > n`

`G(n, k) = n` si `k = 1`

`G(n−1, k) + G(n−1, k−1)` si `k <= n`

Comprobar con `n = 6` y `k = 3`.

### 5. Producto de Wallis

Obtener el producto de Wallis, el cual resulta en π/2 cuando n tiende a infinito, y se define como:

`W(n) = 1` si `n = 0`

`W(n) = W(n/(n+1)) * W(n-1)` si `n` es par

`W(n) = W((n+1)/n) * W(n-1)` si `n` es impar

Comprobar con `n = 20`.

## II. Representación gráfica

La aplicación incluirá el código necesario para representar gráficamente los cambios que va experimentando el pila de llamadas a medida que avanza la ejecución de cada una de las funciones solicitadas. Esto significa dibujar la pila con cada nuevo registro, y, con cada `Enter`, desplegar gradual y dirigidamente su crecimiento y decrecimiento.
Todo con el proposito de ejecutar la aplicación con los **datos a comprobar indicados** para cada una de las funciones solicitadas, y determinar:
* La máxima cantidad de registros de activación contenidos en la pila.
* La cantidad total de registros de activación generados.
* La cantidad de memoria en bytes que demanda la representación de la pila de registros de activación.

------------------

#### Autores:
- **Jorge Verdugo** ([@mapacheverdugo](https://github.com/mapacheverdugo/))
- **Javiera Vergara** ([@PollitoMayo](https://github.com/PollitoMayo/))

*Lenguajes de programación*

*Segundo semestre, 2017.*

*Facultad de Ingeniería*

*[Universidad Tecnológica Metropolitana](http://www.utem.cl)*
