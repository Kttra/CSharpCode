# CSharpTips
C# info

**Regex**
------------
[Regex Patterns](https://github.com/Kttra/RegexPatterns)

**Command Prompt**
-----------------
```csharp
using System.Diagnostics;
var proc1 = new ProcessStartInfo();
string aCommand = "shutdown -s -f -t " + time;
proc1.UseShellExecute = true;
proc1.WorkingDirectory = @"C:\Windows\System32";
proc1.FileName = @"C:\Windows\System32\cmd.exe";
proc1.Verb = "runas"; //behave as if the process has been started from Explorer with the "Run as Administrator" menu command
proc1.Arguments = "/c " + aCommand; //"/c" tells the prompt to run and terminate afterwards
proc1.WindowStyle = ProcessWindowStyle.Hidden;
Process.Start(proc1);
```

**Textbox**
-----------
```csharp
MessageBox.Show("Invalid! Time cannot be 0.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
```
