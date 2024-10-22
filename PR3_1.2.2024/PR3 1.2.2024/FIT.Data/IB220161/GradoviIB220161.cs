﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220161
{
    [Table("GradoviIB220024")]
    public class GradoviIB220161
    {
        public int Id { get; set; }
        [ForeignKey("DrzaveIB220161")]
        public int DrzavaId { get; set; }
        public virtual DrzaveIB220161 Drzava { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }

    }
}
