using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
   public void quitButton()
   {
       Debug.Log("Quit");
   }

   public void openQuitScene()
   {
     SceneManager.LoadScene("Quit_Screen");  
   }

   public void resume()
   {
     SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
       //resumes the game
       Time.timeScale = 1;
   }
}
