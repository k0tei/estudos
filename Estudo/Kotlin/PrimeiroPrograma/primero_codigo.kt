 //TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
fun main() {
    for (i in 1..10 step 3)
    {
        println("Contagem ${i}")
    }

    var numero = 999
    while (numero != 0 && numero > 0){
        println("Digite um número aleatório")
        numero = readln().toInt()
        when(numero) {
            1 -> println("First")
            2 -> print("Second")
            else -> {
                println("Número inválido")
                println("Saindo do laço")
                break
            }
        }
    }

    println("Digite um dia da semana")
    var diaDaSemana = readln().toInt()
    when(diaDaSemana){
        1 -> println("Segunda-feira")
        2 -> println("Terça-feira")
        3 -> println("Quarta-feira")
        4 -> println("Quinta-feira")
        5 -> println("Sexta-feira")
        6 -> println("Sábado")
        7 -> println("Domingo")
        else -> {
            println("Dia inválido")
            diaDaSemana = 0
        }
    }
}
