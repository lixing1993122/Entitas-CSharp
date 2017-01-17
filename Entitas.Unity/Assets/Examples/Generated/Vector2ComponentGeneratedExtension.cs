//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public sealed partial class VisualDebuggingEntity : XXXEntity {

        public Vector2Component vector2 { get { return (Vector2Component)GetComponent(VisualDebuggingComponentIds.Vector2); } }
        public bool hasVector2 { get { return HasComponent(VisualDebuggingComponentIds.Vector2); } }

        public void AddVector2(UnityEngine.Vector2 newVector2) {
            var component = CreateComponent<Vector2Component>(VisualDebuggingComponentIds.Vector2);
            component.vector2 = newVector2;
            AddComponent(VisualDebuggingComponentIds.Vector2, component);
        }

        public void ReplaceVector2(UnityEngine.Vector2 newVector2) {
            var component = CreateComponent<Vector2Component>(VisualDebuggingComponentIds.Vector2);
            component.vector2 = newVector2;
            ReplaceComponent(VisualDebuggingComponentIds.Vector2, component);
        }

        public void RemoveVector2() {
            RemoveComponent(VisualDebuggingComponentIds.Vector2);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher<VisualDebuggingEntity> _matcherVector2;

        public static IMatcher<VisualDebuggingEntity> Vector2 {
            get {
                if(_matcherVector2 == null) {
                    var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentIds.Vector2);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherVector2 = matcher;
                }

                return _matcherVector2;
            }
        }
    }
