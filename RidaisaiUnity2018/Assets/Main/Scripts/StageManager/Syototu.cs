using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syototu : MonoBehaviour
{

    private MainHPBer gobattack;
    // Use this for initialization
    void Start()
    {
        GameObject Player = GameObject.Find("2Handed Warrior");
        gobattack = Player.GetComponent<MainHPBer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        {
            // string layer = LayerMask.LayerToName(other.gameObject.layer);
            if (other.gameObject.CompareTag("Player")){
                gobattack.Attacked();
            }


        }

    }
}