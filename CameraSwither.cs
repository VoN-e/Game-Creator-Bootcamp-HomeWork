using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    private List<Camera> cameras;

    void Start()
    {
        // Sahnedeki t�m Camera nesnelerini listeler
        cameras = new List<Camera>(FindObjectsOfType<Camera>());

        // Oyun ba�lad���nda listedeki ilk kameran�n aktif kamera olmas�n� sa�lar
        if (cameras.Count > 0)
        {
            ActivateCamera(cameras[0]);
        }
    }

    void Update()
    {
        // Klavyeden bir say� tu�una bas�ld���nda ilgili kameraya ge�i� yapar
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
        // Sadece aktif olan kameray� etkinle�tirir
        foreach (Camera cam in cameras)
        {
            cam.gameObject.SetActive(false);
        }
        activeCamera.gameObject.SetActive(true);
    }
}
