    public abstract class A
    {
        public virtual void Method1()
        {
            //Say Hello
        }
    }

    public class B : A // Generates CS0534.
    {
        public override void Method1()
        {
            // Say Something Else
        }
    }

Trong ví dụ trên, ta khai báo 1 lớp A với phương thức Method1() và cho phép lớp con ghi đè (override) bằng từ khóa virtual.

Các từ khóa này rất quan trọng, nó chỉ ra việc lớp con có được sở hữu, ghi đè các thuộc tính, phương thức của lớp cha hay không. Hãy xem một vài ví dụ dưới đây về việc gây lỗi biên dịch khi sử dụng inheritance

        public class A
	{
		public void Method1()
		{
			// Do something.
		}
	}

	public class B : A
	{
		public override void Method1() // Biên dịch báo lỗi vì Method1 của lớp A ko được đánh dấu Virtual
		{
			// Do something else.
		}
	}

Ví dụ tiếp theo, trình biên dịch sẽ thông báo lỗi khi lớp con không thực hiện việc bổ sung (implement) phương thức được đánh dấu abstract ở lớp cha.

public abstract class A
{
    public abstract void Method1();
}

public class B : A // Generates CS0534.
{
    public void Method3()
    {
        // Do something.
    }
}

Kế thừa chỉ áp dụng cho class và interface(sẽ được trình bày ở các bài sau). Những loại khác như structs, enums hoặc delegate sẽ gây ra lỗi biên dịch.

public enum ProductStatus
	{
		Available =1,
		Sold = 2
	}

	public class B : ProductStatus  //Báo lỗi không cho kế thừa từ 1 lớp type là enum
	{
		public void Method3()
		{
			// Do something.
		}
	}