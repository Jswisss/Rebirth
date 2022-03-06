//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// The purpose of this script is to control the lights during the Laboratory Opening Scene
/// </summary>
public class LaboratoryLights : MonoBehaviour
{
    public GameObject[] lights;
    public void Start()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].GetComponent<Light>().range = 55f;
        }
    }
    public void Off()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].GetComponent<Light>().range = 0f;
        }
    }
    public void On()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].GetComponent<Light>().range = 55f;
        }
    }
}
