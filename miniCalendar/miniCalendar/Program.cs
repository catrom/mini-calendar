using System;
using miniCalendar.Schedule;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            //Tạo thư mục mặc định chứa dữ liệu
            Directory.CreateDirectory("Data/Appointment");
            Directory.CreateDirectory("Data/Schedule");
            Directory.CreateDirectory("Data/ToDoList/Stt");
            Directory.CreateDirectory("Data/ToDoList/Sub");
            
            //Lấy dữ liệu
            DataTable dataTable = new DataTable();
            dataTable.Deserialize();

            monthItem myMonthCalendar = new monthItem();
            myMonthCalendar.Deserialize();

            TodoList todoList = new TodoList();
            todoList.Deserialize();

            Schedule.ScheduleDataTable scDataTable = new Schedule.ScheduleDataTable();
            scDataTable.Deserialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(dataTable, myMonthCalendar, todoList, scDataTable));
        }
    }
}
