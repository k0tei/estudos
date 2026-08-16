media = 0
lista_temperaturas = []
for i in range(7):
    try:
        temperatura_coletada = float(input(f"Digite a média da temperatura do dia {i+1}: "))
        lista_temperaturas.append(temperatura_coletada)
        media += lista_temperaturas[i]
    except ValueError:
        print("Digite um valor valido")

media /= 7
print(f"Lista de temperaturas: {lista_temperaturas}")
print(f"A média das temperaturas coletadas na semana é {media:.1f}")

for i in range(len(lista_temperaturas)):
    if(lista_temperaturas[i] > media):
        print(f"A temperatura do dia {i+1} é maior do que média semanal: {media}")