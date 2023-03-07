using ConvenTech.Domain.ValueObject;
using FluentValidation;
using System.Text.RegularExpressions;


namespace ConvenTech.Domain.Validator
{
    
        public class CnpjValidator : AbstractValidator<Cnpj>
        {
            private const string Pattern = @"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$";

            public CnpjValidator()
            {
                RuleFor(x => x.Valor)
                    .NotEmpty()
                    .Must(BeACnpjValid).WithMessage("CNPJ inválido");
            }

            private bool BeACnpjValid(string valor) => Regex.IsMatch(valor, Pattern) && ValidateCnpj(valor);

            private bool ValidateCnpj(string cnpj)
            {
                int[] multiplicador1 = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma = 0;
                int resto = 0;
                string digito = "";
                string tempCnpj = "";
                cnpj = cnpj.Trim();
                cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

                if (cnpj.Length != 14)
                    return false;

                tempCnpj = cnpj.Substring(0, 12);
                soma = 0;

                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

                resto = (soma % 11);

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();
                tempCnpj = tempCnpj + digito;
                soma = 0;

                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

                resto = (soma % 11);

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }
        }
    }

