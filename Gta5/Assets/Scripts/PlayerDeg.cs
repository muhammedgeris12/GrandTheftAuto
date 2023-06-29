using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeg : MonoBehaviour
{
    public GameObject franklin,trevor,micheal,micO,fraO,treO;
    public GameObject panel;

    public bool isPanelActive = false; // Panelin durumu

    void Start()
    {
        panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {
            isPanelActive = !isPanelActive; // Panelin durumunu deðiþtir (aktifse pasif, pasifse aktif)
            panel.SetActive(isPanelActive); // Panelin durumuna göre aktif veya pasif hale getir
        }
        if (isPanelActive==false)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;

        }
    }
    public void Trevor()
    {
        trevor.SetActive(true);
        treO.SetActive(true);

        micheal.SetActive(false);
        micO.SetActive(false);

        franklin.SetActive(false);
        fraO.SetActive(false);
    }
    public void Franklin()
    {
        franklin.SetActive(true);
        fraO.SetActive(true);

        trevor.SetActive(false);
        treO.SetActive(false);

        micheal.SetActive(false);
        micO.SetActive(false);
    }
    public void Mike()
    {
        micheal.SetActive(true);
        micO.SetActive(true);

        trevor.SetActive(false);
        treO.SetActive(false);

        franklin.SetActive(false);
        fraO.SetActive(false);
    }
}
