using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCall : MonoBehaviour
{
    public void attaque()
    {
        GameObject.Find("Combat").GetComponent<Combat>().attaque();
    }

    public void fuir()
    {
        GameObject.Find("Combat").GetComponent<Combat>().fuite();
    }

    public void soin()
    {
        GameObject.Find("Combat").GetComponent<Combat>().soin();
    }
}
