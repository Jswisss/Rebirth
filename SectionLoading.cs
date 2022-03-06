using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionLoading : MonoBehaviour
{
    private GameObject section;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Enable section player is currently in
        section = other.gameObject;
        
        foreach (Transform child in section.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Disable section player was previously in
        section = other.gameObject;

        foreach (Transform child in section.transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}
