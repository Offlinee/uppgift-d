using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timerText;
    private float startTime;
    public float number = 1;
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        // ökar med 1 varje sekund
        timerText = timerText + Time.deltaTime; 
        // om timerText är lika mycket som eller större än number så körs följande komandon
        if (timerText >= number)
        {
            // om timerText = eller större än number så printar timer
            print(string.Format("Timer:{0}", timerText));
            // om timerText = eller större än number så ökar number med 1
            number = number + 1;
        }
    }
    }
