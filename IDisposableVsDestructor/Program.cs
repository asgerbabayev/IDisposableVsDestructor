


#region IDisposable

Disposable disposable = MyMain();
disposable.Print();

Disposable MyMain()
{
   Disposable dispose = new();
   return dispose;
}


class Disposable
{
   public bool IsDisposed { get; private set; } = false;
   public void Print() => Console.WriteLine($"From Disposable Class. Is Disposed = {IsDisposed}");
   public void Dispose()
   {
       IsDisposed = true;
   }
}

#endregion

#region Destructor




for (int i = 0; i <= 10; i++)
{
    Destructor des = new Destructor(i);
}
Console.WriteLine("-------------------------------------------------");

GC.Collect();
Console.Read();

class Destructor
{
    public int Number { get; set; }
    public Destructor(int number)
    {
        Number = number;
        Console.WriteLine($"{Number} - Instance Created");
    }
    ~Destructor()
    {
        Console.WriteLine($"{Number} - Instance Deleted");
    }

}

#endregion