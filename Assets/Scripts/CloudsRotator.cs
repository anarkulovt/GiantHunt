using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Transform>().Rotate(1,0,0);
        gameObject.transform.Rotate(new Vector3(0,(1f * Time.deltaTime),0));
    }
}
