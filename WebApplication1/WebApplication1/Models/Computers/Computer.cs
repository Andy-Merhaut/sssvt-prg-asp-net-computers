using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Computers
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }

        public int Ip { get; set; }

        [StringLength(255)]
        public string MacAddress { get; set; }

        [StringLength(255)]
        public string ComputerName { get; set; }

    }
}
