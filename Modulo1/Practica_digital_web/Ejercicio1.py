#Pedir al usuario que digite la extensión de un archivo y decir el tipo de archivo. Utilizar al menos 7 extensiones diferentes (Contemplar mayúsculas y minúsculas). Mostrar un mensaje de notificación cuando la extensión digitada no está dentro del listado.


var = input("Favor digite la extension: ")
extensiones = var.lower()

if extensiones == "txt":
 print("Texto Plano")
elif extensiones == "pdf":
 print("Archivo PDF")
elif extensiones == "xml":
  print("archivo de lenguaje de marcado")
elif extensiones == "rar":
  print("formato de compresión desarrollado por WinRAR")
elif extensiones == "css":
  print("formato documento css")
elif extensiones == "html":
  print("formato documento html")
elif extensiones == "php":
  print("codigo php")
else:
  print("Extension digitada no valida")

print("Fin del programa")
