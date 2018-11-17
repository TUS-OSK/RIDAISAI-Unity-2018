using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {
    private Animator animator;
    public AudioManeger se;
    public float StartTime;
    public float musicSpan;
    private int n;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += transform.forward * 1f * Time.deltaTime;
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
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position += transform.forward * -10f * Time.deltaTime;
            animator.SetBool("walk", true);
        }else{
            animator.SetBool("walk", false);
        }
        if(Input.GetKey(KeyCode.Space)){
            animator.SetBool("Attack1Trigger", true);
            StartCoroutine(music());
            n += 1;
        }
    }
    private IEnumerator music(){
        if(Input.GetKey(KeyCode.Space) && n ==1){
            Debug.Log("攻撃した");
            yield return new WaitForSeconds(musicSpan);
            se.PlaySE();
            yield return new WaitForSeconds(StartTime);
            n = 0;
        }
    }
}
