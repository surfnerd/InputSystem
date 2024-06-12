using Unity.Profiling;
using Unity.Profiling.Editor;
using UnityEditor;

namespace UnityEngine.InputSystem.Editor
{
    [ProfilerModuleMetadata(InputProfilerMetrics.InputUpdateTimeName)]
    public class InputProfilerModule : ProfilerModule
    {
        static readonly ProfilerCounterDescriptor[] k_Counters = {
            new(InputProfilerMetrics.InputUpdateTimeName, ProfilerCategory.Input),
            new(InputProfilerMetrics.InputWriteStateChangeTimeName, ProfilerCategory.Input)
        };
        
        public InputProfilerModule() : base(k_Counters)
        {
        }
    }
}