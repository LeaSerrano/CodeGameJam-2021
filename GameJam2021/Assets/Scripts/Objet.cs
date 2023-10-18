using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Objet : MonoBehaviour
{
    public string nom;
    public Text nomtexte;
    public string type="map";
    public Image image;
    public Image[] objet;

   /* Objet(string n, string type, Image i)
    {
        nom = n;
        this.type = type;
        image = i;
    }*/


    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            if (GlobalVariable.map[i])
            {
                objet[i].enabled = true;
            }
            else
            {
                objet[i].enabled=false;
            }
        }

    }


}
