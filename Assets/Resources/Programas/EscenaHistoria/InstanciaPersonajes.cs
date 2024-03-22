using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaPersonajes : MonoBehaviour
{

    //Científicos
    public GameObject goAda;
   public GameObject goMarie;
    public GameObject goMargaret;
    //Artistas
    public GameObject goLeonardo;
    public GameObject goMiguel;
   public GameObject goSandro;

    public Transform trftargetHistoria;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //Instanciación de Personajes
    //Instancias Científicos
    public void CrearAda()
    {
        GameObject goAdaInstanciado = Instantiate(goAda);
        goAdaInstanciado.transform.SetParent(trftargetHistoria);
        goAdaInstanciado.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        goAdaInstanciado.tag = "Player";


    }
    public void CrearMarie()
    {
        GameObject goMarieInstanciado = Instantiate(goMarie);
        goMarieInstanciado.transform.SetParent(trftargetHistoria);
        goMarieInstanciado.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        goMarieInstanciado.tag = "Player";
      

    }

    public void CrearMargaret()
    {
        GameObject goMargaretInstanciado = Instantiate(goMargaret);
        goMargaretInstanciado.transform.SetParent(trftargetHistoria);
        goMargaretInstanciado.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        goMargaretInstanciado.tag = "Player";


    }
    public void CrearLeonardo()
    {
        GameObject goLeonardoInstanciado = Instantiate(goLeonardo);
        goLeonardoInstanciado.transform.SetParent(trftargetHistoria);
        goLeonardoInstanciado.transform.localScale = new Vector3(0.04f, 0.04f, 0.04f);
        goLeonardoInstanciado.tag = "Player";
      

    }
    public void CrearMiguel()
    {
        GameObject goMiguelInstanciado = Instantiate(goMiguel);
        goMiguelInstanciado.transform.SetParent(trftargetHistoria);
        goMiguelInstanciado.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        goMiguelInstanciado.tag = "Player";
  

    }
    public void CrearSandro()
    {
        GameObject goSandroInstanciado = Instantiate(goSandro);
        goSandroInstanciado.transform.SetParent(trftargetHistoria);
        goSandroInstanciado.transform.localScale = new Vector3(0.07f, 0.07f, 0.07f);
        goSandroInstanciado.tag = "Player";
    

    }
}
