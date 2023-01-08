using Bridge.Pattern.Interface;

namespace Bridge.Pattern.Instruments;

public class Guitar : Instrument
{
    public Guitar(ISound sound) : base(sound)
    {
    }

    public override void Play()
    {
        Console.WriteLine("[Guitar: Play]");
        sound.Sound();
    }
}