using System.ComponentModel.DataAnnotations;

namespace testreactapp.Model{

    public class Person{
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }    
        public string Address { get; set; }
    }
}