using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {
    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up")) {
            transform.position += transform.forward * 0.01f;
            animator.SetBool("Moving", true);
        }else{
            animator.SetBool("Moving", false);
        }
        if(Input.GetKey("right")){
            transform.Rotate(0, 5, 0);
        }
        if(Input.GetKey("left")){
            transform.Rotate(0, -5, 0);
        }
        if(Input.GetKey("down")){
            this.transform.Translate(Vector3.back * 0.2f);
            animator.SetBool("walk", true);
        }else{
            animator.SetBool("walk", false);
        }
        if(Input.GetKey(KeyCode.Space)){
            animator.SetBool("Attack1Trigger", true);
        }
	}
}
