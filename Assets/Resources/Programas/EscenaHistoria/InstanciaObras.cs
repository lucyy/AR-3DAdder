using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaObras : MonoBehaviour
{

    //Científicos
    public GameObject goNotasAda;
    public GameObject goRadioactividadMarie;
    public GameObject goApolloMargaret;
    //Artistas
    public GameObject goUltimaCenaLeonardo;
    public GameObject goCracionAdanMiguel;
    public GameObject goNacimientoVenusSandro;

    public Transform trftargetObras;

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
    public void CrearNotasAda()
    {
        GameObject goNotasAdaInstanciado = Instantiate(goNotasAda);
        goNotasAdaInstanciado.transform.SetParent(trftargetObras);
        goNotasAdaInstanciado.transform.position = trftargetObras.position;
        goNotasAdaInstanciado.tag = "Player";
  

    }
    public void CrearRadioactividadMarie()
    {
        GameObject goRadioactividadMarieInstanciado = Instantiate(goRadioactividadMarie);
        goRadioactividadMarieInstanciado.transform.SetParent(trftargetObras);
        goRadioactividadMarieInstanciado.transform.position = trftargetObras.position;
        goRadioactividadMarieInstanciado.tag = "Player";

    }

    public void CrearApolloMargaret()
    {
        GameObject goApolloMargaretInstanciado = Instantiate(goApolloMargaret);
        goApolloMargaretInstanciado.transform.SetParent(trftargetObras);
        goApolloMargaretInstanciado.transform.position = trftargetObras.position;
        goApolloMargaretInstanciado.tag = "Player";


    }
    public void CrearUltimaCenaLeonardo()
    {
        GameObject goUltimaCenaLeonardoInstanciado = Instantiate(goUltimaCenaLeonardo);
        goUltimaCenaLeonardoInstanciado.transform.SetParent(trftargetObras);
        goUltimaCenaLeonardoInstanciado.transform.position = trftargetObras.position;
        goUltimaCenaLeonardoInstanciado.tag = "Player";


    }
    public void CrearCracionAdanMiguel()
    {
        GameObject goCracionAdanMiguelInstanciado = Instantiate(goCracionAdanMiguel);
        goCracionAdanMiguelInstanciado.transform.SetParent(trftargetObras);
        goCracionAdanMiguelInstanciado.transform.position = trftargetObras.position;
        goCracionAdanMiguelInstanciado.tag = "Player";


    }
    public void CrearNacimientoVenusSandro()
    {
        GameObject goNacimientoVenusSandroInstanciado = Instantiate(goNacimientoVenusSandro);
        goNacimientoVenusSandroInstanciado.transform.SetParent(trftargetObras);
        goNacimientoVenusSandroInstanciado.transform.position = trftargetObras.position;
        goNacimientoVenusSandroInstanciado.tag = "Player";


    }
}
