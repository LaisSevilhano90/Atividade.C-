// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//exer 1

// Console.WriteLine("Digite o nome do produto: ");
// string? nome = Console.ReadLine();

// Console.WriteLine("Digite a quantidade: ");
// int qnt = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o preço do produto: ");
// decimal precoUn = decimal.Parse(Console.ReadLine());

// decimal valorTotal = qnt * precoUn;

// Console.WriteLine($"Produto: {nome}");
// Console.WriteLine($"Quantidades: {qnt}");
// Console.WriteLine($"Preço por Un.: {precoUn:F2}");
// Console.WriteLine($"Valor Total: {valorTotal:C}");




// ------------------------------------------------------------- exer 2

// Console.WriteLine("Digite seu nome: ");
// string nomeAluno = Console.ReadLine();

// Console.WriteLine("Digite sua nota: ");
// int nota = int.Parse(Console.ReadLine());

// if(nota >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else if(nota >= 5 && nota < 7)
// {
//     Console.WriteLine("Recuperação");
// }
// else if(nota < 5)
// {
//     Console.WriteLine("Reprovado");
// }
// else if(nota > 10)
// {
//     Console.WriteLine("Nota inválida");
// }




// ------------------------------------------------------ exer 3

// int tentativa = 0;
// int numeroSecreto = 12;
// int contadorTentativ = 0;


// do
// {
//     Console.WriteLine("Digite seu palpite: ");
//     tentativa = int.Parse(Console.ReadLine());
//     contadorTentativ ++;

//     if(tentativa > numeroSecreto)
//     {
//         Console.WriteLine("Maior, digite um número menor");
//     }
//     else if (tentativa < numeroSecreto)
//     {
//         Console.WriteLine("Menor, digite um número maior");
//     }

// } while (tentativa != numeroSecreto);
// {
// Console.WriteLine($"Parabéns você acertouuu!!! depois de {contadorTentativ} tentativas");
// };



// ---------------------------------------------------------------------------- exer 4
// Console.WriteLine("Escolha a operação desejada:");
// Console.WriteLine("1 - Somar");
// Console.WriteLine("2 - Multiplicar");
// Console.Write("Opção: ");
// string opcao = Console.ReadLine();

// if (opcao != "1" && opcao != "2")
// {
//     Console.WriteLine("Opção inválida! O programa será encerrado.");
//     return;
// }

// Console.Write("\nDigite o primeiro número: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.Write("Digite o segundo número: ");
// double num2 = double.Parse(Console.ReadLine());

// if (opcao == "1")
// {
//     double resultadoSoma = Somar(num1, num2);
//     Console.WriteLine($"\nResultado da Soma: {resultadoSoma}");
// }
// else if (opcao == "2")
// {
//     double resultadoMultiplicacao = Multiplicar(num1, num2);
//     Console.WriteLine($"\nResultado da Multiplicação: {resultadoMultiplicacao}");
// }


// static double Somar(double a, double b)
// {
//     return a + b;
// }

// static double Multiplicar(double a, double b)
// {
//     return a * b;
// }

// ---------------------------------------------------------------------------- exer 5

// double[] notas = new double[3];

// Console.WriteLine("--- Cadastro de Notas ---");

// for (int i = 0; i < notas.Length; i++)
// {
//     Console.Write($"Digite a {i + 1}ª nota: ");
//     notas[i] = Convert.ToDouble(Console.ReadLine());
// }

// Console.WriteLine("\n--- Notas Cadastradas ---");

// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine($"Nota {i + 1}: {notas[i]}");
// }

// double soma = 0;

// foreach (double nota in notas)
// {
//     soma += nota;
// }

// double media = soma / notas.Length;

// Console.WriteLine("\n--- Resultado Final ---");
// Console.WriteLine($"Média das notas: {media:F2}");

// ---------------------------------------------------------------------------- exer 6

// List<string> produtos = new List<string>();

// Console.WriteLine("--- Cadastro de Produtos ---");
// for (int i = 1; i <= 3; i++)
// {
//     Console.Write($"Digite o nome do {i}º produto: ");
//     string item = Console.ReadLine();
//     produtos.Add(item);
// }

// Console.WriteLine("\n--- Produtos Cadastrados ---");
// foreach (string produto in produtos)
// {
//     Console.WriteLine($"- {produto}");
// }

// Console.WriteLine("\n--- Buscar Produto ---");
// Console.Write("Digite o nome do produto que deseja buscar: ");
// string produtoBusca = Console.ReadLine();

// if (produtos.Contains(produtoBusca))
// {
//     Console.WriteLine($"O produto '{produtoBusca}' está na lista!");
// }
// else
// {
//     Console.WriteLine($"O produto '{produtoBusca}' NÃO foi encontrado.");
// }

// Console.WriteLine("\n--- Remover Produto ---");
// Console.Write("Digite o nome do produto que deseja remover: ");
// string produtoRemover = Console.ReadLine();


// if (produtos.Remove(produtoRemover))
// {
//     Console.WriteLine($"Produto '{produtoRemover}' removido com sucesso.");
// }
// else
// {
//     Console.WriteLine($"Não foi possível remover: '{produtoRemover}' não estava na lista.");
// }

// Console.WriteLine("\n--- Lista de Produtos Atualizada ---");
// if (produtos.Count > 0)
// {
//     foreach (string produto in produtos)
//     {
//         Console.WriteLine($"- {produto}");
//     }
// }
// else
// {
//     Console.WriteLine("A lista está vazia.");
// }