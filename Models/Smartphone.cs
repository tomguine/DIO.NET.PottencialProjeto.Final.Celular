namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string tipo, string numero, string modelo, string imei, int memoria) // ctor base
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades - 0k
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            Tipo = tipo;
        }


        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama - ok

        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private int Memoria { get; set; }
        
        private string Tipo { get; set; }


        public void Apresentar()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(Tipo);
            Console.WriteLine(Numero);
            Console.WriteLine(Modelo);
            Console.WriteLine(IMEI);
            Console.WriteLine(Memoria + " gb");
            Console.WriteLine("------------------------");
        }   

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}