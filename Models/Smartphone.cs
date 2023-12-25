namespace DesafioPOO.Models {
    public abstract class Smartphone {
        public string Numero { get; private set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, int memoria) {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar() {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao() {
            Console.WriteLine("Recebendo ligação...");
        }

        public override string ToString() {
            return $"{Numero}, {Modelo}, IMEI: {IMEI}, {Memoria} GB.";
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}