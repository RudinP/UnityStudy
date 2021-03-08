using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer;
    public Color touchColor;
    private Color originalColor;
    public bool check=false;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;

    }

    


    void OntriggerEnter(Collider other) {
        if (other.tag == "Goal") myRenderer.material.color = touchColor;
    }
    void OnTriggerExit(Collider other)
    {
        myRenderer.material.color = originalColor;
        check = false;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Goal")
        {
            myRenderer.material.color = touchColor;
            check = true;
        }
    }
}
