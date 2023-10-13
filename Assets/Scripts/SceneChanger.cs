using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public void ToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }

    public void ToSingleplayer()
    {
        SceneManager.LoadScene("Singleplayer", LoadSceneMode.Single);
    }

    public void ToMultiplayer()
    {
        SceneManager.LoadScene("Multiplayer", LoadSceneMode.Single);
    }

    public void ToMinecraftRealms()
    {
        SceneManager.LoadScene("MinecraftRealms", LoadSceneMode.Single);
    }

    public void ToLanguages()
    {
        SceneManager.LoadScene("Languages", LoadSceneMode.Single);
    }

    public void ToOptions()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }

    public void ToAccessibility()
    {
        SceneManager.LoadScene("Accessibility", LoadSceneMode.Single);
    }
}
