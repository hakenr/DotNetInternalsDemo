using System;

int a = 0xAAAA;
bool b = true;
Int64 c = 0xCCCCCCCC;
for (int i = 0; i < 0xFF; i++)
{
	MyClass instance = new MyClass(a);
}
int r;

Console.WriteLine("Collect dump and press ENTER to end...");
Console.ReadLine();

public class MyClass
{
	private static MyClass lastInstance;
	private int field1;
	private int field2;
	private int field3;

	public MyClass(int field)
	{
		field1 = field;
		lastInstance = this;
	}
}


// dotnet tool install -g dotnet-dump
// dotnet-dump ps
// dotnet-dump collect -p <id>
// dotnet-dump analyze <path>
//		setsymbolserver -directory <path> -ms
//		clrstack [-a] [-i]
//      setthread <id>
//		dumpheap -stat
//		dumpheap -type MyClass
//      do <addr>
//      eeheap -gc
// https://github.com/dotnet/diagnostics/blob/main/documentation/design-docs/dotnet-tools.md#dotnet-dump

// wsl
// cd "/mnt/d/temp/_dumps/2020-08-17 - BT crashing Azure Redis client (Linux)"
// dotnet-dump analyze dump.codebooks.fail
//		setsymbolserver -directory ./Codebooks.API

// WINDOWS
// Commands:
//  clrmodules                           Lists the managed modules in the process.
//  q, exit, quit                        Exit interactive mode.
//  help, soshelp <command>              Display help for a command.
//  logging                              Enable/disable internal logging
//  lm, modules                          Displays the native modules in the process.
//  r, registers <threadindex>           Displays the thread's registers.
//  setclrpath <clrpath>                 Set the path to load coreclr DAC/DBI files.
//  threads, setthread <thread>          Sets or displays the current thread for the SOS commands.
//  clrstack <arguments>                 Provides a stack trace of managed code only.
//  clrthreads <arguments>               List the managed threads running.
//  dbgout <arguments>                   Enable/disable (-off) internal SOS logging.
//  dumpalc <arguments>                  Displays details about a collectible AssemblyLoadContext into which the specified object is loaded.
//  dumparray <arguments>                Displays details about a managed array.
//  dumpasync <arguments>                Displays info about async state machines on the garbage-collected heap.
//  dumpassembly <arguments>             Displays details about an assembly.
//  dumpclass <arguments>                Displays information about a EE class structure at the specified address.
//  dumpdelegate <arguments>             Displays information about a delegate.
//  dumpdomain <arguments>               Displays information all the AppDomains and all assemblies within the domains.
//  dumpheap <arguments>                 Displays info about the garbage-collected heap and collection statistics about objects.
//  dumpil <arguments>                   Displays the Microsoft intermediate language (MSIL) that is associated with a managed method.
//  dumplog <arguments>                  Writes the contents of an in-memory stress log to the specified file.
//  dumpmd <arguments>                   Displays information about a MethodDesc structure at the specified address.
//  dumpmodule <arguments>               Displays information about a EE module structure at the specified address.
//  dumpmt <arguments>                   Displays information about a method table at the specified address.
//  do, dumpobj <arguments>              Displays info about an object at the specified address.
//  dumpvc <arguments>                   Displays info about the fields of a value class.
//  dso, dumpstackobjects <arguments>    Displays all managed objects found within the bounds of the current stack.
//  eeheap <arguments>                   Displays info about process memory consumed by internal runtime data structures.
//  eeversion <arguments>                Displays information about the runtime version.
//  finalizequeue <arguments>            Displays all objects registered for finalization.
//  gcroot <arguments>                   Displays info about references (or roots) to an object at the specified address.
//  gcwhere <arguments>                  Displays the location in the GC heap of the argument passed in.
//  ip2md <arguments>                    Displays the MethodDesc structure at the specified address in code that has been JIT-compiled.
//  name2ee <arguments>                  Displays the MethodTable structure and EEClass structure for the specified type or method in the specified module.
//  pe, printexception <arguments>       Displays and formats fields of any object derived from the Exception class at the specified address.
//  sosstatus <arguments>                Displays the global SOS status.
//  syncblk <arguments>                  Displays the SyncBlock holder info.
//  histclear <arguments>                Releases any resources used by the family of Hist commands.
//  histinit <arguments>                 Initializes the SOS structures from the stress log saved in the debuggee.
//  histobj <arguments>                  Examines all stress log relocation records and displays the chain of garbage collection relocations that may have led
//                                       to the address passed in as an argument.
//  histobjfind <arguments>              Displays all the log entries that reference an object at the specified address.
//  histroot <arguments>                 Displays information related to both promotions and relocations of the specified root.
//  setsymbolserver <arguments>          Enables the symbol server support.
//  verifyheap <arguments>               Checks the GC heap for signs of corruption.
//  threadpool <arguments>               Lists basic information about the thread pool.
//  dumprcw <arguments>                  Displays information about a Runtime Callable Wrapper.
//  dumpccw <arguments>                  Displays information about a COM Callable Wrapper.
//  dumppermissionset <arguments>        Displays a PermissionSet object (debug build only).
//  traverseheap <arguments>             Writes out a file in a format understood by the CLR Profiler.
//  analyzeoom <arguments>               Displays the info of the last OOM occurred on an allocation request to the GC heap.
//  verifyobj <arguments>                Checks the object for signs of corruption.
//  listnearobj <arguments>              Displays the object preceding and succeeding the address specified.
//  gcheapstat <arguments>               Display various GC heap stats.
//  watsonbuckets <arguments>            Displays the Watson buckets.
//  comstate <arguments>                 Lists the COM apartment model for each thread.
//  gchandles <arguments>                Provides statistics about GCHandles in the process.
//  objsize <arguments>                  Lists the sizes of the all the objects found on managed threads.
//  gchandleleaks <arguments>            Helps in tracking down GCHandle leaks

// LINUX
// Commands:
//  clrmodules                           Lists the managed modules in the process.
//  q, exit, quit                        Exit interactive mode.
//  help, soshelp <command>              Display help for a command.
//  logging                              Enable/disable internal logging
//  lm, modules                          Displays the native modules in the process.
//  r, registers <threadindex>           Displays the thread's registers.
//  setclrpath <clrpath>                 Set the path to load coreclr DAC/DBI files.
//  threads, setthread <thread>          Sets or displays the current thread for the SOS commands.
//  clrstack <arguments>                 Provides a stack trace of managed code only.
//  clrthreads <arguments>               List the managed threads running.
//  dbgout <arguments>                   Enable/disable (-off) internal SOS logging.
//  dumpalc <arguments>                  Displays details about a collectible AssemblyLoadContext into which the specified object is loaded.
//  dumparray <arguments>                Displays details about a managed array.
//  dumpasync <arguments>                Displays info about async state machines on the garbage-collected heap.
//  dumpassembly <arguments>             Displays details about an assembly.
//  dumpclass <arguments>                Displays information about a EE class structure at the specified address.
//  dumpdelegate <arguments>             Displays information about a delegate.
//  dumpdomain <arguments>               Displays information all the AppDomains and all assemblies within the domains.
//  dumpheap <arguments>                 Displays info about the garbage-collected heap and collection statistics about objects.
//  dumpil <arguments>                   Displays the Microsoft intermediate language (MSIL) that is associated with a managed method.
//  dumplog <arguments>                  Writes the contents of an in-memory stress log to the specified file.
//  dumpmd <arguments>                   Displays information about a MethodDesc structure at the specified address.
//  dumpmodule <arguments>               Displays information about a EE module structure at the specified address.
//  dumpmt <arguments>                   Displays information about a method table at the specified address.
//  do, dumpobj <arguments>              Displays info about an object at the specified address.
//  dumpvc <arguments>                   Displays info about the fields of a value class.
//  dso, dumpstackobjects <arguments>    Displays all managed objects found within the bounds of the current stack.
//  eeheap <arguments>                   Displays info about process memory consumed by internal runtime data structures.
//  eeversion <arguments>                Displays information about the runtime version.
//  finalizequeue <arguments>            Displays all objects registered for finalization.
//  gcroot <arguments>                   Displays info about references (or roots) to an object at the specified address.
//  gcwhere <arguments>                  Displays the location in the GC heap of the argument passed in.
//  ip2md <arguments>                    Displays the MethodDesc structure at the specified address in code that has been JIT-compiled.
//  name2ee <arguments>                  Displays the MethodTable structure and EEClass structure for the specified type or method in the specified module.
//  pe, printexception <arguments>       Displays and formats fields of any object derived from the Exception class at the specified address.
//  sosstatus <arguments>                Displays the global SOS status.
//  syncblk <arguments>                  Displays the SyncBlock holder info.
//  histclear <arguments>                Releases any resources used by the family of Hist commands.
//  histinit <arguments>                 Initializes the SOS structures from the stress log saved in the debuggee.
//  histobj <arguments>                  Examines all stress log relocation records and displays the chain of garbage collection relocations that may have led to the address passed
//                                       in as an argument.
//  histobjfind <arguments>              Displays all the log entries that reference an object at the specified address.
//  histroot <arguments>                 Displays information related to both promotions and relocations of the specified root.
//  setsymbolserver <arguments>          Enables the symbol server support.
//  verifyheap <arguments>               Checks the GC heap for signs of corruption.
//  threadpool <arguments>               Lists basic information about the thread pool.