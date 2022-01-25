#Hacer un programa que permita digitar 7 personas (nombres) con sus edades.
#a)Cuantos hay mayores de edades
#b)Cuantas hay menores de edades
#c)Mostrar la sumatoria de las edades de los que son menores de edades
#d)Mostrar las edades mayores que sean pares

lista = []

acumulador = 0

contador1 = 0
contador2 = 0

for i in range(7):
    persona = str(input("Dime tu nombre: "))
    edad = int(input("Dime tu edad: "))
    if edad >= 18:
        contador1 = contador1 + 1
    elif edad % 2 == 0:
        lista.append(contador1)
    elif edad < 18:
        contador2 = contador2 + 1
        acumulador = acumulador + edad

print(lista)

        
        
      
