using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightZone: MonoBehaviour
{
    [SerializeField] Material shopOnMaterial;
    [SerializeField] Material shopOffMaterial;

    [SerializeField] Material streetOnMaterial;
    [SerializeField] Material streetOffMaterial;

    [SerializeField] Material neonOnMaterial;
    [SerializeField] Material neonOffMaterial;

    [SerializeField] GameObject[] objects;
    void Start()
    {
        TurnLightsOff();
    }

    public void TurnLightsOn()
    {
        foreach (var obj in objects)
        {
            MeshRenderer mr;

            obj.TryGetComponent(out mr);

            if (mr != null)
            {
                for (int i = 0; i < mr.materials.Length; i++)
                {
                    mr.materials[i] = shopOnMaterial;
                    Debug.Log(mr.materials[i].name);
                    if (mr.materials[i].name == shopOffMaterial + " (Instance)")
                    {
                        Debug.Log("Toggle");
                        mr.materials[i] = shopOnMaterial;
                    } else if (mr.materials[i].name == streetOffMaterial + " (Instance)")
                    {
                        Debug.Log("Toggle");
                        mr.materials[i] = streetOnMaterial;
                    }
                }
            }
        }
    }

    public void TurnLightsOff()
    {
        foreach (var obj in objects)
        {
            MeshRenderer mr;

            obj.TryGetComponent(out mr);

            if (mr != null)
            {
                for (int i = 0; i < mr.materials.Length; i++)
                {
                    Debug.Log(mr.materials[i].name);
                    if (mr.materials[i].name == shopOnMaterial + " (Instance")
                    {
                        Debug.Log("Toggle");
                        mr.materials[i] = shopOffMaterial;
                    }
                    else if (mr.materials[i].name == streetOnMaterial + " (Instance")
                    {
                        Debug.Log("Toggle");
                        mr.materials[i] = streetOffMaterial;
                    }
                }
            }
        }
    }
}
