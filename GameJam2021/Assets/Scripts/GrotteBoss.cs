using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrotteBoss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            GlobalVariable.intmap++;
            SceneManager.LoadScene("CombatBoss");
        }
    }
}
