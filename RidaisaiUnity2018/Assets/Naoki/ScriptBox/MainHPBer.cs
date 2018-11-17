using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainHPBer : MonoBehaviour
{

    private Slider mainslider;
    public float mainHP;
    public AudioManeger gameover;
    public AudioManeger bgm;
    //EnemyHP script;
    //GameObject enemy;
    // Use this for initialization
    void Start()
    {
        mainslider = GameObject.Find("HPBerMain").GetComponent<Slider>();
        mainslider.maxValue = mainHP;
        mainslider.value = mainHP;
        //enemy = GameObject.Find("Enemy");
        //script = enemy.GetComponent<EnemyHP>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attacked()
    {
        mainHP = mainHP - 1;
        mainslider.value = mainHP;
        if (mainHP == 0)
        {
            gameover.PlaySE3();
            bgm.StopBGM();
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        /*      if (other.gameObject.CompareTag("Eken")) {
                mainHP = mainHP - 1;
              Debug.Log(other.name);
            mainslider.value = mainHP;
          if(mainHP == 0){
            Destroy(this.gameObject);
         }
        }*/
        other.gameObject.GetComponent<EnemyHP>().attack();
        //other.gameObjectで全てのもの,その後に関数を獲得して、獲得した後に持って来たい関数を書く

        //script.attack();
    }
}
