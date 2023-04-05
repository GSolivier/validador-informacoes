// 1. Ler o nome inserido pelo usuário, e valida-lo para ser diferente de vazio.
// 2. Ler a idade inserida pelo usuário, ela tem que estar entre 0 e 100.
// 3. Perguntar o salário do usuário, ele tem que ser maior que zero.
// 4. Estado Civil: s - solteiro; c - casado; v - viuvo; d - divorciado.

Console.WriteLine($"Digite seu nome: ");
string? nome = Console.ReadLine();

while(nome.Length == 0)
{
    Console.WriteLine($"O nome não pode estar vazio. Digite novamente um nome válido: ");
    nome = Console.ReadLine();
}

Console.WriteLine($"Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

while(idade < 0 || idade > 100)
{
    Console.WriteLine($"Digite uma idade entre 0 e 100: ");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Informe a sua renda: ");
float salario = float.Parse(Console.ReadLine());

while(salario == 0)
{
    Console.WriteLine($"O salário não pode ser zero, digite um salário válido");
    salario = float.Parse(Console.ReadLine());
}

char civil;
bool loopBreak = true;

do
{

Console.WriteLine(@$"
      Informe seu estado civil:

        's' para Solteiro
        'c' para Casado
        'v' para Viúvo
        'd' para Divorciado
");

civil = char.Parse(Console.ReadLine().ToLower());

switch (civil)
{
    case 's':
    Console.Clear();
    Console.WriteLine($"CARREGANDO...");
    Thread.Sleep(3000);
    Console.Clear();    
    Console.WriteLine($"O usuário {nome}, com idade de {idade} anos, com o salario de {salario} reais, está atualmente solteiro.");
    loopBreak = false;
        break;

    case 'c':
        Console.Clear();
    Console.WriteLine($"CARREGANDO...");
    Thread.Sleep(3000);
    Console.Clear(); 
    Console.WriteLine($"O usuário {nome}, com idade de {idade} anos, com o salario de {salario} reais, está atualmente casado.");
    loopBreak = false;
        break;

    case 'v':    
    Console.Clear();
    Console.WriteLine($"CARREGANDO...");
    Thread.Sleep(3000);
    Console.Clear(); 
    Console.WriteLine($"O usuário {nome}, com idade de {idade} anos, com o salario de {salario} reais, está atualmente viúvo.");
    loopBreak = false;
        break;

    case 'd':
        Console.Clear();
    Console.WriteLine($"CARREGANDO...");
    Thread.Sleep(3000);
    Console.Clear(); 
    Console.WriteLine($"O usuário {nome}, com idade de {idade} anos, com o salario de {salario} reais, está atualmente divorciado.");
    loopBreak = false;
        break;

    default:
    Console.Clear();
    Console.WriteLine($"Resposta inválida. Digite uma letra válida.");
    loopBreak = true;
        break;
}
} while(loopBreak);

