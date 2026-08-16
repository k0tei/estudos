from random import randint

contador = 0
numero_secreto = randint(1, 100)

print("BEM VINDO AO NOSSO JOGO DE ADIVINHAR NUMEROS!!!")
print("YEYYYYYYYYYYYYYYYYYY")
print("O número secreto está entre 1 e 100")
print("Será que vc consegue acertar?")
print("Vamos começar!")
while True:
    try:
        palpite = int(input("Digite seu palpite: "))
        contador += 1
        print(f"Número de tentativas totais até o momento: {contador}")
        if(palpite < 1 or palpite > 100):
            print("Digite um valor entre 1 e 100")
            continue
        if (palpite == numero_secreto):
            print(f"Parabéns!!! Você acertou o numero: {numero_secreto}!")
            break
        elif (palpite < numero_secreto):
            print("O número secreto é maior do que seu palpite")
        else:
            print("O número secreto é menor do que seu palpite")
    except ValueError:
        print("O valor não é válido, tente novamente")
        continue