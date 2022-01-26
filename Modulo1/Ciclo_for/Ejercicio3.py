#3.Pedir al usuario digitar el principio y el final de un rango. Mostrar los números de ese rango.

numero1 = int(input("Ingresa el rango inicial: "))
numero2 = int(input("Ingresa el rango final: "))

for i in range(numero1,numero2 + 1):
  print(i)