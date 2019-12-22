using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartChangeScene : MonoBehaviour {
    
    Slider _slider;
    float hp = 0;
    public GameObject Slider;

	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Return)){
            Debug.Log("Enter入力");

            StartCoroutine("WaitScene");
        }
	}

    IEnumerator WaitScene()
    {
        yield return new WaitForSeconds(1.0f);
        Slider.SetActive(true);
        _slider = GameObject.Find("Slider").GetComponent<Slider>();

        while (hp < 1)
        {
            hp += 0.005f;
            _slider.value = hp;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Stage3");
        yield return null;
    }
}
