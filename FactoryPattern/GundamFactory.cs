using System;

static class GundamFactory
{
	public static IGundam GetGundam()
	{
		Console.WriteLine("Would you rather save the moon or the orphans?");
		var response = Console.ReadLine().ToLower();
		switch(response) 
		{
			case ("moon"):
				return new Wing();
            case ("orphans"):
                return new Orphan();
			default: return null;
        }
	}
}
