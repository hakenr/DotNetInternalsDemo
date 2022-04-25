using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace PerformanceBenchmarks
{
	[ShortRunJob]
	public class SkipLocalsInitBenchmark
	{
		[Params(64, 256, 1024)]
		public int AllocationSize { get; set; }

		[Benchmark(Baseline = true)]
		public byte InitLocals()
		{
			Span<byte> s = stackalloc byte[AllocationSize];
			return s[0];
		}

		[Benchmark]
		[SkipLocalsInit]
		public byte SkipInitLocals()
		{
			Span<byte> s = stackalloc byte[AllocationSize];
			return s[0];
		}
	}
}

//|         Method | AllocationSize |      Mean |     Error |    StdDev | Ratio |
//|--------------- |--------------- |----------:|----------:|----------:|------:|
//|     InitLocals |             64 |  2.358 ns | 0.4895 ns | 0.0268 ns |  1.00 |
//| SkipInitLocals |             64 |  2.443 ns | 0.1242 ns | 0.0068 ns |  1.04 |
//|                |                |           |           |           |       |
//|     InitLocals |            256 |  8.533 ns | 0.3126 ns | 0.0171 ns |  1.00 |
//| SkipInitLocals |            256 |  2.480 ns | 0.7763 ns | 0.0426 ns |  0.29 |
//|                |                |           |           |           |       |
//|     InitLocals |           1024 | 34.518 ns | 3.6189 ns | 0.1984 ns |  1.00 |
//| SkipInitLocals |           1024 |  2.540 ns | 1.5668 ns | 0.0859 ns |  0.07 |