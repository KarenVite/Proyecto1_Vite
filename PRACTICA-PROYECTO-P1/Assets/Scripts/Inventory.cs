using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> prefabs;
    public int CurrentSlot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObjectGeneration(Transform Parent)
    {
        

        GameObject obj = prefabs[Random.Range(0, prefabs.Count)];
        GameObject clone = Instantiate(obj);
        clone.transform.parent = Parent;
    }

   
}

public class AccessChildren : MonoBehaviour
{
    private void Start()
    {
        Transform[] children = GetComponentsInChildren<Transform>();

        foreach(Transform child in children)
        {
            Debug.Log("Nombre del hijo: " + child.name);
        }
    }
}


