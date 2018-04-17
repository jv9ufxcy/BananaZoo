using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempratureControllerGrand : MonoBehaviour 
{

    public bool habitat1check = false;
    public bool habitat2check = false;
    public bool habitat3check = false;
	
	// Update is called once per frame
	void Update ()
    {
		if (habitat1check == true && habitat2check == true && habitat3check == true)
        {
            Debug.Log("eyo");
        }
	}
}
