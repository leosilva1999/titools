using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiTiTools.Models
{
    public class Call
    {
        [Key]
        public int CallId { get; set; }

        [Required]
        [StringLength(100)]
        public string Reason { get; set; }
        [Required]
        [StringLength(300)]
        public string Description { get; set; }
        [Required]
        public DateTime CallTime { get; set; }
        [Required]
        public DateTime ServiceStart { get; set; }
        [Required]
        public DateTime ServiceEnd { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int CallerId { get; set; }

        [JsonIgnore]
        public Caller? Caller { get; set; }
        [JsonIgnore]
        public User? User { get; set; }
    }
}
