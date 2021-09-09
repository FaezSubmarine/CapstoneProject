using System.ComponentModel.DataAnnotations;

namespace CapstoneProject.Models
{
    public class circuit
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }

        public circuit(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public circuit(string name)
        {
            this.name = name;
        }
        public circuit():this("")
        {

        }
    }
}
