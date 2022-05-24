using System;

namespace ModelApi
{
    public class WorkerExpGetDates
    {
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public WorkerApi Worker { get; set; }
        public string Postion { get; set; }
        public int? IsRemuved { get; set; }
    }
}