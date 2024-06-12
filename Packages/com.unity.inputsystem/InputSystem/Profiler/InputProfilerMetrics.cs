using Unity.Profiling;
using Unity.Profiling.Editor;

namespace UnityEngine.InputSystem
{
    public static class InputProfilerMetrics
    {

        public const string InputUpdateTimeName = "Input Update Time";
        public static readonly ProfilerCounterValue<double> InputUpdateTime =
            new(ProfilerCategory.Input, InputUpdateTimeName, ProfilerMarkerDataUnit.TimeNanoseconds,
                ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);
        
        public const string InputWriteStateChangeTimeName = "Input Write State Change Time";
        public static readonly ProfilerCounterValue<double> InputWriteStateChangeTime =
            new(ProfilerCategory.Input, InputWriteStateChangeTimeName, ProfilerMarkerDataUnit.TimeNanoseconds,
                ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);
    }
}