using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HourTimer : MonoBehaviour {


    public Text timer;
    public Text text;
    private float startTime;
    private int limitTime = 5;

    //La carrera acabo
    private GameObject player;
    private GameObject omni;
    private GameObject line;
    private bool finished = false; // bool de carrera

    // Use this for initialization
    void Start ()
    {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (finished)
        {
            return;
        }

        float t = Time.time - startTime;

        int iMin = ((int)t / 60);
        float iSec = (t % 60);
        int iMil = ((int)(t * 100f) % 100);

        string minutes = iMin.ToString("00");
        string seconds = iSec.ToString("00");
        string mili = iMil.ToString("00");


        if (iMin >= limitTime)
        {
            t = limitTime;
            timer.color = Color.red;
            text.color = Color.red;
        }
        timer.text = minutes + ":" + seconds + ":" + mili;
    }

    public void finish()
    {
        finished = true;
        timer.color = Color.blue;
        
    } 

}
