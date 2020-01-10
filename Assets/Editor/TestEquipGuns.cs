using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using NUnit.Framework;
using UnityEngine;

public class TestEquipGuns
{
    [Test]
    public void EquipSilencer()
    {
        var managerEntities = new EntitiesManger();
        var equipManager = new GunEquipController();
        managerEntities.Init();
        
        var entityGun = managerEntities.GlobalContext.game.GetGroup(GameMatcher.Gun).AsEnumerable().First();
        var entitySilencer = managerEntities.GlobalContext.game.GetGroup(GameMatcher.ComponentnsSilencer).AsEnumerable().First();

        var result = equipManager.Mount(entityGun, entitySilencer);
        Assert.True(result);
    }
    
    
    [Test]
    public void RemoveEquipSilencer()
    {
        var managerEntities = new EntitiesManger();
        var equipManager = new GunEquipController();
        managerEntities.Init();
        
        var entityGun = managerEntities.GlobalContext.game.GetGroup(GameMatcher.Gun).AsEnumerable().First();
        var entitySilencer = managerEntities.GlobalContext.game.GetGroup(GameMatcher.ComponentnsSilencer).AsEnumerable().First();

        var result = equipManager.Dismount(entityGun, entitySilencer);
        Assert.True(result);
        
    }
    
    [Test]
    public void EquipRearSight()
    {
        var managerEntities = new EntitiesManger();
        var equipManager = new GunEquipController();
        managerEntities.Init();
        
        var entityGun = managerEntities.GlobalContext.game.GetGroup(GameMatcher.Gun).AsEnumerable().First();
        var entitySilencer = managerEntities.GlobalContext.game.GetGroup(GameMatcher.ComponentnsRearSight).AsEnumerable().First();

        var result = equipManager.Mount(entityGun, entitySilencer);
        Assert.True(result);
        
    }
    
    [Test]
    public void RemoveEquipRearSight()
    {
        var managerEntities = new EntitiesManger();
        var equipManager = new GunEquipController();
        managerEntities.Init();
        
        var entityGun = managerEntities.GlobalContext.game.GetGroup(GameMatcher.Gun).AsEnumerable().First();
        var entitySilencer = managerEntities.GlobalContext.game.GetGroup(GameMatcher.ComponentnsRearSight).AsEnumerable().First();

        var result = equipManager.Dismount(entityGun, entitySilencer);
        Assert.True(result);
        
    }
}
