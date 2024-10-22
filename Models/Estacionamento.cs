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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
           Console.WriteLine("Digite a placa do veículo para estacionar:");
           string liscencePlate = Console.ReadLine();
           veiculos.Add(liscencePlate);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string plate = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
            bool error;
            int horas = 0;
            
            do
            {
                error = false; // Reset error to false at the start of each loop
                Console.WriteLine("Digite o número de horas:");
            
                try
                {
                    horas = int.Parse(Console.ReadLine()); // Parse user input into an integer
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    error = true; // Set error to true if parsing fails
                }
            }
            while (error);


                Console.WriteLine($"O veículo {plate} foi removido e o preço total foi de: R$ {this.precoInicial + (this.precoPorHora * horas)}");
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
                foreach(string plates in veiculos)
                {
                    Console.WriteLine(plates);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
