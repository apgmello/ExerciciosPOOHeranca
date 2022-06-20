namespace ExerciciosPOOHeranca
{
    internal class Funcionario
    {
        public string? nome;
        public double salario;
        public double bonificacao;

        public Funcionario(string? nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
            this.bonificacao = CalcularBonificacao();
        }
        public virtual double CalcularBonificacao()
        {
            return salario * 0.10;
        }
        public virtual void MostraDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário base: {salario}");
            Console.WriteLine($"Bonificação: {bonificacao}");
            Console.WriteLine($"Salário final: {salario + bonificacao}");
        }
    }
}
