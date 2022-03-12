using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    
    public int  Taille;
    private GameObject[,] Case;
    // Start is called before the first frame update
    void Start()
    {
        Case = new GameObject[Taille, Taille];
        for (int i = 0; i < Taille; i++)
        {
            for (int j = 0; j < Taille; j++)
            {
                if(GameObject.Find("case" + i.ToString() + "  " + j.ToString()))
                {
                    Case[i, j] = GameObject.Find("case" + i.ToString() + "  " + j.ToString());
                }
                else
                {
                    Case[i, j] = null;
                }
              
            }
        }
        for (int i = 1; i < Taille-1; i++)
        {
            for (int j = 1; j < Taille -1; j++)
            {
                if(Case[i, j])
                {
                    if (Case[i + 1, j] != null)
                    {
                        Case[i, j].GetComponent<Case>().CaseNord = Case[i + 1, j];
                    }
                    if (Case[i - 1, j] != null)
                    {
                        Case[i, j].GetComponent<Case>().CaseSud = Case[i - 1, j];
                    }
                    if (Case[i, j + 1] != null)
                    {
                        Case[i, j].GetComponent<Case>().CaseEst = Case[i, j + 1];
                    }
                    if (Case[i, j - 1] != null)
                    {
                        Case[i, j].GetComponent<Case>().CaseOuest = Case[i, j - 1];
                    }
                }
              
            }
        }
    }
    public GameObject getCase(int x,int y)
    {
        return Case[x, y];
    }


}
