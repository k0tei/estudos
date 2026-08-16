usuario_correto = "deusgamer"
senha_correta = "123123"

usuario = input("Digite o seu nome de usuário: ").lower().strip()
senha = input("Digite sua senha: ").lower().strip()

if usuario == usuario_correto and senha == senha_correta:
    print("OI")
elif usuario != usuario_correto:
    print("Usuário incorreto")
elif senha != senha_correta:
    print("Senha incorreta")