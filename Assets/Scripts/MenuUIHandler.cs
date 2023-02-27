using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField myInputField;



    private void Start()
    {
        MainPersist.Instance.LoadPlayerData();

    }

    public void StartNew()
    {
        MainPersist.Instance.userName = myInputField.text;
        MainPersist.Instance.LoadPlayerData();
        SceneManager.LoadScene(1);
    }


    public void Exit()
    {
        MainPersist.Instance.SavePlayerData();

#if UNITY_EDITOR


        EditorApplication.ExitPlaymode();
        
#else
        
        
        Application.Quit(); // original code to quit Unity player



#endif
    }
}
