using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPlug.TestDelay;
public class TestDelayUI : IAudioPluginView
{
	private ViewRectangle _Size = new ViewRectangle(50, 50, 250, 250);
	public ViewRectangle Size => _Size;

	private bool calledStartUILoop = false;

	// Todo: fix these functions later, just adding test implementations for now
	public void Attached(nint parent, AudioPluginViewPlatform type)
	{
		Debug.WriteLine("ZZZ: Attached");
		
		if (!calledStartUILoop)
		{
			Debug.WriteLine("ZZZ: Calling StartUILoop method");
			calledStartUILoop = true;
			Program.StartUILoop();
		}
	}

	public bool CanResize()
	{
		Debug.WriteLine("ZZZ: CanResize");
		return true;
	}

	public bool CheckSizeConstraint(ViewRectangle rect)
	{
		Debug.WriteLine("ZZZ: CheckSizeConstraint");
		return true;
	}

	public bool IsPlatformTypeSupported(AudioPluginViewPlatform platform)
	{
		Debug.WriteLine("ZZZ: IsPlatformTypeSupported: " + platform.ToString());

		//if (platform == AudioPluginViewPlatform.Hwnd)
		//{
		//	return true;
		//}
		return true;
	}

	public void OnFocus(bool state)
	{
		Debug.WriteLine("ZZZ: OnFocus");
		//throw new NotImplementedException();
	}

	public void OnKeyDown(ushort key, short keyCode, short modifiers)
	{
		Debug.WriteLine("ZZZ: OnKeyDown");
		//throw new NotImplementedException();
	}

	public void OnKeyUp(ushort key, short keyCode, short modifiers)
	{
		Debug.WriteLine("ZZZ: OnKeyUp");
		//throw new NotImplementedException();
	}

	public void OnSize(ViewRectangle newSize)
	{
		Debug.WriteLine("ZZZ: OnSize");
		//throw new NotImplementedException();
		_Size = newSize;
	}

	public void OnWheel(float distance)
	{
		Debug.WriteLine("ZZZ: OnWheel");
		//throw new NotImplementedException();
	}

	public void Removed()
	{
		Debug.WriteLine("ZZZ: Removed");
		//throw new NotImplementedException();
	}

	public void SetContentScaleFactor(float factor)
	{
		Debug.WriteLine("ZZZ: SetContentScaleFactor");
		//throw new NotImplementedException();
	}

	public void SetFrame(IAudioPluginFrame frame)
	{
		Debug.WriteLine("ZZZ: SetFrame");
		//throw new NotImplementedException();
	}

	public bool TryFindParameter(int xPos, int yPos, out AudioParameterId parameterId)
	{
		Debug.WriteLine("ZZZ: TryFindParameter");
		//throw new NotImplementedException();
		parameterId = default(AudioParameterId);
		return false;
	}
}