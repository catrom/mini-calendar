using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace miniCalendar
{
    [Serializable]

    public partial class frmAppointment : UserControl
    {
        Dictionary<int, Appointment> dataTable = new Dictionary<int, Appointment>();
        Dictionary<DateTime, List<int>> dateGroup = new Dictionary<DateTime, List<int>>();
        List<List<int>> taskOfDay = new List<List<int>>();

        // for my month calendar
        List<List<Button>> matrix = new List<List<Button>>();
        List<string> dayOfWeek = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        DateTime monthSelected = DateTime.Today;
        DateTime daySelected = DateTime.Today;
        List<Bunifu.Framework.UI.BunifuCheckbox> listColor = new List<Bunifu.Framework.UI.BunifuCheckbox>();
        Dictionary<DateTime, int> colorHistory = new Dictionary<DateTime, int>();
        Dictionary<DateTime, int> symbolHistory = new Dictionary<DateTime, int>();






        // mã màu RGB của bảng chọn màu cho ngày
        int[,] array = new int[8, 3] { { 215, 27, 95 }, { 229, 123, 114 }, { 239, 146, 1 }, { 245, 190, 44 },
            { 122, 178, 68}, {179, 157, 218 }, { 12, 155, 227}, { 6, 127, 68} };


        // thuộc tính
        int totalWidth = 380;


        public frmAppointment()
        {
            InitializeComponent();
        }

        public frmAppointment(Dictionary<int, Appointment> dataTable, monthItem myMonthCalendar)
        {
            InitializeComponent();

            this.dataTable = dataTable;
            this.colorHistory = myMonthCalendar.colorHistory;
            this.symbolHistory = myMonthCalendar.symbolHistory;

            lbToday.Text = "Today: " + DateTime.Today.ToString("ddddddddd, dd MMM yyyy");
            lbpickDay.Text = daySelected.ToString("dd/MM/yy");

            updateDrawingTimeTable();
            DrawTimeTable();

            initMatrix();
            showMonth(monthSelected);
            calendarColoring();


            initListColor();

        }

        // for my monthcalendar
        public void initMatrix()
        {
            Point location = new Point(3, 42);
            int id = 0;

            for (int i = 0; i < 6; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < 7; j++)
                {
                    var btn = new Button();

                    btn.BackColor = System.Drawing.Color.White;
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                    btn.Location = location;
                    btn.Name = id.ToString();
                    btn.Size = new System.Drawing.Size(35, 35);
                    btn.TabIndex = (i + 1) * (j + 1);
                    btn.Text = "";
                    btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                    btn.TabIndex = id++;

                    btn.Click += new EventHandler(day_Click);

                    matrix[i].Add(btn);
                    panelMonthCalendar.Controls.Add(btn);
                    location.X += 34;

                }
                location.X = 3;
                location.Y += 34;
            }

        }

        public void showMonth(DateTime date)
        {
            lbMonth.Text = monthSelected.ToString("MMMMMMMM yyyy");

            // clear 
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrix[i][j].Text = "";
                }
            }


            var start = new DateTime(date.Year, date.Month, 1);
            int numsOfDay = getDayOfMonth(date);
            int row = 0;

            for (int i = 1; i <= numsOfDay; i++, start = start.AddDays(1))
            {
                int col = dayOfWeek.IndexOf(start.DayOfWeek.ToString());

                matrix[row][col].ForeColor = Color.Black;
                matrix[row][col].Text = i.ToString();

                if (i == 1)
                {
                    DateTime oldMonth = start.AddMonths(-1);
                    int idx = getDayOfMonth(oldMonth);

                    for (int j = col - 1; j >= 0; j--, idx--)
                    {
                        matrix[row][j].ForeColor = Color.LightGray;
                        matrix[row][j].Text = idx.ToString();
                    }
                }

                if (col >= 6)
                {
                    row++;
                }

                if (i == numsOfDay)
                {
                    int idx = 1;
                    int j = (col + 1) % 7;

                    for (; j < 7; j++, idx++)
                    {
                        matrix[row][j].ForeColor = Color.LightGray;
                        matrix[row][j].Text = idx.ToString();

                        if (j == 6)
                        {
                            if (row == 4)
                            {
                                j = -1;
                                row++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }


        }

        public int getDayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || (date.Year % 400 == 0))
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }


        private void ibtnNext_Click(object sender, EventArgs e)
        {
            monthSelected = monthSelected.AddMonths(1);
            lbMonth.Text = monthSelected.ToString("MMMMMMMM yyyy");
            showMonth(monthSelected);
            calendarColoring();
        }

        private void ibtnPrev_Click(object sender, EventArgs e)
        {
            monthSelected = monthSelected.AddMonths(-1);
            lbMonth.Text = monthSelected.ToString("MMMMMMMM yyyy");
            showMonth(monthSelected);
            calendarColoring();
        }

        private List<int> getDayClick()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (matrix[i][j].ForeColor == Color.Black && matrix[i][j].Text == daySelected.Day.ToString())
                    {
                        return new List<int> { i, j };
                    }
                }
            }
            return null;
        }

        private void day_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            // thay đổi tháng nếu ô được chọn là của tháng trước / tháng sau
            if (btn.ForeColor == Color.LightGray)
            {
                if (btn.TabIndex / 7 == 0)
                {
                    monthSelected = monthSelected.AddMonths(-1);
                }
                else if (btn.TabIndex / 7 >= 3)
                {
                    monthSelected = monthSelected.AddMonths(1);
                }

            }


            daySelected = new DateTime(monthSelected.Year, monthSelected.Month, Convert.ToInt32(btn.Text));
            lbpickDay.Text = daySelected.ToString("dd/MM/yy");

            // nếu không nằm trong dateGroup thì đóng 2 cái tag chọn symbol với chọn màu.
            if (dateGroup.ContainsKey(daySelected) == false)
            {
                panelSymbol.Height = 30;
                panelColor.Height = 30;
            }



            //MessageBox.Show(daySelected.ToString());
            showMonth(monthSelected);
            calendarColoring();


            // vẽ lại bảng công việc
            updateDrawingTimeTable();
            DrawTimeTable();

            // sửa đổi thông tin ở bảng chọn màu
            if (colorHistory.ContainsKey(daySelected) == true)
            {
                // un check mấy cái cũ
                for (int i = 0; i < 8; i++)
                {
                    listColor[i].Checked = false;
                }

                listColor[colorHistory[daySelected]].Checked = true;
            }
        }

        private void lbToday_Click(object sender, EventArgs e)
        {
            monthSelected = DateTime.Today;
            daySelected = DateTime.Today;
            showMonth(monthSelected);
            calendarColoring();
            lbpickDay.Text = daySelected.ToString("dd/MM/yy");
        }

        private void calendarColoring()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (matrix[i][j].ForeColor == Color.LightGray)
                    {
                        if (i == 0)
                        {
                            DateTime prevMonth = monthSelected.AddMonths(-1);
                            DateTime dateButton = new DateTime(prevMonth.Year, prevMonth.Month, Convert.ToInt32(matrix[i][j].Text));

                            // set color
                            if (colorHistory.ContainsKey(dateButton) == true) {
                                matrix[i][j].BackColor = Color.FromArgb(array[colorHistory[dateButton], 0],
                                                                        array[colorHistory[dateButton], 1],
                                                                        array[colorHistory[dateButton], 2]);
                            }
                            else
                            {
                                matrix[i][j].BackColor = Color.White;
                            }

                            // set symbol
                            if (symbolHistory.ContainsKey(dateButton) == true)
                            {
                                matrix[i][j].Image = getImage(symbolHistory[dateButton]);
                            }
                            else
                            {
                                matrix[i][j].Image = null;
                            }
                        }
                        else if (i >= 3)
                        {
                            DateTime nextMonth = monthSelected.AddMonths(1);
                            DateTime dateButton = new DateTime(nextMonth.Year, nextMonth.Month, Convert.ToInt32(matrix[i][j].Text));

                            if (colorHistory.ContainsKey(dateButton) == true)
                            {
                                matrix[i][j].BackColor = Color.FromArgb(array[colorHistory[dateButton], 0],
                                                                        array[colorHistory[dateButton], 1],
                                                                        array[colorHistory[dateButton], 2]);
                            }
                            else
                            {
                                matrix[i][j].BackColor = Color.White;
                            }

                            if (symbolHistory.ContainsKey(dateButton) == true)
                            {
                                matrix[i][j].Image = getImage(symbolHistory[dateButton]);
                            }
                            else
                            {
                                matrix[i][j].Image = null;
                            }
                        }
                    }
                    else
                    {
                        DateTime dateButton = new DateTime(monthSelected.Year, monthSelected.Month, Convert.ToInt32(matrix[i][j].Text));

                        if (colorHistory.ContainsKey(dateButton) == true)
                        {
                            matrix[i][j].BackColor = Color.FromArgb(array[colorHistory[dateButton], 0],
                                                                        array[colorHistory[dateButton], 1],
                                                                        array[colorHistory[dateButton], 2]);
                        }
                        else if (dateButton == DateTime.Today)
                        {
                            matrix[i][j].BackColor = Color.FromArgb(68, 133, 242);
                        }
                        else if (dateButton == daySelected)
                        {
                            matrix[i][j].BackColor = Color.FromArgb(223, 223, 223);
                        }
                        else
                        {
                            matrix[i][j].BackColor = Color.White;
                        }

                        if (symbolHistory.ContainsKey(dateButton) == true)
                        {
                            matrix[i][j].Image = getImage(symbolHistory[dateButton]);
                        }
                        else
                        {
                            matrix[i][j].Image = null;
                        }
                    }
                }
            }
        }

        private void initListColor()
        {
            
            Point location = new Point(27, 34);

            for (int i = 0; i < 8; i++)
            {
                Bunifu.Framework.UI.BunifuCheckbox checkbox = new Bunifu.Framework.UI.BunifuCheckbox();

                checkbox.BackColor = System.Drawing.Color.FromArgb(array[i,0], array[i,1], array[i,2]);
                checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(array[i, 0], array[i, 1], array[i, 2]);
                checkbox.Checked = false;
                checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(array[i, 0], array[i, 1], array[i, 2]);
                checkbox.ForeColor = System.Drawing.Color.White;
                checkbox.Location = location;
                checkbox.Name = "checkboxColor" + i.ToString();
                checkbox.Size = new System.Drawing.Size(20, 20);
                checkbox.TabIndex = i;
                checkbox.Click += new EventHandler(colorPicker);

                panelColor.Controls.Add(checkbox);
                listColor.Add(checkbox);
                location.X += 25;
            }
            
        }


        // hàm xử lí khi người dùng chọn màu từ bảng màu
        private void colorPicker(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                listColor[i].Checked = false;
            }

            var pick = (Bunifu.Framework.UI.BunifuCheckbox)sender;
            pick.Checked = true;

            List<int> dayInMatrix = getDayClick();
            matrix[dayInMatrix[0]][dayInMatrix[1]].BackColor = pick.BackColor;
            colorHistory[daySelected] = pick.TabIndex;
        }

        private Image getImage(int index)
        {
            switch(index)
            {
                case 0:
                    return null;
                case 1:
                    return (Image)(new Bitmap(Properties.Resources.icons8_Destination_48, new Size(16, 16)));
                case 2:
                    return (Image)(new Bitmap(Properties.Resources.icons8_Expired_48, new Size(16, 16)));
                case 3:
                    return (Image)(new Bitmap(Properties.Resources.icons8_North_Direction_48, new Size(16, 16)));
                case 4:
                    return (Image)(new Bitmap(Properties.Resources.icons8_Poison_48, new Size(16, 16))); 
                case 5:
                    return (Image)(new Bitmap(Properties.Resources.icons8_Sports_Mode_48, new Size(16, 16))); 
                case 6:
                    return (Image)(new Bitmap(Properties.Resources.icons8_Star_48, new Size(16, 16)));
                case 7:
                    return (Image)(new Bitmap(Properties.Resources.icons8_Heart_Outline_48, new Size(16, 16))); 

            }

            return null;
        }

        private void symbol_Click(object sender, EventArgs e)
        {
            List<int> dayInMatrix = getDayClick();
            var pick = (Bunifu.Framework.UI.BunifuImageButton)sender;
            int index = pick.Name[pick.Name.Length - 1] - '0';

            matrix[dayInMatrix[0]][dayInMatrix[1]].Image = getImage(index);
            symbolHistory[daySelected] = index;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dateGroup.ContainsKey(daySelected))
            {
                if (panelSymbol.Height == 30)
                {
                    panelSymbol.Height = 65;
                }
                else
                {
                    panelSymbol.Height = 30;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (dateGroup.ContainsKey(daySelected))
            {
                if (panelColor.Height == 30)
                {
                    panelColor.Height = 65;
                }
                else
                {
                    panelColor.Height = 30;
                }
            }
        }


        // ---------------------------------------------------------------------

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
            
            frmNewAppointment form = new frmNewAppointment(getID(), dataTable, daySelected, false);
            form.Disposed += new EventHandler(dispose_event);
            panelNewApp.Controls.Add(form);

            panelTimeTable.Visible = false;
            btnNewAppointment.Enabled = false;
            panelMonthCalendar.Enabled = false;
            panelColor.Enabled = false;
            panelSymbol.Enabled = false;
        }

        private void dispose_event(object sender, EventArgs e)
        {
            
            
            updateDrawingTimeTable();
            DrawTimeTable();

            panelTimeTable.Visible = true;
            btnNewAppointment.Enabled = true;
            panelMonthCalendar.Enabled = true;
            panelColor.Enabled = true;
            panelSymbol.Enabled = true;
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

            
            // gán giá trị cho color history
            foreach (var key in dateGroup.Keys)
            {
                if (colorHistory.ContainsKey(key) == false)
                {
                    colorHistory.Add(key, 0);
                }
            }

            // xoá các giá trị bị dư của color history
            foreach (var key in colorHistory.Keys)
            {
                if (dateGroup.ContainsKey(key) == false)
                {
                    colorHistory.Remove(key);
                    break;
                }
            }

            // gán giá trị cho symbol history
            foreach (var key in dateGroup.Keys)
            {
                if (symbolHistory.ContainsKey(key) == false)
                {
                    symbolHistory.Add(key, 0);
                }
            }

            // xoá các giá trị bị dư của symbol history
            foreach (var key in symbolHistory.Keys)
            {
                if (dateGroup.ContainsKey(key) == false)
                {
                    symbolHistory.Remove(key);
                    break;
                }
            }
            
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
            DateTime currentTime = daySelected;

            if (dateGroup.ContainsKey(currentTime) == false)
            {
                return;
            }

            List<int> list = dateGroup[currentTime];

            taskOfDay_Building(list);

          
            int numsColumn = taskOfDay.Count;
            
            if (numsColumn < 5)
            {
                numsColumn = 5;
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

        private void frmAppointment_Move(object sender, EventArgs e)
        {
            
        }
    }
}
