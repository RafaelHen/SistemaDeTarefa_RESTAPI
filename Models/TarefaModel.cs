using SistemaDeTarefa.Enum;

namespace SistemaDeTarefa.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Status status { get; set;}
    }
}
