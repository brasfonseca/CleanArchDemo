using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Models
{
    /// <summary>
    /// City = Cidade
    /// </summary>
    public class TCity
    {   
        public short Id { get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string City { get; set; }
    }
}