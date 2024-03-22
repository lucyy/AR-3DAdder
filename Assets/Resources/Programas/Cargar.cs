using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class Cargar : MonoBehaviour
{
    Vector3 posicionActual = new Vector3();
    string path = "/Users/luciaubilluz/Desktop/PruebaAR/my_player.xml";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CargarElemento()
    {
        var serializer = new XmlSerializer(typeof(Jugador));
        var stream = new FileStream(path, FileMode.Open);
        var container = serializer.Deserialize(stream) as Jugador;
        stream.Close();

        GameObject instance = Instantiate(Resources.Load("Prefabs/Pikachu", typeof(GameObject))) as GameObject;



        Vector3 posicionActual = new Vector3();
        posicionActual.x = container.PosX;
        posicionActual.y = container.PosY;
        posicionActual.z = container.PosZ;
        //transform.position = posicionActual;

        instance.transform.position = posicionActual;

    }
    public void CargarTodosElementos()
    {
        var serializer = new XmlSerializer(typeof(Jugador));
        var stream = new FileStream(path, FileMode.Open);

        var containers = serializer.Deserialize(stream) as ContenedorJugadores;
        stream.Close();
        
        Debug.Log("el rpimer contenedor"+containers.listaJugadores[0].PosX.ToString());
        /**
        foreach(var clone in containers)
        {
            GameObject instanceDeserializado = Instantiate(Resources.Load("Prefabs/Pikachu", typeof(GameObject))) as GameObject;

            posicionActual.x = clone.PosX;
            posicionActual.y = clone.PosY;
            posicionActual.z = clone.PosZ;
            instanceDeserializado.transform.position = posicionActual;
        }

**/

        //transform.position = posicionActual;

       

    }
}
