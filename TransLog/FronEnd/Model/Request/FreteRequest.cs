using System.ComponentModel.DataAnnotations;

namespace FronEnd.Model.Request
{
    public class FreteRequest
    {
        [Required(ErrorMessage = "Este campo é obrigatoro é obrigatório")]
        public decimal Distancia { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatoro é obrigatório")]
        public decimal Altura { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatoro é obrigatório")]
        public decimal Largura { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatoro é obrigatório")]
        public decimal PesoCarga { get; set; }
    }
}
