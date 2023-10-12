using UnityEngine;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour
{
    public float speed = 6f; // 이동 속도

    private void Update()
    {
        if (!GameManager.instance.isGameover)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}