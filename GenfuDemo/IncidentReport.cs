using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenfuDemo
{
    internal class IncidentReport
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ReportedOn { get; set; }
        public Person ReportedBy { get; set; }
    }
}
