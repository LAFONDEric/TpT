using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pather : MonoBehaviour
{

    public Case[] recherche(int CoordonerDepartx, int CoordonerDeparty, int CoordonerArriverx, int CoordonerArrivery) 
    {
        Case depart = GameObject.Find("case" + CoordonerDepartx.ToString() + "  " + CoordonerDeparty.ToString()).GetComponent<Case>();
        Case arriver = GameObject.Find("case" + CoordonerArriverx.ToString() + "  " + CoordonerArrivery.ToString()).GetComponent<Case>();

        List<Case> LisDeplacement = new List<Case>();
        LisDeplacement.Add(depart);
        depart.Niveau = 1;
        depart.valider = true;
        int max = int.MaxValue;
        int l = 0;
        bool AucunChangement = false;
        // si il y'a eu un changement on doit tout faire repasser
        while (!AucunChangement && l<100)
        {
            AucunChangement = true;
       
            //On parcours Toute les case 
            for (int i = 0; i < LisDeplacement.Count; i++)
            {
                l++;
                Case caseActive = LisDeplacement[i];
   
                // Valide les case adjacente a un point valide
                if (caseActive.CaseNord != null )
                {
                    // on verifie si il est deja passer dans l'algo
                    if (caseActive.CaseNord.GetComponent<Case>().valider)
                    {
                        // si oui on cherche si le chemin est plus avanatgeux
                        if (caseActive.CaseNord.GetComponent<Case>().Niveau > caseActive.Niveau + caseActive.CaseNord.GetComponent<Case>().poids && caseActive.Niveau + caseActive.CaseNord.GetComponent<Case>().poids < max)
                        {
               
                            caseActive.CaseNord.GetComponent<Case>().Niveau = caseActive.Niveau + caseActive.CaseNord.GetComponent<Case>().poids;
                            LisDeplacement.Add(caseActive.CaseNord.GetComponent<Case>());
                            AucunChangement = false;
                        }
                    }
                    else
                    {
                        // si non ol le fait entre
                        if (caseActive.Niveau + caseActive.CaseNord.GetComponent<Case>().poids < max)
                        {
             
                            caseActive.CaseNord.GetComponent<Case>().valider = true;
                            caseActive.CaseNord.GetComponent<Case>().Niveau = caseActive.Niveau + caseActive.CaseNord.GetComponent<Case>().poids;
                            LisDeplacement.Add(caseActive.CaseNord.GetComponent<Case>());
                            AucunChangement = false;
                        }
                    }

                    if(LisDeplacement[LisDeplacement.Count -1] == arriver)
                    {
                        max = arriver.Niveau;
                    }

                }
                if (caseActive.CaseOuest != null )
                {
                    // on verifie si il est deja passer dans l'algo
                    if (caseActive.CaseOuest.GetComponent<Case>().valider)
                    {
                        // si oui on cherche si le chemin est plus avanatgeux
                        if (caseActive.CaseOuest.GetComponent<Case>().Niveau > caseActive.Niveau + caseActive.CaseOuest.GetComponent<Case>().poids && caseActive.Niveau + caseActive.CaseOuest.GetComponent<Case>().poids < max)
                        {
           
                            caseActive.CaseOuest.GetComponent<Case>().Niveau = caseActive.Niveau + caseActive.CaseOuest.GetComponent<Case>().poids;
                            LisDeplacement.Add(caseActive.CaseOuest.GetComponent<Case>());
                            AucunChangement = false;
                        }
                    }
                    else
                    {
                        // si non ol le fait entre
                        if (caseActive.Niveau + caseActive.CaseOuest.GetComponent<Case>().poids < max)
                        {
              
                            caseActive.CaseOuest.GetComponent<Case>().valider = true;
                            caseActive.CaseOuest.GetComponent<Case>().Niveau = caseActive.Niveau + caseActive.CaseOuest.GetComponent<Case>().poids;
                            LisDeplacement.Add(caseActive.CaseOuest.GetComponent<Case>());
                            AucunChangement = false;
                        }
                    }

                    if (LisDeplacement[LisDeplacement.Count - 1] == arriver)
                    {
                        max = arriver.Niveau;
                    }
                }
                if (caseActive.CaseSud != null )
                {
                    // on verifie si il est deja passer dans l'algo
                    if (caseActive.CaseSud.GetComponent<Case>().valider)
                    {
                        // si oui on cherche si le chemin est plus avanatgeux
                        if (caseActive.CaseSud.GetComponent<Case>().Niveau > caseActive.Niveau + caseActive.CaseSud.GetComponent<Case>().poids && caseActive.Niveau + caseActive.CaseSud.GetComponent<Case>().poids < max)
                        {
                 
                            caseActive.CaseSud.GetComponent<Case>().Niveau = caseActive.Niveau + caseActive.CaseSud.GetComponent<Case>().poids;
                            LisDeplacement.Add(caseActive.CaseSud.GetComponent<Case>());
                            AucunChangement = false;
                        }
                    }
                    else
                    {
                        // si non ol le fait entre
                        if (caseActive.Niveau + caseActive.CaseSud.GetComponent<Case>().poids < max)
                        {
         
                            caseActive.CaseSud.GetComponent<Case>().valider = true;
                            caseActive.CaseSud.GetComponent<Case>().Niveau = caseActive.Niveau + caseActive.CaseSud.GetComponent<Case>().poids;
                            LisDeplacement.Add(caseActive.CaseSud.GetComponent<Case>());
                            AucunChangement = false;
                        }
                    }


                    if (LisDeplacement[LisDeplacement.Count - 1] == arriver)
                    {
                        max = arriver.Niveau;
                    }
                }
                if (caseActive.CaseEst != null)
                {
                    // on verifie si il est deja passer dans l'algo
                    if (caseActive.CaseEst.GetComponent<Case>().valider)
                    {
                        // si oui on cherche si le chemin est plus avanatgeux
                        if (caseActive.CaseEst.GetComponent<Case>().Niveau > caseActive.Niveau + caseActive.CaseEst.GetComponent<Case>().poids && caseActive.Niveau + caseActive.CaseEst.GetComponent<Case>().poids < max)
                        {
                  
                            caseActive.CaseEst.GetComponent<Case>().Niveau = caseActive.Niveau + caseActive.CaseEst.GetComponent<Case>().poids;
                            LisDeplacement.Add(caseActive.CaseEst.GetComponent<Case>());
                            AucunChangement = false;
                        }
                    }
                    else
                    {
                        // si non ol le fait entre
                        if (caseActive.Niveau + caseActive.CaseEst.GetComponent<Case>().poids < max)
                        {
                    
                            caseActive.CaseEst.GetComponent<Case>().valider = true;
                            caseActive.CaseEst.GetComponent<Case>().Niveau = caseActive.Niveau + caseActive.CaseEst.GetComponent<Case>().poids;
                            LisDeplacement.Add(caseActive.CaseEst.GetComponent<Case>());
                            AucunChangement = false;
                        }
                    }


                    if (LisDeplacement[LisDeplacement.Count - 1] == arriver)
                    {
                        max = arriver.Niveau;
                    }
                }

                
            }
        }

        int dernier = max;
        if(max == int.MaxValue)
        {
            foreach(Case casse in LisDeplacement)
            {
                casse.valider = true;
                casse.Niveau = 0;
            }
            return null;
        }


        List<Case> parcours = new List<Case>();
        parcours.Add(arriver);
   
        while (dernier > 1 )
        {
            Case tempoUn;
            if (parcours[parcours.Count - 1].CaseNord != null && parcours[parcours.Count - 1].CaseSud != null)
            {
                tempoUn = CaseValid(parcours[parcours.Count - 1].CaseNord.GetComponent<Case>(), parcours[parcours.Count - 1].CaseSud.GetComponent<Case>());
            }
            else if(parcours[parcours.Count - 1].CaseNord != null)
            {
                tempoUn = parcours[parcours.Count - 1].CaseNord.GetComponent<Case>();
            }
            else if (parcours[parcours.Count - 1].CaseSud != null)
            {
                tempoUn = parcours[parcours.Count - 1].CaseSud.GetComponent<Case>();
            }
            else
            {
                tempoUn = null;
            }

            Case tempoDe;
            if (parcours[parcours.Count - 1].CaseEst !=null && parcours[parcours.Count - 1].CaseOuest != null)
            {
                tempoDe = CaseValid(parcours[parcours.Count - 1].CaseOuest.GetComponent<Case>(), parcours[parcours.Count - 1].CaseEst.GetComponent<Case>());
            }
            else if (parcours[parcours.Count - 1].CaseEst != null)
            {
                tempoDe = parcours[parcours.Count - 1].CaseEst.GetComponent<Case>();
            }
            else if (parcours[parcours.Count - 1].CaseOuest != null)
            {
                tempoDe = parcours[parcours.Count - 1].CaseOuest.GetComponent<Case>();
            }
            else
            {
                tempoDe = null;
            }
          

            tempoDe = CaseValid(tempoUn, tempoDe);
  
            if (tempoDe)
            {
                Debug.Log(dernier);
                parcours.Add(tempoDe);
                dernier = tempoDe.Niveau;
            }
            else
            {
                Debug.Log("aie");
                return null;
            }
        }
        foreach (Case casse in LisDeplacement)
        {
            casse.valider = true;
            casse.Niveau = 0;
        }
        Case[] rechercher = new Case[parcours.Count]; ;
        // copie colle nos resultat valider dans un tableau qui ne contien que les valider et reset les autre
        int lo = 0;
        foreach (Case caseActive in parcours)
        {
            rechercher[lo] = caseActive;
            lo++;
        }


        return rechercher;
    }

    private Case CaseValid(Case Un, Case De)
    {
        if (Un && De && Un.valider && De.valider)
        {
            if(Un.Niveau < De.Niveau)
            {
                return Un;
            }
            else
            {
                return De;
            }
        }
        else if(Un && Un.valider)
        {
            return Un;
        }
        else if (De && De.valider)
        {
            return De;
        }
        return null;
    }

  
}
