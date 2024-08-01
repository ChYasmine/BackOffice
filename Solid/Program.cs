// See https://aka.ms/new-console-template for more information




public class Person : IEquatable<string>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public object Clone()
    {
        return new Person { Name = this.Name, Age = this.Age };
    }

  

    public bool Equals(string? other)
    {
        throw new NotImplementedException();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        bool t = Example.Anagramme("test", "estt");
    }
    class Example
    {
      

        public static bool Anagramme(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            char[] tabS1 = s1.ToCharArray();
            char[] tabS2 = s2.ToCharArray();
            Array.Sort(tabS1);
            Array.Sort(tabS2);
            for (int i = 0; i < tabS1.Length; i++)
            {
                if (tabS1[i] != tabS2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}