using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    public GameObject menuObject;
    public bool estActive = false;

    void Update()
    {

        if (estActive == true)
        {
            menuObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        else
        {
            menuObject.SetActive(false);
            Cursor.visible = false;
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            reprendre();
        }

    }

    public void reprendre()
    {
        estActive = !estActive;
    }
}