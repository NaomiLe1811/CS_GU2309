Trong kế thừa, mối quan hệ giữa lớp con (delivered class) và lớp cha (base class) là mối quan hệ “is a”. Ví dụ, lớp Female và lớp Male “là một” thể hiện của lớp Person.

Ngoài ra thì mối quan hệ “is a” cũng là mối quan hệ giữa kiểu và một thể hiện cụ thể của nó. Ở ví dụ bên dưới đây, Automobile là một lớp có 3 thuộc tính read-only (ko cho phép ghi từ bên ngoài): Make: công ty sản xuất, Model: loại, Year: năm sản xuất. Trong lớp Automobile, hàm ToString() được override lại để tạo ra một mã định danh duy nhất cho object Automobile. ( ở bài trước có nhắc đến hàm ToString(), nó được ngầm kế thừa (implicit inheritance) từ Object class, sẽ trả về tên kiểu của lớp.


using System;

public class Automobile
{
    public Automobile(string make, string model, int year)
    {
        if (make == null)
           throw new ArgumentNullException("The make cannot be null.");
        else if (String.IsNullOrWhiteSpace(make))
           throw new ArgumentException("make cannot be an empty string or have space characters only.");
        Make = make;

        if (model == null)
           throw new ArgumentNullException("The model cannot be null.");
        else if (String.IsNullOrWhiteSpace(model))
           throw new ArgumentException("model cannot be an empty string or have space characters only.");
        Model = model;

        if (year < 1857 || year > DateTime.Now.Year + 2)
           throw new ArgumentException("The year is out of range.");
        Year = year;
    }

    public string Make { get; }
    
    public string Model { get; }

    public int Year { get; }

    public override string ToString() => $"{Year} {Make} {Model}";
}
Lúc này bạn không thể dựa vào inheritance để có các thể hiện khác nhau. Ví dụ khác nhau về nhà sản xuất và mẫu mã. Thay vào đó, bạn có thể thể hiện chúng bằng cách truyền vào các tham số thông qua constructor.


 public static void Main()
    {
        var packard = new Automobile("Packard", "Custom Eight", 1948);
        Console.WriteLine(packard); // In ra: 1948 Packard Custom Eight
    }

Mối quan hệ “is a” rất phù hợp cho các trường hợp khi áp dụng cho các lớp cha (base class), hoặc các lớp con (delivered class) có mở rộng thêm các thông tin khác từ lớp cha.