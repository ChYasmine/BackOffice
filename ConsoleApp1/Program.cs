
using Newtonsoft.Json;
using System.Collections;
using System.Net.Http.Json;


class ClassNode
{
    public int Value;
    public ClassNode Next;
    public ClassNode(int value)
    {
        Value = value;
        Next = null;
    }
}
class ListNode
{
    private ClassNode head;
    public ListNode()
    {
        head = null;
    }
    public void AddLast(int value)
    {
        ClassNode newNode = new ClassNode(value);
        if(head == null)
        {
            head = newNode;    
        }
        ClassNode current = head.Next;
        while(current.Next!= null)
        {
            current = current.Next;
        }
        current.Next = newNode; 
    }

    public void Remove(int value)
    {
        ClassNode current = head.Next;  
        while(current != null && current.Value != value )
        {
            current = current.Next;

        }
        if(current.Value == value)
        {

        }

    }

}
public class Program2
{

   public static int[] MoveZeroes(int[] tab)
    {
        int taille = tab.Length-1;
      
        for(int i = 0; i < tab.Length; i++)
        {
            int left = i;
            if(tab[i] == 0)
            {
                while (left < taille)
                {
                tab[left] = tab[left+1];
                 tab[left+1] = 0;
                    left++;
                }
                taille--;
            }
          
        }
        return tab; 
    }
  //public static int maxA(int[] tab)
  //  {
  //      int nbrBar = tab.Length;
  //      int max1 = tab[0];
  //      int max2 = tab[tab.Length-1];
  //      int left = 1;   
  //      int right = tab.Length-2;
        

  //          while(left < right)
  //      {
  //          if(max2<tab[right] )
  //          {
  //              max2 = tab[right];
  //          }else if(max1<tab[left])
  //          {

  //          }
  //      }
  //  }
  public static bool checkSub(string s1, string s2)
    {
        int indice = -1;
        for (int i = 0; i < s2.Length; i++)
        {
            int j = i;
            if (!s1.Contains(s2[i]))
            {
                return false;
            }
                else if (s1.Contains(s2[i]) && indice == -1)
            {
                indice = s1.IndexOf(s2[i]);
            }
            else if (s1.Contains(s2[i]) && indice < s1.IndexOf(s2[i]) )
            {
                indice = s1.IndexOf(s2[i]);
            }

        }
        return true;
    }

    public static bool checkF(int[] t, int n)
    {
        int cpt = 0;
        int taille = t.Length - 1;
        for(int i = 0; i < t.Length; i++)
        {
            if(t[i] == 0)
            {
                int left = i;
                while(left < taille)
                { 
                    if(t[left] == 0 && t[left+1] == 0)
                    {
                        cpt++;
                        i += 2;
                        break;
                    }
                   
                }
            }
        }
        if(cpt == n)
            return true;    
        return false;   
    }
    public static void Main(string[] args)
    {
        int[] chars = new int [] { 1, 0, 0, 0, 0, 1, 0};
    
        Console.WriteLine("Hello word 123   ");
       

    }

  
    
   
}

