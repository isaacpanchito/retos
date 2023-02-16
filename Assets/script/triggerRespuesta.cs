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
            case "3-3":
            porcentaje+=1;
            break;
            case "1-8":
            porcentaje+=.125;
            break;
            case "3-5":
            porcentaje+=.6;
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
