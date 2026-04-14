using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider slider;
    private float hp = 100;
    GameObject canvas;
    public GameObject psenemy;
    public GameObject psplayer;
    public GameObject gameover;
    public Text score;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        slider = slider.GetComponent<Slider >();
        slider.maxValue = 100;
        slider.value = hp;
        canvas = GameObject.Find("Canvas2");
        score = score.GetComponent<Text>();
        text = text.GetComponent<Text>();
    }

    public void OnTriggerEnter(Collider o)
    {
        if (o.gameObject .tag =="Enemy")
        {
            Destroy(o.gameObject);//被撞销毁
            Instantiate(psenemy, o.gameObject.transform.position, Quaternion.identity);
            DamagePlayer(10);//撞到敌机减10血量
            canvas.GetComponent<GetScore>().Addscore(100);//自身撞到敌机加分
            //GetScore.score += 100;
        }
        if (o.gameObject .tag=="EnemyBullet")
        {
            Destroy(o.gameObject );//被撞销毁
            DamagePlayer(3);//撞到敌机减3血量
        }
    }

    public void DamagePlayer(float hit)//血量减少
    {
        hp -= hit;
        slider.value = hp;
        if (hp <= 0)
        {
            GameObject obj = Instantiate(psplayer);
            obj.transform.position = transform.position;
            gameover.SetActive(true);//结束画面显示
            score.text = text.text;//显示最终得分
            Destroy(this.gameObject);              
           
        }
        if (hp>100)
        {
            hp = 100;
        }

    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
