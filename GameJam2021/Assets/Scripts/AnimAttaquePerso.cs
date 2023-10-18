using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimAttaquePerso : MonoBehaviour
{
    public Rigidbody2D perso;
    private Vector2 mouvement;
    private Vector2 deplacementPerso;

    public void deplacementAnim()
    {
        StartCoroutine(deplacementAnimation());
    }

    IEnumerator deplacementAnimation()
    {
        for (int i = 0; i < 15; i++)
        {
            transform.Translate(Vector2.right * 0.2f);
            yield return new WaitForSeconds(0.05f);
        }

        for (int i = 0; i < 15; i++)
        {
            transform.Translate(Vector2.left * 0.2f);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
