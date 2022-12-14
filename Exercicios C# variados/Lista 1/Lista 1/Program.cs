#region Exercicio 1
////1.Caracteres progressivos 1 - Escrever um programa que produza a saída abaixo na tela, para N
////linhas e usando um caractere lido do teclado (no exemplo, *). Após mostrar uma vez, o programa
////repete o processo, só parando quando N for zero.
////*
////**

////***

////****

////(...)
//int vezes;
//string caractere;
//do
//{
//    do
//    {
//        Console.Write("digite um caractere:   ");
//        caractere = Console.ReadLine();
//    }
//    while (caractere.Length != 1);
//    Console.Write("digite o número de linhas e vezes (progressivamente) que ele deve aparecer:   ");
//    vezes = int.Parse(Console.ReadLine());
//    Console.WriteLine();
//    for (int i = 0; i < vezes; i++)
//    {
//        for (int j = 0; j <= i; j++)
//        {
//            Console.Write(caractere);
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//while (vezes != 0);

#endregion
#region Exercicio 2
////Maior - Escrever um programa que lê números inteiros até que o número lido seja zero,
////quando então é mostrado o maior número lido.
//int numero = -1;
//bool verif = false;
//int numerocomp = 0;
//while (numero != 0)
//{
//    Console.Write("digite um número:  ");
//    verif = int.TryParse(Console.ReadLine(), out numero);
//    if (verif == false)
//    {
//        Console.WriteLine("Você não digitou um numero! ");
//        numero = -1;
//    }
//    if (numerocomp < numero)
//    {
//        numerocomp = numero;
//    }
//}

//Console.WriteLine($"o maior numero digitado foi : {numerocomp} ");
#endregion
#region Exercicio 3
//Maior e menor - Alterar o programa anterior para que mostre também o menor número lido.
//int numero = -1;
//bool verif = false;
//int numerocomp = 0;
//int numero2 = 1000000000;
//while (numero != 0)
//{
//    Console.Write("digite um número:  ");
//    verif = int.TryParse(Console.ReadLine(), out numero);
//    if (verif == false)
//    {
//        Console.WriteLine("Você não digitou um numero! ");
//        numero = -1;
//    }
//    if (numerocomp < numero)
//    {
//        numerocomp = numero;
//    }
//    if (numero2 > numero && numero != -1 && numero!=0)
//    {
//        numero2 = numero;
//    }
//}

//Console.WriteLine($"o maior numero digitado foi : {numerocomp} ");
//Console.WriteLine($"o menor numero digitado foi : {numero2}");
#endregion
#region Exercicio 4
////Soma de pares - Implemente um programa que calcula a soma dos números pares
////compreendidos entre dois números lidos.
//using System.Security.Cryptography;

//int n1;
//int n2;
//int nmaior;
//int nmenor;
//int ii=0;
//int a;
//int b;
//do
//{
//    Console.Write("digite o primeiro número:  ");
//    n1 = int.Parse(Console.ReadLine());
//    Console.Write("digite o segundo número:  ");
//    n2 = int.Parse(Console.ReadLine());
//} while (n1 == n2);

//if(n1 > n2)
//{
//    nmenor = n2;
//    nmaior = n1;
//}
//else
//{
//    nmenor = n1;
//    nmaior = n2;
//}
//int niterador = nmenor;
//int[] valoresint = new int[nmaior - nmenor];
//if (nmenor%2 == 0 && nmaior%2 ==0)
//{
//    for (int i = 0; i < ((nmaior-nmenor)/2-1); i++)
//    {
//        valoresint[i] = niterador + 2;
//        niterador = niterador + 2;
//        ii = i+1;
//    }
//}

//else if (nmenor%2 == 1)
//{
//    for (int i = 0; i < ((nmaior-nmenor) / 2); i++)
//    {
//        valoresint[i] = niterador + 1;
//        niterador = niterador + 2;
//        ii = i+1;
//    }
//}
//else
//{
//    {
//        for (int i = 0; i < ((nmaior - nmenor) / 2); i++)
//        {
//            valoresint[i] = niterador + 2;
//            niterador = niterador + 2;
//            ii = i + 1;
//        }
//    }
//}
//Random rnd = new Random();
//do
//{
//    a = rnd.Next(0, ii );
//    b = rnd.Next(0, ii );
//} while (a == b);
//Console.WriteLine($"A soma de {valoresint[a]} + {valoresint[b]} : {valoresint[a] + valoresint[b]} ");
//Console.Write($"todos os números pares entre {nmenor} e {nmaior}:  " );
//for (int i =0; i<ii; i++)
//{
//    Console.Write(valoresint[i] + " ");
//}
#endregion
#region Exercicio 5
//Ímpares múltiplos 1 - Escreva um programa que soma todos os números ímpares múltiplos de
//três situados na faixa de 1 a 1000.
//int[] num = new int[1000];
//int[] impar = new int[500];
//int imp;
//int[] multiplo = new int[1000];
//int j=0;

//for (int i=1; i<=1000; i++)
//{
//    num[i-1] = i;
//}
//Console.WriteLine(num[0]);
//Console.WriteLine(num[999]);
//impar[0] = 1;
//for(int i=0; i<1000; i++)
//{
//    if (num[i]%2==1)
//    {
//        impar[i/2] = num[i];        
//    }
//}
//Console.WriteLine(impar[0]);
//Console.WriteLine(impar[499]);

//for(int i=0; i<500; i++)
//{
//    if (impar[i] % 3 == 0)
//    {
//        multiplo[j] = impar[i];
//        j++;
//    }
//}
//Console.Write("os numeros impares múltiplos de 3 compreendidos entre 1 e 1000 são: ");
//int soma = 0;
//for(int i=0; i<j; i++)
//{
//    Console.Write(multiplo[i] + " ");
//    soma = soma + multiplo[i];
//}
//Console.WriteLine($"soma dos impares múltiplos de 3 compreendidos entre 1 a 1000 é: {soma}");
#endregion
#region Exercicio 6
////Ímpares múltiplos 2 - Altere o programa acima de forma que a faixa seja informada pelo
////usuário, e os números ímpares múltiplos de três sejam mostrados em ordem decrescente.
//int n1;
//int n2;
//int nmaior;
//int nmenor;

//do
//{
//    Console.Write("digite o primeiro número:  ");
//    n1 = int.Parse(Console.ReadLine());
//    Console.Write("digite o segundo número:  ");
//    n2 = int.Parse(Console.ReadLine());
//} while (n1 == n2);

//if (n1 > n2)
//{
//    nmenor = n2;
//    nmaior = n1;
//}
//else
//{
//    nmenor = n1;
//    nmaior = n2;
//}
//int tamanho;
//int ncontador = nmenor;
//int j = 0;
//int[] impar = new int[(nmaior - nmenor)/2+1];
//int[] num = new int[(nmaior - nmenor +1)];
//for (int i = 0; i <=(nmaior-nmenor); i++)
//{
//    num[i] = ncontador + i;
//    tamanho = num[i];
//}
//for (int i = 0; i < (nmaior-nmenor); i++)
//{
//    if (num[i] % 2 == 1)
//    {
//        impar[j] = num[i];
//        j++;
//    }
//}
//int[] multiplo = new int[(nmaior - nmenor) / 2];
//int k = 0;
//for (int i = 0; i < j+1; i++)
//{
//    if (impar[i] % 3 == 0)
//    {
//        multiplo[k] = impar[i];
//        k++;
//    }
//}
//Console.Write($"\n\nos numeros impares múltiplos de 3 compreendidos entre {nmaior} e {nmenor} são: ");
//int soma = 0;
//for (int i = 0; i < k; i++)
//{
//    Console.Write(multiplo[i] + " ");
//    soma = soma + multiplo[i];
//}
//Console.WriteLine($"\n\nsoma dos impares múltiplos de 3 compreendidos entre {nmenor} a {nmaior} é: {soma}");
#endregion
#region Exercicio 7
////7.Inserção de caractere 1 - Implementar um programa que insere hífens entre as letras de uma
////cadeia de caracteres, como em f-a-b-u-l-o-s-o.

//string palavra;
//Console.WriteLine("escreva uma palavra! ");
//palavra = Console.ReadLine();

//for(int i = 0; i< palavra.Length -1; i++)
//{
//    Console.Write(palavra[i] + "-");
//}
//Console.WriteLine(palavra[palavra.Length-1]);
#endregion

