using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClick : MonoBehaviour
{
    private bool pointerDown;
    private float pointerDownTimer;
    [SerializeField] private float requiredHoldTime;
    public UnityEvent onLongClick;

    [SerializeField] private Image fillImage;

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
        Debug.Log("OnPointerDown");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
        Debug.Log("OnPointerUp");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (pointerDown)
        {
            pointerDownTimer += Time.deltaTime;
            if (pointerDownTimer>=requiredHoldTime)
            {
                if (onLongClick!=null)
                    onLongClick.Invoke();

                Reset();
            }
        }
	}

    private void Reset()
    {
        pointerDown = false;
        pointerDownTimer = 0;
        fillImage.fillAmount = pointerDownTimer / requiredHoldTime;
    }
}
