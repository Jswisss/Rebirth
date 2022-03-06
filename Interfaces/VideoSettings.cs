using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoSettings : MonoBehaviour
{

    public Dropdown Video;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Video.value == 0)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        if (Video.value == 1)
        {
            Screen.SetResolution(1600, 900, true);
        }
        if (Video.value == 2)
        {
            Screen.SetResolution(1366, 768, true);
        }
        if (Video.value == 3)
        {
            Screen.SetResolution(1280, 800, true);
        }
    }
}
