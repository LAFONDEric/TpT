using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{
    //Difficulter a marcher sur la case
    public int poids;

    public int Niveau;
    [HideInInspector]
    public bool valider;
    [HideInInspector]
    public GameObject CaseNord;
    [HideInInspector]
    public GameObject CaseSud;
    [HideInInspector]
    public GameObject CaseEst;
    [HideInInspector]
    public GameObject CaseOuest;

}
