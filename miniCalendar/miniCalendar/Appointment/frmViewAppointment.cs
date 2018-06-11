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
    /// <summary>
    /// Hiển thị thông tin của một cuộc hẹn.
    /// </summary>
    public partial class frmViewAppointment : UserControl
    {
        #region Các thuộc tính

        // Danh sách các appointment theo ID đã có
        public Dictionary<int, Appointment> dataTable = new Dictionary<int, Appointment>();
        // ID của appointment 
        public int ID;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">ID của appointment cần xem (lấy từ tabIndex khi người dùng click vào task)</param>
        /// <param name="dataTable">Danh sách các appointment theo ID đã có</param>
        public frmViewAppointment(int ID, Dictionary<int, Appointment> dataTable)
        {
            InitializeComponent();

            this.ID = ID;
            this.dataTable = dataTable;

            displayInfo();
        }

        #region Hiển thị thông tin ra màn hình

        /// <summary>
        /// Hiển thị thông tin của appointment ra màn hình.
        /// </summary>
        private void displayInfo()
        {
            // Hiển thị Title
            if (dataTable[ID].Title == "")
            {
                lbTitle.Text = "(No Title)";
            }
            else
            {
                lbTitle.Text = dataTable[ID].Title;
            }

            // Hiển thị thời gian
            if (dataTable[ID].startHour.Date == dataTable[ID].endHour.Date)
            {
                lbStartHour.Text = dataTable[ID].startHour.ToString("ddddddddd, dd MMM yyyy");
                if (dataTable[ID].endHour.Minute == 59)
                {
                    lbEndHour.Text = "(All day)";
                    lbEndHour.ForeColor = Color.DarkGray;
                }
                else
                {
                    lbEndHour.Text = dataTable[ID].startHour.ToString("hh:mm tt") + " - " +
                                dataTable[ID].endHour.ToString("hh:mm tt");
                    lbEndHour.ForeColor = Color.Black;
                }
            }
            else
            {
                lbStartHour.ForeColor = Color.Black;
                lbEndHour.ForeColor = Color.Black;
                lbStartHour.Text = dataTable[ID].startHour.ToString("ddddddddd, dd MMM yyyy       hh:mm tt");
                lbEndHour.Text = dataTable[ID].endHour.ToString("ddddddddd, dd MMM yyyy       hh:mm tt");
            }

            // Hiển thị location
            if (dataTable[ID].Location == "")
            {
                panelLocation.Visible = false;
            }
            else
            {
                panelLocation.Visible = true;
                lbLocation.Text = dataTable[ID].Location;
            }

            // Hiển thị giá trị noti và đơn vị noti
            lbNoti.Text = Convert.ToString(dataTable[ID].notiValue) + " " + dataTable[ID].notiUnit + " before";

            if (dataTable[ID].Description == "")
            {
                panelDescription.Visible = false;
            }
            else
            {
                panelDescription.Visible = true;
                lbDescription.Text = dataTable[ID].Description;
            }

            // Thay đổi màu nền của form view appointment
            switch (dataTable[ID].Color)
            {
                case "Red":
                    panelTitle.BackColor = Color.FromArgb(192, 0, 0);
                    break;
                case "Orange":
                    panelTitle.BackColor = Color.FromArgb(255, 128, 0);
                    break;
                case "Yellow":
                    panelTitle.BackColor = Color.FromArgb(192, 192, 0);
                    break;
                case "Green":
                    panelTitle.BackColor = Color.FromArgb(0, 192, 0);
                    break;
                case "Blue":
                    panelTitle.BackColor = Color.FromArgb(0, 192, 192);
                    break;
            }
        }

        #endregion

        #region Xử lí sự kiện

        /// <summary>
        /// Xử lí sự kiện button Modify được click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            // Ẩn panelView chứa thông tin của cuộc hẹn đi
            panelView.Visible = false;
                    
            // Gọi form newAppointment ở chế độ chỉnh sửa
            frmNewAppointment frmModify = new frmNewAppointment(new List<int> { ID }, dataTable, new List<DateTime> { dataTable[ID].startHour }, true); // true là ở chế độ chỉnh sửa
            frmModify.Disposed += new EventHandler(dispose_event);
            panelModify.Controls.Add(frmModify);
        }

        /// <summary>
        /// Xử lí sự kiện button Delete được click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Delete this appointment?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataTable.Remove(ID);
                Dispose();
            }
            else if (dialogResult == DialogResult.No)
            { 
            }
            
        }

        /// <summary>
        /// Xử lí sự kiện button Back được click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Sự kiện khi form chỉnh sửa bị disposed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispose_event(object sender, EventArgs e)
        {
            panelView.Visible = true;
            displayInfo();
        }

        #endregion
    }
}
