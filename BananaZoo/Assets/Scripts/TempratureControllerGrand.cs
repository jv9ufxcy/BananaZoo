using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempratureControllerGrand : MonoBehaviour 
{

    public bool habitat1check = false;
    public bool habitat2check = false;
    public bool habitat3check = false;

    private Random random;
    private int hab1Random;
    string hab1RandomText;
    private int hab2Random;
    private int hab3Random;

    public Text hab1;
    public Text hab2;
    public Text hab3;

    public List<Text> Texts;

    private void Start()
    {
        hab1Random = hab1Random.ToString;
        this.hab1.text = hab1Random;
        this.hab2.text = hab2Random.ToString;
        this.hab3.text = hab3Random.ToString;
    }

    // Update is called once per frame
    void Update ()
    {
		if (habitat1check == true && habitat2check == true && habitat3check == true)
        {
            Debug.Log("eyo");
        }
	}
}
