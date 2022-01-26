#7.Generar las tablas de multiplicar del 1 al 5, excepto la del 2 y 3.

for n in range(1,6):
  if n in (1,4,5):
    print("----------")
    for i in range(1,13):
      resultado = n * i
      print(i, "x", n, "=", resultado)

print("Fin del programa")