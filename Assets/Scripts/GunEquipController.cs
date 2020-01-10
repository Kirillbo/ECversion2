using Entitas;

namespace DefaultNamespace
{
    public class GunEquipController
    {
        
        public bool Mount(Entity gunEntity, Entity gunAccessories)
        {
            Gun component = gunEntity.GetComponent(GameComponentsLookup.Gun) as Gun;

            if (gunAccessories.HasComponent(GameComponentsLookup.ComponentnsRearSight))
            {
                component.IdConnectorRearSight = gunAccessories.creationIndex;
                return true;
            }

            else if (gunAccessories.HasComponent(GameComponentsLookup.ComponentnsSilencer))
            {
                component.IdConnectorSilencer = gunAccessories.creationIndex;
                return true;
            }
            
            return false;
        }

        public bool Dismount(Entity gunEntity, Entity gunAccessories)
        {
            Gun component = gunEntity.GetComponent(GameComponentsLookup.Gun) as Gun;

            if (gunAccessories.HasComponent(GameComponentsLookup.ComponentnsRearSight))
            {
                component.IdConnectorRearSight = 0;
                return true;
            }

            else if (gunAccessories.HasComponent(GameComponentsLookup.ComponentnsSilencer))
            {
                component.IdConnectorSilencer = 0;
                return true;
            }
            
            return false;
        }
    }
}