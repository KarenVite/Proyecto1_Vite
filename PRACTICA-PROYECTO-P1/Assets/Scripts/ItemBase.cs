using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tipo
{
    MATERIAL = 0,
    HERRAMIENTA = 1,
    DECORACIÓN = 2

}

public enum Rareza
{
    ESCENCIAL = 0,
    COMÚN = 1,
    INUSUAL = 2
}


public class ItemBase : MonoBehaviour
{
    public Sprite icon;
    public string Name;
    public int Vida;
    public string Descripción;

    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = icon;
    }

    public virtual void Setup(string _name, int _vida, string _descripción)
    {
        Name = _name;
        Vida = _vida;
        Descripción = _descripción;
        GetComponent<SpriteRenderer>().sprite = icon;
    }
}
