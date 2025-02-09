using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Models.Entities
{
    public class BaseEntity
    {
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
