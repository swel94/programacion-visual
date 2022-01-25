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
      if edad % 2 == 0:
        lista.append(edad) 
    #elif edad % 2 == 0 and edad >= 18:// Si una primera condicion se cumple se omite la parte inferior. Solucion un if anidado.
      #lista.append(edad)
    elif edad < 18:
      contador2 = contador2 + 1
      acumulador = acumulador + edad

print(contador1)
print(contador2)
print(acumulador)
print(lista)

        
        
      
