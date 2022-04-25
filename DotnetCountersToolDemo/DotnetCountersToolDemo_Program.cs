using System;
using System.Threading;
using System.Threading.Tasks;

long x = 0;

Task.Run(() =>
{
	while (true)
	{
		DoSomething();
	}
});

void DoSomething()
{
	x++;
	var z = new byte[512];
	Task.Delay(50);
}

Console.ReadLine();


// dotnet tool install -g dotnet-counters
// dotnet-counters ps
// dotnet-counters list
// dotnet-counters monitor -p <id> [counters]
// dotnet-counters monitor -n iisexpress
// https://github.com/dotnet/diagnostics/blob/main/documentation/design-docs/dotnet-tools.md#dotnet-counters