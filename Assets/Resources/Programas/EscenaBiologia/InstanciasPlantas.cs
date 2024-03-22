using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciasPlantas : MonoBehaviour
{
    //Frutas
    public GameObject goBanana;
    public GameObject goManzana;
    public GameObject goPera;
    public GameObject goPina;
    //Flores
    public GameObject goFlorLoto;
    public GameObject goRosa;
    public GameObject goTulipan;
    public GameObject goGirasol;

    public Transform trftargetPlantas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Instanciación de Plantas
    //Instancias Frutas
    public void CrearBanana()
    {
        GameObject goBananaInstanciado = Instantiate(goBanana);
        goBananaInstanciado.transform.SetParent(trftargetPlantas);
        goBananaInstanciado.transform.localScale = new Vector3(0.002f, 0.002f, 0.002f);
        goBananaInstanciado.tag = "Player";
     

    }
    public void CrearManzana()
    {
        GameObject goManzanaInstanciado = Instantiate(goManzana);
        goManzanaInstanciado.transform.SetParent(trftargetPlantas);
        goManzanaInstanciado.transform.localScale = new Vector3(10f, 10f, 10f);
        goManzanaInstanciado.tag = "Player";
  

    }
    public void CrearPera()
    {
        GameObject goPeraInstanciado = Instantiate(goPera);
        goPeraInstanciado.transform.SetParent(trftargetPlantas);
        goPeraInstanciado.transform.localScale = new Vector3(0.025f, 0.025f, 0.025f);
        goPeraInstanciado.tag = "Player";


    }
    public void CrearPina()
    {
        GameObject goPinaInstanciado = Instantiate(goPina);
        goPinaInstanciado.transform.SetParent(trftargetPlantas);
        goPinaInstanciado.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
        goPinaInstanciado.tag = "Player";
   

    }
    //Instancias Flores
    public void CrearFlorLoto()
    {
        GameObject goFlorLotoInstanciado = Instantiate(goFlorLoto);
        goFlorLotoInstanciado.transform.SetParent(trftargetPlantas);
        goFlorLotoInstanciado.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        goFlorLotoInstanciado.tag = "Player";
      

    }
    public void CrearTulipan()
    {
        GameObject goTulipanInstanciado = Instantiate(goTulipan);
        goTulipanInstanciado.transform.SetParent(trftargetPlantas);
        goTulipanInstanciado.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
        goTulipanInstanciado.tag = "Player";
  

    }
    public void CrearRosa()
    {
        GameObject goRosaInstanciado = Instantiate(goRosa);
        goRosaInstanciado.transform.SetParent(trftargetPlantas);
        goRosaInstanciado.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        goRosaInstanciado.tag = "Player";
     

    }
    public void CrearGirasol()
    {
        GameObject goGirasolInstanciado = Instantiate(goGirasol);
        goGirasolInstanciado.transform.SetParent(trftargetPlantas);
        goGirasolInstanciado.transform.localScale = new Vector3(0.002f, 0.002f, 0.002f);
        goGirasolInstanciado.tag = "Player";
    
    }
}
