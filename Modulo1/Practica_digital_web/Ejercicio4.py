#4. Hacer el proceso de registro de usuario y login.

print("Registro\n")

nombre = input("Ingresa tu nombre: ")
apellido = input("Ingresa tu apellido: ")
email = input("Ingresa el correo electronico: ")
contraseña = input("Ingresa la contraseña: ")
fecha_compleños = (input("Ingresa tu fecha de cumpleaños: "))
sexo = input("Ingresa tu sexo: ")

login = input("Desea acceder a su cuenta? y / n: ")
if login == "y":
  input("Ingresa tu correo: ")
  input("Ingresa tu contraseña: ")
  print("Bienvenido!")
elif login == "n": 
  print("Fin del programa")    