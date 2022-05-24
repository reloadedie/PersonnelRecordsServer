using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class WorkerExp
    {
        public WorkerApi Worker { get; set; }

        public List<WorkerCompanyExp> History { get; set; } = new List<WorkerCompanyExp>();
    }

    public class WorkerCompanyExp
    {
        public CompanyApi Company { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int IsRemuved { get; set; }
    }
}
