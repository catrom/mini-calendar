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
    public partial class frmAppointment : UserControl
    {
        #region Các thuộc tính

        #region Thuộc tính chính của form Appointment

        // Danh sách các appointment theo ID
        Dictionary<int, Appointment> dataTable = new Dictionary<int, Appointment>();
        // Nhóm các appointment lại theo ngày (key là ngày, value là list các ID)
        Dictionary<DateTime, List<int>> dateGroup = new Dictionary<DateTime, List<int>>();
        // Phân nhóm các ID của một ngày theo từng cột để tránh va chạm khi vẽ các task ra màn hình
        List<List<int>> taskOfDay = new List<List<int>>();
        // Độ rộng vùng showArea dùng để vẽ task, dùng để tính toán xác định độ rộng của một task khi vẽ
        int totalWidth = 380;

        #endregion

        #region Thuộc tính của myMonthCalendar

        /*
         * Câu hỏi: Tại sao lại tạo mới MonthCalendar mà không dùng toolbox có sẵn?
         * -> Việc tạo riêng myMonthCalendar sẽ cho phép các điều sau:
         *     - Tuỳ ý custom lại nút chọn ngày (thay đổi màu, thêm kí hiệu), tăng trải nghiệm người dùng
         *      - Cho phép chọn nhiều ngày cùng lúc khi nhấn giữ phím CTRL (tính năng đặt lịch hẹn giống nhau cho nhiều ngày)
         *      - Tính năng double click để vào nhanh form điền thông tin lịch hẹn mới
         *      - Đẹp hơn... :D
         */

        // Ma trận lưu các button thể hiện ngày của myMonthCalendar
        // Vì button mặc định không cho phép sự kiện doubleclick nên cần tạo một class myButton (kế thừa button) (ở dưới cùng của file này).
        List<List<myButton>> matrix = new List<List<myButton>>();
        List<string> dayOfWeek = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        // Xác định tháng được chọn để hiển thị lịch, mặc định khi khởi tạo là Datetime.Today
        DateTime monthSelected = DateTime.Today;
        // Danh sách các ngày được chọn khi nháy chọn button, mặc định khởi tạo là Datetime.Today
        List<DateTime> daySelected= new List<DateTime> { DateTime.Today };
        // Các checkbox chọn màu để thay đổi màu cho ngày có cuộc hẹn,
        // đưa vào list để dễ dàng uncheck
        List<Bunifu.Framework.UI.BunifuCheckbox> listColor = new List<Bunifu.Framework.UI.BunifuCheckbox>();
        // Lưu giá trị màu cho ngày có cuộc hẹn 
        Dictionary<DateTime, int> colorHistory = new Dictionary<DateTime, int>();
        // Lưu giá trị kí hiệu cho ngày có cuộc hẹn
        Dictionary<DateTime, int> symbolHistory = new Dictionary<DateTime, int>();
        // Mã màu RGB của bảng chọn màu cho ngày
        int[,] array = new int[8, 3] { { 215, 27, 95 }, { 229, 123, 114 }, { 239, 146, 1 }, { 245, 190, 44 },
            { 122, 178, 68}, {179, 157, 218 }, { 12, 155, 227}, { 6, 127, 68} };

        #endregion

        #endregion

        #region Contrucstor

        public frmAppointment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        /// <param name="dataTable">Danh sách các cuộc hẹn theo ID có được sau khi Deserialize</param>
        /// <param name="myMonthCalendar">Dữ liệu về màu, kí hiệu của các ngày có lịch hẹn</param>
        public frmAppointment(Dictionary<int, Appointment> dataTable, monthItem myMonthCalendar)
        {
            InitializeComponent();

            this.dataTable = dataTable;
            this.colorHistory = myMonthCalendar.colorHistory;
            this.symbolHistory = myMonthCalendar.symbolHistory;

            lbToday.Text = "Today: " + DateTime.Today.ToString("ddddddddd, dd MMM yyyy");
            lbpickDay.Text = daySelected[0].ToString("dd/MM/yy");

            updateTimeTable();
            DrawTimeTable();

            initMatrix();
            showMonth(monthSelected);
            calendarColoring();


            initListColor();

        }

        #endregion

        #region Các phương thức dùng để vẽ ra màn hình

        /// <summary>
        /// Khởi tạo ma trận button cho myMonthCalendar
        /// </summary>
        public void initMatrix()
        {
            Point location = new Point(3, 42);
            int id = 0;

            for (int i = 0; i < 6; i++)
            {
                matrix.Add(new List<myButton>());
                for (int j = 0; j < 7; j++)
                {
                    var btn = new myButton();

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
                    btn.DoubleClick += new EventHandler(btnNewAppointment_Click);

                    matrix[i].Add(btn);
                    panelMonthCalendar.Controls.Add(btn);
                    location.X += 34;

                }
                location.X = 3;
                location.Y += 34;
            }
        }

        /// <summary>
        /// Hiển thị giá trị ngày cho ma trận các button
        /// </summary>
        /// <param name="date">Ngày được chọn</param>
        public void showMonth(DateTime date)
        {
            lbMonth.Text = monthSelected.ToString("MMMMMMMM yyyy");

            // xoá tất cả các text cũ 
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

            // Đoạn code hiển thị ngày sẽ gồm 2 phần:
            // - Hiển thị ngày của tháng được chọn (có màu đen)
            // - Hiển thị ngày của tháng trước đó, và tháng sau đó (có màu xám)

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

        /// <summary>
        /// Thể hiện màu sắc, kí hiệu cho ma trận ngày.
        /// Thuật toán (chưa cải tiến):
        /// Duyệt mảng 2 chiều, với mỗi vị trí lấy giá trị ngày mà button đó thể hiện.
        /// Kiểm tra nếu ngày đó có trong colorHistory, symbolHistory thì đổi màu hay thêm kí tự cho button đó. 
        /// </summary>
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
                        else if (daySelected.Contains(dateButton) == true)
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

        /// <summary>
        /// Khởi tạo list các checkbox chọn màu cho button ngày
        /// (Đưa vào list để dễ quản lí, uncheck, check...)
        /// </summary>
        private void initListColor()
        {
            // vị trí của checkbox đầu tiên
            Point location = new Point(27, 34);

            for (int i = 0; i < 8; i++)
            {
                Bunifu.Framework.UI.BunifuCheckbox checkbox = new Bunifu.Framework.UI.BunifuCheckbox();

                checkbox.BackColor = System.Drawing.Color.FromArgb(array[i, 0], array[i, 1], array[i, 2]);
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

                // cập nhật vị trí cho checkbox kế tiếp
                location.X += 25;
            }
        }

        /// <summary>
        /// Hàm có chức năng hiển thị tất cả các task của ngày được chọn ra màn hình.
        /// </summary>
        public void DrawTimeTable()
        {
            // Xoá các task cũ.
            for (int i = panelTimeTable.Controls.Count - 1; i >= 0; i--)
            {
                if (panelTimeTable.Controls[i] is Button)
                {
                    panelTimeTable.Controls.RemoveAt(i);
                }
            }



            // Lấy ngày hiện tại của lịch chọn
            DateTime currentTime = daySelected[0];

            if (dateGroup.ContainsKey(currentTime) == false)
            {
                return;
            }


            List<int> list = dateGroup[currentTime];
            taskOfDay_Building(list);


            int numsColumn = taskOfDay.Count;

            // Xử lí số lượng cột để canh độ rộng cho task.
            if (numsColumn < 5)
            {
                numsColumn = 5;
            }


            int idCol = 1;
            foreach (var col in taskOfDay)
            {
                foreach (var ID in col)
                {
                    drawingTask(ID, idCol, numsColumn);
                }

                ++idCol;
            }
        }

        /// <summary>
        /// Vẽ một task ra màn hình (sử dụng button).
        /// </summary>
        /// <param name="ID">ID của appointment mà task đó đang thể hiện</param>
        /// <param name="col">Vị trí cột của task</param>
        /// <param name="numsCol">Tổng số cột của taskOfDay</param>
        public void drawingTask(int ID, int col, int numsCol)
        {
            // Tính độ rộng của khu vực dùng để vẽ task
            totalWidth = (panelTimeTable.Width - 2) - 40;

            // Tính chiều rộng 
            float width = (float)totalWidth / numsCol;

            // Tính chiều dài
            // Giải quyết 2 trường hợp: appointment kết thúc trong một ngày, và kéo dài trong nhiều ngày.

            int totalMinutes = 0;
            float height = 0;
            int totStart = dataTable[ID].startHour.DayOfYear;
            int totEnd = dataTable[ID].endHour.DayOfYear;
            int totSelected = daySelected[0].DayOfYear;

            // Xảy ra trong một ngày
            if (totStart == totEnd)
            {
                totalMinutes = (int)(dataTable[ID].endHour - dataTable[ID].startHour).TotalMinutes;
            }
            else // Kéo dài trong nhiều ngày
            {
                if (totStart == totSelected)
                {
                    var temp = new DateTime(dataTable[ID].startHour.Year, dataTable[ID].startHour.Month, dataTable[ID].startHour.Day, 23, 59, 59);
                    totalMinutes = (int)(temp - dataTable[ID].startHour).TotalMinutes;
                }
                else if (totSelected < totEnd)
                {
                    totalMinutes = 1440;
                }
                else
                {
                    var temp = new DateTime(daySelected[0].Year, daySelected[0].Month, daySelected[0].Day, 0, 0, 0);
                    totalMinutes = (int)(dataTable[ID].endHour - temp).TotalMinutes;
                }
            }

            height = ((float)totalMinutes / 60) * (float)22.15; // 22.15 pixel là chiều cao của "một ô giờ" trong timeTable


            // Tính toán vị trí 
            float X = width * (col - 1) + 41;
            float Y = 0;
            if (totStart == totSelected)
            {
                Y = (dataTable[ID].startHour.Hour * 2 + dataTable[ID].startHour.Minute / 30) * (float)11.075; // 11.5 = 22.15/2 là chiều cao của mỗi "khoảng nửa giờ" trong timeTable
            }
            else
            {
                Y = 0;
            }

            // Lấy giá trị màu
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

            // Vẽ task ra màn hình (sử dụng button).
            Button task = new Button();
            task.Location = new Point((int)X, (int)Y);
            task.Width = (int)width;
            task.Height = (int)height;

            // Hiển thị nội dung text của task.
            // Trường hợp không có tiêu đề
            if (dataTable[ID].Title == "")
            {
                task.Text = "(No Title)";
            }
            else // Trường hợp có tiêu đề.
            {
                task.Text = dataTable[ID].Title;
            }
            // Trường hợp task kéo dài trong nhiều ngày, hiển thị thêm thông tin về số lượng ngày.
            if (totStart != totEnd)
            {
                task.Text += "\n";
                task.Text += "(" + (totSelected - totStart + 1).ToString() + "/" + (totEnd - totStart + 1).ToString() + ")";
            }

            task.BackColor = color;
            task.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            task.ForeColor = System.Drawing.Color.White;

            // Gán TabIndex = ID để biết được task đang thể hiện cho appointment nào, dùng cho sự kiện task_click. 
            task.TabIndex = ID;
            task.Click += btnTask_Click;

            panelTimeTable.Controls.Add(task); // thêm vào panelTimeTable để dễ xoá sau này.
            task.Visible = true;
            task.BringToFront();
        }

        #endregion

        #region Xử lí sự kiện

        /// <summary>
        /// Sự kiện image button Next được click (next month)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnNext_Click(object sender, EventArgs e)
        {
            monthSelected = monthSelected.AddMonths(1);
            lbMonth.Text = monthSelected.ToString("MMMMMMMM yyyy");
            showMonth(monthSelected);
            calendarColoring();
        }

        /// <summary>
        /// Sự kiện image button Prev được click (previous month)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnPrev_Click(object sender, EventArgs e)
        {
            monthSelected = monthSelected.AddMonths(-1);
            lbMonth.Text = monthSelected.ToString("MMMMMMMM yyyy");
            showMonth(monthSelected);
            calendarColoring();
        }


        /* 
         * Đây là BUG
         * Để hiện thực tính năng double click cho button ngày, cần tạo class mới là myButton.
         * Tuy nhiên khi click vào myButton thì sự kiện click bị "hiểu nhầm" là doubleclick, và ngược lại...
         * --> Tóm lại là không thể chọn được nhiều ngày cùng lúc khi nhấn giữ phím Ctrl.
         * 
         * Giải quyết: Tạo thêm biến bool firstClick để kiểm tra mỗi khi sự kiện day_Click được gọi.
         */

        bool firstClick = true;

        /// <summary>
        /// Sự kiện khi chọn ngày trong myMonthCalendar.
        /// Công việc: 
        /// - Giải quyết bug doubleclick
        /// - Thay đổi dữ liệu của daySelected
        /// - Cập nhật việc hiển thị giá trị ngày và tô màu cho myMonthCalendar
        /// - Vẽ lại bảng công việc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void day_Click(object sender, EventArgs e)
        {
            // Kiểm tra biến firstClick, giải quyết bug.
            var btn = (Button)sender;
            if (firstClick == true)
            {
                firstClick = false;
                return;
            }
            firstClick = true;


            // thay đổi tháng nếu ô được chọn là của tháng trước / tháng sau 
            // (sử dụng màu chữ và tabIndex của ô được click)
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

            // Lấy thông tin về ngày được click
            var pick = new DateTime(monthSelected.Year, monthSelected.Month, Convert.ToInt32(btn.Text));

            // Xử lí việc chọn nhiều ngày khi nhấn phím Ctrl
            if (ModifierKeys == Keys.Control)
            {
                //MessageBox.Show("Y");
                if (daySelected.Contains(pick) == true)
                {
                    if (daySelected.Count == 1)
                    {
                        return;
                    }

                    daySelected.Remove(pick);
                }
                else
                {
                    daySelected.Add(pick);
                }
            }
            else
            {
                //MessageBox.Show("N");
                daySelected.Clear();
                daySelected = new List<DateTime> { pick };
            }

            lbpickDay.Text = daySelected[0].ToString("dd/MM/yy");

            // nếu không nằm trong dateGroup thì đóng 2 cái tag chọn symbol với chọn màu.
            if ((daySelected.Count == 1 && dateGroup.ContainsKey(daySelected[0]) == false) ||
                daySelected.Count > 1)
            {
                panelSymbol.Height = 30;
                panelColor.Height = 30;
            }
            else
            {
                // sửa đổi thông tin ở bảng chọn màu
                if (colorHistory.ContainsKey(daySelected[0]) == true)
                {
                    // uncheck các checkbox chọn màu 
                    for (int i = 0; i < 8; i++)
                    {
                        listColor[i].Checked = false;
                    }

                    listColor[colorHistory[daySelected[0]]].Checked = true;
                }
            }

            // cập nhật việc hiển thị giá trị ngày và tô màu cho myMonthCalendar
            showMonth(monthSelected);
            calendarColoring();

            // vẽ lại bảng công việc
            if (daySelected.Count == 1)
            {
                updateTimeTable();
                DrawTimeTable();
            }
        }

        /// <summary>
        /// Sự kiện khi người dùng nháy vào label Today.
        /// Thay đổi và cập nhật các thông tin có liên quan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbToday_Click(object sender, EventArgs e)
        {
            monthSelected = DateTime.Today;
            daySelected[0] = DateTime.Today;
            showMonth(monthSelected);
            calendarColoring();
            lbpickDay.Text = daySelected[0].ToString("dd/MM/yy");

            updateTimeTable();
            DrawTimeTable();
        }

        /// <summary>
        /// Hàm có chức năng xử lí khi người dùng nháy chọn checkbox màu.
        /// Bao gồm: 
        /// - Uncheck tất cả các checkbox
        /// - Check cái checkbox được chọn
        /// - Thay đổi màu cho các button được chọn và cập nhật thông tin cho colorHistory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPicker(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                listColor[i].Checked = false;
            }

            var pick = (Bunifu.Framework.UI.BunifuCheckbox)sender;
            pick.Checked = true;

            var dayInMatrix = getButtonPositionClick();

            for (int i = 0; i < dayInMatrix.Count; i++)
            {
                matrix[dayInMatrix[i][0]][dayInMatrix[i][1]].BackColor = pick.BackColor;
                colorHistory[daySelected[i]] = pick.TabIndex;
            }

        }

        /// <summary>
        /// Hàm có chức năng xử lí khi người dùng nháy chọn symbol.
        /// Thêm kí hiệu cho các ngày được chọn và cập nhật vào symbolHistory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void symbolPicker(object sender, EventArgs e)
        {
            var dayInMatrix = getButtonPositionClick();
            var pick = (Bunifu.Framework.UI.BunifuImageButton)sender;
            int index = pick.Name[pick.Name.Length - 1] - '0';

            for (int i = 0; i < dayInMatrix.Count; i++)
            {
                matrix[dayInMatrix[i][0]][dayInMatrix[i][1]].Image = getImage(index);
                symbolHistory[daySelected[i]] = index;
            }
        }

        /// <summary>
        /// Hàm xử lí khi người dùng click vô biểu tượng 'symbol' hay label "Symbols"
        /// Thay đổi kích thước của panelSymbol.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dateGroup.ContainsKey(daySelected[0]))
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

        /// <summary>
        /// Hàm xử lí khi người dùng click vô biểu tượng 'color' hay label "Colors"
        /// Thay đổi kích thước của panelColor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (dateGroup.ContainsKey(daySelected[0]))
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

        /// <summary>
        /// Xử lí sự kiện button NewAppointment click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            if (daySelected.Count == 1)
            {
                frmNewAppointment form = new frmNewAppointment(new List<int> { getID() }, dataTable, daySelected, false);
                form.Disposed += new EventHandler(dispose_event);
                panelNewApp.Controls.Add(form);
            }
            else
            {
                // Lấy list ID dùng cho daySelected

                List<int> listID = new List<int>();
                int nums = daySelected.Count;

                for (int i = 1; nums > 0; i++)
                {
                    if (dataTable.ContainsKey(i) == false)
                    {
                        listID.Add(i);
                        nums--;
                    }
                }

                frmNewAppointment form = new frmNewAppointment(listID, dataTable, daySelected, false);
                form.Disposed += new EventHandler(dispose_event);
                panelNewApp.Controls.Add(form);
            }

            panelTimeTable.Visible = false;
            btnNewAppointment.Enabled = false;
            panelMonthCalendar.Enabled = false;
            panelColor.Enabled = false;
            panelSymbol.Enabled = false;
        }

        /// <summary>
        /// Xử lí sự kiện dispose của form NewAppointment và form ViewAppointment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispose_event(object sender, EventArgs e)
        {
            updateTimeTable();
            DrawTimeTable();

            for (int i = daySelected.Count - 1; i > 0; i--)
            {
                daySelected.RemoveAt(i);
            }

            showMonth(monthSelected);
            calendarColoring();

            panelTimeTable.Visible = true;
            btnNewAppointment.Enabled = true;
            panelMonthCalendar.Enabled = true;
            panelColor.Enabled = true;
            panelSymbol.Enabled = true;
        }

        /// <summary>
        /// Hàm xử lí sự kiện task click.
        /// Gọi form ViewAppointment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnTask_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmViewAppointment form = new frmViewAppointment(btn.TabIndex, dataTable);
            form.Disposed += new EventHandler(dispose_event);
            panelNewApp.Controls.Add(form);

            panelTimeTable.Visible = false;
            btnNewAppointment.Enabled = false;
            panelMonthCalendar.Enabled = false;
            panelColor.Enabled = false;
            panelSymbol.Enabled = false;
        }

        /// <summary>
        /// Hàm xử lí khi panelTimeTable (vùng để vẽ task) thay đổi kích thước.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTimeTable_SizeChanged(object sender, EventArgs e)
        {
            updateTimeTable();
            DrawTimeTable();
        }

        #endregion

        #region Các hàm tính toán và xử lí dữ liệu

        /// <summary>
        /// Trả về số lượng ngày của một tháng 
        /// </summary>
        /// <param name="date">Thông tin về ngày được truyền vào</param>
        /// <returns></returns>
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

        /// <summary>
        /// Trả về vị trí trong ma trận (hàng, cột) của các button được nhấn.
        /// Vì daySelected là một list (cho phép chọn nhiều ngày) nên kiểu trả về của hàm cũng là list (nhiều cặp vị trí)
        /// (Có thể sử dụng tabIndex của button được khởi gán trong hàm initMatrix, tuy nhiên cần phải thay đổi nhiều thứ về sau,
        /// nên tạm thời vẫn sử dụng hàm này để lấy vị trí)
        /// </summary>
        /// <returns></returns>
        private List<List<int>> getButtonPositionClick()
        {
            List<List<int>> position = new List<List<int>>();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    foreach (var daySelect in daySelected)
                    {
                        if (matrix[i][j].ForeColor == Color.Black && matrix[i][j].Text == daySelect.Day.ToString())
                        {
                            position.Add(new List<int> { i, j });
                        }
                    }

                }
            }
            return position;
        }

        /// <summary>
        /// Hàm trả về giá trị image tương ứng với index truyền vào
        /// (Thứ tự và giá trị đã được định sẵn)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Image getImage(int index)
        {
            switch (index)
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

        /// <summary>
        /// Hàm trả về ID chưa tồn tại trong dữ liệu dataTable.
        /// Thuật toán: Vì khi deserialize ID được gán ngẫu nhiên theo thứ tự tăng dần,
        /// nên chỉ cần duyệt từ 1 và kiểm tra nếu ID chưa xuất hiện thì trả về giá trị.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Hàm thực hiện chức năng nhóm các cuộc hẹn theo ngày và đưa thông tin ID vào dateGroup.
        /// </summary>
        public void dateGroupping()
        {
            foreach (var i in dataTable)
            {
                DateTime timeStart = new DateTime(i.Value.startHour.Year, i.Value.startHour.Month, i.Value.startHour.Day);
                DateTime timeFinish = new DateTime(i.Value.endHour.Year, i.Value.endHour.Month, i.Value.endHour.Day);

                for (var time = timeStart; time <= timeFinish; time = time.AddDays(1))
                {
                    if (dateGroup.ContainsKey(time) == false)
                    {
                        dateGroup.Add(time, new List<int>());
                    }
                    dateGroup[time].Add(i.Key);
                }
            }
        }

        /// <summary>
        /// Hàm thực hiện chức năng sắp xếp các cuộc hẹn theo thời gian tăng dần trong một ngày.
        /// Dễ dàng hơn cho việc xếp các cuộc hẹn theo cột khi vẽ ra màn hình.
        /// </summary>
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

        /// <summary>
        /// Tạo taskOfDay.
        /// (Sắp xếp các công việc trong cùng một ngày theo cột để vẽ ra màn hình)
        /// </summary>
        /// <param name="list"></param>
        public void taskOfDay_Building(List<int> list)
        {
            foreach (var i in list)
            {
                if (taskOfDay.Count == 0)
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

        /// <summary>
        /// Hàm có chức năng cập nhật lại thông tin dateGroup và taskOfDay.
        /// Sử dụng khi có sự kiện thay đổi ngày, thêm/xoá một cuộc hẹn...
        /// </summary>
        public void updateTimeTable()
        {
            // Xoá các dữ liệu cũ
            taskOfDay.Clear();
            dateGroup.Clear();


            // Làm mới lại dữ liệu
            dateGroupping();
            taskSorting();


            // Trường hợp thêm mới một appointment cho một ngày trống, thêm vào colorHistory với màu mặc định là 0.
            foreach (var key in dateGroup.Keys)
            {
                if (colorHistory.ContainsKey(key) == false)
                {
                    colorHistory.Add(key, 0);
                }
            }

            // Trường hợp xoá đi appointment làm cho ngày trống, xoá dữ liệu bên colorHistory
            for (int i = colorHistory.Keys.Count - 1; i >= 0; i--)
            {
                if (dateGroup.ContainsKey(colorHistory.Keys.ElementAt(i)) == false)
                {
                    colorHistory.Remove(colorHistory.Keys.ElementAt(i));
                }
            }

            // Trường hợp thêm mới một appointment cho một ngày trống, thêm vào symbolHistory với kí hiệu mặc định là 0.
            foreach (var key in dateGroup.Keys)
            {
                if (symbolHistory.ContainsKey(key) == false)
                {
                    symbolHistory.Add(key, 0);
                }
            }

            // Trường hợp xoá đi appointment làm cho ngày trống, xoá dữ liệu bên symbolHistory
            for (int i = symbolHistory.Keys.Count - 1; i >= 0; i--)
            {
                if (dateGroup.ContainsKey(symbolHistory.Keys.ElementAt(i)) == false)
                {
                    symbolHistory.Remove(symbolHistory.Keys.ElementAt(i));
                }
            }

        }
        #endregion
    }


    /// <summary>
    /// Class kế thừa Button.
    /// Cho phép cài đặt sự kiện doubleclick.
    /// </summary>
    public class myButton : Button
    {
        public myButton()
        {
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }
    }
}