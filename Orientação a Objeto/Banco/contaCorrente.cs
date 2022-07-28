namespace Banco
{
    public class ContaCorrente
    {
        public string conta;
        public string nomeAgencia;
        public  int numeroAgencia;  
        public double saldo;
    

    public bool Sacar(double valor)
    {
        if(saldo < valor || valor < 0)
        {
            return false;
        } else
        {
            saldo = saldo - valor;
            return true;
        }
    }

    public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

    public bool Transferir (double valor, ContaCorrente destino)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.Depositar(valor);
                return true;
            }
        }

    }
} 