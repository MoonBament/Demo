using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setting : MonoBehaviour
{
    public GameObject setting;
    public AudioSource au;
    public Slider slider;
    public Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        au = au.GetComponent<AudioSource>();
        slider = slider.GetComponent<Slider>();
        toggle = toggle.GetComponent<Toggle >();
    }

    public void OpenSettingPanel()//打开设置页面
    {
        setting.SetActive(true);
    }

    public void CloseSettingPanel()//关闭设置页面
    {
        setting.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        au.volume = slider.value;
        au.mute = toggle.isOn;
    }
}
