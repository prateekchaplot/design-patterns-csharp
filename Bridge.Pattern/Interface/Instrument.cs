namespace Bridge.Pattern.Interface;

public abstract class Instrument
{
    protected readonly ISound sound;

    public Instrument(ISound sound)
    {
        this.sound = sound;
    }

    public abstract void Play();
}