using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popmonstre : MonoBehaviour
{

    public GameObject[] menuObject;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 4; i++)
        {
            if (!GlobalVariable.monstre[i])
            {
                menuObject[i].SetActive(true);
            }
            else
            {
                menuObject[i].SetActive(false);
            }
        }
    }

    
}
