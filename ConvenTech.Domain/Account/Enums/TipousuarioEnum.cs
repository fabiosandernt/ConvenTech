using System.ComponentModel;


namespace ConvenTech.Domain.Account.Enums
{
    public enum TipoUsuarioEnum : int
    {
        [Description("Administrador")]
        Administrador = 1,

        [Description("Clínica")]
        Clinica = 2,

        [Description("Cliente")]
        Cliente = 3,
    }
}
