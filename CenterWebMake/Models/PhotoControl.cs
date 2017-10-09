using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CenterWebMake.Models
{
    public class PhotoControl
    {
        [required]
        [Key]
        [Column(Order = 0)]      
        public int ID { get; set; }

        [required]
        [Column(Order = 1)]
        [StringLength(50)]
        [DisplayName("图片主题")]
        public string Title { get; set; }

        [required]
        [Column(Order = 2)]
        [StringLength(50)]
        [DisplayName("图片类型")]
        public string Type { get; set; }
        
        [required]
        [Column(Order = 3)]
        [StringLength(50)]
        [DisplayName("上传日期")]
        public string UploadDate { get; set; }

        [required]
        [Column(Order = 4)]
        [StringLength(200)]
        [DisplayName("上传地址")]
        public string LoadPosition { get; set; }

        
    }
}