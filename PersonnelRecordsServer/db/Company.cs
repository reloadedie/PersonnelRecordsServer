﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class Company
    {
        public Company()
        {
            Staffings = new HashSet<Staffing>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public int? IsRemuved { get; set; }

        public virtual ICollection<Staffing> Staffings { get; set; }
    }
}
