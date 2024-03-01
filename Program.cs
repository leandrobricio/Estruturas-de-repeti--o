string? opcao;
bool exibirMenu = true;
while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - apagar cliente");
    Console.WriteLine("4 - encerrar");


    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
          Console.WriteLine("Cadastro de cliente");
          break;


        case "2":
         Console.WriteLine("Busca de cliente");
         break;


        case "3":
        Console.WriteLine("Apagar cliente");
        break;

         case "4":
        Console.WriteLine("Encerrar");
        exibirMenu = false;

        break;

         default:
          Console.WriteLine("Opção invalida");
          break;
    }


    
    
        
        
    
}
    













































//int numero = 5;

//for(int contador = 0; contador <=10; contador++ )
//{
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}