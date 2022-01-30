#3.Realizar un programa que calcule la cantidad de cervezas pedidas en un bar, mostrándole al cliente si desea comprar otra y tomando como referencia la cantidad de dinero que carga el cliente.

acumulador = 0
cerveza = 250
acumulador2 = 3000

pedido = int(input("Ingrese la cantidad de cervezas que desea:  "))

while pedido > 0:
  acumulador = acumulador + pedido
  otra = input("Desea otra cerveza? y o n: ")
  if otra == "y":
    pedido = int(input("Ingrese la cantidad de cervezas que desea: "))
  elif otra == "n":
    print("El total de cervezas son: ", acumulador)
    print("Gracias por su compra")
   

    

  



  
  
  


