using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecherheDistance : MonoBehaviour
{
    public Case[] recherche(int Coordonerx, int Coordonery, int distance)
    {

        List<Case> LisDeplacement = new List<Case>();
       

        for(int i = 0; i< distance ; i++)
        {
            if(GameObject.Find("case" + (Coordonerx + distance - i).ToString() + "  " + (Coordonery + i).ToString()))
            {
                LisDeplacement.Add(GameObject.Find("case" + (Coordonerx + distance - i).ToString() + "  " + (Coordonery + i).ToString()).GetComponent<Case>());
            }
        }
        for (int i = 0; i < distance; i++)
        {
            if (GameObject.Find("case" + (Coordonerx - distance + i).ToString() + "  " + (Coordonery - i).ToString()))
            {
                LisDeplacement.Add(GameObject.Find("case" + (Coordonerx - distance + i).ToString() + "  " + (Coordonery - i).ToString()).GetComponent<Case>());
            }
        }

        for (int i = 0; i < distance; i++)
        {
            if (GameObject.Find("case" + (Coordonerx - i).ToString() + "  " + (Coordonery + distance - i).ToString()))
            {
                LisDeplacement.Add(GameObject.Find("case" + (Coordonerx - i).ToString() + "  " + (Coordonery + distance - i).ToString()).GetComponent<Case>());
            }
        }
        for (int i = 0; i < distance; i++)
        {
            if (GameObject.Find("case" + (Coordonerx + i).ToString() + "  " + (Coordonery - distance + i).ToString()))
            {
                LisDeplacement.Add(GameObject.Find("case" + (Coordonerx + i).ToString() + "  " + (Coordonery - distance + i).ToString()).GetComponent<Case>());
            }
        }

        Case[] tableauDeplacement = new Case[LisDeplacement.Count];

        // copie colle nos resultat valider dans un tableau qui ne contien que les valider et reset les autre
        int lo = 0;
        foreach (Case caseActive in LisDeplacement)
        {

            tableauDeplacement[lo] = caseActive;
            lo++;

        }
     //   tab[0] = GameObject.Find("case" + (Coordonerx + distance).ToString() + "  " + Coordonery.ToString()).GetComponent<Case>().GetComponent<Case>();
  //      tab[1] = GameObject.Find("case" + (Coordonerx - distance).ToString() + "  " + Coordonery.ToString()).GetComponent<Case>().GetComponent<Case>();
    //    tab[2] = GameObject.Find("case" + Coordonerx.ToString() + "  " + (Coordonery + distance).ToString()).GetComponent<Case>().GetComponent<Case>();
   //     tab[3] = GameObject.Find("case" + Coordonerx.ToString() + "  " + (Coordonery - distance).ToString()).GetComponent<Case>().GetComponent<Case>();
        return tableauDeplacement;
    }
}
