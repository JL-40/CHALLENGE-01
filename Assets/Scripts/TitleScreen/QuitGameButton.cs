using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QuitGameButton : MonoBehaviour
{
    public void QuitGame()
    {
        PlayerPrefs.DeleteAll();

#if UNITY_EDITOR

        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
