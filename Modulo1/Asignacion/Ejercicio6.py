#6.Utilizar un acumulador para calcular la ganancia de un local en 6 meses.

acumulador = 0

print("Vamos a calcular las ganacias de tu negocio en los ultimos 6 meses!\n")
for i in range(1,7):
 meses = int(input("Ingrese cantidad: "))
 acumulador = acumulador + meses
 ganancias = acumulador * .20
 
print("Las ganacias totales son: ", ganancias, "$")

