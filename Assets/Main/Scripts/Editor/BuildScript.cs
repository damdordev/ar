using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildScript
{

    [MenuItem("Damdor/Build")]
    public static void Build()
    {
        var options = new BuildPlayerOptions
        {
            options = BuildOptions.None,
            scenes = Enumerable.Range(0, SceneManager.sceneCountInBuildSettings)
                               .Select(SceneUtility.GetScenePathByBuildIndex)
                               .ToArray(),
            target = BuildTarget.Android,
            targetGroup = BuildTargetGroup.Android,
            locationPathName = Path.Combine(Path.Combine(Path.GetDirectoryName(Application.dataPath), "Builds"), "ar.apk")
        };
        BuildPipeline.BuildPlayer(options);
    }

}
