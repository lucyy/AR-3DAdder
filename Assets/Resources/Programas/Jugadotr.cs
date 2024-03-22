using System.Xml.Serialization;

public class Jugador
{
    [XmlElement]
    public float PosX { get; set; }

    [XmlElement]
    public float PosY { get; set; }

    [XmlElement]
    public float PosZ { get; set; }
}