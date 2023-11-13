[Bài đọc] Overriding và Overloading

Trong C#, khi lớp con (delivered class) điều chỉnh hoặc mở rộng hành vi của lớp cha (base class), ta gọi là override.
Khi có nhiều hơn một phương thức cùng tên, nhưng khác số lượng tham số truyền vào, ta gọi là method overload.

Hãy cùng xem ví dụ sau. Chúng ta tạo ra 1 lớp Person với phương thức Say(). Một lớp Girl kế thừa Person, có 1 phương thức Say() và 1 phương thức Say(string name).

Ta nói rằng lớp Girl đã override lại phương thức Say() – đã được định nghĩa ở lớp cha Person. Tức là lớp Girl đã điều hình hành vi Say(), thay vì nói I’m a Person, chúng sẽ nói I’m a girl.

Trong lớp Girl, chúng ta thấy có 2 phương thức Say() – có tham số (stringname) và không có tham số. trường hợp này ta gọi là overload.


public class Person
    {
        public virtual void Say()
        {
            Console.WriteLine("I'm a person");
        }
    }

    public class Girl : Person
    {
        public override void Say()
        {
            Console.WriteLine("I'm a girl");
        }
        public void Say(string name)
        {
            Console.WriteLine($"I'm a girl. Nice to meet you, {name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var girl = new Girl();
            girl.Say(); /* OUTPUT: I'm a girl */
            girl.Say("Ronaldo"); /* OUTPUT: I'm a girl. Nice to meet you, Ronaldo */
        }
    }
Một số quy tắc khi sử dụng từ khóa override như sau:

– Chúng phải có cùng signature với nhau. Tức là có cùng tên hàm, cùng tham số và kiểu dữ liệu trả về và cùng phạm vi truy cập access (access modifier: public, private, protected,…)

– Không áp dụng override khi phương thức được đánh dấu static.

– Lớp con chỉ có thể override những phương thức được đánh dấu bằng các từ khóa như: virtual, abstract, override.

– Access modifier (public,private,proteted..)

– Không thể thay đổi một phương thức đã override bằng các từ khóa new, static, virtual.

– Thuộc tính được khai báo với các từ khóa virtual, abstract, override sẽ cho phép lớp con override. Lớp con phải khai báo chính xác phạm vi truy cập, kiểu và tên giống như thuộc tính cha.

Một số quy tắ khi sử dụng method overloading như sau:

– Chúng có cùng signature nhưng khác nhau ở số lượng tham số truyền vào.

– Nếu có cùng số lượng tham số truyền vào, chúng phải có ít nhất một tham số truyền vào có kiểu khác nhau. Ví dụ bên dưới mô tả rõ hơn điều này.


        //Ham say 1
        public void Say(string name)
        {
            Console.WriteLine($"I'm a girl. Nice to meet you, {name}");
        }
        //Ham say 2
        public void Say(string name)
        {
            Console.WriteLine($"I'm a girl. Nice to meet you, {name}");
        }
        //Ham say 3
        public void Say(int age)
        {
            Console.WriteLine($"I'm a girl. I know you are {age} years old");
        }

Hàm Say(string name) thứ 2 đã gây lỗi biên dịch do khai báo trùng tên (Say), kiểu trả về (void), và tham số truyền vào (string name).

Hàm Say(int age) cuối cùng hợp lệ, nó overload lại phương thức Say(string name), tuy cùng số lượng tham số truyền vào nhưng khác kiểu (int age).