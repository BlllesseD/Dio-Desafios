using System; 

class Desafio7 {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, horaMomentoTermino;

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);


            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);

            int transformaSegundosInicio = RetornaTotalSegundos(dadosMomentoInicio, diaInicio);
            int transformaSegundosTermino = RetornaTotalSegundos(dadosMomentoTermino, diaTermino);

            var arrayDiferencaData = RetornaDiferencaHoraFormatada(
                transformaSegundosInicio, transformaSegundosTermino
            );

            Console.WriteLine("{0} dia(s)", arrayDiferencaData[0]);
            Console.WriteLine("{0} hora(s)", arrayDiferencaData[1]);
            Console.WriteLine("{0} minuto(s)", arrayDiferencaData[2]);
            Console.WriteLine("{0} segundo(s)", arrayDiferencaData[3]);
        }
        public static int RetornaTotalSegundos(string[] tempo, int dia)
        {
            int hora = Convert.ToInt32(tempo[0]);
            int minuto = Convert.ToInt32(tempo[2]);
            int segundos = Convert.ToInt32(tempo[4]);

            int totalSegundosPorHora = hora * 3600;
            int totalSegundosPorMinuto = minuto * 60;

            int totalSegundosPorDia = dia * 86400;

            var totalSegundos = totalSegundosPorDia +
                totalSegundosPorHora + totalSegundosPorMinuto + segundos;

            return totalSegundos;
        }
        public static string[] RetornaDiferencaHoraFormatada(int inicio, int fim)
        {
            var diferencaMomentos = fim - inicio;

            var dia = diferencaMomentos / 86400;
            if (dia > 0) diferencaMomentos = diferencaMomentos % (dia * 86400);

            var hora = diferencaMomentos / 3600;
            if (hora > 0) diferencaMomentos = diferencaMomentos % (hora * 3600);

            var minutos = diferencaMomentos / 60;
            if (minutos > 0) diferencaMomentos = diferencaMomentos % (minutos * 60);

            var segundos = diferencaMomentos;

            string[] arrayDiferencaData = {
                dia.ToString(),
                hora.ToString(),
                minutos.ToString(),
                segundos.ToString()
            };

            return arrayDiferencaData;
        }
}