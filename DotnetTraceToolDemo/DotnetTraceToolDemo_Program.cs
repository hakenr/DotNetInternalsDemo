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
	Task.Delay(50);
}

Console.ReadLine();


// dotnet tool install -g dotnet-trace
// dotnet-trace ps
// dotnet-trace collect -p <id>
// dotnet-trace report <file> topN
// https://github.com/dotnet/diagnostics/blob/main/documentation/design-docs/dotnet-tools.md#dotnet-trace