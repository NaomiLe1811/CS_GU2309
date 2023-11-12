using System;
namespace HW_OOP_L1._1_Fan
{
    public class Fan
    {
        //data members
        public int SLOW = 1;
        public int MEDIUM = 2;
        public int FAST = 3;
        public string tocDo;
        public string batHayTat;

        public int speed { get; set; }
        private bool onOff { get; set; }
        public string colour { get; set; }
        private double radius = 5;


        //constructor
        public Fan(int Speed, bool OnOff, string Colour, double Radius = 5)
        {
            this.speed = Speed;
            if(speed == 1){tocDo = "slow"; }
            if(speed == 2){tocDo = "medium"; }
            if(speed == 3){tocDo = "fast"; }


            this.onOff = OnOff;
            if (onOff == false) { batHayTat = "TAT"; }
            else { batHayTat = "BAT"; }

            this.colour = Colour;
            this.radius = Radius;
        }
            
        //method
        public void Display()
        {
            Console.WriteLine($"Cai quat toc do {speed} rat la {tocDo} dang {batHayTat} co mau {colour} va ban kinh la {radius}");
        }

        public override string ToString()
        {
            return $"Speed: {speed}, Status: {batHayTat}, Color: {colour}, Radius: {radius}";
        }
    }
}
