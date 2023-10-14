using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ForceUnicodeFont : MonoBehaviour
{
    bool forceUnicode = false;

    [SerializeField] TMP_FontAsset defaultFont;
    [SerializeField] TMP_FontAsset unicodeFont;
    [SerializeField] TMP_Text on_off_Text;

    public void ForceUnicode()
    {
        forceUnicode = !forceUnicode;
    }

    public void UpdateFont()
    {
        if (forceUnicode)
        {
            on_off_Text.text = "ON";
        }
        else
        {
            on_off_Text.text = "OFF";
        }
    }
}
