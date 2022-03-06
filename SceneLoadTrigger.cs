//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadTrigger : MonoBehaviour
{
    public string loadName;
    public string unloadName;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (loadName != "")
            {
                SceneAdditiveLoader.Instance.Load(loadName);
            }
            if (unloadName != "")
            {
                StartCoroutine("UnloadScene");
            }
        }
    }
    IEnumerator UnloadScene()
    {
        yield return new WaitForSeconds(.5f);
        SceneAdditiveLoader.Instance.Unload(unloadName);
    }
}
