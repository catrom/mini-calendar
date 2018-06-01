using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCalendar
{
    public partial class frmAppointment : UserControl
    {
        Dictionary<int, Appointment> dataTable = new Dictionary<int, Appointment>();
        Dictionary<DateTime, List<int>> dateGroup = new Dictionary<DateTime, List<int>>();
        List<List<int>> taskOfDay = new List<List<int>>();
        

        // thuộc tính
        int totalWidth = 380;


        public frmAppointment()
        {
            InitializeComponent();
        }

        public frmAppointment(Dictionary<int, Appointment> dataTable)
        {
            InitializeComponent();
            this.dataTable = dataTable;

            
            dateGroupping();
            taskSorting();

            DrawTimeTable();
        }

        private int getID()
        {
            for (int i = 1; ; i++)
            {
                if (dataTable.ContainsKey(i) == false)
                {
                    return i;
                }
            }
        }

        
        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            
            frmNewAppointment form = new frmNewAppointment(getID(), dataTable, monthCalendar.SelectionRange.Start, false);
            form.Disposed += new EventHandler(dispose_event);
            panelNewApp.Controls.Add(form);

            panelTimeTable.Visible = false;
            btnNewAppointment.Enabled = false;
        }

        private void dispose_event(object sender, EventArgs e)
        {
            
            
            updateDrawingTimeTable();
            DrawTimeTable();

            panelTimeTable.Visible = true;
            btnNewAppointment.Enabled = true;

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            updateDrawingTimeTable();
            DrawTimeTable();
        }

        // 
        // PROCESSING TO DRAW TASKS ON TIMETABLE
        //

        // Nhóm các appoinment vào dictionary với key là ngày bắt đầu
        public void dateGroupping()
        {
            foreach (var i in dataTable)
            {
                DateTime time = new DateTime(i.Value.startHour.Year, i.Value.startHour.Month, i.Value.startHour.Day);
                if (dateGroup.ContainsKey(time) == false)
                {
                    dateGroup.Add(time, new List<int>());
                }
                dateGroup[time].Add(i.Key);
            }
        }

        // Sắp xếp tăng dần theo thời gian bắt đầu của tất cả appointment trong mỗi ngày
        public void taskSorting()
        {
            foreach (var i in dateGroup.Values)
            {
                for (int a = 0; a < i.Count; a++)
                {
                    for (int b = a + 1; b < i.Count; b++)
                    {
                        if (dataTable[i[a]].startHour > dataTable[i[b]].startHour)
                        {
                            var temp = dataTable[i[a]];
                            dataTable[i[a]] = dataTable[i[b]];
                            dataTable[i[b]] = temp;
                        }
                    }
                }
            }

        }

        // Hàm có chức năng sắp các task trong một ngày theo từng CỘT 
        // giúp tránh việc đụng độ khi thể hiện vẽ task ra màn hình
        public void taskOfDay_Building(List<int> list)
        {
            foreach (var i in list)
            {
                if(taskOfDay.Count == 0)
                {
                    taskOfDay.Add(new List<int>());
                    taskOfDay[0].Add(i);
                } 
                else
                {
                    bool isDone = false;
                    foreach (var l in taskOfDay)
                    {
                        bool isFill = false;
                        foreach (var a in l)
                        {
                            if ((dataTable[a].startHour <= dataTable[i].startHour && dataTable[i].startHour < dataTable[a].endHour) ||
                                (dataTable[a].startHour < dataTable[i].endHour && dataTable[i].endHour <= dataTable[a].endHour))
                            {
                                isFill = true;
                                break;
                            }
                        }
                        if (isFill == false)
                        {
                            l.Add(i);
                            isDone = true;
                            break;
                        }
                    }

                    if (isDone == false)
                    {
                        taskOfDay.Add(new List<int>());
                        taskOfDay[taskOfDay.Count - 1].Add(i);
                    }
                }
            }
        }

        // Hàm này được gọi khi có sự kiện Datechanged, thêm appointment...
        // clear tất cả các container cũ
        // tạo lại mới container
        public void updateDrawingTimeTable() 
        {
            // clear old data
            taskOfDay.Clear();
            dateGroup.Clear();

           
            // update new data
            dateGroupping();
            taskSorting();

            monthCalendar.BoldedDates = dateGroup.Keys.ToArray();
        }

        // Hàm hiển thị tất cả các task của cùng một ngày ra màn hình
        public void DrawTimeTable()
        {
            // bolded date in monthcalendar
            
            


            // clear old task
            for (int i = panelTimeTable.Controls.Count - 1; i >= 0; i--)
            {
                if (panelTimeTable.Controls[i] is Button)
                {
                    panelTimeTable.Controls.RemoveAt(i);
                }
            }



            // lấy ngày hiện tại của lịch chọn
            DateTime currentTime = new DateTime(monthCalendar.SelectionRange.Start.Year,
                                                monthCalendar.SelectionRange.Start.Month,
                                                monthCalendar.SelectionRange.Start.Day);

            if (dateGroup.ContainsKey(currentTime) == false)
            {
                return;
            }

            List<int> list = dateGroup[currentTime];

            taskOfDay_Building(list);

          
            int numsColumn = taskOfDay.Count;
            
            if (numsColumn < 3)
            {
                numsColumn = 3;
            }

           
           // MessageBox.Show(Convert.ToString(numsColumn) + "\n" + Convert.ToString(numsTasks));

            int idCol = 1;
            foreach(var col in taskOfDay)
            {
               foreach(var ID in col)
               {
                    drawingTask(ID, idCol, numsColumn);
               }

               ++idCol;
            }
        }

        // hàm vẽ task ra màn hình, sử dụng button
        public void drawingTask(int ID, int col, int numsCol)
        {
            totalWidth = (panelTimeTable.Width - 2) - 40;

            // width
            float width = (float)totalWidth / numsCol;

            // height
            int totalMinutes = (int)(dataTable[ID].endHour - dataTable[ID].startHour).TotalMinutes;
            float height = ((float)totalMinutes / 60) * (float)22.15; // 23 là độ rộng của một giờ trong timeTable

            // location
            float X = width * (col - 1) + 41;
            float Y = (dataTable[ID].startHour.Hour * 2 + dataTable[ID].startHour.Minute / 30) * (float)11.075; // 11.5 pixel là độ dài mỗi khoảng nửa giờ trong timeTable

            // color
            Color color = new Color();
            switch (dataTable[ID].Color)
            {
                case "Red":
                    color = Color.FromArgb(192, 0, 0);
                    break;
                case "Orange":
                    color = Color.FromArgb(255, 128, 0);
                    break;
                case "Yellow":
                    color = Color.FromArgb(192, 192, 0);
                    break;
                case "Green":
                    color = Color.FromArgb(0, 192, 0);
                    break;
                case "Blue":
                    color = Color.FromArgb(0, 192, 192);
                    break;
            }

            // draw
            Button task = new Button();
            task.Location = new Point((int)X, (int)Y);
            task.Width = (int)width;
            task.Height = (int)height;

            if (dataTable[ID].Title == "")
            {
                task.Text = "(No Title)";
            }
            else
            {
                task.Text = dataTable[ID].Title;
            }
            
            task.BackColor = color;
            task.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            task.ForeColor = System.Drawing.Color.White;
            task.TabIndex = ID;

            task.Click += btnTask_Click;


            panelTimeTable.Controls.Add(task); // thêm vào panel
            task.Visible = true;
            task.BringToFront();
        }

        public void btnTask_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmViewAppointment form = new frmViewAppointment(btn.TabIndex, dataTable);
            form.Disposed += new EventHandler(dispose_event);
            panelNewApp.Controls.Add(form);

            panelTimeTable.Visible = false;
        }

        private void panelTimeTable_SizeChanged(object sender, EventArgs e)
        {
            updateDrawingTimeTable();
            DrawTimeTable();
        }

        
    }
}
