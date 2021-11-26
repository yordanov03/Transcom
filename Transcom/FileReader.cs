namespace PSITranscom
{
    public static class FileReader
    {
        public static string[] ImportRunningDaysFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A32_Sample SPOT Table TOMSCALENDAR.txt");
            return lines;
        }
        public static string[] ImportTimetableFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A34_Sample SPOT Table TOMSTRAINHEAD.txt");
            return lines;
        }

        public static string[] ImportScheduleFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A33_Sample SPOT Table TOMSTRAINDET.txt");
            return lines;
        }
    }
}
