using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    private List<Camera> cameras;

    void Start()
    {
        // Sahnedeki tüm Camera nesnelerini listeler
        cameras = new List<Camera>(FindObjectsOfType<Camera>());

        // Oyun baþladýðýnda listedeki ilk kameranýn aktif kamera olmasýný saðlar
        if (cameras.Count > 0)
        {
            ActivateCamera(cameras[0]);
        }
    }

    void Update()
    {
        // Klavyeden bir sayý tuþuna basýldýðýnda ilgili kameraya geçiþ yapar
        for (int i = 0; i < cameras.Count && i < 10; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                ActivateCamera(cameras[i]);
            }
        }
    }

    void ActivateCamera(Camera activeCamera)
    {
        // Sadece aktif olan kamerayý etkinleþtirir
        foreach (Camera cam in cameras)
        {
            cam.gameObject.SetActive(false);
        }
        activeCamera.gameObject.SetActive(true);
    }
}
