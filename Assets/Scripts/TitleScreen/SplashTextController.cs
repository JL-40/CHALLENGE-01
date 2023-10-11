using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SplashTextController : MonoBehaviour
{
    [SerializeField] TextAsset splashTextFile;

    TMP_Text splashText;

    // Start is called before the first frame update
    void Start()
    {
        splashText = GetComponent<TMP_Text>();


        if (splashTextFile != null)
        {
            string[] lines = splashTextFile.text.Split('\n');

            int option = Random.Range(0, lines.Length);

            splashText.text = lines[option];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
