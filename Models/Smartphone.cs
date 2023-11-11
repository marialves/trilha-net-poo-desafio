namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementado: Implementar as propriedades faltantes de acordo com o diagrama

        private string Modelo;

        private string IMEI;

        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Implementado: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...\n");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...\n");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}