using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStartBtn()
    {
        SceneManager.LoadScene("LV_Play2");
    }

    public void ClickExitBtn()
    {
        Debug.Log("게임종료");
#if UNITY_EDITOR
        // 에디터 상에서의 게임 종료
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // 빌드된 게임에서의 종료
         Application.Quit();
#endif
    }
}
