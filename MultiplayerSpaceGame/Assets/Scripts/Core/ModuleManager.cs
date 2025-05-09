using System.Collections.Generic;
using UnityEngine;

public class ModuleManager : MonoBehaviour
{
    public enum ModuleType
    {
        Car,
        Flight,
        bike,
        boat,
        bus,
        truck,
        train,
        helicopter,
        spaceship,
        submarine,
    }

    private ModuleType currentModule;
    private Dictionary<ModuleType, GameObject> modulePrefabs;

    void Start()
    {
        modulePrefabs = new Dictionary<ModuleType, GameObject>
        {
            { ModuleType.Car, Resources.Load<GameObject>("Prefabs/Vehicles/Car") },
            { ModuleType.bike, Resources.Load<GameObject>("Prefabs/Vehicles/bike") },
            { ModuleType.boat, Resources.Load<GameObject>("Prefabs/Vehicles/boat") },
            { ModuleType.bus, Resources.Load<GameObject>("Prefabs/Vehicles/bus") },
            { ModuleType.truck, Resources.Load<GameObject>("Prefabs/Vehicles/truck") },
            { ModuleType.train, Resources.Load<GameObject>("Prefabs/Vehicles/train") },
            { ModuleType.helicopter, Resources.Load<GameObject>("Prefabs/Vehicles/helicopter") },
            { ModuleType.spaceship, Resources.Load<GameObject>("Prefabs/Vehicles/spaceship") },
            { ModuleType.submarine, Resources.Load<GameObject>("Prefabs/Vehicles/submarine") },
            { ModuleType.Flight, Resources.Load<GameObject>("Prefabs/Vehicles/Spaceship") }
        };

        SwitchModule(ModuleType.Car); // Start with the car module
    }

    public void SwitchModule(ModuleType newModule)
    {
        if (currentModule != newModule)
        {
            DestroyCurrentModule();
            currentModule = newModule;
            Instantiate(modulePrefabs[currentModule], transform.position, transform.rotation);
        }
    }

    private void DestroyCurrentModule()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}