using Bridge.Pattern.Interface;

namespace Bridge.Pattern.Sounds;

public class AcousticSound : ISound
{
    public void Sound()
    {
        Console.WriteLine("[Acoustic: Sound]");
    }
}