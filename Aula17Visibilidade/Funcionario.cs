namespace Aula17Visibilidade
{
    public class Funcionario
    {
        public string? Nome;

        private double Salario;

        protected string? Cargo;

        public Funcionario(string nome, double salario, string cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Cargo {Cargo}");
        }

        protected void AtualizarCargo(string novoCargo)
        {
            Cargo = novoCargo;
            System.Console.WriteLine($"Cargo atualizado para: {Cargo}");
        }

        private double CalcularImposto()
        {
            return Salario * 0.1;
        }
    }
}