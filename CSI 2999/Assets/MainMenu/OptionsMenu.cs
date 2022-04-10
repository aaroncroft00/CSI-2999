using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{

    //Put under SettingsMenu once it works
    //Put as ClickOn function under Fullscreen Toggle
    public void setFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = !Screen.fullScreen;
    }


}