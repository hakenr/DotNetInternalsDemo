using System;

byte[] empty = new byte[0]; // 24 bytes
byte[] soh = new byte[85000 - 25];
byte[] loh = new byte[85000 - 24];
byte[] test = new byte[0x1D4C0];

Console.WriteLine($"soh Generation: " + GC.GetGeneration(soh));
Console.WriteLine($"loh Generation: " + GC.GetGeneration(loh));
Console.WriteLine($"test Generation: " + GC.GetGeneration(test));

// COMPlus_GCLOHThreshold environment variable (HEX! 1D4C0 = 120_000) via launchSettings.json
// https://docs.microsoft.com/en-us/dotnet/core/run-time-config/garbage-collector