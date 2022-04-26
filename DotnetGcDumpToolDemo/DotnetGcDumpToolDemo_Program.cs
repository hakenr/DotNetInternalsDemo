int a = 0xAAAA;
bool b = true;
Int64 c = 0xCCCCCCCC;
for (int i = 0; i < 0xFF; i++)
{
	MyClass instance = new MyClass(a);
}
int r;

Console.WriteLine("Collect gcdump and press ENTER to end...");
Console.ReadLine();

public class MyClass
{
	private static MyClass lastInstance;
	private int field1;
	private int field2;
	private int field3;
	private byte[] data = new byte[2048];

	public MyClass(int field)
	{
		field1 = field;
		lastInstance = this;
	}
}


// dotnet tool install -g dotnet-gcdump
// dotnet-gcdump ps
// dotnet-gcdump collect -p <id>
// dotnet-gcdump report <path>
// .gcdump file -> VisualStudio / PerfView
