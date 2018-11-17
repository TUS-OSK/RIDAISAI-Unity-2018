using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerController : MonoBehaviour {

    [SerializeField]GameObject mainChar;

    GameObject insCtrl;


    Vector3 move = new Vector3(1, 0, 1);
	// Use this for initialization
	void Start () {
        insCtrl = Instantiate(mainChar);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
