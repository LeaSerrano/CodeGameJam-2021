using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D perso;
    private Vector2 mouvement;
    private Vector2 deplacementPerso;
    public float vitesse;

    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Grotte")
        {
            perso = GetComponent<Rigidbody2D>();
            perso.position = GameObject.Find("Spawn").GetComponent<Rigidbody2D>().position;
        }
        if (GlobalVariable.position != GetComponent<Rigidbody2D>().position)
        {
            perso = GetComponent<Rigidbody2D>();
            perso.position = GlobalVariable.position;
        }

        else
        {
            perso = GetComponent<Rigidbody2D>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        mouvement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;

        deplacementPerso = mouvement.normalized * vitesse;
        GlobalVariable.valeur++;
        

    }

    void FixedUpdate()
    {
        perso.MovePosition(perso.position + deplacementPerso * Time.fixedDeltaTime);
        GlobalVariable.position = perso.position;
    }
}
