namespace ExerciciosPOOHeranca
{
    internal class Gerente : Funcionario
    {
        public string senha;
        public string usuario;

        public Gerente(string? nome, double salario, string senha, string usuario) : base(nome, salario)
        {
            this.senha = senha;
            this.usuario = usuario;
        }
        public override double CalcularBonificacao()
        {
            return salario * 0.15;
        }
        public override void MostraDados()
        {
            Console.WriteLine("Dados Gerente");
            base.MostraDados();
            Console.WriteLine($"Senha: {senha}");
            Console.WriteLine($"Usuário: {usuario}");
            Console.WriteLine("--------------------------");
        }
    }
}
