//using NPlug.Validator;
using SharpDX.DXGI;
using System.Runtime.CompilerServices;

namespace NPlug.TestDelay;

public static class TestDelayPlugin
{
    public static AudioPluginFactory GetFactory()
    {
        var factory = new AudioPluginFactory(new("NPlug", "https://github.com/xoofx/NPlug", "no_reply@nplug.org"));
        factory.RegisterPlugin<TestDelayProcessor>(new(TestDelayProcessor.ClassId, "TestDelay", AudioProcessorCategory.Effect));
        factory.RegisterPlugin<TestDelayController>(new(TestDelayController.ClassId, "TestDelay Controller"));
        return factory;
    }

    [ModuleInitializer]
    internal static void ExportThisPlugin()
    {
        AudioPluginFactoryExporter.Instance = GetFactory();
        /*
        // Call the validator on the plugin
		var result = AudioPluginValidator.Validate(AudioPluginFactoryExporter.Instance.Export, Console.Out, Console.Error);
		if (!result)
		{
            // TODO: handle error
            Console.WriteLine("~~~~~~~~~~~~ VALIDATOR ERROR ~~~~~~~~~~~~~");
            Console.WriteLine(result.ToString());
			Console.WriteLine("~~~~~~~~~~~~ VALIDATOR ERROR END ~~~~~~~~~~~~~");
		}
        */
	}
}