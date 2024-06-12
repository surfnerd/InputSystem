using Unity.Profiling;
using Unity.Profiling.Editor;

namespace UnityEngine.InputSystem.Editor
{
    [ProfilerModuleMetadata(InputProfilerMetrics.InputUpdateTimeName)]
    public class InputProfilerModule : ProfilerModule
    {
        static readonly ProfilerCounterDescriptor[] k_Counters = {
            new(InputProfilerMetrics.InputUpdateTimeName, ProfilerCategory.Input)
        };
        
        public InputProfilerModule() : base(k_Counters)
        {
        }
    }
}