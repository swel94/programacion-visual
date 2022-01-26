#10.Generar las tablas de multiplicar de un rango especificado por el usuario.

numero1 = int(input("Digite el primer rango: "))
numero2 = int(input("Digite el segundo rango: "))


for n in range(numero1, numero2 + 1):
  print("--------------")
  for i in range(1,13):
    resultado = n * i
    print(n, "x", i, "=", resultado)
