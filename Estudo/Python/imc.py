opcao = ""
nome = [], altura = [], peso = [], imc = []


while opcao != "sair":
    nome.append(input("Digite o nome para cadastro: "))
    altura.append(float(input("Digite a altura para cadastro: ")))
    peso.append(float(input("Digite o peso para cadastro: ")))
    imc.append(peso[-1] / altura[-1] **2)
    print(f"O seu IMC é: {imc[-1]:0.2f}")
    if imc[-1] < 18.5:
        print("Você está abaixo do peso ideal")
    elif imc[-1] < 25:
        print("Você está na faixa de peso ideal")
    elif imc[-1] < 30:
        print("Você está em sobrepeso")
    elif imc[-1] < 35:
        print("Você está com obesidade de grau 1")
    elif imc[-1] < 40:
        print("Você está com obesidade de grau 2")
    else:
        print("Você está com obesidade de grau 3")

    print("Você deseja continuar o cadastro de pessoas?")
    opcao = input("Digite aqui sua opção [ficar/sair]: ").lower()

print("Aqui está a lista de pessoas e IMCs cadastrados")

for i in range(len(imc)):
    print(f"{nome[i]}, {imc[i]:0.2f}")