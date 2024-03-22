using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarDescripcion : MonoBehaviour
{
    public GameObject goImagenDescripcionBiologia;
    public GameObject goImagenDescripcionHistoria; 
    public GameObject goImagenTextoComun;
 
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarDescripcionBiologia()
    {
        goImagenDescripcionBiologia.SetActive(true);
        goImagenTextoComun.SetActive(false);

    }
    public void MostrarDescripcionHistoria()
    {
        goImagenDescripcionHistoria.SetActive(true);
        goImagenTextoComun.SetActive(false);

    }
}
