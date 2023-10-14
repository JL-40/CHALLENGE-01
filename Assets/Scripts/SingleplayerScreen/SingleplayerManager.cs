using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleplayerManager : MonoBehaviour
{
    public static SingleplayerManager Instance;

    [SerializeField] List<Button> worldButtons;
    [SerializeField] List<GameObject> worldSaves;
    [SerializeField] ScrollRect scrollView;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetInteractable(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (worldSaves.Count <= 0)
        {
            return;
        }

        foreach (GameObject worldSave in worldSaves)
        {
            Button worldSaveButton = worldSave.GetComponent<Button>();

            if (worldSaveButton.image.IsActive() == true)
            {
                SetInteractable(true);
            }
        }
    }

    void SetInteractable(bool isInteractable)
    {
        foreach (Button worldButtonOption in worldButtons)
        {
            worldButtonOption.interactable = isInteractable;
        }
    }

    public void AddWorldSave(GameObject newWorldSave)
    {
        worldSaves.Add(newWorldSave);
    }

    public void DeleteWorldSave(GameObject worldSaveToDelete)
    {

    }
}
