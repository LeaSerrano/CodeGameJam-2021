using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VieMonstre : MonoBehaviour
{

    public Text vietexte;
    // Start is called before the first frame update
    void Start()
    {
        Vie();
    }

    public void Vie()
    {
        vietexte.text = "Vie : " + GameObject.Find("Combat").GetComponent<Combat>().vie + "/" + GameObject.Find("Combat").GetComponent<Combat>().vieM;
    }
}
