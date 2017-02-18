using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour {

    [SerializeField]
    private TimeCounter counter;
    [SerializeField]
    private Text text;
	// Use this for initialization
	void Start () {
        counter.timerEventHandler = (time) =>
        {
            text.text = time.ToString();
        };
	}
}
