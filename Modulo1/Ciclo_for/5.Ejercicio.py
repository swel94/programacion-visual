#.5 Generar la tabla de multiplicar pidiendo al usuario que digite el valor.

n = int(input("Digite un valor para la tabla: "))

for i in range(1,13):
  resultado = i * n
  print(i, "x", n, "=", resultado)

