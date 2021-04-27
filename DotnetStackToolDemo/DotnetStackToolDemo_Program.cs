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


// dotnet tool install -g dotnet-stack
// dotnet-stack ps
// dotnet-stack report -p <id>
// https://github.com/dotnet/diagnostics/blob/main/documentation/design-docs/dotnet-tools.md#dotnet-stack