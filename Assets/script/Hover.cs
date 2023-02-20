using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hover : MonoBehaviour
{
    public TextMeshProUGUI TextoCubo;
    private Renderer renderer;


    void Start()
    {
        //TextoCubo = GetComponent<TextMeshProUGUI>();
        //TextoCubo.gameObject.SetActive(false);
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        switch (tag)
        {
            case "1-2":
                renderer.material.color = Color.red;
                TextoCubo.text = "1-2";
                TextoCubo.gameObject.SetActive(true);
                

                break;
            case "1-3":
                renderer.material.color = Color.red;
                break;
            case "1-4":
                renderer.material.color = Color.red;
                break;
            case "1-5":
                renderer.material.color = Color.red;
                break;
            case "1-8":
                renderer.material.color = Color.red;
                break;
            case "1-9":
                renderer.material.color = Color.red;
                break;
            case "2-5":
                renderer.material.color = Color.red;
                break;
            case "2-6":
                renderer.material.color = Color.red;
                break;
            case "2-8":
                renderer.material.color = Color.red;
                break;
            case "3-3":
                renderer.material.color = Color.red;
                break;
            case "3-8":
                renderer.material.color = Color.red;
                break;
            case "3-12":
                renderer.material.color = Color.red;
                break;
            case "4-5":
                renderer.material.color = Color.red;
                break;
            case "4-6":
                renderer.material.color = Color.red;
                break;
            case "4-7":
                renderer.material.color = Color.red;
                break;
            case "6-6":
                renderer.material.color = Color.red;
                break;
            case "6-8":
                renderer.material.color = Color.red;
                break;
            case "7-4":
                renderer.material.color = Color.red;
                break;
            case "7-10":
                renderer.material.color = Color.red;
                break;
            case "10-8":
                renderer.material.color = Color.red;
                break;
        }
    }

    void OnMouseExit()
    {
        switch (tag)
        {
            case "1-2":
                renderer.material.color = Color.white;
                TextoCubo.text = "1-2";
                TextoCubo.gameObject.SetActive(false);
                

                break;
            case "1-3":
                renderer.material.color = Color.white;
                break;
            case "1-4":
                renderer.material.color = Color.white;
                break;
            case "1-5":
                renderer.material.color = Color.white;
                break;
            case "1-8":
                renderer.material.color = Color.white;
                break;
            case "1-9":
                renderer.material.color = Color.white;
                break;
            case "2-5":
                renderer.material.color = Color.white;
                break;
            case "2-6":
                renderer.material.color = Color.white;
                break;
            case "2-8":
                renderer.material.color = Color.white;
                break;
            case "3-3":
                renderer.material.color = Color.white;
                break;
            case "3-8":
                renderer.material.color = Color.white;
                break;
            case "3-12":
                renderer.material.color = Color.white;
                break;
            case "4-5":
                renderer.material.color = Color.white;
                break;
            case "4-6":
                renderer.material.color = Color.white;
                break;
            case "4-7":
                renderer.material.color = Color.white;
                break;
            case "6-6":
                renderer.material.color = Color.white;
                break;
            case "6-8":
                renderer.material.color = Color.white;
                break;
            case "7-4":
                renderer.material.color = Color.white;
                break;
            case "7-10":
                renderer.material.color = Color.white;
                break;
            case "10-8":
                renderer.material.color = Color.white;
                break;
        }
    }
}
