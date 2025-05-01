using MultApps.Models.Entidades;
using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enums;

namespace MultApps.Models.Entities
{
    public class Produto : EntidadeBase
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public int Estoque { get; set; }
        public StatusEnum Status { get; set; }

    }
}
