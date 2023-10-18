using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariable : MonoBehaviour
{
    static public double valeur = 0;
    static public int vie = 30;
    static public int vieM = 30;
    static public int force = 15;
    static public int defense = 10;
    static public int rapidite = 10;
    static public int habilite = 5;
    static public int pm = 0;
    static public int pmM = 0;
    static public int puissanceM = 0;
    static public string[] sort = { };
    static public int level = 1;
    static public int exp = 0;

    static public int intmap=1;
    static public bool mort=false;
    static public int nbTresorMort = 0;
    static public bool[] map= { false, false, false, false };
    static public string[,] inventaire2;

    static public Vector2 position;

    static public bool[] monstre = { false, false, false, false };
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
