using System.ComponentModel;


namespace ConvenTech.Domain.Account.Enums
{
    public enum TipoUsuarioEnum : int
    {
        [Description("Administrador")]
        Administrador = 1,

        [Description("Funcionário")]
        Funcionário = 2,

        [Description("Cliente")]
        Cliente = 3,
    }
}
