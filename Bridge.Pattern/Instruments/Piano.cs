using Bridge.Pattern.Interface;

namespace Bridge.Pattern.Instruments;

public class Piano : Instrument
{
    public Piano(ISound sound) : base(sound)
    {
    }

    public override void Play()
    {
        Console.WriteLine("[Piano: Play]");
        sound.Sound();
    }
}