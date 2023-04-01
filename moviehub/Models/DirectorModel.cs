using System.ComponentModel.DataAnnotations;

namespace moviehub.Models
{
    public class DirectorModel
    {
        [Key]
        public int DirectoId { get; set; }
        public string DirectorName { get; set; }
        public string DirectorDescription { get; set; }
        public string DirectorImageURL { get; set; }

        //Relationships
        public List<MovieModel> Movies { get; set; }
    }
}
