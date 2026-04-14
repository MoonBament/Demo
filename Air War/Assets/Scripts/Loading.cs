using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider slider;
    public Text text;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        slider = slider.GetComponent<Slider>();
        text = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t>=5)
        {
            t = 5;
            slider.value = 1;
            Invoke("DelayTime", 1);
        }
        slider.value = t / 5;
        text.text = (int)(slider.value*100) + "%";
    }
    public void DelayTime()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}

