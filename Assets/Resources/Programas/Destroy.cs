using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destruir()
    {
        GameObject[] grupoGOGato = GameObject.FindGameObjectsWithTag("PlayerGato");
        GameObject[] grupoGOLoro = GameObject.FindGameObjectsWithTag("PlayerLoro");
        if (grupoGOGato[0]!=null)
        {
            Destroy(grupoGOGato[0]);
        }
        if (grupoGOLoro[0] != null)
        {
            Destroy(grupoGOLoro[0]);
        }
    }
}
