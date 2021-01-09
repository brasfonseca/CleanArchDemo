using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Models
{
    /// <summary>
    /// Parish = Paróquia
    /// Community = Comunidade
    /// Name = Nome
    /// Responsible = Responsável
    /// Telephone = Telefone
    /// City = Cidade
    /// State = Estado
    /// </summary>            
    public class TParishCommunity
    {
        public int Id { get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string Responsible { get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Site { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(150)]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefone { get; set; }
        public short City { get; set; }
        public short State { get; set; }
    }
}