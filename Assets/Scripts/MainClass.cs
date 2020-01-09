using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class MainClass
{
    private Contexts _globalContext;
    private static int _amountEntity;
    
    void Main()
    {
        CreateEntitySilencer(_globalContext, _amountEntity);
        CreateEntityRearSight(_globalContext, _amountEntity);
        CreateEntitiesGuns(_globalContext, _amountEntity);
        CreateEntityInventory(_globalContext);
        CreateEntityPlayer(_globalContext);
    }

    private void CreateEntityPlayer(Contexts pool)
    {
        var entity = pool.game.CreateEntity();
        var singlInventory = pool.game.GetGroup(GameMatcher.AllOf(GameMatcher.ComponentnsInventory)).GetSingleEntity();
        entity.AddComponentnsPlayer(singlInventory.creationIndex);
    }


    void CreateEntitySilencer(Contexts pool, int amountEntity)
    {
        for (int i = 0; i < amountEntity; i++)
        {
            var entitySilencer = pool.game.CreateEntity();
            entitySilencer.isComponentnsSilencer = true;
            entitySilencer.isComponentnsItem = true;
        }
    }
        
    void CreateEntityRearSight(Contexts pool, int amountEntity)
    {
        for (int i = 0; i < amountEntity; i++)
        {
            var realSightComponent =  pool.game.CreateEntity();
            realSightComponent.isComponentnsRearSight = true;
            realSightComponent.isComponentnsItem = true;
        }
    }
    
    
    void CreateEntitiesGuns(Contexts pool, int amountEntity)
    {
        var allEntitiesSilencer = pool.game.GetGroup(GameMatcher.AllOf(GameMatcher.ComponentnsSilencer)).GetEntities();
        var allEntitiesRearSight = pool.game.GetGroup(GameMatcher.AllOf(GameMatcher.ComponentnsRearSight)).GetEntities();
        
        for (int i = 0; i < amountEntity; i++)
        {
            var gunEntity = pool.game.CreateEntity();
            gunEntity.isComponentnsItem = true;
            gunEntity.AddGun(allEntitiesSilencer[i].creationIndex, allEntitiesRearSight[i].creationIndex);
        }     
    }
    
    private void CreateEntityInventory(Contexts globalContext)
    {
        var entity = globalContext.game.CreateEntity();
        var allItems = globalContext.game.GetGroup(GameMatcher.ComponentnsItem);
        Dictionary<int, Entity> dict = new Dictionary<int, Entity>();
        
        foreach (var item in allItems)
        {
            dict.Add(item.creationIndex, item);
        }
        entity.AddComponentnsInventory(dict);
    }

}
