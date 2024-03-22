using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciasAnimales : MonoBehaviour {

    //Domésticos
    public GameObject goGato;
    public GameObject goLoro;
    public GameObject goPerro;
    public GameObject goOveja;
    //Salvajes
    public GameObject goSerpiente;
    public GameObject goLeon;
    public GameObject goLobo;
    public GameObject goTiburon;

    public Transform trftargetAnimales;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

 
   //Instanciación de animales
    //Instancias animales domésticos
    public void CrearGato()
    {
        GameObject goGatoInstanciado = Instantiate(goGato);
        goGatoInstanciado.transform.SetParent(trftargetAnimales);
        goGatoInstanciado.transform.position = trftargetAnimales.position;
        goGatoInstanciado.transform.Rotate(180f, 180f, 180f, Space.Self);
        goGatoInstanciado.tag = "PlayerGato";
   

    }
    public void CrearLoro()
    {
        GameObject goLoroInstanciado = Instantiate(goLoro);
        goLoroInstanciado.transform.SetParent(trftargetAnimales);
        goLoroInstanciado.transform.position = trftargetAnimales.position;
        goLoroInstanciado.transform.Rotate(0f, 0f, 0f, Space.Self);
        goLoroInstanciado.tag = "PlayerLoro";
    

    }
    public void CrearPerro()
    {
        GameObject goPerroInstanciado = Instantiate(goPerro);
        goPerroInstanciado.transform.SetParent(trftargetAnimales);
        goPerroInstanciado.transform.position = trftargetAnimales.position;
        goPerroInstanciado.transform.Rotate(180f, 180f, 180f, Space.Self);
        goPerroInstanciado.tag = "Player";


    }
    public void CrearOveja()
    {
        GameObject goOvejaInstanciado = Instantiate(goOveja);
        goOvejaInstanciado.transform.SetParent(trftargetAnimales);
        goOvejaInstanciado.transform.position = trftargetAnimales.position;
        goOvejaInstanciado.transform.Rotate(180f, 180f, 180f, Space.Self);
        goOvejaInstanciado.tag = "Player";
    

    }

    //Instancias animales salvajes
    public void CrearSerpiente()
    {
        GameObject goSerpienteInstanciado = Instantiate(goSerpiente);
        goSerpienteInstanciado.transform.SetParent(trftargetAnimales);
        goSerpienteInstanciado.transform.position = trftargetAnimales.position;
        goSerpienteInstanciado.transform.Rotate(-90f, -90f, 0f, Space.Self);
        goSerpienteInstanciado.tag = "Player";


    }
    public void CrearLeon()
    {
        GameObject goLeonInstanciado = Instantiate(goLeon);
        goLeonInstanciado.transform.SetParent(trftargetAnimales);
        goLeonInstanciado.transform.position = trftargetAnimales.position;
        goLeonInstanciado.transform.Rotate(-90f, 0f, 0f, Space.Self);
        goLeonInstanciado.tag = "Player";
     

    }
    public void CrearLobo()
    {
        GameObject goLoboInstanciado = Instantiate(goLobo);
        goLoboInstanciado.transform.SetParent(trftargetAnimales);
        goLoboInstanciado.transform.position = trftargetAnimales.position;
        goLoboInstanciado.transform.Rotate(180f, 180f, -90f, Space.Self);
        goLoboInstanciado.tag = "Player";
  

    }
    public void CrearTiburon()
    {
        GameObject goTiburonInstanciado = Instantiate(goTiburon);
        goTiburonInstanciado.transform.SetParent(trftargetAnimales);
        goTiburonInstanciado.transform.position = trftargetAnimales.position;
        goTiburonInstanciado.transform.Rotate(0f, 180f, 0f, Space.Self);
        goTiburonInstanciado.tag = "Player";
  
    }

   

}
