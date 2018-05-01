using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    //Timer bar code thanks to Katus Production
    //Video link: https://www.youtube.com/watch?v=98s8r0Pjb1g


    Image fillImg;

    [SerializeField]
    float timerAmmountSeconds = 20;

    [SerializeField]
    float clean = 5;

    float time;

    [SerializeField]
    bool tempControll;
    [SerializeField]
    bool habCleanControll;
    [SerializeField]
    GameObject Broken;
    [SerializeField]
    GameObject self;

    // Use this for initialization
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = timerAmmountSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > timerAmmountSeconds)
            time = timerAmmountSeconds;

        if (time > 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timerAmmountSeconds;
        }

        if (time <= 0 && tempControll == true)
        {
            Broken.SetActive(true);
            self.SetActive(false);
        }

        if (time <= 0 && habCleanControll == true)
        {
            Broken.SetActive(true);
            self.SetActive(false);
        }
    }

    public void Clean()
    {
        time+=clean;
    }
}