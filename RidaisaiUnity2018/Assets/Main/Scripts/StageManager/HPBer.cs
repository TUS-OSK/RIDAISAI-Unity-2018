using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBer : MonoBehaviour {

    private Slider slider;

	// Use this for initialization
	void Start () {
        slider = GameObject.Find("HPSlider").GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Camera.main.transform.rotation;
	}
}
