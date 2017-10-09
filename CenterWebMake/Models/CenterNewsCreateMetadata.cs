using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CenterWebMake.Models
{
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(CenterNewsCreateMetadata))]
    public partial class CenterNewsCreate
    {
        public class CenterNewsCreateMetadata
        {

            public int ID { get; set; }

            [Required]
            [StringLength(50)]
            [DisplayName("标题")]
            public string Title { get; set; }

            [Required]
            [DisplayName("內容")]
            [UIHint("Html")]
            [AllowHtml]
            public string ContentText { get; set; }

            [DisplayName("是否发布")]
            public bool IsPublich { get; set; }

            [DataType(DataType.Date)]
            [DisplayName("发布日期")]
            public DateTime PublishDate { get; set; }

            [Required]
            [StringLength(50)]
            [DisplayName("创建者")]
            public string CreateUser { get; set; }

            [DisplayName("创建日期")]
            [DataType(DataType.Date)]
            public DateTime CreateDate { get; set; }

            [DisplayName("更新日期")]
            [DataType(DataType.Date)]
            public DateTime UpdateDate { get; set; }
        }
    }
}