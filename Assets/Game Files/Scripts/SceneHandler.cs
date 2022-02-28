using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject contineBtn;
    void Start()
    {
        string userl =  PlayerPrefs.GetString("userLevel");
        if (userl == null){
            contineBtn.SetActive(false);
            Debug.Log(userl);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame(){
       string userl =  PlayerPrefs.GetString("userLevel");
       switch(userl){
           case "Level 0":
           SceneManager.LoadScene("Level 1");
           break;
           case "Level 1":
           SceneManager.LoadScene("Level 2");
           break;
           case "Level 2":
           SceneManager.LoadScene("Level 3");
           break;
           case "Level 3":
           SceneManager.LoadScene("Level 4");
           break;
           case "Level 4":
           SceneManager.LoadScene("Level 5");
           break;
           case "Level 5":
           SceneManager.LoadScene("Level 6");
           break;
           case "Level 6":
           SceneManager.LoadScene("Level 7");
           break;
           case "Level 7":
           SceneManager.LoadScene("Level 8");
           break;
           case "Level 8":
           SceneManager.LoadScene("Level 9");
           break;
           case "Level 9":
           SceneManager.LoadScene("Level Ten");
           break;
           case "Level 10":
           SceneManager.LoadScene("Level elev");
           break;
           case "Level 11":
            SceneManager.LoadScene("Level elev");
            break;
           default:
            SceneManager.LoadScene("MainMenu");
           break;
       }
        SceneManager.LoadScene(userl);


       }
       
    
    public void NewGame(){
        SceneManager.LoadScene("Level 0");
    }
    public void shop(){

    }
}
