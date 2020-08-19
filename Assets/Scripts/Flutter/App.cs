using Unity.UIWidgets.engine;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace Flutter {
    public class App : UIWidgetsPanel {
        protected override Widget createWidget() {
            return new Mainless();
        }

        protected override void OnEnable() {
            FontManager.instance.addFont(
                Resources.Load<Font>("MaterialIcons-Regular"),
                "Material Icons"
            );
            base.OnEnable();
        }
    }
}