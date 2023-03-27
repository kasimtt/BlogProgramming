using BlogProgramming.Core.Entities.Abstract;
using BlogProgramming.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Entities.Dtos.Articles;

public class ArticleAddDto
{
    [DisplayName("Başlık")]
    [Required(ErrorMessage = "{0} boş geçilmemelidir")]
    [MaxLength(100, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
    [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
    public string Title { get; set; }
    
    [DisplayName("içerik")]
    [Required(ErrorMessage = "{0} boş geçilmemelidir")]
    [MinLength(40,ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
    public string Content { get; set; }
  
    [DisplayName("resim")]
    [MaxLength(250, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
    [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalıdır ")]
    public string Thumbnail { get; set; }
   
    [DisplayName("Tarih")]
    [Required(ErrorMessage = "{0} boş geçilmemelidir")]
    [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime Date { get; set; }
    
    [DisplayName("Seo yazar")]
    [Required(ErrorMessage ="{0} boş gecilmemelidir")]
    [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
    [MaxLength(50, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
    public string SeoAuthor { get; set; }
    
    [DisplayName("Seo açıklama")]
    [Required(ErrorMessage = "{0} boş gecilmemelidir")]
    [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
    [MaxLength(150, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
    public string SeoDescription { get; set; }
   
    [DisplayName("Seo Tag")]
    [Required(ErrorMessage = "{0} boş gecilmemelidir")]
    [MinLength(2, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
    [MaxLength(70, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
    public string SeoTags { get; set; }

    [DisplayName("kategori")]
    [Required(ErrorMessage ="{0} boş gecilmemelidir")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    [DisplayName("Aktif mi?")]
    [Required(ErrorMessage = "{0} boş gecilmemelidir")]
    public bool IsActive { get; set; }



}
