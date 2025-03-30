using MelonLoader;
using UnityEngine;

namespace Enhanced_Drop_Rate;

public class Enhanced_Drop_Rate : MonoBehaviour
{
    public void Start()
    {
        Plugin.Logger.Msg("MyBehaviour component initialized!");
        Plugin.Logger.Msg($"My setting is {Plugin.Config.MySetting.Value}");
        Plugin.Logger.Msg("Please delete these logs to keep the console clean!");
    }
}
