using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionMonstre : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Perso")
        {
            int i = 0;
            while (i < 4)
            {
                if (GlobalVariable.monstre[i] == false)
                {
                    GlobalVariable.monstre[i] = !GlobalVariable.monstre[i];
                    GlobalVariable.map[i] = true;
                    i = 100;
                }

                i++;
            }
            SceneManager.LoadScene("Combat");
        }
    }  
}