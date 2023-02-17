using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class triggerRespuesta : MonoBehaviour
{
    public Text porc;
    public double Meta=3;
    public double porcentaje;

    public GameObject bien;
    public GameObject mal;

    public GameObject robot;
    public Vector3 temp;
    public Image health;

    float test = 0f;

    public fracSelection FracSelection;

    private void OnTriggerEnter (Collider other){
        Debug.Log("colicion");

        FracSelection.pos.SetActive(false);

        switch (other.tag){
            case "1-2":
            porcentaje+=.5;
                temp = new Vector3(100, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.25f, 0, 1f);
                Debug.Log("1-2");
            break;
            case "1-3":
            porcentaje+=.333;
                temp = new Vector3(66, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.166f, 0, 1f);
                break;
            case "1-4":
            porcentaje+=.25;
                temp = new Vector3(50, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.125f, 0, 1f);
                break;
            case "1-5":
            porcentaje+=.2;
                temp = new Vector3(40, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.1f, 0, 1f);
                break;
            case "1-8":
            porcentaje+=.125;
                temp = new Vector3(25, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.06f, 0, 1f);
                break;
            case "1-9":
            porcentaje+=.111;
                temp = new Vector3(22, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.05f, 0, 1f);
                break;
            case "2-5":
            porcentaje+=.4;
                temp = new Vector3(80, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.2f, 0, 1f);
                break;
            case "2-6":
            porcentaje+=.333;
                temp = new Vector3(66, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.16f, 0, 1f);
                break;
            case "2-8":
            porcentaje+=.25;
                temp = new Vector3(50, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.125f, 0, 1f);
                break;
            case "3-3":
            porcentaje+=1;
                temp = new Vector3(200, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.5f, 0, 1f);
                break;
            case "3-8":
            porcentaje+=.375;
                temp = new Vector3(75, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.187f, 0, 1f);
                break;
            case "3-12":
            porcentaje+=.25;
                temp = new Vector3(50, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.125f, 0, 1f);
                break;
            case "4-5":
            porcentaje+=.8;
                temp = new Vector3(160, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.4f, 0, 1f);
                break;
            case "4-6":
            porcentaje+=.666;
                temp = new Vector3(133, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.33f, 0, 1f);
                break;
            case "4-7":
            porcentaje+=.57;
                temp = new Vector3(114, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.285f, 0, 1f);
                break;
            case "6-6":
            porcentaje+=1;
                temp = new Vector3(200, 0, 0);
                robot.transform.position += temp;  
                health.fillAmount = Mathf.Clamp(test=test+0.5f, 0, 1f);
                break;
            case "6-8":
            porcentaje+=.75;
                temp = new Vector3(150, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.375f, 0, 1f);
                break;
            case "7-4":
            porcentaje+=1.75;
                temp = new Vector3(350, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.875f, 0, 1f);
                break;
            case "7-10":
            porcentaje+=.7;
                temp = new Vector3(140, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.35f, 0, 1f);
                break;
            case "10-8":
            porcentaje+=1.25;
                temp = new Vector3(250, 0, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.625f, 0, 1f);
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        RectTransform robot = GetComponent<RectTransform>();
    }

    public void Scene()
    {
        bien.SetActive(false);
        mal.SetActive(false);
        SceneManager.LoadScene("Reto");
    }

    // Update is called once per frame
    void Update()
    {
    if(porcentaje>Meta){
        porc.text="Te pasaste";
            mal.SetActive(true);
            bien.SetActive(false);
            Invoke("Scene", 1.0f);
        }
    else if(porcentaje>=1.9){
        porc.text="Listo";
            bien.SetActive(true);
            mal.SetActive(false);
            Invoke("Scene", 1.0f);
        }
    else{
            porc.text=porcentaje.ToString()+"/"+Meta.ToString(); 
        }
    }
}
