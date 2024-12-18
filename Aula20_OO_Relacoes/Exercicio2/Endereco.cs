namespace Aula20_OO_Relacoes
{
    public class Endereco
    {
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public Cidade? Cidade { get; set; }

        public Endereco(string rua, int numero, string bairro, string cep, Cidade cidade)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
        }
    }
}