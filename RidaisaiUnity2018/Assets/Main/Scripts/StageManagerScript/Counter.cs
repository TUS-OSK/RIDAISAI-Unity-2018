using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    public Text CountText;
    private static int n = 1;
    // Use this for initialization
    void Start () {
        CountText = GameObject.Find("Kaisou").GetComponent<Text>();
        CountText.text = "第" + n + "階層";
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Y)){
            n++;
            CountText.text = "第"+n+"階層";
        }
	}

}
