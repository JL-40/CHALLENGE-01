using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panorama : MonoBehaviour
{
    Camera mainCamera;

    [SerializeField] float speed;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.Rotate(0f, 1f * speed * Time.deltaTime, 0f, Space.Self);
    }
}
