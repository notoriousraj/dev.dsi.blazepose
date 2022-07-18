using UnityEngine;
using UnityEditor;
using System.IO;
[InitializeOnLoad]
public class ManageStreamingAssets : Editor
{
    [InitializeOnLoadMethod]
    static void OnProjectLoadedInEditor()
    {
        Debug.Log("Project loaded in Unity Editor");
        if (Directory.Exists("Assets/StreamingAssets"))
        {
            if (Directory.Exists("Assets/Samples/DSI Blaze Pose/1.0.0/blazepose Tacker/StreamingAssets"))
                FileUtil.DeleteFileOrDirectory("Assets/Samples/DSI Blaze Pose/1.0.0/blazepose Tacker/StreamingAssets");
        }
        else if (Directory.Exists("Assets/Samples/DSI Blaze Pose/1.0.0/blazepose Tacker/StreamingAssets"))
        {
            FileUtil.MoveFileOrDirectory("Assets/Samples/DSI Blaze Pose/1.0.0/blazepose Tacker/StreamingAssets", "Assets/StreamingAssets");
            FileUtil.DeleteFileOrDirectory("Assets/Samples/DSI Blaze Pose/1.0.0/blazepose Tacker/StreamingAssets");
        }
    }
}