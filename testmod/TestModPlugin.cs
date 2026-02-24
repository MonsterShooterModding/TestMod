using BepInEx;
using UnityEngine;

[BepInPlugin("test.testmod", "Test Mod", "1.0.0")]
public class TestModPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("TestMod: Awake called (loaded successfully)");
    }
}