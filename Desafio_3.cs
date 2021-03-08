using System; 

class Desafio3 {

    static void Main(string[] args) { 

            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());

                       //insira os valores corretos de acordo com o enunciado

            if(salario <= 400.00)
            {
            reajuste = salario * 0.15; 

            novoSalario = salario + reajuste;

            percentual = ((novoSalario - salario) * 100) /salario;

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);

            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);

            Console.WriteLine("Em percentual: 15 %");

            }
            else if(salario >= 400.01 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 12 %", percentual);
            }
            else if(salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 10 %", percentual);
            }
            else if(salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 7 %", percentual);
            }
            else
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 4 %", percentual);
            }
    }

}