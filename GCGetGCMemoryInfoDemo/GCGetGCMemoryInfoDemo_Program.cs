using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


const int count = 1000;

MyClass instance;
for (int i = 0; i < count; i++)
{
	instance = new MyClass();
}

ShowMemoryInfo();
Console.ReadLine();
GC.Collect();
ShowMemoryInfo();

void ShowMemoryInfo()
{
	var info = GC.GetGCMemoryInfo(); // <======

	Console.WriteLine(JsonConvert.SerializeObject(info, Formatting.Indented));
	var gen = 0;
	foreach (var generationInfo in info.GenerationInfo)
	{
		Console.WriteLine($"Generation {gen}:");
		Console.WriteLine(JsonConvert.SerializeObject(generationInfo, Formatting.Indented));
		gen++;
	}
}
public class MyClass
{
	private byte[] arr = new byte[1024];
}
