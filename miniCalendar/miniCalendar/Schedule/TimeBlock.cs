    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace miniCalendar.Schedule
{
    /// <summary>
    /// Lớp lưu trữ khung giờ làm việc,
    /// Một TimeBlock chứa thông tin về khung giờ làm việc như
    /// Tên công việc, thứ trong tuần, thời gian bắt đầu, thời gian kết thúc, màu, thời gian thông báo, ghi chú mô tả
    /// </summary>
    public class TimeBlock
    {
        #region Trường và Thuộc tính

        [XmlAttribute]
        string subjectTitle;
        [XmlAttribute]
        int weekDay;
        [XmlAttribute]
        DateTime startTime;
        [XmlAttribute]
        DateTime endTime;
        [XmlAttribute]
        string color;
        [XmlAttribute]
        int notiValue;
        [XmlAttribute]
        string description;

        /// <summary>
        /// Tên khung giờ làm việc - thuộc tính khóa
        /// </summary>
        public string SubjectTitle
        {
            get
            {
                return subjectTitle;
            }
            set
            {
                if (value == "")
                { throw new Exception("Subject Title invalid"); }
                else subjectTitle = value;
            }
        }

        /// <summary>
        /// Thứ trong tuần của khung giờ làm việc
        /// </summary>
        public int WeekDay
        {
            get
            {
                return weekDay;
            }
            set
            {
                if (value < 0 || value > 6) throw new Exception("Weekday invalid");
                weekDay = value;
            }
        }

        /// <summary>
        /// Thời gian bắt đầu khung giờ làm việc
        /// </summary>
        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        /// <summary>
        /// Thời gian kết thúc khung giờ làm việc
        /// </summary>
        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }

        /// <summary>
        /// Màu khung giờ làm việc
        /// </summary>
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        /// <summary>
        /// Thời gian thông báo trước khung giờ
        /// </summary>
        public int NotiValue
        {
            get
            {
                return notiValue;
            }
            set
            {
                if (value < 0) throw new Exception("Notification delay time invalid");
                notiValue = value;
            }
        }

        /// <summary>
        /// Ghi chú mô tả khung giờ làm việc
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        #endregion

        #region Hàm dựng
        public TimeBlock() { }

        /// <summary>
        /// Hàm dựng và khởi tạo khung giờ làm việc
        /// </summary>
        /// <param name="subjectTitle">Tên khung giờ</param>
        /// <param name="weekDay">Thứ trong tuần</param>
        /// <param name="startTime">Thời gian bắt đầu</param>
        /// <param name="endTime">Thời gian kết thúc</param>
        /// <param name="color">Màu</param>
        /// <param name="notiValue">Thời gian thông báo trước</param>
        /// <param name="description">Ghi chú mô tả</param>
        public TimeBlock(string subjectTitle, int weekDay, DateTime startTime, DateTime endTime, string color, int notiValue, string description)
        {
            if (subjectTitle == "")
                throw new Exception("Title must not be blank");
            else
                this.subjectTitle = subjectTitle;
            this.weekDay = weekDay;
            this.color = color;
            this.notiValue = notiValue;
            this.description = description;
            if ((startTime.Hour > endTime.Hour)
                || (startTime.Hour == endTime.Hour) && (startTime.Minute >= endTime.Minute))
                throw new Exception("Start time and End time invalid");
            else
            {
                this.startTime = startTime;
                Helper.toDefaultDay(ref this.startTime);

                this.endTime = endTime;
                Helper.toDefaultDay(ref this.endTime);
            }
        }
        #endregion

        #region Hàm chức năng
        /// <summary>
        /// Hàm chuyển đỗi giữa thuộc tính Weekday của lớp và DayOfWeek của DateTime
        /// </summary>
        /// <returns>DayOfWeek</returns>
        public DayOfWeek GetDayOfWeek()
        {
            switch(weekDay)
            {
                case 0:
                    return DayOfWeek.Monday;
                case 1:
                    return DayOfWeek.Tuesday;
                case 2:
                    return DayOfWeek.Wednesday;
                case 3:
                    return DayOfWeek.Thursday;
                case 4:
                    return DayOfWeek.Friday;
                case 5:
                    return DayOfWeek.Saturday;
                case 6:
                    return DayOfWeek.Sunday;
            }
            return DayOfWeek.Monday;
        }
        #endregion
    }
}
