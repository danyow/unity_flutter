using System.Collections.Generic;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

namespace Flutter {
    public class PopupMenuTest : StatefulWidget {
        public override State createState() {
            return new PopupMenuState();
        }
    }

    enum WhyFarther {
        harder,
        smarter,
        selfStarter,
        tradingCharter
    }

    class PopupMenuState : State<PopupMenuTest> {
        public override Widget build(BuildContext context) {
            return new Scaffold(
                appBar: new AppBar(
                    actions: new List<Widget>() {
                        new IconButton(icon: new Icon(Icons.create))
                    }
                )
            );
        }
    }
}