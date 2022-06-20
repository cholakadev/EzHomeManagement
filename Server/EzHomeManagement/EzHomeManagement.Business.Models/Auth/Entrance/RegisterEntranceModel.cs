namespace EzHomeManagement.Business.Models.Auth.Entrance
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterEntranceModel
    {
        /// <summary>
        /// Auto generated unique entrance code. 
        /// It is usable when a user wants to register to connect to the same entrance.
        /// </summary>
        public string? Code { get; private set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Address { get; set; }

        public void GenerateEntranceCode()
            => this.Code = Guid.NewGuid().ToString("N").Substring(0, 8);
    }
}
