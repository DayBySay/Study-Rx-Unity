using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class TimerView : MonoBehaviour {

    [SerializeField]
    private TimeCounter counter;
    [SerializeField]
    private Text text;
	// Use this for initialization
	void Start () {
        counter.OnTimeChanged.Subscribe(time =>
        {
            text.text = time.ToString();
        });
	}
}
