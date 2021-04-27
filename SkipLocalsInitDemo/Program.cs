using System;
using System.Runtime.CompilerServices;

unsafe void DoSomethingWithZeroing()
{
	long x;
	Console.WriteLine(*&x); // Outputs 0
}

[SkipLocalsInit]
unsafe void DoSomethingSkipLocalsInit()
{
	long x;
	Console.WriteLine(*&x); // Unpredictable output
}

DoSomethingWithZeroing();
DoSomethingSkipLocalsInit();