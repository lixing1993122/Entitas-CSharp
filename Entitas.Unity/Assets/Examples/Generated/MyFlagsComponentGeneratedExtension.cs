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

        public MyFlagsComponent myFlags { get { return (MyFlagsComponent)GetComponent(VisualDebuggingComponentIds.MyFlags); } }
        public bool hasMyFlags { get { return HasComponent(VisualDebuggingComponentIds.MyFlags); } }

        public void AddMyFlags(MyFlagsComponent.MyFlags newMyFlags) {
            var component = CreateComponent<MyFlagsComponent>(VisualDebuggingComponentIds.MyFlags);
            component.myFlags = newMyFlags;
            AddComponent(VisualDebuggingComponentIds.MyFlags, component);
        }

        public void ReplaceMyFlags(MyFlagsComponent.MyFlags newMyFlags) {
            var component = CreateComponent<MyFlagsComponent>(VisualDebuggingComponentIds.MyFlags);
            component.myFlags = newMyFlags;
            ReplaceComponent(VisualDebuggingComponentIds.MyFlags, component);
        }

        public void RemoveMyFlags() {
            RemoveComponent(VisualDebuggingComponentIds.MyFlags);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher<VisualDebuggingEntity> _matcherMyFlags;

        public static IMatcher<VisualDebuggingEntity> MyFlags {
            get {
                if(_matcherMyFlags == null) {
                    var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentIds.MyFlags);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherMyFlags = matcher;
                }

                return _matcherMyFlags;
            }
        }
    }
