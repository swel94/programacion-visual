#3 Hacer un programa que confirme que las dos contraseñas ingresadas por un usuario son iguales. Mostrar un mensaje de éxito cuando sean iguales. En caso contrario, pedir al usuario que intente nuevamente hasta que sean iguales.

con1 = input("Ingresa la contraseña: ")
con2 = input("Confirma la contraseña: ")

while con2 != con1 :
  print("La contraseña no coincide")
  con2 = input("Confirma la contraseña: ")

print("Acceso otorgado")  