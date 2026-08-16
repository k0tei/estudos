opcao = 0
saldo = 0

def ver_saldo(saldo):
    print(f"Seu saldo é {saldo}")
def depositar(saldo):
    try:
        deposito = float(input("Digite quanto você quer depositar: "))
        return deposito
    except:
        print("tente novamente")
        return 0
def sacar(saldo):
    saque = float(input("Digite quanto você quer sacar: "))
    if(saque > saldo):
        print(f"Não foi possivel realizar o saque. Saldo insuficiente. ")
        return 0
    else:
        print(f"Você sacou {saque}")
        return saque


while(opcao != 4):
    print("---------------------")
    print("-     BANCO         -")
    print("---------------------")
    print("Escolha sua opção:")
    print("1. Ver saldo")
    print("2. Depositar")
    print("3. Sacar")
    print("4. Sair")
    print("---------------------")
    opcao = int(input("Digite sua opção: "))
    print(opcao)
    match opcao:
        case 1:
            ver_saldo(saldo)
        case 2:
            saldo += depositar(saldo)
        case 3:
            saldo -= sacar(saldo)
        case 4:
            break
        case _:
            print("Opção invalida, tente novamente.")


