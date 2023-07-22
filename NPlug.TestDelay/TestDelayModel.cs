using System.Diagnostics;

namespace NPlug.TestDelay;

public class TestDelayModel : AudioProcessorModel
{
    public TestDelayModel() : base("NPlug.TestDelay")
    {
		Debug.WriteLine("ZZZ: Calling TestDelayModel constructor");
		AddByPassParameter();
        Delay = AddParameter(new AudioParameter("Delay", units: "sec", defaultNormalizedValue: 1.0));
    }

    public AudioParameter Delay { get; }
}