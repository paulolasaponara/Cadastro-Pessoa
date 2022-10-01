using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    //classe pessoa fisica que herda da superclasse Pessoa
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        //atributos da classe pessoa fisica
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500f)
            {
                return 0;
            }
            else if (rendimento >= 1501 && rendimento <= 3500)
            {
                return rendimento * 0.02f;
            }
            else if (rendimento >= 3501 && rendimento <= 6000)
            {
                return rendimento * 0.035f;
            }
            else
            {
                return rendimento * 0.5f;
            }
        }

        public bool ValidarDataNascimento(DateTime datanascimento)
        {
            throw new NotImplementedException();
        }
    }
}