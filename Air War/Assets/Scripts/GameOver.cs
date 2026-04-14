using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameover;
    public Button restart;
    
    // Start is called before the first frame update
    void Start()
    {
        restart = restart.GetComponent<Button>();
        
    }
    public void Restart()//点击Restart后跳转至加载页面
    {
        gameover.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
