namespace ExerciciosPOOHeranca
{
    internal class TestaFuncionarios
    {
        public void Testar()
        {
            Secretaria sec = new Secretaria("Pedro Pedro", 3000, 10);
            Telefonista tel = new Telefonista("Joana Joana", 2000, "J20");
            Gerente ger = new Gerente("Maria Maria", 5000, "1234", "Pedro30");

            sec.MostraDados();
            tel.MostraDados();
            ger.MostraDados();
        }
    }
}
