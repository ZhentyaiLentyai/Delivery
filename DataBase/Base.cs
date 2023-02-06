using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class Base
    {
        public int Id { get; set; }

        [Display(Name = "Enter the sender's city")]
        [Required(ErrorMessage = "Fill in the field")]
        public string SenderCity { get; set; }

        [Display(Name = "Enter the sender's address (street, house)")]
        [Required(ErrorMessage = "Fill in the field")]
        public string SenderAddress { get; set; }

        [Display(Name = "Enter the recipient's city")]
        [Required(ErrorMessage = "Fill in the field")]
        public string RecipientCity { get; set; }

        [Display(Name = "Enter the recipient's address (street, house)")]
        [Required(ErrorMessage = "Fill in the field")]
        public string RecipientAddress { get; set; }

        [Display(Name = "Enter the weight of the parcel (gram)")]
        [Required(ErrorMessage = "Fill in the field")]
        public int Weight { get; set; }

        [Display(Name = "Enter the date of acceptance of the cargo")]
        [Required(ErrorMessage = "Fill in the field")]
        public DateTime Date { get; set; }
    }
}