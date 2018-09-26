using System.ComponentModel.DataAnnotations;

namespace DatingApp.API
{
    public class Values
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}