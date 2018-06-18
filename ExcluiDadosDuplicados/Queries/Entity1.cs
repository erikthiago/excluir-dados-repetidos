using System;
using ExcluiDadosDuplicados.Repositories;

namespace ExcluiDadosDuplicados.Queries
{
    // Classe que representa a entidade1
    public class Entity1 : IQuery
    {
        public int Id { get; set; }
        public int Prop2 { get; set; }
        public int Prop3 { get; set; }
        public string Prop4 { get; set; }
        public string Prop5 { get; set; }
        public string Prop6 { get; set; }
    }
}
