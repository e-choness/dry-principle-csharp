using ExtensionsLibrary;

namespace AsyncDummyLib;

public class TeaBrewer
{
    public static async Task<string> MakeTeaAsync()
    {
        var boilingWater = BoilWaterAsync();

        "Take cups out.".Dump();
        "Put tea in cups.".Dump();
        
        var water = await boilingWater;
        
        var tea = $"pour {water} in cups.".Dump();
        
        return tea;
    }

    private static async Task<string> BoilWaterAsync()
    {
        "Start the kettle.".Dump();

        "Waiting for the kettle.".Dump();

        await Task.Delay(2000);

        "Kettle finished boiling".Dump();

        return "boiling water";
    }
}