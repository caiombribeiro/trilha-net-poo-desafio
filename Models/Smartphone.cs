namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {      
        public string Numero { get; set; }
        private string _modelo; 
        public string Modelo
        {   
            get => _modelo;
            set => _modelo = value;    
        }

        private string _imei;

        public string Imei
        {   
            get => _imei;
            set => _imei = value;    
        }

        private int _memoria;
        public int Memoria
        { 
            get => _memoria;
            set => _memoria = value;    
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        
        }

        public void especificacoes()
        {
            Console.WriteLine("----------------------------Especificações Técnicas---------------------------");
            Console.WriteLine($"Número: {Numero} | Modelo: {Modelo} | IMEI: {Imei} | Memória geral: {Memoria}");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void InstalarAplicativo(string nomeApp)
        {

        }
    }
}