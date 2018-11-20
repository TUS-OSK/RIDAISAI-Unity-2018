﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchCaracter : MonoBehaviour {


    private void OnCollisionStay(Collision col)
    {
        if(col.gameObject.CompareTag("Player")){
            MoveEnemy.EnemyState state = GetComponentInParent<MoveEnemy>().GetState();
            if(state != MoveEnemy.EnemyState.Chase){
                Debug.Log("プレイヤー発見");
                GetComponent<MoveEnemy>().SetState("chase", col.transform);
            }
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
