using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerRespuesta : MonoBehaviour
{
    public Text porc;
    public double Meta=3;
    public double porcentaje;

    private void OnTriggerEnter (Collider other){
        Debug.Log("colicion");

        switch(other.tag){
            case "1-2":
            porcentaje+=.5;
            Debug.Log("1-2");
            break;
            case "1-3":
            porcentaje+=.333;
            break;
            case "1-4":
            porcentaje+=.25;
            break;
            case "1-5":
            porcentaje+=.2;
            break;
            case "1-8":
            porcentaje+=.125;
            break;
            case "1-9":
            porcentaje+=.111;
            break;
            case "2-5":
            porcentaje+=.4;
            break;
            case "2-6":
            porcentaje+=.333;
            break;
            case "2-8":
            porcentaje+=.25;
            break;
            case "3-3":
            porcentaje+=1;
            break;
            case "3-8":
            porcentaje+=.375;
            break;
            case "3-12":
            porcentaje+=.25;
            break;
            case "4-5":
            porcentaje+=.8;
            break;
            case "4-6":
            porcentaje+=.666;
            break;
            case "4-7":
            porcentaje+=.57;
            break;
            case "6-6":
            porcentaje+=1;
            break;
            case "6-8":
            porcentaje+=.75;
            break;
            case "7-4":
            porcentaje+=1.75;
            break;
            case "7-10":
            porcentaje+=.7;
            break;
            case "10-8":
            porcentaje+=1.25;
            break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {  
      
    }

    // Update is called once per frame
    void Update()
    {
    if(porcentaje>Meta){
            porc.text="Te pasaste";
    }
    else if(porcentaje>=1.9){
        porc.text="Listo";
    }
    else{
            porc.text=porcentaje.ToString()+"/"+Meta.ToString(); 
        }
    }
}
