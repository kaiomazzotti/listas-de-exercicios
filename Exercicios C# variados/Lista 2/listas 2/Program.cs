using System.Diagnostics.CodeAnalysis;

#region exercicio 6
//exercicio 6
int numero;
int num;
int digito;
int soma = 0;
Console.WriteLine("programa de multiplicação por 11 !!");
Console.Write("informe o número de 2 digitos para multiplicarmos por 11:  ");
num = Convert.ToInt32(Console.ReadLine());
numero = num;
while (numero > 0)
{
    digito = numero % 10;
    soma = soma + digito;
    numero = numero / 10;
}
if (soma > 9)
{
    Console.WriteLine("a multiplicação por 11 deu: " + (num / 10 + 1) + (soma % 10) + (num % 10));
}
else
{
    Console.WriteLine("a multiplicação por 11 deu: " + (num / 10) + (soma) + (num % 10));
}

Console.ReadKey();
#endregion

#region  exercicio 2

////Exercício dois
//double c1 = (26.0 + 115.0);
//double c2= (20.0 / (-2.0) / 5.0);
//double c3=(20.0 / 22.0);
//double c4 = ((3.0 + 9.0) / 34.0);
//double c5 = ((56.0 / (3.0 + 2.0) - 154.0) / 6.0 - 4.0);
//double c6= (4.0 + 322.0 - 72.0 / (9.0 - 2.0)); 

//Console.WriteLine("operações matemáricas: ");
//Console.WriteLine("26 + 115: " + c1);
//Console.WriteLine("20/(-2)/5: " + c2);
//Console.WriteLine("20/22: " + c3 );
//Console.WriteLine("(3+9)/34: " + c4);
//Console.WriteLine("(56/(3+2)-154)/6-4: " + c5);
//Console.WriteLine("4+322-72/(9-2): " + c6);
//Console.ReadKey();

#endregion

#region exercicio 4

//Console.WriteLine("escreva o seu nome: ");
//string nome = Console.ReadLine();   
//Console.WriteLine("escreva o seu sobrenome: ");
//string sobrenome = Console.ReadLine();
//int nomelength = nome.Length;
//int sobrenomelength = sobrenome.Length;
//Console.WriteLine("Suas letras finais são: " + nome[nomelength-1] + ". e " + sobrenome[sobrenomelength-1] + ". ");
#endregion

#region exercicio 3
//Console.WriteLine("escreva o seu nome: ");
//string nome = Console.ReadLine();
//Console.WriteLine("escreva o seu sobrenome: ");
//string sobrenome = Console.ReadLine();

//Console.WriteLine("Suas letras iniciais são: " + nome[0] + ". e " + sobrenome[0] + ". ");
#endregion

#region exercicio 1

//Console.WriteLine("FOTOSSÍNTESE");
//Console.ReadKey();
//Console.Clear();
//Console.WriteLine("A água e os sais minerais absorvidos pelas raízes sobem através dos vasos lenhosos do caule e chegam às folhas.");
//Console.ReadKey();
//Console.Clear();
//Console.WriteLine("Nas folhas, existe uma substância verde, a clorofila, que absone a energia luminosa do sol. Ao mesmo tempo, por meio dos estômatos presentes nas folhas, a planta absorve gás carbônico do ar.");
//Console.ReadKey();
//Console.Clear();
//Console.WriteLine("Usando a energia solar, o gás carbônico e o hidrogênio contido na água retirada do solo, após complicadas reações químicas, a planta produz açúcares (glicose).");
//Console.ReadKey();
//Console.Clear();
#endregion

#region exercício 5
//Console.WriteLine("Digite os números do primeiro prêmio");
//int[] premio1 = new int[6];
//for (int i = 0; i < 6; i++)
//{
//    Console.Write("digite o número corespondente a posição " + (i+1) + ": ");
//    premio1[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Digite os números do segundo prêmio");
//int[] premio2 = new int[6];
//for (int i = 0; i < 6; i++)
//{
//    Console.Write("digite o número corespondente a posição " + (i + 1) + ": ");
//    premio2[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("o número sorteado é: " + premio1[3] + premio1[4] + premio1[5] + premio2[3] + premio2[4] + premio2[5]);
#endregion

