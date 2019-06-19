using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte x = 100;
            Byte n1 = 126;
            int n2 = 1001, n3 = 2147483647;
            long n4 = 2147483648L; //quando se usa uma variável long, usa-se a letra L no final para ajudar a identificar melhor
            bool completo = false;
            char genero = 'F'; //pode ser usado código Unicode que representa a letra F, como se fosse em exadecimal
            char letra = '\u0041'; //este é o código Unicode, sendo necessário a contrabarra e letra u para identificá-lo
            float n5 = 4.5f; //para que identifique que é float, tem que colocar o f depois do número, senão identifica como double
            double n6 = 4.5;
            string nome = "Meredith Grey"; //string em aspas duplas, letras em simples
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine("Hello World!");
            Console.WriteLine(x);
            n1++;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
