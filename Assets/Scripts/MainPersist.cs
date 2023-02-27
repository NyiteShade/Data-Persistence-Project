using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class MainPersist : MonoBehaviour
{
    public static MainPersist Instance;
        
     
    // Game variables
    public int highScore;
    public string userName;
    public string userNameHighScore;
    
               
    
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
            
            
        }
   
    
    }


    private void Update()
    {

    }



    


}  
