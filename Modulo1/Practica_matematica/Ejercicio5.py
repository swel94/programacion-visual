#Ejercicio 5 Realizar un programa para obtener el factorial de un número entero.

var = int(input("Ingrese un numero: "))

acum = 1

for y in range(var, 0, -1):
  acum = y * acum
    
print(acum)