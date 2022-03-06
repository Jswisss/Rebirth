using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImeters : MonoBehaviour
{

    public Slider SpecialBar;
    public Slider AdrenalineBar;
    //public GameObject ComboMeter;
    private float AdrenalineNumber = 100;
    private float SpecialNumber = 0;
    //private float comboNumber = .10f;
    private float timetotransparent = 12;
    private float timer = 0f;
    public Image meters;
    public AudioClip damage;
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //AdrenlineChange();
        //SpecialChange();
        //ComboChange();
        //meters.GetComponent<CanvasRenderer>().SetAlpha(0f);
        //meters.CrossFadeAlpha(0f, 1f, false);
        //SpecialBar.GetComponent<Slider>().image.CrossFadeAlpha(0f, 1f, false);
        //AdrenalineBar.GetComponent<Slider>().image.CrossFadeAlpha(0f, 1f, false);

        if (timer<Time.time)
        {
            //meters.CrossFadeAlpha(0f, 1f, false);
            // SpecialBar.
            meters.CrossFadeAlpha(0f, 1f, false);
            SpecialBar.GetComponent<Slider>().image.CrossFadeAlpha(0f, 1f, false);
            AdrenalineBar.GetComponent<Slider>().image.CrossFadeAlpha(0f, 1f, false);
        }
        else
        {
            meters.CrossFadeAlpha(1f, 0f, true);
            SpecialBar.GetComponent<Slider>().image.CrossFadeAlpha(1f, 0f, true);
            AdrenalineBar.GetComponent<Slider>().image.CrossFadeAlpha(1f, 0f, true);
        }


    }

    public void hit()
    {
        float currentlife = AdrenalineBar.GetComponent<Slider>().value - 10;
        AdrenlineChange(currentlife);
        audiosource.PlayOneShot(damage);
    }

    void AdrenlineChange(float life)
    {
        AdrenalineNumber = life;
        //meters.CrossFadeAlpha(1f, 0f, false);
        AdrenalineBar.GetComponent<Slider>().value = AdrenalineNumber;
        timer = Time.time + timetotransparent;
    }
    void SpecialChange()
    {
        SpecialBar.GetComponent<Slider>().value = SpecialNumber;
        timer = Time.time + timetotransparent;
    }
    /*void ComboChange()
    {
        ComboMeter.GetComponent<Image>().fillAmount = comboNumber;
    }*/


}
