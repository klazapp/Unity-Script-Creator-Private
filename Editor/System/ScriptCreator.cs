using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEditor;
using System.IO;

public class ScriptCreator : MonoBehaviour
{
    [MenuItem("Klazapp/Create/MonoBehaviour Script", false, 80)]
    private static void CreateMonoBehaviourScriptFromMenuBar()
    {
        CreateMonoBehaviourScript();
    }
    
    [MenuItem("Assets/Create/Klazapp/MonoBehaviour Script", false, 80)]
    private static void CreateMonoBehaviourScriptFromRightClick()
    {
        CreateMonoBehaviourScript();
    }
    
    [MenuItem("Klazapp/Create/ScriptableObject Script", false, 80)]
    private static void CreateScriptableObjectScriptFromMenuBar()
    {
        CreateScriptableObjectScript();
    }
    
    [MenuItem("Assets/Create/Klazapp/ScriptableObject Script", false, 80)]
    private static void CreateScriptableObjectScriptFromRightClick()
    {
        CreateScriptableObjectScript();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void CreateMonoBehaviourScript()
    {
        if (!CheckValidPath(GetCurrentProjectWindowPath()))
            return;

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(ScriptCreatorComponent.MONOBEHAVIOUR_TEMPLATE_PATH, ScriptCreatorComponent.MONOBEHAVIOUR_DEFAULT_NAME);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void CreateScriptableObjectScript()
    {
        if (!CheckValidPath(GetCurrentProjectWindowPath()))
            return;

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(ScriptCreatorComponent.SCRIPTABLEOBJECT_TEMPLATE_PATH, ScriptCreatorComponent.SCRIPTABLEOBJECT_DEFAULT_NAME);
    }
    
    private static bool CheckValidPath(string path)
    {
        //Check if path is not null or empty
        if (string.IsNullOrEmpty(path))
        {
            return false;
        }

        //Check if path is in Assets folder
        if (!path.StartsWith("Assets"))
        {
            return false;
        }

        //Check if path is not in Packages folder
        if (path.StartsWith("Packages/"))
        {
            return false;
        }

        //Check if path is not in any Editor folder
        return !path.Contains("/Editor/") && !Path.GetFileName(path).Equals("Editor");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string GetCurrentProjectWindowPath()
    {
        var path = "Assets";

        //Get currently selected object
        var selectedObject = Selection.activeObject;

        //If something is selected
        if (selectedObject == null)
        {
            // Focus the Project window
            EditorUtility.FocusProjectWindow();
            return path;
        }
        
        //Get path to selected object
        path = AssetDatabase.GetAssetPath(selectedObject);

        //If selected object is folder, return its path
        return System.IO.Directory.Exists(path) ? path :
            //If selected object is not folder, return path to its directory
            System.IO.Path.GetDirectoryName(path);

        //If nothing is selected, return the root Assets path
    }
}
