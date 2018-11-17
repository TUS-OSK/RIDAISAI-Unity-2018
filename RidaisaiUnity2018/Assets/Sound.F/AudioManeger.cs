using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource se;
    public AudioSource gameclear;
    public AudioSource gameover;
    // Use this for initialization
    public void PlayBGM()
    {
        bgm.Play();
    }
    public void StopBGM()
    {
        bgm.Stop();
    }
    public void PlaySE()
    {
        se.PlayOneShot(se.clip);
        Debug.Log("attack!!");
    }
    public void PlaySE2()
    {
        gameclear.PlayOneShot(gameclear.clip);
        Debug.Log("Clear!!");
    }
    public void PlaySE3()
    {
        gameover.PlayOneShot(gameover.clip);
        Debug.Log("GameOver");
    }
}
