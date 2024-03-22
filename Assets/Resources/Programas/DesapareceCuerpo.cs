using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesapareceCuerpo : MonoBehaviour
{

    bool triggerColision=false;
    // Start is called before the first frame update
    void Start()
    {
        //antAnim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //if(triggerColision==true)
       // {
         //   animBasurero.Play();
       // }
    }
   
    void OnCollisionEnter(Collision col)
    {
        triggerColision = true;
        if (col.gameObject.tag == "Player")
        {
           
            Destroy(col.gameObject);
           //antAnim.Play("AnimBasurero", 0, 0.25f);
           
        }
    }
}
