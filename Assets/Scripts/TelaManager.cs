using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelaManager : MonoBehaviour {

    public Texture[] telas;

    public static TelaManager Instance { set; get; }

    void Start ()
    {
        Instance = this;
	}

    public void escogerTela(int index)
    {
        GetComponent<SkinnedMeshRenderer>().material.SetTexture("_MainTex", telas[index]);
    }
}
