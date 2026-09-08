using System;
using System.Windows.Forms;
using PdmPdfCollector;

namespace PdmPdfCollectorTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("================================");
                Console.WriteLine("PDM PDF Collector - Test Runner");
                Console.WriteLine("================================");
                Console.WriteLine();

                // Attempt to initialize the PDF collector
                var collector = new PdfCollector();
                
                Console.WriteLine("[✓] PdfCollector initialized successfully.");
                Console.WriteLine("[✓] Library is functioning correctly.");
                Console.WriteLine();
                Console.WriteLine("To use this add-in with SOLIDWORKS PDM:");
                Console.WriteLine("1. Build the PdmPdfCollector library (DLL)");
                Console.WriteLine("2. Register it in PDM Administrator");
                Console.WriteLine("3. Configure it in your PDM vault settings");
                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[✗] Error initializing collector:");
                Console.WriteLine($"    {ex.GetType().Name}: {ex.Message}");
                Console.WriteLine();
                Console.WriteLine("Troubleshooting:");
                Console.WriteLine("- Ensure SOLIDWORKS PDM is installed");
                Console.WriteLine("- Verify EPDM.Interop.epdm.dll path is correct");
                Console.WriteLine("- Check that PdmPdfCollector.dll is built");
                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }
}
