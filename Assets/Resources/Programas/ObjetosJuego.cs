
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEditor;

[XmlRoot("RaizJuego")]
[XmlInclude(typeof(ObjJuegoGato))]
[XmlInclude(typeof(ObjJuegoLoro))]
public class ObjetosJuego
{
    [XmlAttribute("ObjsName")]
    public string vestName;
    [XmlArray("Juegos")]
    [XmlArrayItem("eljuego")]
    public List<ObjJuegoGato> vestJuegoGato = new List<ObjJuegoGato>();
    public List<ObjJuegoLoro> vestJuegoLoro = new List<ObjJuegoLoro>();
}

[XmlType("JuegoGato")]
public class ObjJuegoGato
{
    // The type of pouch
    [XmlAttribute("ObjJuegoNameGato")]
    public string objNameGato;

    // Posición Gato
    [XmlElement("posXGato")]
    public float posXGato;
    [XmlElement("posYGato")]
    public float posYGato;
    [XmlElement("posZGato")]
    public float posZGato;

}
[XmlType("JuegoLoro")]
public class ObjJuegoLoro
{
    // The type of pouch
    [XmlAttribute("ObjJuegoName")]
    public string objNameLoro;

    // Posición Loro
    [XmlElement("posXLoro")]
    public float posXLoro;
    [XmlElement("posYLoro")]
    public float posYLoro;
    [XmlElement("posZLoro")]
    public float posZLoro;

}