//Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
//A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
//Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

//Entrada
Console.WriteLine(@$"
Bem vindo! Para iniciar o atendimento, escolha uma bebida do nosso menu:
'1' para Coca-Cola
'2' para Campari
'3' para suco de uva
'4' para cerveja
'5' para Red Bull
");

//Recebe a informação
char escolha = char.Parse(Console.ReadLine());

//Processamento
switch (escolha)
{
    case '1':
        char resposta;

        Console.WriteLine($"Deseja adicionar gelo e limão? Digite 's' para sim e 'n' para não.");
        resposta = char.Parse(Console.ReadLine());

        if (resposta == 's') 
        {
            Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
        }
        else
        {
            Console.WriteLine($"Apenas gelo? Digite 's' para sim e 'n' para não.");
            resposta = char.Parse(Console.ReadLine());

                if (resposta == 's')
                {
                    Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
                }
                else 
                {
                    Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
                }
        }
        break;

    case '2':
        char respostaC;

        Console.WriteLine($"Deseja que sirva como um negroni? Digite 's' para sim e 'n' para não.");
        respostaC = char.Parse(Console.ReadLine());

        if (respostaC == 's') 
        {
            Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
        }
        else
        {
            Console.WriteLine($"Deseja então adicionar apenas gelo? Digite 's' para sim e 'n' para não.");
            respostaC = char.Parse(Console.ReadLine());

                if (respostaC == 's')
                {
                    Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
                }
                else 
                {
                    Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
                }
        }
        break;

    case '3':
        char respostaS;

        Console.WriteLine($"Deseja adicionar gelo? Digite 's' para sim e 'n' para não.");
        respostaS = char.Parse(Console.ReadLine());

        if (respostaS == 's') 
        {
            Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
        }
        else
        {
            Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
        }
        break;

    case '4':
        Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
        break;

    case '5':
        char respostaR;

        Console.WriteLine($"Deseja que seja servido em um copo com gelo? Digite 's' para sim e 'n' para não.");
        respostaR = char.Parse(Console.ReadLine());

        if (respostaR == 's') 
        {
            Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
        }
        else
        {
            Console.WriteLine($"Ok :) Sua bebida chegará em breve!");
        }
        break;        
}

//Saída
Console.WriteLine($"Agradecemos a preferência, volte sempre!");
