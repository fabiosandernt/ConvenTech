using ConvenTech.Domain.ValueObject;
using FluentValidation;
using System.Text.RegularExpressions;


namespace ConvenTech.Domain.Validator
{
    public class CpfValidator : AbstractValidator<Cpf>
    {
        private const string Pattern = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$";

        public CpfValidator()
        {
            RuleFor(x => x.Valor)
                .NotEmpty()
                .Must(BeACpfValid).WithMessage("CPF inválido");
        }

        private bool BeACpfValid(string valor) => Regex.IsMatch(valor, Pattern) && ValidateCpf(valor);

        private bool ValidateCpf(string cpf)
        {
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
                return false;

            int[] multiplicador1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf = "";
            int soma = 0;
            int resto = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            tempCpf = cpf.Substring(0, 9) + resto.ToString();
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            tempCpf = tempCpf + resto.ToString();
            return cpf.EndsWith(tempCpf);
        }
    }
}