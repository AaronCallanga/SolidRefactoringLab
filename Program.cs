using System;

namespace SolidRefactoringLab
{
    public class ReportManager
    {
        public string ReportData { get; set; }
        private readonly IReportFormatter _formatter;

        public ReportManager(IReportFormatter formatter) {
            _formatter = formatter;
        }

    
        public void GenerateReport() {
          _formatter.FormatReport(); 
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            IReportFormatter formatter = new PdfFormatter();
            ReportManager manager = new ReportManager(formatter);
            ReportSaver saver = new ReportSaver();

            manager.GenerateReport();
            saver.SaveToFile("Q1_Report.pdf");
        }
    }
}
