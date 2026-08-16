tarefas = int(input("Digite o número de tarefas pendentes: "))
sobra = tarefas % 4
if(sobra > 0 ):
    print(f"Essa quantidade de tarefas precisa ser adiantada: {4 - sobra}")
else:
    print(f"Cada funcionário deve fazer {tarefas//4} tarefas")