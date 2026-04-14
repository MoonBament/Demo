using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginAndReginster : MonoBehaviour
{
    public InputField luser_id;
    public InputField luser_password;
    public InputField ruser_id;
    public InputField ruser_password;
    public GameObject reginster_panel;
    public GameObject error_text;

    string id;
    string password;

    // Start is called before the first frame update
    void Start()
    {
        luser_id = luser_id.GetComponent<InputField>();
        luser_password = luser_password.GetComponent<InputField>();
        ruser_id = ruser_id.GetComponent<InputField>();
        ruser_password = ruser_password.GetComponent<InputField>();
    }

    public void OpenReginsterPanel()
    {
        reginster_panel.SetActive(true);
    }

    public void ConfirmReginster()
    {
        id = ruser_id.text;
        password = ruser_password.text;
        ruser_id.text = "";
        ruser_password.text = "";
        reginster_panel.SetActive(false);
    }

    public void Login()
    {
        if (luser_id.text == id && luser_password.text == password)
        {
            print("Login Successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            print("Login Failure");
            error_text.SetActive(true);
            Invoke("DelayErrorText",3);
        }
        luser_id.text = "";
        luser_password.text = "";

    }

    public void DelayErrorText()
    {
        error_text.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
