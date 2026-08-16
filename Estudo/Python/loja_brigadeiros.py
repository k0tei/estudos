numero_brigadeiros = int(input("Digite quantos brigadeiros você vai comprar:\n"))
preco = float(input("Digite o preço de cada unidade: R$ "))
valor_final = numero_brigadeiros * preco

if numero_brigadeiros > 10:
    print(f"Você ganhou um desconto de: R$ {valor_final * 0.1:.2f}")
    print(f"O valor final de sua compra é: {valor_final * 0.9:.2f}")
else:
    print(f"O valor final de sua compra é: {valor_final:.2f}")