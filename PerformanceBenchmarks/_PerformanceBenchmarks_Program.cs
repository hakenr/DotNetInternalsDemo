using BenchmarkDotNet.Running;
using PerformanceBenchmarks;
using System;


// !! Quit Microsoft Teams as it eats your CPU !!

BenchmarkRunner.Run<SkipLocalsInitBenchmark>();
