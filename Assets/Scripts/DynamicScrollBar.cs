using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicScrollBar : MonoBehaviour
{
    [SerializeField] ScrollRect scrollRect;
    [SerializeField] Scrollbar scrollBar;

    int maxViewableWorlds = 4;
    int worldCount;

    // Start is called before the first frame update
    void Start()
    {
        worldCount = 0;
        scrollRect.vertical = false;
    }

    // Update is called once per frame
    void Update()
    {
        worldCount = scrollRect.content.childCount;

        if (worldCount < maxViewableWorlds)
        {
            return;
        }

        scrollRect.vertical = true;
        // scrollBar.size -= 
    }

    public int WorldCount { get { return worldCount; } set { worldCount = value; } }
}
