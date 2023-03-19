using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Entities.Dtos.Categories
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("kategori adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Name { get; set; }

        [DisplayName("kategori açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Description { get; set; }

        [DisplayName("kategori aktifliği")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir")]
        public bool IsActive { get; set; }

        [DisplayName("kategori notu")]
        [MaxLength(100, ErrorMessage = "{0} {1} karaterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        public string Note { get; set; }

        [DisplayName("kategori silinme durumu")]
        [Required]
        public bool IsDeleted { get; set; }
    }
}
