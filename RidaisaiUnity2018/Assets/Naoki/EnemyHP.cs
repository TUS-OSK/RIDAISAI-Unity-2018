using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour
{


    public int enemyHP;
    private Slider slider;


        // Use this for initialization
        void Start()
        {
        slider = GameObject.Find("HPSlider").GetComponent<Slider>();
        slider.maxValue = enemyHP;
        slider.value = enemyHP;
        }

        // Update is called once per frame
        void Update()
        {

        }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ken"))
        {
            enemyHP = enemyHP - 1;
            slider.value = enemyHP;
            if (enemyHP == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
