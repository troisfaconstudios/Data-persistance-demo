using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public static StartMenu Instance;
    public string userName;
    
    public TMP_InputField inputField;
    // Start is called before the first frame update



    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    void Start()
    {
        inputField = GameObject.FindGameObjectWithTag("NameField").GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SaveName()
    {
        SetUserInfo(inputField.text);
        SceneManager.LoadScene(1);
    }

    public void SetUserInfo(string name)
    {
        StartMenu.Instance.userName = name;
    }


}
