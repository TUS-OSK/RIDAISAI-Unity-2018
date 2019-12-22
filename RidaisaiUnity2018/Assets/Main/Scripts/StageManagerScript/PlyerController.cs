using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerController : MonoBehaviour {

    [SerializeField]GameObject mainChar;
    [SerializeField] GameObject enemyChar;

    GameObject insCtrl;
    GameObject EnemyChar;


    Vector3 move = new Vector3(1, 0, 1);
	// Use this for initialization
	void Start () {
        insCtrl = Instantiate(mainChar);
        EnemyChar = Instantiate(enemyChar);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
