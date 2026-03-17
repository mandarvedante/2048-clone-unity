using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class BuildScript : MonoBehaviour
{
    [MenuItem("Build/Build Game %&b")]
    public static void BuildGame()
    {
        string path = "Builds/2048/2048.exe";
        BuildPlayerOptions buildOptions = new BuildPlayerOptions();
        buildOptions.scenes = new string[]
        {
            "Assets/Scenes/2048.unity"
        };
        buildOptions.locationPathName = path;
        buildOptions.target = BuildTarget.StandaloneWindows64;
        buildOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildOptions);
        Debug.Log("Build complete.");
        System.Diagnostics.Process.Start("explorer.exe", "Builds");
    }
}
