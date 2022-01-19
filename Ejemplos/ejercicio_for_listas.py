#Pedirle a un usuario que digite 10 numeros y al final mostrar los numeros pares.

lista = [] 

for i in range(10):
    num = int(input("Digite un numero: "))
    lista.append(num)
    
for i in lista:
    if i % 2 == 0:
        print("Los numeros son: ", i)
      