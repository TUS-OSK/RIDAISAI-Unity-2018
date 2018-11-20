using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

    private EnemyState state;
    public bool arrived;
    public float elapsedTime;
    public Animator animator;
    private Transform playerTransform;
    UnityEngine.AI.NavMeshAgent setPosition;
    private Rigidbody rb;
    private CharacterController enemycontroller;
    public enum EnemyState
    {
        Walk,
        Wait,
        Chase
    };


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        setPosition = GetComponent<UnityEngine.AI.NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        enemycontroller = GetComponent<CharacterController>();
        }

    public void SetState(string mode, Transform obj = null)
    {
        if (mode == "walk")
        {
            arrived = false;
            elapsedTime = 0f;
            state = EnemyState.Walk;
           // setPosition.CreateRandomPosition();
        }else if(mode == "chase"){
            state = EnemyState.Chase;
            arrived = false;
            playerTransform = obj;

        }else if(mode == "wait"){
            elapsedTime = 0f;
            state = EnemyState.Wait;
            arrived = true;
            rb.constraints = RigidbodyConstraints.FreezeAll;


        }
    }

    public EnemyState GetState(){
        return state;
    }
    // Update is called once per frame
    void Update () {
        if(state == EnemyState.Walk || state == EnemyState.Chase){
            if(state == EnemyState.Chase){
                setPosition.SetDestination(playerTransform.position);
            }
            if(enemycontroller.isGrounded){

            }
        }
	}
}
