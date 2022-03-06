//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Invector.vCharacterController;
public class SceneAdditiveLoader : MonoBehaviour
{
    public vCharacter player;
    public static SceneAdditiveLoader Instance { set; get; }
    private void Awake()
    {
        Instance = this;
        //Load("Player");
        Load("Laboratory");
        Load("StairTransition");
    }
    //public void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        Load("Pause Menu");
    //    }
    //}
    public void Respawn()
    {
        StartCoroutine("RespawnTimer");
    }
    public IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(3f);
        player.ChangeHealth(150);
    }
    public void Load(string sceneName)
    {
        if(!SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            Debug.Log(sceneName);
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
    }

    public void Unload(string sceneName)
    {
        if(SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            SceneManager.UnloadSceneAsync(sceneName);
        }
    }
}
