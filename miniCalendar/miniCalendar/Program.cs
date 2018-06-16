using System;
using miniCalendar.Schedule;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCalendar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataTable dataTable = new DataTable();
            dataTable.Deserialize();

            monthItem myMonthCalendar = new monthItem();
            myMonthCalendar.Deserialize();

            TimeBlock test = new TimeBlock("a", 1, new DateTime(1, 1, 1, 1, 1, 1), new DateTime(1, 1, 1, 2, 2, 2), "Red", 10);
            bool[] enableWd = new bool[7] { true, true , false , true , false , true , true};
            List<TimeBlock> timeBlocks = new List<TimeBlock>();
            timeBlocks.Add(test);
            TimeTable timeTable = new TimeTable("b", enableWd, new DateTime(1, 1, 1, 2, 0, 0), new DateTime(1, 1, 1, 7, 30, 0), timeBlocks);
            TimeTable timeTable2 = new TimeTable("c", enableWd, new DateTime(1, 1, 1, 2, 30, 0), new DateTime(1, 1, 1, 4, 0, 0), timeBlocks);

            Schedule.ScheduleDataTable scDataTable = new Schedule.ScheduleDataTable();
            scDataTable.Add(timeTable);
            scDataTable.Add(timeTable2);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(scDataTable));
        }

    }
}
