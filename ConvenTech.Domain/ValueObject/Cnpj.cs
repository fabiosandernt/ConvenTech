
namespace ConvenTech.Domain.ValueObject
{
    public class Cnpj
    {
        public Cnpj()
        {

        }

        public Cnpj(string cnpj)
        {
            Valor = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
        }

        public string Valor { get; set; }
    }
}
