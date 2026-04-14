using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public Text text;
    int score = 0;
    //public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        text = text.GetComponent<Text>();
        text.text = "Score:0";
    }
    public void Addscore(int num)//显示目前得分情况
    {
        score += num;
        text.text = "Score:" + score;
    }
  
    // Update is called once per frame
    void Update()
    {
        //text.text = ("Score:" + score);
    }

   

}
