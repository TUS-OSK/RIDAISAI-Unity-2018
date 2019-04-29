using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneBrake : MonoBehaviour {

    public GameObject ene;
	// Use this for initialization
	void Start () {
        ene = GameObject.Find("goblin_main");
        ene = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
       


	}
}
