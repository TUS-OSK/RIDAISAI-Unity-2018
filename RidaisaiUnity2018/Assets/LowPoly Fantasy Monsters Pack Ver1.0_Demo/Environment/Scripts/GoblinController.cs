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
    private bool n;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        hani.SetActive(false);
        n = true;
    }


        // Update is called once per frame
        void Update()
        {
           
        }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (n == true)
            {
                animator.SetBool("walk", true);
                transform.rotation = Quaternion.Slerp(transform.rotation,
                                                      Quaternion.LookRotation(target.position - transform.position), 1f * Time.deltaTime);
                transform.position += transform.forward * 1.5f * Time.deltaTime;
                n = false;
            }

        }else{
            animator.SetBool("walk", false);
            n = true;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player")){
            StartCoroutine(Atakkedspm());
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