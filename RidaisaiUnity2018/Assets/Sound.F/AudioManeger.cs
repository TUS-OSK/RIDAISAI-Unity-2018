using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource se;
    public AudioSource gameclear;
    public AudioSource gameover;
    public AudioSource se4;
    public AudioSource titlebgm;
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
    public void PlaySE4()
    {
        se4.PlayOneShot(se4.clip);
        Debug.Log("やられた!!");
    }
    public void TitleBgmStart()
    {
        titlebgm.Play();
    }
    public void TitleBgmStop()
    {
        titlebgm.Stop();
    }

}