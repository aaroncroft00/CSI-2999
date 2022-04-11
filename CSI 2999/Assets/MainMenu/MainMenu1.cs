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
       StormMage currentScene = new StormMage();
       SceneManager.LoadScene(currentScene.activeScene);
       //resumes the game
       Time.timeScale = 0;
   }
}
