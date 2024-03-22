
using System.Collections.Generic;
 using System.Xml.Serialization;
 
 [XmlRoot("ColeccionJugadores")]
public class ContenedorJugadores
{
    [XmlArray("Jugadores")]
    [XmlArrayItem("Jugador")]
    public List<Jugador> listaJugadores = new List<Jugador>();
}