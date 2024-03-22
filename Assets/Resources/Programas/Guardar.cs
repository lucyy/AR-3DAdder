using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class Guardar : MonoBehaviour
{

    // Start is called before the first frame update
    string path;
    float temporalX;
    float temporalY;
    float temporalZ;
    Vector3 posicion=new Vector3(1,1,1);
    public Transform trftarget2;
    string pathenMac;
    void Start()
    {
        Debug.Log("el path es " + Application.persistentDataPath);

        // ReadData();

       // path = Application.persistentDataPath + "/my_player.xml";
        path = "/Users/luciaubilluz/Desktop/PruebaARTFM/my_player.xml";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CerrarMenuInterno()
    {
        Application.Quit();

    }
    public void SaveDataAnimales()
    {

        ObjetosJuego listaObjetosJuego = new ObjetosJuego();

        XmlSerializer mySerializer = new XmlSerializer(typeof(ObjetosJuego));

        StreamWriter myWriter = new StreamWriter(path);
        ObjetosJuego newObjetosJuego = new ObjetosJuego();

        newObjetosJuego.vestName = "PrimerIntento";

        var clonesGato = GameObject.FindGameObjectsWithTag("PlayerGato");
        var clonesLoro = GameObject.FindGameObjectsWithTag("PlayerLoro");
        foreach (var clone in clonesGato)
        {
            temporalX = clone.transform.position.x;
            temporalY = clone.transform.position.y;
            temporalZ = clone.transform.position.z;
            newObjetosJuego.vestJuegoGato.Add(new ObjJuegoGato{ posXGato = temporalX, posYGato = temporalY, posZGato = temporalZ});
        }
        foreach (var clone in clonesLoro)
        {
            temporalX = clone.transform.position.x;
            temporalY = clone.transform.position.y;
            temporalZ = clone.transform.position.z;
            newObjetosJuego.vestJuegoLoro.Add(new ObjJuegoLoro { posXLoro = temporalX, posYLoro = temporalY, posZLoro = temporalZ });
        }


        mySerializer.Serialize(myWriter.BaseStream, newObjetosJuego);
        myWriter.Close();
    }

    public void ReadDataAnimales()
    {

        GameObject goGato = Resources.Load("Prefabs/Animales/Gato") as GameObject;
        GameObject goLoro = Resources.Load("Prefabs/Animales/Loro") as GameObject;
        var serializer = new XmlSerializer(typeof(ObjetosJuego));
        var stream = new FileStream(path, FileMode.Open);
        var container = serializer.Deserialize(stream) as ObjetosJuego;
        stream.Close();

        foreach (var clone in container.vestJuegoGato)
        {
            temporalX = clone.posXGato;
            temporalY = clone.posYGato;
            temporalZ = clone.posZGato;


            GameObject goGatoInstanciado = Instantiate(goGato);
            goGatoInstanciado.transform.SetParent(trftarget2);
            goGatoInstanciado.transform.position=new Vector3(temporalX, temporalY, temporalZ);
            //goPicachuInstanciado.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            goGatoInstanciado.tag = "PlayerGato";

        }
        foreach (var clone in container.vestJuegoLoro)
        {
            temporalX = clone.posXLoro;
            temporalY = clone.posYLoro;
            temporalZ = clone.posZLoro;


            GameObject goLoroInstanciado = Instantiate(goLoro);
            goLoroInstanciado.transform.SetParent(trftarget2);
            goLoroInstanciado.transform.position = new Vector3(temporalX, temporalY, temporalZ);
            //goPicachuInstanciado.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            goLoroInstanciado.tag = "PlayerLoro";

        }

        Debug.Log("posx " + container.vestJuegoGato[0].posXGato);
    }
}

   

