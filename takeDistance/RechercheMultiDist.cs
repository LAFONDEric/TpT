using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechercheMultiDist : MonoBehaviour
{
    private RecherheDistance Dist;
    // Start is called before the first frame update
    void Start()
    {
        Dist = FindObjectOfType<RecherheDistance>();
    }

    public Case[] recherche(int Coordonerx, int Coordonery, int distanceMin, int distanceMax)
    {
        List<Case> LisDeplacement = new List<Case>();

        for(int i = distanceMin;i<distanceMax;i++)
        {
            Case[] tempo = Dist.recherche(Coordonerx, Coordonery, i);
            foreach(Case casePres in tempo)
            {
                LisDeplacement.Add(casePres);
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
        return tableauDeplacement;
    }
}
