using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CenterWebMake.Models
{
    public class Labintroduce
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("标题")]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [UIHint("Html")]
        [AllowHtml]
        [DisplayName("内容")]
        public string ContentText { get; set; }

        [DisplayName("发布日期")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required]
        [DisplayName("创建者")]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Required]
        [DisplayName("创建日期")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [Required]
        [DisplayName("更新时间")]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }
    }
}