using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Combat : MonoBehaviour
{
    public int vie;
    public int vieM;
    public int force;
    public int rapidite;
    public int habilite;
    public int defense;
    public int exp=0;
    bool actionpers=false;
    
    public bool levelencour = false;

    public bool attacperso = false;
    public bool attacennemy = false;
    
    // Start is called before the first frame update
    void Start()
    {
        vie = 25 * GlobalVariable.intmap;
        vieM = 25 * GlobalVariable.intmap;
        force = 15 * GlobalVariable.intmap;
        rapidite = 5 * GlobalVariable.intmap;
        habilite = 5 * GlobalVariable.intmap;
        defense = 10 * GlobalVariable.intmap;
        exp = Random.Range(10 + GlobalVariable.intmap, 20 + GlobalVariable.intmap);
        affichagevie();
    }

    public void attaque() {
        print(actionpers);
        if (!GlobalVariable.mort && !actionpers && vie>0) {
            actionpers = true;
            print(actionpers);
            // si perso +rapide que monstre
            if (GlobalVariable.rapidite >= rapidite) {
                // attaque perso

                mouvementperso();
                if (GlobalVariable.force - defense > 0) // si force plus grande que defense
                    vie -= GlobalVariable.force - defense;

                // attaque monstre
                if (vie > 0) {

                    mouvementmon();
                    if (force - GlobalVariable.defense > 0) { // si force plus grande que defense
                        GlobalVariable.vie -= force - GlobalVariable.defense;
                            
                    }
                }
            }
                // si monstre plus rapide 
            else {

                mouvementmon();
                // attaque monstre
                if (force - GlobalVariable.defense > 0) {  // si force plus grande que defense
                    GlobalVariable.vie -= force - GlobalVariable.defense;
                    
                }

                // si personnage toujours en vie il attaque 
                if (GlobalVariable.vie > 0) {

                    mouvementperso();
                    if (GlobalVariable.force - defense > 0) { // si force plus grande que defense
                        vie -= GlobalVariable.force - defense;
                    }
                }
            }

            if (vie > 0)
                combatG();


        }
    }

   


    //void Magie() { }
    // a voir si le temps

    void verification() {

        if (vie <= 0){ // si montre mort et si pas d�j� en cours

            vie = 0;
            GlobalVariable.exp += exp;
            lvl();
            if (GameObject.Find("Mimic").tag == "BOSS")
                SceneManager.LoadScene("win");
           // GlobalVariable.map[GlobalVariable.nbTresorMort] = true;
            GlobalVariable.nbTresorMort++;
            

        }



        if (!GlobalVariable.mort && vie > 0) // le combat continue si monstre et joueur en vie
            combatG();
    }

    public void fuite() {

        if (!actionpers && !GlobalVariable.mort) { // si aucune action en cours
            actionpers = true;
            int a = Random.Range(0, GlobalVariable.habilite * 2);
            if (a <= habilite) { // fuite rat� si a inf�rieur a l'habilit� du monstre
               mouvementmon();
                // attaque du monstre
                if (force - GlobalVariable.defense > 0){  // si force plus grande que defense
                    GlobalVariable.vie -= force - GlobalVariable.defense;
                    
                }
                StartCoroutine(time(3.2f));
            }

            else {  // fuite r�ussie si a inf�rieur a l'habilit� du monstre
                vie = 0;
                SceneManager.LoadScene("Plage");

            }
            
        }
    }

    void lvl() { // monter un niveau actualisation des stats en fonction de sa classe 
    


        if (GlobalVariable.exp >= 10 * (GlobalVariable.level / 5) && !levelencour ){ // si assez exp est si levelup non en cour

            GlobalVariable.vie += 5;
            GlobalVariable.vieM += 5;
            GlobalVariable.force += 4;
            GlobalVariable.defense += 3;
            GlobalVariable.rapidite += 1;
            GlobalVariable.habilite += 1;
            GlobalVariable.exp -= 10 * (GlobalVariable.level / 5);
            GlobalVariable.level += 1;
        }
        levelencour = true;
        StartCoroutine(timeLevel(1f));

    }
    


    void affichagevie()
    {
        GameObject.Find("ViePerso").GetComponent<VieJoeur>().Vie();
        GameObject.Find("VieMonstre").GetComponent<VieMonstre>().Vie();
    }

    

    void combatG()
    {
        StartCoroutine(time(3.2f));
    }

    IEnumerator time(float time)
    {
        
        yield return new WaitForSeconds(time);
        
        actionpers = false;
        verification();
        affichagevie();
        if(GlobalVariable.vie <= 0)
            SceneManager.LoadScene("gameover");
    }
    
    IEnumerator timeLevel(float time)
    {
        print("attendre");
        yield return new WaitForSeconds(time);

        levelencour = false;
        
        SceneManager.LoadScene("MortTresor");
    }

    void mouvementmon()
    {
        GameObject.Find("Mimic").GetComponent<AnimAttaqueMonstre>().deplacementAnim();
        
    }

    


    void mouvementperso()
    {
        GameObject.Find("Perso").GetComponent<AnimAttaquePerso>().deplacementAnim();
    }
    

    public void soin()
    {
        if (!actionpers)
        {
            actionpers = true;
            GlobalVariable.vie += 10 * GlobalVariable.level;
            if (GlobalVariable.vie > GlobalVariable.vieM)
                GlobalVariable.vie = GlobalVariable.vieM;
            mouvementmon();
            // attaque du monstre
            if (force - GlobalVariable.defense > 0)  // si force plus grande que defense
                GlobalVariable.vie -= force - GlobalVariable.defense;
            
            StartCoroutine(time(3.2f));
        }
    }



}
