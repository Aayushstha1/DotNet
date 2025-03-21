using system;
public class program 
{
    public static void main(string[] args)
    {
        int[] num int[10];
        console.clear();
        for(int i=0;i<num.length;i++)
        {
           console.writeline("Enter {0}th number", i+1);
           num[i]= convert.ToInt32(console.Readline ());
        }
        console.writeline("The numbers are");
        foreach(int n in num)
        {
            console.writeline(n.ToString()+"\t");
        }
    }
}