using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testkoru : MonoBehaviour {


    private Rigidbody rb;


    // Use this for initialization
    void Start () {
        rb = this.gameObject.GetComponent<Rigidbody>();
        StartCoroutine(buttai());
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    private IEnumerator buttai(){
        Debug.Log("落ちた");
        yield return new WaitForSeconds(3);

        rb.constraints = RigidbodyConstraints.FreezeAll;
        Debug.Log("止まった");

        yield return new WaitForSeconds(3);

        Destroy(gameObject);
        Debug.Log("ぶっ壊れた！");
    }
}
