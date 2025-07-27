<<<<<<< HEAD
﻿namespace VelopackTest;

public class Program
{
    static void Main()
    {

        TestWriteLine("VELOPACK");
    }

    static void TestWriteLine(string text)
    {
        Console.WriteLine(text);
    }
=======
﻿using Velopack;

namespace VelopackTest;

class Program
{
    static async Task Main(string[] args)
    {
        VelopackApp.Build().Run();
        
        RunMainApplication();

        await UpdateMyApp();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void RunMainApplication()
    {
        Console.WriteLine("Updating new patch...");
        var text = "Velopack Dryrun 3.0.0";

        Console.WriteLine(text);
        Console.WriteLine(text);
        Console.WriteLine(text);
    }

    static async Task UpdateMyApp()
    {
        var mgr = new UpdateManager(@"C:\Users\Nimbyx\Documents\Gab Github\code-training\VelopackTest\Updates");

        // check for new version
        var newVersion = await mgr.CheckForUpdatesAsync();
        if (newVersion == null)
            return; // no update available

        // download new version
        await mgr.DownloadUpdatesAsync(newVersion);

        // install new version and restart app
        mgr.ApplyUpdatesAndRestart(newVersion);
    }
>>>>>>> 50fbef3cf2fd4cbe73ee5fb2ea7c7f5eb39576e2
}