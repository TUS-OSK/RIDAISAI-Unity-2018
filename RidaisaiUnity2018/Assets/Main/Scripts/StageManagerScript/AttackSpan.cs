using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpan : MonoBehaviour {

    public GameObject sword;
    public float attackTime;
    public float stTime;

	// Use this for initialization
	void Start () {
        attackTime = 0;
        sword.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sword.SetActive(true);
            attackTime = 0;

        }
        else if(sword.activeSelf){
            attackTime += Time.deltaTime;
            if (attackTime > stTime)
            {
                sword.SetActive(false);
            }
        }
	}
}
