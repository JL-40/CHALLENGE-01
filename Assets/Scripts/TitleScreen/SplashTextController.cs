using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class SplashTextController : MonoBehaviour
{
    [SerializeField] TextAsset splashTextFile;

    TMP_Text splashText;

    // Start is called before the first frame update
    void Start()
    {
        splashText = GetComponent<TMP_Text>();

        if (PlayerPrefs.HasKey("SplashText") == true)
        {
            splashText.text = PlayerPrefs.GetString("SplashText");

            return;
        }


        if (splashTextFile != null)
        {
            string[] lines = splashTextFile.text.Split('\n');

            int option = Random.Range(0, lines.Length);

            splashText.text = lines[option];

            PlayerPrefs.SetString("SplashText", splashText.text);
            PlayerPrefs.Save();
        }
    } 
}
