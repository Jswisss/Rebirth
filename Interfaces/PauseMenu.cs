using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Canvas Pause_Menu;
    public Button Continue;
    public Button Settings;
    public Button Quit;
    public GameObject PauseMenuPanel;
    public GameObject SettingsPanel;
    public GameObject ControlsPanel;
    //public GameObject AudioPanel;
   // public GameObject VideoPanel;
    public Button Controls;
    // public Button Audio;
    // public Button Video;
    public Image Xboxcontrol;
    public Button XboxControlbutton;
    public Image PCcontrol;
    public Button PCcontrolButton;
    public Button back;
    public Button backcontrols;
   // public Button backAudio;
   // public Button backVideo;



    private void Awake()
    {
        Pause_Menu.GetComponent<Canvas>().enabled = false;
        SettingsPanel.gameObject.SetActive(false);
        ControlsPanel.gameObject.SetActive(false);
        PCcontrol.gameObject.SetActive(false);
        // AudioPanel.gameObject.SetActive(false);
        // VideoPanel.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        Continue.onClick.AddListener(ResumeGame);
        Settings.onClick.AddListener(DisplaySettings);
        Quit.onClick.AddListener(returnsMainMenu);
        Controls.onClick.AddListener(ControlsUI);
       // Audio.onClick.AddListener(AudioUI);
       // Video.onClick.AddListener(VideoUI);
        back.onClick.AddListener(returnToPauseMenu);
        backcontrols.onClick.AddListener(returnToSettings);
        // backAudio.onClick.AddListener(returnToSettings);
        // backVideo.onClick.AddListener(returnToSettings);
        XboxControlbutton.onClick.AddListener(ChangetoXbox);
        PCcontrolButton.onClick.AddListener(ChangetoPC);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            Pause_Menu.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        

    }

    void ResumeGame()
    {
        Pause_Menu.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1.0f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void DisplaySettings()
    {
        PauseMenuPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(true);
    }
    void returnsMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    void ControlsUI()
    {
        SettingsPanel.gameObject.SetActive(false);
        ControlsPanel.gameObject.SetActive(true);
    }
    /*void AudioUI()
    {
        SettingsPanel.gameObject.SetActive(false);
        AudioPanel.gameObject.SetActive(true);
    }
    void VideoUI()
    {
        SettingsPanel.gameObject.SetActive(false);
        VideoPanel.gameObject.SetActive(true);
    }*/
    void returnToPauseMenu()
    {
        SettingsPanel.gameObject.SetActive(false);
        PauseMenuPanel.gameObject.SetActive(true);
    }
    void returnToSettings()
    {
        ControlsPanel.gameObject.SetActive(false);
      //  AudioPanel.gameObject.SetActive(false);
      //  VideoPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(true);
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
