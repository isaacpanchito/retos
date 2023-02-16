using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fracSelection : MonoBehaviour
{
    public GameObject[]objectsToInstantiate;
    int frac;
    public Transform pos;

     
    // Start is called before the first frame update
    void Start()
    {
        generate();
    }
    void generate(){
        
        for(int i=0; i<8;i++){
            frac=Random.Range(0,objectsToInstantiate.Length);
            Instantiate(objectsToInstantiate[frac], new Vector3(-5f+0.01f+i*.1f,4.36f+i,-.24f), pos.transform.rotation) ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
