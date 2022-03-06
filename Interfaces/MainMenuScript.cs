using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Button Continue;
    public Button Start_game;
    public Button Settings;
    public Button Credits;
    public Button Quit;
    public Canvas MainMenu;
    public Canvas SettingsCanvas;
    public Button Controls;
   // public Button Audio;
    //public Button Video;
    public Button back;
    public Canvas ControlCanvas;
    public Image Xboxcontrol;
    public Button XboxControlbutton;
    public Image PCcontrol;
    public Button PCcontrolButton;
    public Button backcontrols;
    //public Canvas AudioCanvas;
    //public Button backAudio;
    //public Canvas VideoCanvas;
   // public Button backVideo;

    private void Awake()
    {
        SettingsCanvas.GetComponent<Canvas>().enabled = false;
        ControlCanvas.GetComponent<Canvas>().enabled = false;
        // AudioCanvas.GetComponent<Canvas>().enabled = false;
        // VideoCanvas.GetComponent<Canvas>().enabled = false;
        PCcontrol.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Continue.onClick.AddListener(returnToCurrentPosition);
        Start_game.onClick.AddListener(startgame);
        Settings.onClick.AddListener(Activate_Settings_UI);
        Credits.onClick.AddListener(credits_scene);
        Quit.onClick.AddListener(quitgame);
        Controls.onClick.AddListener(ControlsUI);
      //  Audio.onClick.AddListener(AudioUI);
       // Video.onClick.AddListener(VideoUI);
        back.onClick.AddListener(returnToMainMenu);
        backcontrols.onClick.AddListener(returnToSettings);
        // backAudio.onClick.AddListener(returnToSettings);
        // backVideo.onClick.AddListener(returnToSettings);
        //controls
        XboxControlbutton.onClick.AddListener(ChangetoXbox);
        PCcontrolButton.onClick.AddListener(ChangetoPC);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void returnToCurrentPosition()
    {
        //if save file exist, read save file and grab current level
        // loads that level
        int savelevel;
        savelevel = 1;
        SceneManager.LoadScene(savelevel);
    }
    void startgame()
    {
        //Loads into level 1
        SceneManager.LoadScene(1);
    }
    void Activate_Settings_UI()
    {
        MainMenu.GetComponent<Canvas>().enabled = false;
        SettingsCanvas.GetComponent<Canvas>().enabled = true;
    }
    void credits_scene()
    {
        SceneManager.LoadScene(8);
    }
    void quitgame()
    {
        Application.Quit();
    }

    void ControlsUI()
    {
        SettingsCanvas.GetComponent<Canvas>().enabled = false;
        ControlCanvas.GetComponent<Canvas>().enabled = true;
    }
   /* void AudioUI()
    {
        SettingsCanvas.GetComponent<Canvas>().enabled = false;
        AudioCanvas.GetComponent<Canvas>().enabled = true;
    }
    void VideoUI()
    {
        SettingsCanvas.GetComponent<Canvas>().enabled = false;
        VideoCanvas.GetComponent<Canvas>().enabled = true;
    }*/
    void returnToMainMenu()
    {
        MainMenu.GetComponent<Canvas>().enabled =true;
        SettingsCanvas.GetComponent<Canvas>().enabled = false;
    }
    void returnToSettings()
    {
        ControlCanvas.GetComponent<Canvas>().enabled = false;
        //AudioCanvas.GetComponent<Canvas>().enabled = false;
        //VideoCanvas.GetComponent<Canvas>().enabled = false;
        SettingsCanvas.GetComponent<Canvas>().enabled = true;
    }

    void ChangetoXbox()
    {
        PCcontrol.gameObject.SetActive(false);
        Xboxcontrol.gameObject.SetActive(true);
    }
    void ChangetoPC()
    {
        PCcontrol.gameObject.SetActive(true);
        Xboxcontrol.gameObject.SetActive(false);
    }
}
