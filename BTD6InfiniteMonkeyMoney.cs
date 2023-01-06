using MelonLoader;
using BTD_Mod_Helper;
using BTD6InfiniteMonkeyMoney;

[assembly: MelonInfo(typeof(BTD6InfiniteMonkeyMoney.BTD6InfiniteMonkeyMoney), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BTD6InfiniteMonkeyMoney;

public class BTD6InfiniteMonkeyMoney : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<BTD6InfiniteMonkeyMoney>("BTD6InfiniteMonkeyMoney loaded!");
    }
}