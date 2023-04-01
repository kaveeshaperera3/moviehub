using System.ComponentModel.DataAnnotations;

namespace moviehub.Models
{
    public class CinemaModel
    {
        [Key]
        public int CinemaId { get; set; }
        public string CinemaName { get; set; }
        public string CinemaDescription { get; set; }
        public string CinemaImageURL { get; set; }

        //Relationships
        public List<MovieModel> Movies { get; set; }

    
    
    }
}
