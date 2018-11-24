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
    public AudioManeger se4;


        // Use this for initialization
        void Start()
        {
        slider = this.GetComponentInChildren<Slider>();
        slider.maxValue = enemyHP;
        slider.value = enemyHP;
        Player = GameObject.Find("2Handed Warrior");  //ここで変数に格納する
        //if(Player) mainhp = Player.GetComponent<MainHPBer>();   //スクリプトを変数に格納する
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
            se4.PlaySE4();
            Destroy(this.gameObject);
        }
    }
   /* private void OnTriggerEnter(Collider other)
    {
        {
            // string layer = LayerMask.LayerToName(other.gameObject.layer);
            if (other.gameObject.CompareTag("Player")/*layer == "Player")
            {
              //  goblincon.n = true;
              //  if (goblincon.n == true)
                //{
                mainhp.Attacked();
               // }
            }
        }*/
    //}

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
