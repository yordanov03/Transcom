namespace PSITranscom
{
    public static class FileReader
    {
        public static string[] ImportRunningCalendarFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A32_Sample SPOT Table TOMSCALENDAR.txt");
            return lines;
        }
        public static string[] ImportRunningDayFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A34_Sample SPOT Table TOMSTRAINHEAD.txt");
            return lines;
        }

        public static string[] ImportTimeTableFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A33_Sample SPOT Table TOMSTRAINDET.txt");
            return lines;
        }
    }
}
