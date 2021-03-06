//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Componentns.Silencer componentnsSilencerComponent = new Componentns.Silencer();

    public bool isComponentnsSilencer {
        get { return HasComponent(GameComponentsLookup.ComponentnsSilencer); }
        set {
            if (value != isComponentnsSilencer) {
                var index = GameComponentsLookup.ComponentnsSilencer;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentnsSilencerComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherComponentnsSilencer;

    public static Entitas.IMatcher<GameEntity> ComponentnsSilencer {
        get {
            if (_matcherComponentnsSilencer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentnsSilencer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentnsSilencer = matcher;
            }

            return _matcherComponentnsSilencer;
        }
    }
}
