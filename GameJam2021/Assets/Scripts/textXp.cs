using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textXp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("AffichageXp").transform.localScale= new Vector3(0f, 0f, 0f); 
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Combat").GetComponent<Combat>().levelencour)
            GameObject.Find("AffichageXp").transform.localScale= new Vector3(400f, 400f, 0f);
    }
}
