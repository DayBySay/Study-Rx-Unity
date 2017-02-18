using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter : MonoBehaviour {
    public delegate void TimerEventHandler(int time);
    public TimerEventHandler timerEventHandler;

	// Use this for initialization
	void Start () {
        StartCoroutine(TimerCoroutine());		
	}

    IEnumerator TimerCoroutine()
    {
        var time = 100;
        while (time > 0)
        {
            time--;
            timerEventHandler(time);

            yield return new WaitForSeconds(1);
        }
    }
}