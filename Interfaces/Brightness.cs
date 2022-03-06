using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{

    public Slider BrightnessLevel;
    float rbgValue = .5f;
    // Start is called before the first frame update
   void Start()
    {
        BrightnessLevel.GetComponent<Slider>().value = rbgValue*100;
    }

    // Update is called once per frame
    void Update()
    {
        rbgValue = BrightnessLevel.GetComponent<Slider>().value/100;
        RenderSettings.ambientLight = new Color(rbgValue, rbgValue, rbgValue, 1);
    }

}
