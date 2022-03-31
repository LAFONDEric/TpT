using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDistance : MonoBehaviour
{
    public RecherheDistance dep;
    //Sortie du tableau de deplacement
    public Case[] tabDeplacement;
    public bool lancer;

    //Coordonner de la ou on se trouve
    public int xa;
    public int ya;
    public int disatnce;
    // Update is called once per frame
    void Update()
    {
        //permet de tester les deplacement
        if (lancer)
        {
            lancer = false;
            tabDeplacement = dep.recherche(xa, ya, disatnce);
            gameObject.GetComponent<zonz>().apparaitre(tabDeplacement);
        }
    }
}
