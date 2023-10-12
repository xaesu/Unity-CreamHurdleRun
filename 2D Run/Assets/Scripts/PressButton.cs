using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressButton : MonoBehaviour
{
    public string targetSceneName; // 이동할 씬의 이름

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
