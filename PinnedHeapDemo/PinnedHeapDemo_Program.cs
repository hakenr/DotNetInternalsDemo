using System;
using System.Diagnostics;
using System.Text;

//var pinnedArray = GC.AllocateArray<byte>(length: 1024 * 1024, pinned: true);
var pinnedArray = GC.AllocateUninitializedArray<byte>(length: 1024 * 1024, pinned: true);

Encoding.ASCII.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZ").CopyTo(pinnedArray, 0);

GC.Collect();
Debugger.Break();

pinnedArray = null; // run in RELEASE!

GC.Collect();
Debugger.Break();

// dumpheap -stat
// dumpheap -mt
// do
// eeheap -gc