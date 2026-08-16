def acesso(nome, idade):
    if idade > 15 or nome == "Ana Silva" or nome == "Paulo Santos":
        print("Acesso liberado")
    else:
        print("Acesso negado")



nome = input("Digite seu nome: ")
idade = int(input("Digite sua idade: "))

acesso(nome, idade)

