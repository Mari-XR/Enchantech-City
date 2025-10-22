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

    Material[] FindAndReplaceMaterial(Material[] materials, Material toFind, Material replacement)
    {
        var newMaterials = materials;
        for (int i = 0; i < materials.Length; i++)
        {
            Debug.Log(newMaterials[i]);
            Debug.Log(toFind);
            if (newMaterials[i] == toFind)
            {
                Debug.Log(newMaterials[i].name);
                newMaterials[i] = replacement;
            }
        }
        return newMaterials;
    }

    public void TurnLightsOn()
    {
        foreach (var obj in objects)
        {
            MeshRenderer mr;

            obj.TryGetComponent(out mr);

            if (mr != null)
            {
                var newMaterials = FindAndReplaceMaterial(mr.sharedMaterials, shopOffMaterial, shopOnMaterial);
                newMaterials = FindAndReplaceMaterial(newMaterials, streetOffMaterial, streetOnMaterial);
                newMaterials = FindAndReplaceMaterial(newMaterials, neonOffMaterial, neonOnMaterial);
                mr.sharedMaterials = newMaterials;
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
                var newMaterials = FindAndReplaceMaterial(mr.sharedMaterials, shopOnMaterial, shopOffMaterial);
                newMaterials = FindAndReplaceMaterial(newMaterials, streetOnMaterial, streetOffMaterial);
                newMaterials = FindAndReplaceMaterial(newMaterials, neonOnMaterial, neonOffMaterial);
                mr.sharedMaterials = newMaterials;
            }
        }
    }
}
