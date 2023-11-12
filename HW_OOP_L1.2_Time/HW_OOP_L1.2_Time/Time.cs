using System;
namespace HW_OOP_L1._2_Time
{
    public class Time
    {
        //b1: member property
        private DateTime startTime { get; set; }
        private DateTime endTime { get; set; }


        // Getter for startTime
        public DateTime StartTime
        {
            get { return startTime; }
        }

        // Getter for endTime
        public DateTime EndTime
        {
            get { return endTime; }
        }

        //b2: default constructor - Phương thức khởi tạo không tham số khởi tạo startTime với thời gian hiện tại của hệ thống.
        public Time()
        {
            startTime = DateTime.Now;
        }

        // Method to reset startTime to the current system time
        public void Start()
        {
            startTime = DateTime.Now;
        }

        // Method to set endTime to the current system time
        public void Stop()
        {
            endTime = DateTime.Now;
        }

        // Method to get the elapsed time in milliseconds
        public long GetElapsedTime()
        {
            TimeSpan elapsed = endTime - startTime;
            return (long)elapsed.TotalMilliseconds;
        }
    }
}
