Từ khóa static

public class Program
 {
 public static void Main(string[] args)
 {
     Student student = new Student();
     student.GetAge();
 }

}
 public class Student
 {
     private int age;
     public int GetAge()
     {
         return this.age;
     } 
 }
Đôi khi lập trình viên mong muốn một thuộc tính hay một phương thức được dùng chung cho mọi đối tượng. Từ đó static ra đời.

Đặc điểm:

Được khởi tạo một lần duy nhất ngay khi biên dịch chương trình
Có thể dùng chung cho mọi đối tượng
Được gọi thông qua tên lớp
Được hủy khi kết thúc chương trình
Có 4 loại static chính:

Biến static
Phương thức static
Lớp static
Hàm khởi tạo static
Để khai báo 1 biến static ta sử dụng từ khoá static đặt trước tên biến

<phạm vi truy cập> static <kiểu dữ liệu> <tên biến> = <giá trị khởi tạo>;
______________________________________

Biến static

Biến static là biến dùng chung cho mọi đối tượng thuộc lớp. Được khởi tạo vùng nhớ một lần duy nhất ngay khi chương trình thực thi, có vùng nhớ riêng và không bị thay đổi, biến static có thể được khai báo bên ngoài hàm. Được gọi trực tiếp thông qua tên lớp mà không cần khởi tạo đối tượng của lớp.

Quan sát đoạn mã sau sử dụng biến static

class Rectangle
 {
    public static double width = 20;
    public static double height = 60;
 }
 class Program
 {
     static void Main(string[] args)
     {
         Console.WriteLine("Height:" + Rectangle.height + "\nWidth:" + Rectangle.width);
      }
 }
Ở class Rectangle khai báo biến static width giá trị là 20, biến height giá trị là 60 kiểu dữ liệu là double
Ở hàm Main ta sử dụng 2 biến này thông qua tên lớp Rectangle mà không cần tạo đối tượng của lớp Rectangle.

______________________________________

Phương thức static 

Static method là một phương thức dùng chung của lớp. Được gọi thông qua tên lớp và không cần khởi tạo đối tượng. Hỗ trợ trong việc viết các hàm tiện ích của thư viện để sử dụng lại.

Quan sát ví dụ sau

class Rectangle
 {
     static double width = 20;
     static double height = 60;
     public static void Print()
     {
         Console.WriteLine("Height:" + height + "\nWidth:" + width);
     }
 }
 class Program
 {
     static void Main(string[] args)
     {
          Rectangle.Print();
     }
 }
Đoạn mã trên định nghĩa phương thức static Print trong lớp Rectangle. Phương thức này hiển thị lên màn hình giá trị của thuộc tính height và width
Ở hàm Main gọi hàm Print thông qua lên lớp là Rectangle mà không cần khởi tạo instance của lớp Rectangle.
