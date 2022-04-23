using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RotarModeloIzquierda : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
     public GameObject maniqui;
    private bool _rotate;

    void Update()
    {
        if (_rotate)
        {
            maniqui.transform.Rotate(new Vector3(0, -2, 0));
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _rotate = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _rotate = false;
    }

}
