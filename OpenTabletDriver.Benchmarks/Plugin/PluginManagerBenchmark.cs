using BenchmarkDotNet.Attributes;
using OpenTabletDriver.Reflection;

namespace OpenTabletDriver.Benchmarks.Plugin
{
    [DryJob]
    public class PluginManagerBenchmark
    {
        public PluginManager pluginManager;

        [Benchmark]
        public void PluginManagerCtor()
        {
            pluginManager = new PluginManager();
        }
    }
}