using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stop : MonoBehaviour
{
    public Text PauseText;
    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
            PauseText.gameObject.SetActive(false);
        }
        else
        {
            Time.timeScale = 0f;
            isPaused = true;

            // ESC 키 입력 시 Text UI를 활성화
            PauseText.gameObject.SetActive(true);
        }
    }
}
