using System.Text.RegularExpressions;


namespace ConvenTech.Domain.ValueObject
{
    public class CnpjVo : IEquatable<CnpjVo>
    {
        private readonly string _cnpj;

        public CnpjVo(string cnpj)
        {
            if (!ValidarCNPJ(cnpj))
                throw new ArgumentException("CNPJ inválido");

            _cnpj = cnpj;
        }
        public string Valor => _cnpj;

        private bool ValidarCNPJ(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj))
                return false;

            // Remover caracteres não numéricos
            cnpj = Regex.Replace(cnpj, "[^0-9]", string.Empty);

            // Verificar tamanho
            if (cnpj.Length != 14)
                return false;

            // Verificar dígitos repetidos
            if (new string(cnpj[0], 14) == cnpj)
                return false;

            // Calcular primeiro dígito verificador
            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma1 = 0;
            for (int i = 0; i < 12; i++)
                soma1 += multiplicadores1[i] * int.Parse(cnpj[i].ToString());
            int resto1 = soma1 % 11;
            int digito1 = resto1 < 2 ? 0 : 11 - resto1;

            // Verificar primeiro dígito verificador
            if (int.Parse(cnpj[12].ToString()) != digito1)
                return false;

            // Calcular segundo dígito verificador
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma2 = 0;
            for (int i = 0; i < 13; i++)
                soma2 += multiplicadores2[i] * int.Parse(cnpj[i].ToString());
            int resto2 = soma2 % 11;
            int digito2 = resto2 < 2 ? 0 : 11 - resto2;

            // Verificar segundo dígito verificador
            if (int.Parse(cnpj[13].ToString()) != digito2)
                return false;

            return true;
        }
        public override string ToString() => _cnpj;

        public override bool Equals(object obj)
        {
            return Equals(obj as CnpjVo);
        }

        public bool Equals(CnpjVo other)
        {
            if (other == null)
                return false;

            return Valor == other.Valor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Valor);
        }
    }

}

