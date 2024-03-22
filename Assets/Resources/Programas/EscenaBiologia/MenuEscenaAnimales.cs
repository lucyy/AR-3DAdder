using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEscenaAnimales : MonoBehaviour
{
    public GameObject goMenuSinTarget;

    public GameObject goMenuAnimales;
    public GameObject goMenuSalvajes;
    public GameObject goMenuDomesticos;

    public GameObject goMenuPlantas;
    public GameObject goMenuFrutas;
    public GameObject goMenuFlores;

    bool presenciaTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //en el caso de que se amplíe más menus, el indicador para el menú principal de animales
    //debe ser bool y los otrso enteros
    public void IndicadorSalvajes()
    {

    }
    void MostrarMenuSinTarget()
    {
        goMenuSinTarget.gameObject.SetActive(true);

    }
    //OnTrackingLost
    void OcultarMenuSinTarget()
    {
        goMenuSinTarget.gameObject.SetActive(false);

    }
    //Animales
   
    public void MostrarMenuAnimalesSalvajes()
    {
        goMenuSalvajes.gameObject.SetActive(true);
        goMenuAnimales.gameObject.SetActive(false);
    }
    public void MostrarMenuAnimalesDomesticos()
    {
        goMenuDomesticos.gameObject.SetActive(true);
        goMenuAnimales.gameObject.SetActive(false);
    }
    public void OcultarMenuAnimalesDomesticos()
    {
        goMenuDomesticos.gameObject.SetActive(false);
        goMenuAnimales.gameObject.SetActive(true);
    }
    public void OcultarMenuAnimalesSalvajes()
    {
        goMenuSalvajes.gameObject.SetActive(false);
        goMenuAnimales.gameObject.SetActive(true);
    }

    //Plantas
    public void MostrarMenuFrutas()
    {
        goMenuFrutas.gameObject.SetActive(true);
        goMenuPlantas.gameObject.SetActive(false);
    }
    public void MostrarMenuFlores()
    {
        goMenuFlores.gameObject.SetActive(true);
        goMenuPlantas.gameObject.SetActive(false);
    }
    public void OcultarMenuFrutas()
    {
        goMenuFrutas.gameObject.SetActive(false);
        goMenuPlantas.gameObject.SetActive(true);
    }
    public void OcultarMenuFlores()
    {
        goMenuFlores.gameObject.SetActive(false);
        goMenuPlantas.gameObject.SetActive(true);
    }

    public void RegresoMenuPrincipal()
    {
        SceneManager.LoadScene(0);

    }
    public void Cerrar()
    {
        Application.Quit();

    }

}
