
public abstract class A
{
    private int _num;
    public string Nom;
    public A(int num, string nom1)
    {
        _num = num;
        Nom = nom1;
    }
    public abstract void Display();
}
public class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
public class B:A
{
    public B(int num, string nom1):base(num,nom1)
    {

    }
   

    public override void Display()
    {
        throw new NotImplementedException();
    }
}
public class P1
{
  
}