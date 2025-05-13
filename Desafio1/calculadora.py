def repetir():
    outra_op = input("Deseja fazer outra operação? (s/n)")

    if outra_op == "s":
        calculadora()
    elif outra_op == "n":
        print("Fim do programa")
    else:
        repetir()

def calculadora():
    try:
        num1 = int(input('Digite o primeiro número: '))
        num2 = int(input('Digite o segundo número: '))
        operador = input("Qual operação deseja realizar? (+, -, *, /)")
        
        if operador == "+":
            print(num1+num2)

        elif operador == "-":
            print(num1-num2)

        elif operador == "*":
            print(num1*num2)

        elif operador == "/":
            if num2 == 0:
                print("Não é possivel dividir por 0")
                repetir()
            else:
                print(num1/num2)

        else:
            print('Insira um operador válido')
    except ValueError:
        print("Digite um número válido")
    repetir()

calculadora()