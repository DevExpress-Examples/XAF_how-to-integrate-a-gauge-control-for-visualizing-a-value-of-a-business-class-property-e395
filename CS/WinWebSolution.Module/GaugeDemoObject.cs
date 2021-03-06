using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    public class GaugeDemoObject : BaseObject {
        public GaugeDemoObject(Session session) : base(session) { }
        private string _stringProperty;
        [EditorAlias("DigitalGaugePropertyEditor")]
        public string StringProperty {
            get { return _stringProperty; }
            set { SetPropertyValue("StringProperty", ref _stringProperty, value); }
        }
        private int _intProperty;
        [EditorAlias("LinearGaugePropertyEditor")]
        public int IntProperty {
            get { return _intProperty; }
            set { SetPropertyValue("IntProperty", ref _intProperty, value); }
        }
        private float _floatProperty;
        [EditorAlias("CircularGaugePropertyEditor")]
        public float FloatProperty {
            get { return _floatProperty; }
            set { SetPropertyValue("FloatProperty", ref _floatProperty, value); }
        }
        private Light _enumProperty;
        [EditorAlias("StateIndicatorGaugePropertyEditor")]
        public Light EnumProperty {
            get { return _enumProperty; }
            set { SetPropertyValue("EnumProperty", ref _enumProperty, value); }
        }
    }
    public enum Light {
        Red,
        Yellow,
        Green
    }
}