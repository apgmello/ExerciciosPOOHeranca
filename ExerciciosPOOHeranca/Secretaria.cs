namespace ExerciciosPOOHeranca
{
    internal class Secretaria : Funcionario
    {
        public int numeroRamal;

        public Secretaria(string? nome, double salario, int numeroRamal) : base(nome, salario)
        {
            this.numeroRamal = numeroRamal;
        }
        public override void MostraDados()
        {
            Console.WriteLine("Dados secretária(o)");
            base.MostraDados();
            Console.WriteLine($"Número do Ramal: {numeroRamal}");
            Console.WriteLine("--------------------------");
        }
    }
}
