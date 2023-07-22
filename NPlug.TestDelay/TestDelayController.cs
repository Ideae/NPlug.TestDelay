using System.Diagnostics;

namespace NPlug.TestDelay;

public class TestDelayController : AudioController<TestDelayModel>
{
    public static readonly Guid ClassId = new("b37582e0-96f6-41f8-a83a-7a0a7586e0f4");

	protected override IAudioPluginView? CreateView()
	{
		Debug.WriteLine("ZZZ: CreateView");
		return new TestDelayUI();
	}
}