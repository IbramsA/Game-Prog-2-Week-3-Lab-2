using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bpf;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
           
        }

        if(Input.GetButtonUp("Fire1")){
            Instantiate(bpf, transform.position, transform.rotation);
        }
    }
}
