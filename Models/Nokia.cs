namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor que chama o construtor da classe base
        public Nokia(string numero) : base(numero)
        {
        }

        // Sobrescreve o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"* Instalando {nomeApp} na Nokia!");
        }

        public override void AplicativoInstalado(string nomeApp)
        {
            Console.WriteLine($"* {nomeApp} Instalado com Sucesso...");
        }
    }
}
