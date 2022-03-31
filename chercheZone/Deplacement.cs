using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deplacement : MonoBehaviour
{

    public Case[] deplacement(int Coordonerx,int Coordonery, int distanceMAx )
    {
       
        int mo = (distanceMAx * 2)* (distanceMAx * 2)+1;

       
        int lb = 0;

        List<Case> LisDeplacement = new List<Case>();
        // vallide le centre
        if(!GameObject.Find("case" + Coordonerx.ToString() + "  " + Coordonery.ToString())) { Debug.Log("la case existe pas"); return null; }
        LisDeplacement.Add(GameObject.Find("case" + Coordonerx.ToString() + "  " + Coordonery.ToString()).GetComponent<Case>());
        LisDeplacement[0].Niveau = distanceMAx;

        bool AucunChangement = false;
        // si il y'a eu un changement on doit tout faire repasser
        while (!AucunChangement)
        {
            AucunChangement = true;
            lb = 0;
            //On parcours Toute les case 
            for (int i = 0; i < LisDeplacement.Count; i++)
            {
                Case caseActive = LisDeplacement[i];
                Debug.Log("ee");
                // Valide les case adjacente a un point valide
                if (caseActive.CaseNord != null && caseActive.Niveau > 0)
                {
                    //On check si il ya le poids <niveau -poids
                    if (caseActive.CaseNord.GetComponent<Case>().Niveau < caseActive.Niveau - caseActive.CaseNord.GetComponent<Case>().poids)
                    {
                        caseActive.CaseNord.GetComponent<Case>().Niveau = caseActive.Niveau - caseActive.CaseNord.GetComponent<Case>().poids;
                        LisDeplacement.Add(caseActive.CaseNord.GetComponent<Case>());
                        AucunChangement = false;
                    }
                 
                }
                if (caseActive.CaseOuest != null && caseActive.Niveau > 0)
                {
                    if (caseActive.CaseOuest.GetComponent<Case>().Niveau < caseActive.Niveau - caseActive.CaseOuest.GetComponent<Case>().poids)
                    {
                        caseActive.CaseOuest.GetComponent<Case>().Niveau = caseActive.Niveau - caseActive.CaseOuest.GetComponent<Case>().poids;
                        LisDeplacement.Add(caseActive.CaseOuest.GetComponent<Case>());
                        AucunChangement = false;
                    }
                }
                if (caseActive.CaseSud != null && caseActive.Niveau > 0)
                {
                    if (caseActive.CaseSud.GetComponent<Case>().Niveau < caseActive.Niveau - caseActive.CaseSud.GetComponent<Case>().poids)
                    {
                        caseActive.CaseSud.GetComponent<Case>().Niveau = caseActive.Niveau - caseActive.CaseSud.GetComponent<Case>().poids;
                        LisDeplacement.Add(caseActive.CaseSud.GetComponent<Case>());
                        AucunChangement = false;
                    }
                }
                if (caseActive.CaseEst != null && caseActive.Niveau > 0)
                {
                    if (caseActive.CaseEst.GetComponent<Case>().Niveau < caseActive.Niveau - caseActive.CaseEst.GetComponent<Case>().poids)
                    {
                        caseActive.CaseEst.GetComponent<Case>().Niveau = caseActive.Niveau - caseActive.CaseEst.GetComponent<Case>().poids;
                        LisDeplacement.Add(caseActive.CaseEst.GetComponent<Case>());
                        AucunChangement = false;
                    }
                }
                
                lb++;
            }
        }

        Case[] tableauDeplacement = new Case[LisDeplacement.Count];

        // copie colle nos resultat valider dans un tableau qui ne contien que les valider et reset les autre
        int lo = 0;
        foreach (Case caseActive in LisDeplacement)
        {
            caseActive.Niveau = 0;
            tableauDeplacement[lo] = caseActive;
            lo++;
           
        }
        return tableauDeplacement;
    }

}
