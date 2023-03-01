namespace ConvenTech.Domain.ValueObject
{
    public class CpfVo : IEquatable<CpfVo>
    {
        private readonly string _cpf;

        public CpfVo(string cpf)
        {
            if (!ValidarCPF(cpf))
                throw new ArgumentException("CPF inválido");

            _cpf = cpf;
        }

        public string Valor => _cpf;

        private bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < cpf.Length && igual; i++)
            {
                if (cpf[i] != cpf[0])
                    igual = false;
            }

            if (igual || cpf == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
            {
                numeros[i] = int.Parse(cpf[i].ToString());
            }

            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += (10 - i) * numeros[i];
            }

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += (11 - i) * numeros[i];
            }

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }

        public bool Equals(CpfVo other)
        {
            if (other == null)
                return false;

            return _cpf == other.Valor;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            CpfVo other = obj as CpfVo;

            if (other == null)
                return false;

            return Equals(other);
        }

        public override int GetHashCode()
        {
            return _cpf.GetHashCode();
        }

        public override string ToString() => _cpf;
    }

}

