using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainHPBer : MonoBehaviour
{
    public GameObject GoalUI;
    public GameObject ThankUI;

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
        if (Input.GetKey(KeyCode.Y))
        {
            SceneManager.LoadScene("Stage3");
        }
        else if (Input.GetKey(KeyCode.N))
        {
            StartCoroutine("Thank");
        }
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
        if (other.gameObject.CompareTag("Eken"))
        {
            /*      if (other.gameObject.CompareTag("Eken")) {
                    mainHP = mainHP - 1;
                  Debug.Log(other.name);
                mainslider.value = mainHP;
              if(mainHP == 0){
                Destroy(this.gameObject);
             }
            }*/
            Debug.Log(this.transform.name + " to " + other.transform.name);
            other.gameObject.GetComponent<EnemyHP>().attack();
            //other.gameObjectで全てのもの,その後に関数を獲得して、獲得した後に持って来たい関数を書く

            //script.attack();
        }
        if(other.gameObject.CompareTag("Plyer")){
            GoalUI.SetActive(true);
        }
       
    }

    IEnumerator Thank()
    {
        ThankUI.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Start");
        yield return null;
    }
}