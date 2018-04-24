using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    //Code thanks to Katus Production
    //Video link: https://www.youtube.com/watch?v=98s8r0Pjb1g


    Image fillImg;

    [SerializeField]
    float timerAmmountSeconds = 20;

    float time;

    // Use this for initialization
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = timerAmmountSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timerAmmountSeconds;
        }
    }
}