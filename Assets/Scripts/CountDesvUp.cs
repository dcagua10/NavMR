using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDesvUp : MonoBehaviour {


    public Text countD1;
    public Text countD2;
    public Text textD1;
    public Text textD2;

    private int cd1;
    private int cd2;

	// Use this for initialization
	void Start ()
    {
        cd1 = 0;
        cd2 = 0;
        countD1.text = cd1.ToString();
        countD2.text = cd2.ToString();
    }	
	
	
	// Update is called once per frame
	void Update ()
    {
        countD1.text = cd1.ToString();
        countD2.text = cd2.ToString();
    }

    public void d1mup()
    {
        cd1 += 1;
    }
    public void d2mup()
    {
        cd2 += 1;
    }
}
