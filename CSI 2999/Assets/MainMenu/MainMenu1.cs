using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
   // StormMage currentScene = new StormMage();
    
   public void quitButton()
   {
       Application.Quit();

       Debug.Log("Quit");
   }


    //Once this works, add it to OnClick under Resume in Unity
   public void resume()
   {
       StormMage currentScene = new StormMage();
       SceneManager.LoadScene(currentScene.activeScene);
   }
}
