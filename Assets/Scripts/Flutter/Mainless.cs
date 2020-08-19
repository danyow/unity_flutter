using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace Flutter {
    public class Mainless : StatelessWidget {
        public override Widget build(BuildContext context) {
            return new MaterialApp(
                title: "Welcome to Flutter",
                // home: new Scaffold(
                //     appBar: new AppBar(
                //         title: new Text("Welcome to Flutter"),
                //         backgroundColor: Color.clear
                //     ),
                //     body: new Center(
                //         // child: new Text("Hello world"),
                //         child: new Mainful()
                //     ),
                //     backgroundColor: Color.clear
                // )
                theme: new ThemeData(primaryColor: Color.black),
                home: new DrawerTest()
            );
        }
    }
}