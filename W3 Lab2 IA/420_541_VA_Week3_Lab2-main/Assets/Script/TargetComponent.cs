using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    public GameManager gm;
    public GameObject target;
    public int points =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision c){
        if(c.gameObject.tag == "Projectile"){
            gm.IncrementScore();
            Destroy(c.gameObject);
            hideTarget();
        }
            
    }

    public void hideTarget(){
        target.SetActive(false);
        Invoke("invoking", 5);
    }

    public void invoking(){
        target.SetActive(true);
    }
}