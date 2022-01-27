#2.Realizar un programa que haga que el usuario sólo digite 2 números positivos.

n1 = int(input("Ingresa un numero: "))
while n1 < 0:
  n1 = int(input("Ingresa un numero positivo: "))

n2 = int(input("Ingres un segundo numero: "))
while n2 < 0:
  n2 = int(input("Ingres un segundo numero positivo: "))

print("Fin del programa")  

