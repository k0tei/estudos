curso = input("Digite seu curso: ").lower()
engenharias_permitidas = ["mecânica","elétrica","mecatrônica",
                          "mecanica", "eletrica","mecatronica"]

if curso in engenharias_permitidas:
    print("Acesso liberado")
else:
    print("Acesso negado")
