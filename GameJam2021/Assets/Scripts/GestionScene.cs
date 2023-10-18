using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
    public void passerAuJeu()
    {
        SceneManager.LoadScene("Plage");
    }

    public void sceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void sceneInventaire()
    {
        SceneManager.LoadScene("Inventaire");
    }

    public void finJeu()
    {
        SceneManager.LoadScene("FinJeu");

    }

    public void fermeAppli()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene("Inventaire");
        }
        Cursor.lockState = CursorLockMode.Confined;
    }
}
