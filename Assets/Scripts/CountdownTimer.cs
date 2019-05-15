using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour {

    float currentTime = 0f;
    float startingTime = 300f;
    
    [SerializeField] Text countdownText;
    [SerializeField] Text tittleText;

    // Use this for initialization
	void Start ()
    {
        currentTime = startingTime;
		
	}

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            countdownText.color = Color.red;
            tittleText.color = Color.red;
        }
		
	}
}
