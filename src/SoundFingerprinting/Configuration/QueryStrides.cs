﻿namespace SoundFingerprinting.Configuration
{
    using SoundFingerprinting.Strides;

    internal static class QueryStrides
    {
        public static IStride LowLatency = new IncrementalRandomStride(1024, 1536);
        public static IStride DefaultStride = new IncrementalRandomStride(512, 768);
        public static IStride HighPrecisionStride = new IncrementalRandomStride(240, 260);
    }
}
