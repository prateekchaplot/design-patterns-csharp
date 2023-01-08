using Bridge.Pattern.Instruments;
using Bridge.Pattern.Interface;
using Bridge.Pattern.Sounds;

ISound sound = new AcousticSound();
Instrument instrument = new Piano(sound);
instrument.Play();
