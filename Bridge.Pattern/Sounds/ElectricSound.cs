using Bridge.Pattern.Interface;

namespace Bridge.Pattern.Sounds;

public class ElectricSound : ISound
{
    public void Sound()
    {
        Console.WriteLine("[Electric: Sound]");
    }
}