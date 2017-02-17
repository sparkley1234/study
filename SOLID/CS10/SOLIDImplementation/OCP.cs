using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDImplementation
{
    public class IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// if you want to introduce a new report type, then just inherit from IReportGeneration.
        /// So IReportGeneration is open for extension but closed for modification.
        /// </summary>
        /// <param name="em"></param>
        public virtual void GenerateReport(Employee em)
        {
            // From base
        }
    }
    /// <summary>
    /// Class to generate Crystal report
    /// </summary>
    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            // Generate crystal report.
        }
    }
    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            // Generate PDF report.
        }
    }
}
