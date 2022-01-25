
#Digitar la informacion necesaria 
nombre = input("Digita tu nombre: ")
edad = int(input("Digita tu edad: "))
while edad < 1 or edad > 120:
  edad = int(input("Digita un numero entre 1 y 120: "))
numero1 = int(input("Ingrese el primer numero: "))
numero2 = int(input("Ingrese el segundo numero: "))

suma = 1
resta = 2
multiplicacion = 3
division = 4

print("1.suma\n","2.resta\n","3.multiplicacion\n","4.division")

operacion = int(input("Ingrese la operacion que desea realizar: "))

while operacion < 1 or operacion > 4:
  operacion = int(input("Opcion no valida ingrese un numero entre 1 y 4: "))

if operacion == 1:
    operacion = numero1 + numero2
    print("La suma de",numero1,"y",numero2,"es igual a", operacion)
elif operacion == 2: 
    operacion = numero1 - numero2
    print("La resta de",numero1,"y",numero2,"es igual a", operacion)
elif operacion == 3:
    operacion = numero1 * numero2
    print("La multiplicacion de",numero1,"y",numero2,"es igual a", operacion)
elif operacion == 4:
    operacion = numero1 // numero2
    print("La division de",numero1,"y",numero2,"es igual a", operacion)




 

    