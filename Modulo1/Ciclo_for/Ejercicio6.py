#6.Generar las tablas de multiplicar del 1 al 5.

for n in range(1,6):
  print("------------------\n")
  for i in range(1,13):
   resultado = i * n
   print(i, "x", n, "=", resultado)
