using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class createcomponents : MonoBehaviour
{
    EntityManager entitymanager;
    // Start is called before the first frame update
    void Start()
    {

        entitymanager = World.Active.EntityManager;
        EntityArchetype a = entitymanager.CreateArchetype(typeof(PingDriverComponent));


        Entity eclient = entitymanager.CreateEntity(a);
        Entity eserver = entitymanager.CreateEntity(a);

        entitymanager.SetComponentData(eserver, new PingDriverComponent { isServer = 1});



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
