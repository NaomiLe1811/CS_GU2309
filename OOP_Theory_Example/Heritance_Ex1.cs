[Bài đọc] Thiết kế lớp cơ sở (base class) và lớp dẫn xuất (derived classes)
LESSON PROGRESS
42% Complete
Trong bài đọc này, bạn sẽ định nghĩa một lớp cha Publication . Sau đó tạo ra các lớp con Book sử dụng kế thừa từ Publication, hoặc là các thể hiện khác như Magazine, Journal, Newspaper và Article.

Các bước thực hiện như sau:

Trước tiên bạn phải xem xét việc tạo lớp cha Publication bằng cách xem xét và trả lời các yêu cầu sau:

Xác định các thuộc tính chung nhất của chúng.
Đâu là các thuộc tính/phương thức cũng cấp sẵn ở lớp Publication, đâu là các thuộc tính/phương thức mà sẽ được thực hiện (implement) ở lớp con. Hay nói cách khác, đâu là những đoạn code có thể reuse được, đâu là những hành vi thuộc về các lớp con. Bước này nên được cân nhắc và làm hiệu quả, bạn sẽ tránh được những đoạn code trùng lặp, khó bảo trì và dễ phát sinh lỗi. 
Sử dụng các access modifier (public, private, protected…) phù hợp.
Xác định xem lớp Publication có đủ điều kiện để tạo thể hiện của chúng hay không? (non-abstract base class || abstract base class). Giả sử Publication không đủ thông tin để xác định được một thể hiện của chúng, vậy ta xác định nó sẽ là một abstract class (sử dụng từ khóa abstract). 
Hãy xem đoạn code bên dưới.


        public abstract class Publication
	{
                  private string uniqueID;
		  public string Publisher { get; set;}
		  public string Title { get; set;}
		  public abstract void MakeCover(); //Tạo ra trang bìa

                  protected void Publish()
                  {
                     Console.Writeline($"Published on {DateTime.Now.ToString()}");
                  }
	}
	
	public class Book : Publication
	{
		 public override void MakeCover()
		 {
			Console.WriteLine("Book Cover");
		 } 
	}

        public class Magazine: Publication
	{
		 public override void MakeCover()
		 {
			Console.WriteLine("Magazine Cover");
		 } 
	}
Đoạn code trên tạo ra một lớp cha (base class) Publication, có các thuộc tính:

UniqueID: mã định danh của tạp chí
Publisher: lưu tên người xuất bản.
Title: lưu tiêu đề/tên bản phát hành.
Một phương thức trừu tượng MakeCover. Hàm MakeCover được đánh dấu là abstract bởi vì bìa của Magazine và Book sẽ khác nhau. Ta sử dụng từ khóa abstract và không có phần {} ở sau tên hàm MakeCover()
Publish(): hàm xuất bản, chia sẽ cho các lớp con (delivered class)
Tiếp theo ta tạo ra lớp Book kế thừa Publication bởi kí tự “:“. Lớp book này sẽ phải override lại phương thức MakeCover().

Tương tự lớp Magazine cũng kế thừa từ Publication và override lại phương thức MakeCover()

Ở lớp Book và Managinze, chúng được sử dụng thuộc tính Title, Publisher được khai báo ở lớp Publication. Thuộc tính UniqueID được đánh dấu Private, nên Book và Manazine sẽ không thể sử dụng. Lớp cha Publication chỉ chia sẻ phương thức Publish cho những lớp nào thế thừa từ chúng.

Lớp cơ sở trừu tượng (abstract base class)
Trong ví dụ trên, Publication cung cấp sẵn một vài các phương thức/ thuộc tính và cho phép lớp con sử dụng. Trong nhiều tình huống, điều này không được phép. Khi đó, Publication sẽ phải được khai báo dưới dạng lớp trừu tượng (abstract base class). Nó đóng vai trò như một khuôn mẫu, và các lớp con sẽ bắt buộc phải thực hiện implement một hay nhiều phương thức trừu tượng (abstract method). Bạn sử dụng từ khóa abstract khi bạn thấy đối tượng đó không đủ thông tin hay hành động để cấu thành lên một đối tượng, tuy nhiên nó có vài điểm chung của một hay nhiều đối tượng khác.

Hay xem ví dụ bên dưới, chúng ta tạo ra 1 lớp abstract base Verhicle, có một thuộc tính Model (xác định tên/ hoặc mã của loại phương tiện), và một hành động Move(). Rõ ràng khi chúng ta sẽ không thể biết phương tiện gì sẽ Move() như nào. Vì vậy, Verhicle chỉ nên đóng vai trò như một lớp mẫu trừu tượng, định nghĩa ra các thông tin chung nhất của phương tiện (Model), và một phương thức trừu tượng Mode() – một phương thức mà sẽ xuất hiện ở các lớp con và hành xử khác nhau ở từng lớp con đó.

public abstract class Verhicle
    {
        public string Model { get; set; }
        public abstract void Move();
    }

    public class Car : Verhicle
    {
        public override void Move()
        {
            Console.WriteLine("Use 4 wheels with fuel");
        }
    }

    public class Bicycle : Verhicle
    {
        public override void Move()
        {
            Console.WriteLine("Use 2 wheels without fuel");
        }
    }
Ở lớp Car, bạn sẽ thấy chúng Move() bằng cách sử dụng 4 bánh cùng với nhiên liệu, trong khi Bicycle cũng Move() với 2 bánh xe mà không cần dùng nguyên liệu.