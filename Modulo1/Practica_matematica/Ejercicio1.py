#Ejercicio Hacer un programa que diga si un número digitado es par o impar.

#Veamos el caso más sencillo. El operador mod que se representa con % te da el sobrante de la división entera de un número entre otro (sin meternos en detalles matemáticos).

#Por lo tanto, 5 mod 2 resulta en 1, pues al dividir 5 (impar) entre 2 el resultado es 2 y sobra 1. Caso contrario cuando, por ejemplo, hacemos un 10 mod 2 en donde sobra 0

numero = int(input("Digite un número: "))

if numero % 2 == 0:
  print("El número es par")
else:
  print("El numero es impar")  

  
