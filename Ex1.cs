
public class Example
{
   public Example Bar(int a, int b)
   {
       if (a < b)
       {
           return null;
       }
       return this;
   }
   public string Foo(int a, int b)
   {
       Example example = Bar(a, b); 
       return example.ToString(); 
   }
}
