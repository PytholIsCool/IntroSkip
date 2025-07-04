using BepInEx;
using YanAPI.Wrappers;
using YanAPI.Logging;
using UnityEngine.SceneManagement;

[BepInPlugin("com.pythol.introskip", "IntroSkip", "1.0.0")]
[BepInDependency("com.pythol.YanAPI", BepInDependency.DependencyFlags.HardDependency)]
public class IntroSkip : BaseUnityPlugin {
    private void Awake() {
        CLogs.LogInfo("IntroSkip loaded.");

        GameSceneWrapper.OnDisclaimerSceneLoaded += () => {
            CLogs.LogInfo("Skipping to Main Menu scene...");
            SceneManager.LoadScene("NewTitleScene", LoadSceneMode.Single);
        };
    }
}
