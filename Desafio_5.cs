using System;

class Desafio5 {

    static void Main(string[] args) {

            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double g1, g2;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                g1 = 1 + double.Parse(valores[2])/100.0;
                g2 = 1 + double.Parse(valores[3])/100.0;
                
                while(pa <= pb && anos <= 100)
                {
                  pa = (int)(pa * g1);
                  pb = (int)(pb * g2);
                  anos++;
                }

                if (anos > 100)
                {
                  Console.WriteLine ("Mais de 1 seculo.");
                }

                if (anos <= 100)
                {
                   Console.WriteLine("{0} anos.", anos);
                }
            }
    }

}