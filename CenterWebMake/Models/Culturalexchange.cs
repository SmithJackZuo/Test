using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CenterWebMake.Models
{
    public class Culturalexchanges
    {
        public int ID { get; set; }

        [Required]
        [Column(Order = 0)]
        [StringLength(50)]
        [DisplayName("标题")]
        public string Title { get; set; }

        [Required]
        [Column(Order = 1)]
        [UIHint("Html")]
        [AllowHtml]
        [DisplayName("内容")]
        public string ContentText { get; set; }

        [Column(Order = 2)]
        [DisplayName("是否发布")]
        public bool IsPublich { get; set; }

        [Column(Order = 3)]
        [DisplayName("发布时间")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required]
        [Column(Order = 4)]
        [StringLength(50)]
        [DisplayName("创建人")]
        public string CreateUser { get; set; }

        [Column(Order = 5)]
        [DisplayName("创建日期")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        
        [Column(Order = 6)]
        [DisplayName("更新日期")]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }
    }
}