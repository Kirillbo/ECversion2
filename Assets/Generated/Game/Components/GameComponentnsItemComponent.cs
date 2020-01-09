//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Componentns.Item componentnsItemComponent = new Componentns.Item();

    public bool isComponentnsItem {
        get { return HasComponent(GameComponentsLookup.ComponentnsItem); }
        set {
            if (value != isComponentnsItem) {
                var index = GameComponentsLookup.ComponentnsItem;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentnsItemComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherComponentnsItem;

    public static Entitas.IMatcher<GameEntity> ComponentnsItem {
        get {
            if (_matcherComponentnsItem == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentnsItem);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentnsItem = matcher;
            }

            return _matcherComponentnsItem;
        }
    }
}