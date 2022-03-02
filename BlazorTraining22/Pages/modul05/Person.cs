using System.ComponentModel.DataAnnotations;

namespace BlazorTraining22.Pages.modul05
{
    public class Person
    {
        public int Id { get; set; } 
        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(10,ErrorMessage ="Max 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [Range(130,195,ErrorMessage ="Größe passt nicht")]
        public int Gross { get; set; }

        [Required(ErrorMessage = "da muss was rein")]
        public DateTime GebDat { get; set; }

    }
}
