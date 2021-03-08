using System;



class Desafio11 {

 public static void Main (string[] args) {

   int totalDeCasosDeTeste = int.Parse(Console.ReadLine());

   string[] valores = Console.ReadLine().Split();  

   int[] numeros = new int[valores.Length];



   int nMultiplosDois = 0;

   int nMultiplosTres = 0;

   int nMultiplosQuatro = 0 ;

   int nMultiplosCinco = 0;

    

   for(int i = 0; i < valores.Length; i++)

   {    

     numeros[i] = int.Parse(valores[i]);

   }

   foreach (int number in numeros)

   {

     if(number % 2 == 0)

     nMultiplosDois++;



     if(number % 3 == 0)

     nMultiplosTres++;



     if(number % 4 == 0)

     nMultiplosQuatro++;

      

     if(number % 5 == 0)

     nMultiplosCinco++;



   }  



   Console.WriteLine("{0} Multiplo(s) de 2",nMultiplosDois);

   Console.WriteLine("{0} Multiplo(s) de 3",nMultiplosTres);

   Console.WriteLine("{0} Multiplo(s) de 4",nMultiplosQuatro);

   Console.WriteLine("{0} Multiplo(s) de 5",nMultiplosCinco);



 }

}