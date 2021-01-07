using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Models
{
    public class TParoquiaComunidade
    {
        public int Id { get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string Nome { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string Responsavel { get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Site { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(150)]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefone { get; set; }
        public short Cidade { get; set; }
        public short Estado { get; set; }
    }
}