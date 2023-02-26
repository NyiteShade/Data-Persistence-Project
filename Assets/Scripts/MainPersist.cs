using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MainPersist : MonoBehaviour
{
    public static MainPersist Instance;

    //public InputField NameInputField;


    // ui text game object
    public GameObject userNameBox;
     
    // Game variables
    public int highScore;
    public string userName;

    // Text Components
    TextMeshProUGUI userNameBoxText;

           
    
    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    

    private void Start()
    {
        if (MainPersist.Instance != null)
        {
            userNameBoxText = userNameBox.GetComponent<TextMeshProUGUI>();
            //userName = userNameBoxText.text;
            userName = "test";
        }
    }


    private void Update()
    {
        userName = userNameBoxText.text;


    }



    public void UserNameSubRoutine()
    {
        userName = userNameBoxText.text;


    }


}  
