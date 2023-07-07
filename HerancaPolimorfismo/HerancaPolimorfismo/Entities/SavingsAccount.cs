

namespace HerancaPolimorfismo.Entities
{
    //para a classe ou metodos sobrepostos, por regra de negócio ou para evitar inconsistencias
     sealed class SavingsAccount: Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { }

        public SavingsAccount( int number, string holder, double balance, double interestRate): base(number,holder,balance) 
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        //Sobreposição
        public override void WithDraw(double amount)
        {
            //Acrescentando o que já tinha na superclasse withdraw e somente adicionando mais coisas

            base.WithDraw(amount);
            Balance -= 2.00;
        }

     }
}
