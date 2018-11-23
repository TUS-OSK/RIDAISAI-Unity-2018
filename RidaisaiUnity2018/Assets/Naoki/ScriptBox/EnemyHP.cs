using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour
{


    public int enemyHP;
    private Slider slider;
    GameObject Player;  //ここで持って来たいスクリプトを持ってるオブジェクトを提示
    MainHPBer mainhp;  //持って来たいスクリプトを提示
    public GoblinController goblincon;


        // Use this for initialization
        void Start()
        {
        slider = GameObject.Find("HPSlider").GetComponent<Slider>();
        slider.maxValue = enemyHP;
        slider.value = enemyHP;
        Player = GameObject.Find("2Handed Warrior");  //ここで変数に格納する
        mainhp = Player.GetComponent<MainHPBer>();   //スクリプトを変数に格納する
        goblincon = GetComponent<GoblinController>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    public void attack(){
        enemyHP = enemyHP - 1;
        slider.value = enemyHP;
        if (enemyHP == 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (goblincon.n == false)
        {
            // string layer = LayerMask.LayerToName(other.gameObject.layer);
            if (other.gameObject.CompareTag("Player")/*layer == "Player"*/)
            {
                mainhp.Attacked();
            }
        }
    }

    /*      if (other.gameObject.CompareTag("ken"))
           {
               enemyHP = enemyHP - 1;
               slider.value = enemyHP;
               if (enemyHP == 0)
               {
                   Destroy(this.gameObject);
               }
           }*/
    //スクリプトのなかに入っている関数を表示

}
