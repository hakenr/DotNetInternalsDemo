using System;
using System.Diagnostics;

Debugger.Break();

var large = new byte[50 * 1024 * 1024];  // 50MB

Debugger.Break();


// https://docs.microsoft.com/en-us/dotnet/core/run-time-config/garbage-collector
// runtimeconfig.template.json

