using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSound : MonoBehaviour
{
    public AudioClip gameoverClip;
    private AudioSource backgroundAudio; // 사용할 오디오 소스 컴포넌트

    private bool isGameover = false;

    void Start()
    {
        backgroundAudio = GetComponent<AudioSource>();
        backgroundAudio.Play();
    }

    void Update()
    {
        if (!isGameover && GameManager.instance.isGameover)
        {
            isGameover = true;
            backgroundAudio.loop = false; // 루프 비활성화
            backgroundAudio.clip = gameoverClip;
            backgroundAudio.Play();
        }
    }
}
