using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("contacts")]
    public class ContactEntity
    {
        internal object Address;

        [Column("id")]
        public int ContactId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationEntity? Organization { get; set; }
    }
}
