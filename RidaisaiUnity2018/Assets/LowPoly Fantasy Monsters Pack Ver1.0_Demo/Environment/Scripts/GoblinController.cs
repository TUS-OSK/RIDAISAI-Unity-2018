using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinController : MonoBehaviour
{

    public Animator animator;
    public Transform target;
    public float tekiat;
    public GameObject hani;
    public float kougeki;
    public float Attime;
   // public bool n;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        hani.SetActive(false);
     //   n = false;
    }


        // Update is called once per frame
        void Update()
        {
           
        }
    private void OnTriggerStay(Collider other)
    {
        //if (n == true)
        // {
        if (other.gameObject.CompareTag("Player"))
        {

            animator.SetBool("walk", true);
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                  Quaternion.LookRotation(target.position - transform.position), 4f * Time.deltaTime);
            transform.position += transform.forward * 0.2f * Time.deltaTime;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            animator.SetBool("walk", false);
        }
    }
    public void OnCollisionEnter(Collision other)
    {

        {
            if (other.gameObject.CompareTag("Player"))
            {
               // n = true;
            //    if (n == true)
               // {
                    StartCoroutine(Atakkedspm());
              //  }
            }
        }
    }
    private IEnumerator Atakkedspm(){
        yield return new WaitForSeconds(tekiat);
        animator.SetTrigger("AtTrigger");
        yield return new WaitForSeconds(kougeki);
        hani.SetActive(true);
        yield return new WaitForSeconds(Attime);
        hani.SetActive(false);
    }
}