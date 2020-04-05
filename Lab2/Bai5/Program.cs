using System;

/*public class Time
{
    private int Hour;
    private int Minute;
    private int Second;

    public void Display()
    {
        Console.WriteLine("{0} : {1} : {2}", Hour, Minute, Second);
    }
    public void GetTime(ref int h, ref int m, ref int s)
    {
        h = Hour;
        m = Minute;
        s = Second;
    }
    public Time(System.DateTime dt)
    {
        Hour = dt.Hour;
        Minute = dt.Minute;
        Second = dt.Second;
    }
}

public class PassingParameterByRef
{
    static void Main()
    {
        DateTime currentTime = DateTime.Now;
        Time t = new Time(currentTime);
        t.Display();

        int theHour = 0;
        int theMinute = 0;
        int theSecond = 0;

        t.GetTime(ref theHour, ref theMinute, ref theSecond);
        Console.WriteLine("Current time: {0}:{1}:{2}", theHour, theMinute, theSecond);
        Console.ReadLine();
    }
}

    */

public class Time
{
    private int Hour;
    private int Minute;
    private int Second;

    public void Display()
    {
        Console.WriteLine("{0} : {1} : {2}", Hour, Minute, Second);
    }
    public void GetTime(out int h, out int m, out int s)
    {
        h = Hour;
        m = Minute;
        s = Second;
    }
    public Time(System.DateTime dt)
    {
        Hour = dt.Hour;
        Minute = dt.Minute;
        Second = dt.Second;
    }
}

public class PassingParameterByRef
{
    static void Main()
    {
        DateTime currentTime = DateTime.Now;
        Time t = new Time(currentTime);
        t.Display();

        int theHour = 0;
        int theMinute = 0;
        int theSecond = 0;

        t.GetTime(out theHour, out theMinute, out theSecond);
        Console.WriteLine("Current time: {0}:{1}:{2}", theHour, theMinute, theSecond);
        Console.ReadLine();
    }
}

//Nhận xét: cả 2 Từ khóa ref và out đều được dùng để truyền Giá trị của các tham số truyền vào phương thức trước và sau
//khi thực thi phương thức sẽ thay đổi. Tuy nhiên từ khóa out cho phép ta sử dụng tham chiếu mà không cần phải khởi gán
//giá trị đầu.