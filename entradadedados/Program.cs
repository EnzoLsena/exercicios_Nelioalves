using System;
using System.Globalization;

namespace entradadedados {
    class Fuck {
        static void Main(string[] args) {

            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu nome, idade e altura (mesma linha): ");
            
            string[] vet = Console.ReadLine().Split(' ');
            name = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu nome é {name}");
            Console.WriteLine($"Sua casa tem {quartos} quartos.");
            Console.WriteLine($"Você ganha {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Nome: {name} Idade: {idade} Alttura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
            
          
            //ex002

            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int age = int.Parse(vet[1]);
            char sexo = char.Parse(vet[2]);
            double heigth = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Aqui estão seus dados: ");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(sexo);
            Console.WriteLine(heigth.ToString("F2", CultureInfo.InvariantCulture));

            // ex003

            string nomeCompleto = Console.ReadLine();
            string[] vet = nomeCompleto.Split(' ');

            string nome = vet[0];
            string composto = vet[1];
            string sobrenome = vet[2];

           Console.WriteLine($"Nome: {nome}");
           Console.WriteLine($"Nome Composto : {composto}");
           Console.WriteLine($"SobreNome: {sobrenome}");
            




        }
    }
}

