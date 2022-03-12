using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateurMap : MonoBehaviour
{
    public GameObject plane;
    public int Longuer;

    
    // Start is called before the first frame update
    void Awake()
    {
        GameObject enCours;
        for(int i=0; i<Longuer;i++)
        {
            for (int j = 0; j < Longuer; j++)
            {
                enCours=Instantiate(plane, new Vector3(j, 0, i), Quaternion.identity);
                enCours.name = ("case" + i.ToString() +"  "+ j.ToString());
            }
        }
    }


}
