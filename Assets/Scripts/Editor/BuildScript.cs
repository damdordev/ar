using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildScript
{

    [MenuItem("Damdor/Build")]
    public static void Build()
    {
        var a = new string[5];
        var options = new BuildPlayerOptions
        {
            options = BuildOptions.None,
            scenes = new[] { "Assets/Scenes/SampleScene.unity" },
            target = BuildTarget.Android,
            targetGroup = BuildTargetGroup.Android,
            locationPathName = Path.Combine(Path.Combine(Path.GetDirectoryName(Application.dataPath), "Builds"), "ar.apk")
        };
        BuildPipeline.BuildPlayer(options);
    }

}
