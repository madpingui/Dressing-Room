using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public GameObject[] camisas;
    public GameObject[] pantalones;

    public void AceptarTelaCamisa(int i)
    {
        GameObject go = GameObject.FindGameObjectWithTag("Camisa");
        go.GetComponent<TelaManager>().escogerTela(i);
    }
    public void AceptarTelaPantalon(int i)
    {
        GameObject go = GameObject.FindGameObjectWithTag("Pantalon");
        go.GetComponent<TelaManager>().escogerTela(i);
    }

    public void CambiarPrendaCamisa(int i)
    {
        foreach (GameObject c in camisas)
        {
            c.SetActive(false);
        }
        camisas[i].SetActive(true);
    }
    public void CambiarPrendaPantalon(int i)
    {
        foreach (GameObject c in pantalones)
        {
            c.SetActive(false);
        }
        pantalones[i].SetActive(true);
    }

}
