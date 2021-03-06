﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BilgeKoleji.Models
{
    public class ogrenci_sube
    {
        public int id { get; set; }
        [ForeignKey("ogrenci")]
        public int ogrenci_id { get; set; }
        public virtual ogrenci ogrenci { get; set; }
        [ForeignKey("sube")]
        public int sube_id { get; set; }
        public virtual sube sube { get; set; }
        [DefaultValue(false)]
        public bool silindiMi { get; set; }
    }
}