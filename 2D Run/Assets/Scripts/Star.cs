using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public AudioClip scoreClip;

    private bool stepped = false; // 플레이어 캐릭터가 밟았었는가
    private AudioSource scoreAudio;

    private void Start()
    {
        // AudioSource 컴포넌트를 가진 게임 오브젝트의 참조를 가져옴
        scoreAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 플레이어 캐릭터가 자신을 밟았을때 점수를 추가하는 처리
        if (other.CompareTag("Player") && !stepped)
        {
            stepped = true;
            GameManager.instance.AddScore(1);

            scoreAudio.clip = scoreClip;
            scoreAudio.Play();

            if (gameObject != null) Destroy(gameObject, 0f);
        }
    }
}