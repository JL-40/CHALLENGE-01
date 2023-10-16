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

        if (PlayerPrefs.HasKey("CameraRotation_X") && PlayerPrefs.HasKey("CameraRotation_Y") && PlayerPrefs.HasKey("CameraRotation_Z") && PlayerPrefs.HasKey("CameraRotation_W"))
        {
            mainCamera.transform.rotation = new Quaternion(PlayerPrefs.GetFloat("CameraRotation_X"), PlayerPrefs.GetFloat("CameraRotation_Y"), PlayerPrefs.GetFloat("CameraRotation_Z"), PlayerPrefs.GetFloat("CameraRotation_W"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.Rotate(0f, 1f * speed * Time.deltaTime, 0f, Space.Self);

        SaveRotation();
    }

    void SaveRotation()
    {
        PlayerPrefs.SetFloat("CameraRotation_X", mainCamera.transform.rotation.x);
        PlayerPrefs.SetFloat("CameraRotation_Y", mainCamera.transform.rotation.y);
        PlayerPrefs.SetFloat("CameraRotation_Z", mainCamera.transform.rotation.z);
        PlayerPrefs.SetFloat("CameraRotation_W", mainCamera.transform.rotation.w);

        PlayerPrefs.Save();
    }
}
