using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testeur : MonoBehaviour
{
  
    public Deplacement dep;
    //Sortie du tableau de deplacement
    public Case[] tabDeplacement;
    public bool lancer;

    //Coordonner de la ou on se trouve
    public int xa;
    public int ya;
    public int depMax;
    // Update is called once per frame
    void Update()
    {
        //permet de tester les deplacement
        if (lancer)
        {
            lancer = false;
            tabDeplacement = dep.deplacement(xa, ya, depMax);
            gameObject.GetComponent<zonz>().apparaitre(tabDeplacement);
        }
    }
}
