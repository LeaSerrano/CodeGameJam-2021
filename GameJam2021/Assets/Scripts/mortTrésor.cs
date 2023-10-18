using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mortTrésor : MonoBehaviour
{

    // Update is called once per frame
    void Start()
    {
        //mettre un timing de 2sec
        StartCoroutine(time(2f));
        
    }
    IEnumerator time(float temps)
    {
        yield return new WaitForSeconds(temps);
        SceneManager.LoadScene("Plage");
    }
}
