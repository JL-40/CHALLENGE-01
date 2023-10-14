using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadingDots : MonoBehaviour
{
    TMP_Text loadingDots;

    string[] loadingDotsFrames = new string[3] {"Ooo", "oOo", "ooO" };

    bool animateLeftToRight = true;

    int frameIndex;

    [SerializeField] float animationSpeed;

    [SerializeField] bool isLooping;

    // Start is called before the first frame update
    void Start()
    {
        loadingDots = this.GetComponent<TMP_Text>();

        frameIndex = 1;

        loadingDots.text = loadingDotsFrames[frameIndex];

        StartCoroutine(AnimateLoadingDots());
    }

    IEnumerator AnimateLoadingDots()
    {
        while (isLooping == true)
        {
            if (frameIndex + 1 == 3)
            {
                animateLeftToRight = false;
            }
            else if (frameIndex - 1 == -1)
            {
                animateLeftToRight = true;
            }

            if (animateLeftToRight == true)
            {
                frameIndex++;
            }
            else
            {
                frameIndex--;
            }

            loadingDots.text = loadingDotsFrames[frameIndex];

            yield return new WaitForSeconds(animationSpeed);
        }
    }
}
