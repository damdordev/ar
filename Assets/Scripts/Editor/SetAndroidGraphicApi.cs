using UnityEditor;
using UnityEngine.Rendering;

public class SetAndroidGraphicApi
{

    [MenuItem("Damdor/Set android graphic api")]
    public static void Setup()
    {
        PlayerSettings.SetGraphicsAPIs(BuildTarget.Android,  new [] { GraphicsDeviceType.OpenGLES3 });
    }
    
}
