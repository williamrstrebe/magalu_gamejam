using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadSystem : MonoBehaviour
{
    //public string SavePath = $"{Application.persistentDataPath}/save.txt";
    public string SavePath;
    public static string QuickSavePath;

    private void Awake()
    {
        this.SavePath = Application.persistentDataPath + "/save.txt";
        SaveLoadSystem.QuickSavePath = Application.persistentDataPath + "/quicksave.txt";
    }

    [ContextMenu("Save")]
    public void save()
    {
        var state = loadFile(SavePath);
        saveState(state);
        saveFile(state, SavePath);
    }

    public void quickSave()
    {
        var state = loadFile(QuickSavePath);
    }
    public void quickLoad()
    {
        var state = loadFile(QuickSavePath);
        loadState(state);
    }

    [ContextMenu("Load")]
    public void load()
    {
        var state = loadFile(SavePath);
        loadState(state);
    }

    void saveFile(object state, string path)
    {

        using (var stream = File.Open(path, FileMode.Create))
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, state);
        }

    }

    Dictionary<string, object> loadFile(string path)
    {
        if (!File.Exists(SavePath))
        {
            Debug.Log("No save file found");
            return new Dictionary<string, object>();
        }

        using (FileStream stream = File.Open(SavePath, FileMode.Open))
        {
            var formatter = new BinaryFormatter();
            stream.Position = 0;
            return (Dictionary<string, object>)formatter.Deserialize(stream);
        }
    }

    public void saveState(Dictionary<string, object> state)
    {

        foreach (var saveable in FindObjectsOfType<SaveableEntity>())
        {
            state[saveable.Id] = saveable.saveState();
        }



    }
    void loadState(Dictionary<string, object> state)
    {

        foreach (var saveable in FindObjectsOfType<SaveableEntity>())
        {
            if (state.TryGetValue(saveable.Id, out object savedState))
            {
                saveable.loadState(savedState);
            }
        }

    }
}
