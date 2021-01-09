using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Models
{
    /// <summary>
    /// State = Estado
    /// </summary>
    public class TState
    {
        public short Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string State { get; set; }
    }
}