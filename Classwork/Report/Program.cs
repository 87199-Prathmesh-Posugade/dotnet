using System;

namespace Report
{
    public abstract class Report
    {
        public virtual void generateReport() {
        }
        protected abstract void CreateReport();
        protected abstract void ParseReport();
        protected abstract void ValidateReport();
        protected abstract void SaveReport();
        public void ProcessReport()
        {
            CreateReport();
            ParseReport();
            ValidateReport();
            SaveReport();
        }
    }
    public sealed class PDF : Report {
        protected override void CreateReport() {
            Console.WriteLine("creating report for pdf");
        }
        protected override void ParseReport() { 
            Console.WriteLine("parsing report for pdf");
        }
        protected override void ValidateReport() { 
            Console.WriteLine("validating report for pdf");
        }
        protected override void SaveReport()
        {
            Console.WriteLine("Saving report for pdf");
        }
    }

    public sealed class TXT : Report { 
        protected override void CreateReport() {
            Console.WriteLine("creating report for txt");
        }
        protected override void ParseReport() { 
            Console.WriteLine("parsing report for txt");
        }
        protected override void ValidateReport() { 
            Console.WriteLine("validating report for txt");
        }
        protected override void SaveReport(){
            Console.WriteLine("Saving report for txt");
        }
    }

    public abstract class AdvancedReport : Report {
        protected abstract void RevalidateReport();
        public override void generateReport() {
            CreateReport();
            ParseReport();
            ValidateReport();
            RevalidateReport();
            SaveReport();
        }
    }
    public sealed class JSON : AdvancedReport
    {
        protected override void RevalidateReport()
        {
            Console.WriteLine("revalidating report for json");
        }

        protected override void CreateReport()
        {
            Console.WriteLine("creating report for json");
        }

        protected override void ParseReport()
        {
            Console.WriteLine("parsing report for json");
        }

        protected override void SaveReport()
        {
            Console.WriteLine("saving report for json");
        }

        protected override void ValidateReport()
        {
            Console.WriteLine("validating report for json");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Report pdf = new PDF();
            pdf.ProcessReport();
            Report json = new JSON();
            json.generateReport();
        }
    }
}
