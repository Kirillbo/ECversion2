using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Entitas;
using TMPro;
using UnityEngine;



    public class EntitiesManger 
    {
        public Contexts GlobalContext;
        private static int _amountEntity = 2;


        
        public void Init()
        {
            GlobalContext = Contexts.sharedInstance;
            CreateEntitySilencer(GlobalContext, _amountEntity);
            CreateEntityRearSight(GlobalContext, _amountEntity);
            CreateEntitiesGuns(GlobalContext, _amountEntity);
            CreateEntityInventory(GlobalContext);
            CreateEntityPlayer(GlobalContext);
        }

        private void CreateEntityPlayer(Contexts pool)
        {
            var entity = pool.game.CreateEntity();
            var singleInventory = pool.game.GetGroup(GameMatcher.AllOf(GameMatcher.ComponentnsInventory)).AsEnumerable().First();
            entity.AddComponentnsPlayer(singleInventory.creationIndex);
        }


        void CreateEntitySilencer(Contexts pool, int amountEntity)
        {
            for (int i = 0; i < amountEntity; i++)
            {
                if(pool == null) return;
                
                var entitySilencer = pool.game.CreateEntity();
                entitySilencer.isComponentnsSilencer = true;
                entitySilencer.isComponentnsItem = true;
            }
        }

        void CreateEntityRearSight(Contexts pool, int amountEntity)
        {
            
            for (int i = 0; i < amountEntity; i++)
            {
                var realSightComponent = pool.game.CreateEntity();
                realSightComponent.isComponentnsRearSight = true;
                realSightComponent.isComponentnsItem = true;
            }
        }


        void CreateEntitiesGuns(Contexts pool, int amountEntity)
        {
            var allEntitiesSilencer =
                pool.game.GetGroup(GameMatcher.AllOf(GameMatcher.ComponentnsSilencer)).GetEntities();
            var allEntitiesRearSight =
                pool.game.GetGroup(GameMatcher.AllOf(GameMatcher.ComponentnsRearSight)).GetEntities();

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

