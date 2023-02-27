using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;






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

        //LoadPlayerData();

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


    [System.Serializable]
    class SaveData
    {
        public int dhighScore;
        public string duserNameHighScore;

    }

        public void SavePlayerData()
        {
            SaveData data = new SaveData();
            data.dhighScore = MainPersist.Instance.highScore;
            data.duserNameHighScore = MainPersist.Instance.userNameHighScore;

            string json = JsonUtility.ToJson(data);

            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

            
        }

        public void LoadPlayerData()
        {
            string path = Application.persistentDataPath + "/savefile.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                SaveData data = JsonUtility.FromJson<SaveData>(json);

                MainPersist.Instance.highScore = data.dhighScore;
                MainPersist.Instance.userNameHighScore = data.duserNameHighScore;

            }
        }

    


}  
