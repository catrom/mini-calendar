using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCalendar.Schedule
{
    /// <summary>
    /// Lớp lưu trữ bảng thời khóa biểu,
    /// Một TimeTable chứa thông tin về thời khóa biểu như
    /// Tên, ngày có hiệu lực, khung thời gian, danh sách các TimeBlock.
    /// </summary>
    public class TimeTable
    {
        #region Trường và Thuộc tính
        [XmlAttribute]
        string title;
        [XmlArray]
        bool[] enableWeekDay = new bool[7] { true, true, true, true, true, true, true };
        [XmlAttribute]
        DateTime startTime;
        [XmlAttribute]
        DateTime endTime;
        [XmlArray]
        List<TimeBlock> timeBlocks;

        /// <summary>
        /// Tên bảng thời khóa biểu - thuộc tính khóa
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value == "") throw new Exception("Title invalid");
                else title = value;
            }
        }

        /// <summary>
        /// Mảng lưu ngày có hiệu lực trong tuần
        /// </summary>
        public bool[] EnableWeekDay
        {
            get
            {
                return enableWeekDay;
            }
            set
            {
                enableWeekDay = value;
            }
        }

        /// <summary>
        /// Thời gian bắt đầu trong ngày
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
        /// Thời gian kết thúc trong ngày
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
        /// Danh sách các khung giờ làm việc
        /// </summary>
        public List<TimeBlock> TimeBlocks
        {
            get
            {
                return timeBlocks;
            }
            set
            {
                timeBlocks = value;
            }
        }
        #endregion

        #region Hàm dựng

        public TimeTable() { }

        /// <summary>
        /// Hàm dựng và khởi tạo bảng thời khóa biểu
        /// </summary>
        /// <param name="title">Tên bảng thời khóa biểu</param>
        /// <param name="enableWeekDay">Mảng ngày có hiệu lực</param>
        /// <param name="startTime">Thời gian bắt đầu</param>
        /// <param name="endTime">Thời gian kết thúc</param>
        /// <param name="timeBlocks">Danh sách khung giờ làm việc</param>
        public TimeTable(string title, bool[] enableWeekDay, DateTime startTime, DateTime endTime, List<TimeBlock> timeBlocks)
        {
            if (title == "")
                throw new Exception("Title must not be blank");
            else
                this.title = title;

            this.enableWeekDay = enableWeekDay;

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

            this.timeBlocks = new List<TimeBlock>();
            if (timeBlocks != null)
            {
                foreach (var item in timeBlocks)
                {
                    Add(item);
                }
            }
        }

        #endregion

        #region Hàm chức năng
        /// <summary>
        /// Hàm thêm khung giờ làm việc (có kiểm tra)
        /// </summary>
        /// <param name="timeBlock">Khung giờ làm việc</param>
        public void Add(TimeBlock timeBlock)
        {
            if (isTimeBlockValid(timeBlock))
            {
                if (timeBlocks != null)
                {
                    foreach (var item in timeBlocks)
                    {
                        if (timeBlock.SubjectTitle == item.SubjectTitle)
                            throw new Exception("Title already taken");
                        if (timeBlock.WeekDay == item.WeekDay)
                        {

                            if (isOverlapped(timeBlock, item))
                                throw new Exception("Time frame overlapped");
                        }
                    }
                }
                timeBlocks.Add(timeBlock);
            }
            else throw new Exception("TimeBlock invalid");
        }

        /// <summary>
        /// Hàm xóa khung giờ làm việc
        /// </summary>
        /// <param name="timeBlock">Khung giờ làm việc</param>
        public void Remove(TimeBlock timeBlock)
        {
            timeBlocks.Remove(timeBlock);
        }

        /// <summary>
        /// Hàm kiểm tra khung giờ làm việc hợp lệ
        /// Không lấn giờ bắt đầu và giờ kết thúc
        /// Không thuộc ngày không có hiệu lực
        /// </summary>
        /// <param name="timeBlock">Khung giờ làm việc</param>
        /// <returns></returns>
        public bool isTimeBlockValid(TimeBlock timeBlock)
        {
            //Check time
            if ((timeBlock.StartTime.Hour < StartTime.Hour)
                || ((timeBlock.StartTime.Hour == startTime.Hour) && (timeBlock.StartTime.Minute < startTime.Minute)))
                return false;

            if ((timeBlock.EndTime.Hour > EndTime.Hour)
                || ((timeBlock.EndTime.Hour == startTime.Hour) && (timeBlock.StartTime.Minute > startTime.Minute)))
                return false;

            //Check weekday
            if (!enableWeekDay[timeBlock.WeekDay])
                return false;

            return true;
        }

        /// <summary>
        /// Hàm kiểm tra khung giờ làm việc không chồng lấn
        /// </summary>
        /// <param name="a">Khung giờ làm việc 1</param>
        /// <param name="b">Khung giờ làm việc 2</param>
        /// <returns></returns>
        public bool isOverlapped(TimeBlock a, TimeBlock b)
        {
            if ((a.StartTime.Hour < b.StartTime.Hour)
                || (a.StartTime.Hour == b.StartTime.Hour) && (a.StartTime.Minute < b.StartTime.Minute))
            {
                if ((a.EndTime.Hour > b.StartTime.Hour)
                    || (a.EndTime.Hour == b.StartTime.Hour) && (a.EndTime.Minute > b.StartTime.Minute))
                    return true;
            }

            else if ((a.StartTime.Hour == b.StartTime.Hour) && (a.StartTime.Minute == b.StartTime.Minute))
            {
                return true;
            }

            else if ((a.StartTime.Hour > b.StartTime.Hour)
                || (a.StartTime.Hour == b.StartTime.Hour) && (a.StartTime.Minute > b.StartTime.Minute))
            {
                if ((a.StartTime.Hour < b.EndTime.Hour)
                    || (a.StartTime.Hour == b.EndTime.Hour) && (a.StartTime.Minute < b.EndTime.Minute))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Hàm sắp xếp thứ tự khung giờ làm việc trong bảng thời khóa biểu
        /// Chưa dùng
        /// </summary>
        public void Sort()
        {
            List<TimeBlock> tempTimeBlocks;
            tempTimeBlocks = TimeBlocks.OrderBy(o => o.WeekDay).ThenBy(o => o.StartTime).ToList();
            TimeBlocks = tempTimeBlocks;
        }

        /// <summary>
        /// Hàm kiểm tra loại bỏ khung giờ không hợp lệ
        /// Chưa dùng
        /// </summary>
        public void Update()
        {
            if(timeBlocks != null)
            {
                foreach (var item in timeBlocks)
                    if (!isTimeBlockValid(item))
                        Remove(item);
            }
        }
        #endregion
    }
}
