using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Savefile : MonoBehaviour
{


    void CreateText()
    {
        string path = Application.dataPath + "/Log.txt";

        if(!File.Exists(path))
        {
            File.WriteAllText(path, "Login log \n\n");
        }

        float Volume = AudioListener.volume;
        File.WriteAllText(path, Volume.ToString());
        Color brightness = RenderSettings.ambientLight;
        File.WriteAllText(path, brightness.ToString());
        //int CurrentLevel = ;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
