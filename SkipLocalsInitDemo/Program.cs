using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

unsafe void DoSomethingWithZeroing()
{
	long x;
	Console.WriteLine(*&x); // Outputs 0
	Debugger.Break();
}

[SkipLocalsInit]
unsafe void DoSomethingSkipLocalsInit()
{
	long x;
	Console.WriteLine(*&x); // Unpredictable output
	Debugger.Break();
}

DoSomethingWithZeroing();
DoSomethingSkipLocalsInit();