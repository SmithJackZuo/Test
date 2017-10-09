using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Web.Mvc;

namespace CenterWebMake.Models
{
    [Table("CenterNewsCreate")]
    public partial class CenterNewsCreate
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        
        [Required]       
        public string ContentText { get; set; }

        public bool IsPublich { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
