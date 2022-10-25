# PS3Lib
PS3Lib with PS3MAPI modified for 4k form designer support.

```CSHARP
// Add PS3Lib folder to root of your Visual Studio project
// Using directive
using PS3Lib;

// Connect to PS3
public static PS3API PS3 = new PS3API();
PS3.ChangeAPI(SelectAPI.ControlConsole);// CCAPI
PS3.ChangeAPI(SelectAPI.TargetManager);// TMAPI
PS3.ChangeAPI(SelectAPI.PS3Manager);// PS3MAPI
PS3.GetCurrentAPIName(); // Returns current api as sting
PS3.ConnectTarget(0); // Open's Ccapi connect menu or connects to current tmapi target - boolean
PS3.AttachProcess(); // Attach - boolean

// Disconnect from PS3
PS3.DisconnectTarget();

// Write to memory
PS3.SetMemory(0x0000000, new byte[] { 0x00, 0x00 });
//
PS3.Extension.WriteInt16(0x0000, 420);
PS3.Extension.WriteBytes(0x0000, new byte[] { 0xff, 0xff });
PS3.Extension.WriteString(0x0000, "CrEaTiiOn");
//... Basically there is one for every primitive datatype.


// Read memory
byte [] buffer = new byte[4096];
PS3.GetMemory(0x0000, buffer);
//
PS3.Extension.ReadInt32(0x0000000); // Int32
PS3.Extension.ReadString(0x0000000); // String
PS3.Extension.ReadBytes(0x000000, 1337/*Length to read*/);
//... Basically there is one for every primitive datatype.

// CCAPI notify message
PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Hello World!");

// CCAPI Ring buzzer
PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Triple);
PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Continuous);


// PS3MAPI Notify message
PS3.PS3MAPI.Notify("Hello World!");

// PS3MAPI Ring buzzer
PS3.PS3MAPI.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Single);
PS3.PS3MAPI.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Double);
PS3.PS3MAPI.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Tripple);
```
