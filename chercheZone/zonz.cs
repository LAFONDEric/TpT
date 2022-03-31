using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonz : MonoBehaviour
{



    public Material un;
    public Material de;
    public void apparaitre(Case[] tableauDeplacement)
    {
        int lb = 0;
        if (tableauDeplacement != null)
        {
            while (lb < tableauDeplacement.Length && tableauDeplacement[lb] != null)
            {
                tableauDeplacement[lb].GetComponent<MeshRenderer>().material = de;
                lb++;

            }
        }
    }

    public void disparaitre(Case[] tableauDeplacement)
    {
        int lb = 0;

        while (lb < 0 && tableauDeplacement[lb] == null)
        {
            tableauDeplacement[lb].GetComponent<MeshRenderer>().material = un;
            lb++;
        }
    }
}
