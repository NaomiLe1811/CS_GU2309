using System;
namespace HW_OOP_L1._2_Time
{
    public class Time
    {
        //b1: member property
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime1 { get => startTime; set => startTime = value; }
        public DateTime EndTime1 { get => endTime; set => endTime = value; }

        //constructor
        public Time(DateTime startTime, DateTime endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }

        // Getter for startTime
        public DateTime StartTime
        {
            get { return StartTime1; }
        }

        // Getter for endTime
        public DateTime EndTime
        {
            get { return EndTime1; }
        }

        //b2: default constructor - Phương thức khởi tạo không tham số khởi tạo startTime với thời gian hiện tại của hệ thống.
        public Time()
        {
            StartTime1 = DateTime.Now;
        }

        // Method to reset startTime to the current system time
        public void Start()
        {
            StartTime1 = DateTime.Now;
        }

        // Method to set endTime to the current system time
        public void Stop()
        {
            EndTime1 = DateTime.Now;
        }

        // Method to get the elapsed time in milliseconds
        public long GetElapsedTime()
        {
            TimeSpan elapsed = EndTime1 - StartTime1;
            return (long)elapsed.TotalMilliseconds;
        }
    }
}
