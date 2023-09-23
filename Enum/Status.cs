using System.ComponentModel;

namespace SistemaDeTarefa.Enum
{
    public enum Status
    {
        [Description("A fazer")]
        Afazer = 0,
        [Description("Em Andamento")]
        EmAndamento = 1,
        [Description("Concluido")]
        Concluido = 2,

    }
}
