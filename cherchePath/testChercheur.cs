using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testChercheur : MonoBehaviour
{
    public Pather path;
    //Sortie du tableau de deplacement
    public Case[] tabDeplacement;
    public bool lancer;

    //Case depart 
    public int depX;
    public int depY;

    //arriver
    public int arrX;
    public int arrY;

    // Update is called once per frame
    void Update()
    {
        //permet de tester les deplacement
        if (lancer)
        {
            lancer = false;
            tabDeplacement = path.recherche(depX, depY, arrX, arrY);
            gameObject.GetComponent<zonz>().apparaitre(tabDeplacement);
        }
    }
}
