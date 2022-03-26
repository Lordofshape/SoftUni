using System.ComponentModel.DataAnnotations;

namespace Country.Data.Models
{
    public class Counntry
    {
        public Counntry()
        {
            ICollection<City> Citys = new List<City>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<City> cities { get; set; }
    }
}
