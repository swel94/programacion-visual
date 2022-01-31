#3.Realizar un programa que calcule la cantidad de cervezas pedidas en un bar, mostrándole al cliente si desea comprar otra y tomando como referencia la cantidad de dinero que carga el cliente.

pedidas = 0
devuelta = 0
cerveza = 250



cartera = int(input("Cuanto dinero tiene usted?: "))

while cartera >= cerveza:
  pedidos = input("Desea un cerveza y / n?: ")
  if pedidos == "y":
    pedidas = pedidas + 1
    cartera = cartera - cerveza
  elif pedidos == "n":
    print("Gracias por su compra!")
    break

else:
  print("Vaya de ahi arrancao!")

print("El total de cervezas bebidas fueron" ,pedidas)
  

  
 
   

    

  



  
  
  


