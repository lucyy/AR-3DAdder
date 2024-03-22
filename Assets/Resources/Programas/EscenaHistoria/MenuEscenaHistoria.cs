using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEscenaHistoria : MonoBehaviour
{
    public GameObject goMenuSinTarget;

    public GameObject goMenuPersonajes;
    public GameObject goMenuCientificos;
    public GameObject goMenuArtistas;

    public GameObject goMenuObras;
    public GameObject goMenuInventos;
    public GameObject goMenuPinturas;


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
    //Personajes

    public void MostrarMenuCientificos()
    {
        goMenuCientificos.gameObject.SetActive(true);
        goMenuPersonajes.gameObject.SetActive(false);
    }
    public void MostrarMenuArtistas()
    {
        goMenuArtistas.gameObject.SetActive(true);
        goMenuPersonajes.gameObject.SetActive(false);
    }
    public void OcultarMenuCientificos()
    {
        goMenuCientificos.gameObject.SetActive(false);
        goMenuPersonajes.gameObject.SetActive(true);
    }
    public void OcultarMenuArtistas()
    {
        goMenuArtistas.gameObject.SetActive(false);
        goMenuPersonajes.gameObject.SetActive(true);
    }

    //Obras
    public void MostrarMenuInventos()
    {
        goMenuInventos.gameObject.SetActive(true);
        goMenuObras.gameObject.SetActive(false);
    }
    public void MostrarMenuPinturas()
    {
        goMenuPinturas.gameObject.SetActive(true);
        goMenuObras.gameObject.SetActive(false);
    }
    public void OcultarMenuInventos()
    {
        goMenuInventos.gameObject.SetActive(false);
        goMenuObras.gameObject.SetActive(true);
    }
    public void OcultarMenuPinturas()
    {
        goMenuPinturas.gameObject.SetActive(false);
        goMenuObras.gameObject.SetActive(true);
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
