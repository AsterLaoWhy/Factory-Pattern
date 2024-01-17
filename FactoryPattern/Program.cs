namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var newGundam = GundamFactory.GetGundam();
            newGundam.Transform();
        }
    }
}
/*
Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply! All methods are based on the Gundam series    
Create an Interface named IGundam that has a stubbed out public void Transform method.
    Create 2 new public classes that will conform to IGundam.
        Example) Wing, Orphan
DONE
    Note: These classes must conform to IGundam and implement the Transform() method - which will just Console.WriteLine(“For the moon!”)
DONE
    Now we will make our static GundamFactory class.DONE
        It will contain a static method GetGundam(), that will return an IGundam based on the desire it’s given as a parameter
    Call this functionality in the Main method.
*/