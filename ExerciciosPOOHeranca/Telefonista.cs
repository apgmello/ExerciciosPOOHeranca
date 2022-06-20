namespace ExerciciosPOOHeranca
{
    internal class Telefonista : Funcionario
    {
        public string codgioEstacao;

        public Telefonista(string? nome, double salario, string codgioEstacao) : base(nome, salario)
        {
            this.codgioEstacao = codgioEstacao;
        }
        public override void MostraDados()
        {
            Console.WriteLine("Dados telefonista");
            base.MostraDados();
            Console.WriteLine($"Codigo da estação: {codgioEstacao}");
            Console.WriteLine("--------------------------");
        }
    }
}
