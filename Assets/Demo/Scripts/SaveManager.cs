using UnityEngine;
using System.IO;
using Object = UnityEngine.Object;
using GameArchitecture.Values;

public class SaveManager : MonoBehaviour
{
    [SerializeField] protected FloatValue floatValue = null;
    [SerializeField] protected Object[] objects = null;

    private void OnEnable()
    {
        Load();
    }

    private void OnDisable()
    {
        Save();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Save();

        if (Input.GetKeyDown(KeyCode.Alpha2))
            Load();
    }

    private string SaveDataPath { get { return Application.persistentDataPath + Path.DirectorySeparatorChar + "savedata.json"; } }

    private void Save()
    {
        string jsonString = JsonUtility.ToJson(floatValue);
        //string jsonString = floatValue.ToJson();

        File.WriteAllText(SaveDataPath, jsonString);
    }

    private void Load()
    {
        if (!File.Exists(SaveDataPath))
        {
            return;
        }

        string jsonString = File.ReadAllText(SaveDataPath);
        
        JsonUtility.FromJsonOverwrite(jsonString, floatValue);
        //floatValue.FromJson(jsonString);
    }
}
