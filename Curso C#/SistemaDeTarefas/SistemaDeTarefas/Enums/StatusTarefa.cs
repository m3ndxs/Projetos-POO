using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("Tarefa pendente")]
        Pendente = 1,
        [Description("Tarefa em andamento")]
        EmAndamento = 2,
        [Description("Tarefa finalizada")]
        Concluido = 3
    }
}
