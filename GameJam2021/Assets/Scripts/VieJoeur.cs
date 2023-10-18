using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VieJoeur : MonoBehaviour
{

    public Text vietexte;
    // Start is called before the first frame update
    void Start()
    {
        Vie();
    }

    public void Vie()
    {
        vietexte.text = "Vie : " + GlobalVariable.vie + "/" + GlobalVariable.vieM;
    }
}
