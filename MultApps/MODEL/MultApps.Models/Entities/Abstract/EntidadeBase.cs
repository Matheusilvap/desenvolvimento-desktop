using MultApps.Models.Enums;
using System;


namespace MultApps.Models.Entities.Abstract
{
    internal class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public StatusEnum Status { get; set; } 

    }
}
