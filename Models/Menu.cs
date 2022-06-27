using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resto_practice.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
