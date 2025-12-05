namespace App.Tasks.Task2_Loggers;

public class ObjectLogger<T> where T : class
{
    public void Log(T data)
    {
        if (data == null)
            Console.WriteLine("Объект пуст (null)");
        else
            Console.WriteLine(data.ToString());
    }
}

public class ValueLogger<T> where T : struct
{
    public void Log(T data)
    {
        Console.WriteLine(data.ToString());
    }
}