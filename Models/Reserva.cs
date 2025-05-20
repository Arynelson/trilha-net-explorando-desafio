namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            bool capacidadeValida = Suite.Capacidade >= hospedes.Count;
            try
            {
                if (capacidadeValida == true)
                {
                    Hospedes = hospedes;
                }
                else
                {

                    throw new Exception("Capacidade da suíte é menor que o número de hóspedes.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cadastro de hóspedes finalizado.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            
            decimal valor = Suite.ValorDiaria * DiasReservados;

           
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.1M);
            }
            else if (DiasReservados <= 0)
            {
                valor = Suite.ValorDiaria * DiasReservados;
            }

            return valor;
        }
    }
}