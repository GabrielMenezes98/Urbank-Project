namespace Ur.Bank    
{
    public class Conta
    {
        //Propriedades
        private TipoConta TipoConta {get; set;}
        private double Saldo {get; set;}
        private double Credito {get; set;}
        private string Nome {get; set;}

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
            //Construtor
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        
        public bool Sacar(double valorSaque)
        {
            //Validação de saldo
            if (this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta {0} é {1}", this.Nome, this.Saldo);
            // 0 e 1 funcionam como um vetor de dados, representando as indicações subsequentes

            return true;
        }   


        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            //this.Saldo = this.Saldo + valorDeposito;  (ambas as linhas possuem a mesma função)

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }


        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }   
        }
    
        public override string ToString()
        {
            string retorno = "";
            // concatenação da string para exibir valores no console
            retorno += "Tipo da Conta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Crédito: " + this.Credito;
            return retorno;
        }
    
    }


}