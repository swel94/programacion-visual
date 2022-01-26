#9.Generar las tablas de multiplicar del 1 hasta el límite que el usuario desee.

limite = int(input("Digite hasta donde desea que las tablas se generen: "))

for n in range(1, limite + 1):
  print("--------------")
  for i in range(1,13):
    resultado = n * i
    print(n, "x", i, "=", resultado)
    
    
