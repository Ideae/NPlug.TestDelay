using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPlug.TestDelay;
public class TestDelayUI : IAudioPluginView
{
	public ViewRectangle Size => throw new NotImplementedException();

	// Todo: fix these functions later, just adding test implementations for now
	public void Attached(nint parent, AudioPluginViewPlatform type)
	{
		throw new NotImplementedException();
	}

	public bool CanResize()
	{
		return true;
	}

	public bool CheckSizeConstraint(ViewRectangle rect)
	{
		return true;
	}

	public bool IsPlatformTypeSupported(AudioPluginViewPlatform platform)
	{
		//if (platform == AudioPluginViewPlatform.Hwnd)
		//{
		//	return true;
		//}
		return true;
	}

	public void OnFocus(bool state)
	{
		//throw new NotImplementedException();
	}

	public void OnKeyDown(ushort key, short keyCode, short modifiers)
	{
		//throw new NotImplementedException();
	}

	public void OnKeyUp(ushort key, short keyCode, short modifiers)
	{
		//throw new NotImplementedException();
	}

	public void OnSize(ViewRectangle newSize)
	{
		//throw new NotImplementedException();
	}

	public void OnWheel(float distance)
	{
		//throw new NotImplementedException();
	}

	public void Removed()
	{
		//throw new NotImplementedException();
	}

	public void SetContentScaleFactor(float factor)
	{
		//throw new NotImplementedException();
	}

	public void SetFrame(IAudioPluginFrame frame)
	{
		//throw new NotImplementedException();
	}

	public bool TryFindParameter(int xPos, int yPos, out AudioParameterId parameterId)
	{
		//throw new NotImplementedException();
		parameterId = default(AudioParameterId);
		return false;
	}
}