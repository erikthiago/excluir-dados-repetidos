using System;

namespace ExcluiDadosDuplicados.Repositories
{
    // Interface para ser implementada nas classes de queries para reuso de código
    public interface IQuery
    {
        int Id { get; set; }
    }
}
