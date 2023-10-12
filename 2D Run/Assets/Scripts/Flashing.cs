using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Flashing : MonoBehaviour
{
    public float flashingDuration = 3f;

    private Text textComponent;
    private float flashingTimer;
    private bool isFlashing;

    private void Start()
    {
        textComponent = GetComponent<Text>();

        // 타이머 초기화
        flashingTimer = flashingDuration;

        isFlashing = true;

        // 플래시 효과 코루틴 호출
        StartCoroutine(FlashText());
    }

    // 플래시 효과 코루틴 (0.3초 대기)
    private IEnumerator FlashText()
    {
        while (isFlashing)
        {
            textComponent.enabled = !textComponent.enabled;
            yield return new WaitForSeconds(0.3f);
        }
    }

    private void Update()
    {
        flashingTimer -= Time.deltaTime;
        if (flashingTimer <= 0)
        {
            isFlashing = false;
        }
    }
}
