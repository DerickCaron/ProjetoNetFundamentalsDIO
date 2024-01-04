namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            try{
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                string placa = Console.ReadLine();
                veiculos.Add(placa.ToUpper());
                Console.WriteLine("Veículo Adicionado com sucesso!!!");
            }catch{
                Console.WriteLine("OPS!!! OCORREU ALGUM PROBLEMA TENTE NOVAMENTE.");
            }
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if (decimal.TryParse(Console.ReadLine(), out decimal horas))
                {
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    veiculos.Remove(placa.ToUpper());
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                int tamanho = veiculos.Count - 1;
                for(int v =0; v<=tamanho; v++){
                    Console.WriteLine(veiculos[v]);        
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}