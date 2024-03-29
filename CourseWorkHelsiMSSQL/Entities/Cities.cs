﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkHelsiMSSQL.Entities
{
    [Table("tblCitiesNames")]
    public class Cities
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }
        
    }
}
