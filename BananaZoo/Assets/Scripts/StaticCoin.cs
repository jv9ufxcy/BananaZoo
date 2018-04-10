using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCoin : MonoBehaviour 
{
    public static int CoinCount {get; private set;}
    public void OnLongCLick()
    {
        CoinCount++;
    }
}

