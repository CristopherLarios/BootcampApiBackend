using System.ComponentModel.DataAnnotations;
using TareaBootcamp.Enum;

namespace TareaBootcamp.Model.DataModels
{
    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescricionCorta { get; set; } = string.Empty;
        public string DescricionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivo { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        [Required]
        public Nivel Nivel { get; set; }
    }
}
