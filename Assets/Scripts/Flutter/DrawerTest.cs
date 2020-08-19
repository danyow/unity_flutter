using System.Collections.Generic;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace Flutter {
    public class DrawerTest : StatefulWidget {
        public override State createState() {
            return new DrawerState();
        }
    }

    class DrawerState : State<DrawerTest> {
        private bool _isExpanded = false;
        public override Widget build(BuildContext context) {
            var descriptionStyle = Theme.of(context).textTheme.subhead;
            return new Scaffold(
                appBar: new AppBar(title: new Text("")),
                drawer: new Drawer(
                    child: new ListView(
                        padding: EdgeInsets.zero,
                        children: new List<Widget>() {
                            new DrawerHeader(
                                decoration: new BoxDecoration(color: Colors.blue),
                                child: new Text(
                                    data: "",
                                    style: new TextStyle(
                                        color: Color.white,
                                        fontSize: 24
                                    )
                                )
                            ),
                            new ExpansionPanelList(
                                children: new List<ExpansionPanel>() {
                                    new ExpansionPanel(
                                        headerBuilder: (buildContext, expanded) => {
                                            return new ListTile(
                                                title: new Text("Setting"));
                                        },
                                        body: new Padding(
                                            padding: EdgeInsets.fromLTRB(16, 16, 16, 16),
                                            child: new ListBody(
                                                children: new List<Widget>() {
                                                    // new Card(
                                                    //     margin: EdgeInsets.only(bottom: 10),
                                                    //     child: new Padding(
                                                    //         padding: EdgeInsets.all(8),
                                                    //         child: new Text("1")
                                                    //     )
                                                    // ),
                                                    // new Card(
                                                    //     margin: EdgeInsets.only(bottom: 10),
                                                    //     child: new Padding(
                                                    //         padding: EdgeInsets.all(8),
                                                    //         child: new Text("2")
                                                    //     )
                                                    // )
                                                    new Padding(
                                                        padding: EdgeInsets.all(8),
                                                        child: new Text("1")
                                                    ),
                                                    new Padding(
                                                        padding: EdgeInsets.all(8),
                                                        child: new Text("2")
                                                    )
                                                }
                                            )
                                        ),
                                        isExpanded: _isExpanded,
                                        canTapOnHeader:true
                                    )
                                },expansionCallback:(index, expanded) => {
                                    setState(() => {
                                        _isExpanded = !_isExpanded;
                                    });
                                }
                            )
                            // new Container(
                            //     padding: EdgeInsets.all(8),
                            //     height: 300f,
                            //     child: new Card(
                            //         child: new Column(
                            //             children: new List<Widget>() {
                            //                 new Expanded(
                            //                     child: new Padding(
                            //                         padding: EdgeInsets.fromLTRB(16, 16, 16, 0),
                            //                         child: new DefaultTextStyle(
                            //                             softWrap: false,
                            //                             // overflow: TextOverflow.ellipsis,
                            //                             style: descriptionStyle,
                            //                             child: new Column(
                            //                                 crossAxisAlignment: CrossAxisAlignment.start,
                            //                                 children: new List<Widget>() {
                            //                                     new Padding(
                            //                                         padding: EdgeInsets.only(bottom: 8),
                            //                                         child: new Text(
                            //                                             data: "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111",
                            //                                             style: descriptionStyle.copyWith(
                            //                                                 color: Colors.black54
                            //                                             )
                            //                                         )
                            //                                     ),
                            //                                     new Text("222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222"),
                            //                                     new Text("333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333")
                            //                                 }
                            //                             )
                            //                         )
                            //                     )
                            //                 )
                            //             }
                            //         )
                            //     )
                            // )
                        }
                    )
                )
            );
        }
    }
}