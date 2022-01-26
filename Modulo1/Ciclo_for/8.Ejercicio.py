#8.Generar las tablas de multiplicar de los números pares del 1 al 8.

for n in range(1,9):
  print("-----------")
  for i in range(1,13):
      resultado = n * i
      if i % 2 == 0:
       print(i, "x", n, "=", resultado)