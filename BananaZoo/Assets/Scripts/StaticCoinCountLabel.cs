using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticCoinCountLabel : MonoBehaviour 
{
    private Text labelText; 
	// Use this for initialization
	void Start () 
	{
        labelText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        labelText.text = "Tickets Sold " + StaticCoin.CoinCount/*.ToString()*/;
    }
}
