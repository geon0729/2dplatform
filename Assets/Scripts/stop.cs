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

            // ESC Ű �Է� �� Text UI�� Ȱ��ȭ
            PauseText.gameObject.SetActive(true);
        }
    }
}
