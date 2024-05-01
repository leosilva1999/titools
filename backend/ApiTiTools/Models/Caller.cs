using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiTiTools.Models
{
    public class Caller
    {
        public Caller()
        {
            Calls = new Collection<Call>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(80)]
        public string Office { get; set; }

        [JsonIgnore]
        public ICollection<Call> Calls { get; set; }
    }
}
