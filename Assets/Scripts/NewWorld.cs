using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NewWorld : MonoBehaviour
{
    [SerializeField] GameObject newWorldPrefab;
    [SerializeField] GameObject scrollViewContentObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateNewWorld(bool isServer = false)
    {
        GameObject newWorld = Instantiate(newWorldPrefab, scrollViewContentObject.transform);

        if (isServer == true)
        {
            newWorld.transform.SetSiblingIndex(scrollViewContentObject.transform.childCount - 2);
        }

        TMP_Text description = newWorld.transform.GetChild(2).GetComponent<TMP_Text>();

        description.text = $"{newWorld.name} ({DateTime.Now.ToString("yyyy-MM-dd hh:mm tt")})";
    }
}
