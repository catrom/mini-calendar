using System;
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

            TodoList todoList = new TodoList();
            todoList.Deserialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(dataTable, myMonthCalendar, todoList));
        }
        
    }
}
