using System.Collections.Generic;
using System.Linq;
using RSG.Promises;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace Flutter {
    public class Mainful : StatefulWidget {
        public override State createState() {
            return new RandomWordState();
        }
    }

    class RandomWordState : State<Mainful> {
        readonly List<string> _suggestions = new List<string>();

        readonly TextStyle _biggerFont = new TextStyle(fontSize: 18);

        readonly HashSet<string> _saved = new HashSet<string>();

        Widget BuildSuggestions() {
            return ListView.builder(
                padding: EdgeInsets.all(16),
                itemBuilder: ((buildContext, i) => {
                    if (i % 2 == 0) {
                        return new Divider();
                    }

                    var index = Mathf.FloorToInt(i / 2f);
                    if (i >= _suggestions.Count) {
                        _suggestions.Add($"Item:{i}");
                    }

                    // suggestions[i] = $"Item:{i}";
                    return BuildRow(_suggestions[index]);
                })
            );
        }

        Widget BuildRow(string text) {
            var alreadySaved = _saved.Contains(text);

            return new ListTile(
                title: new Text(
                    data: text,
                    style: _biggerFont
                ),
                trailing: new Icon(
                    icon: alreadySaved ? Icons.favorite : Icons.favorite_border,
                    color: alreadySaved ? Colors.red : null
                ),
                onTap: (() => {
                    setState(
                        () => {
                            if (alreadySaved) {
                                _saved.Remove(text);
                            } else {
                                _saved.Add(text);
                            }
                        }
                    );
                })
            );
        }

        VoidCallback PushSaved() {
            return new VoidCallback(
                () => {
                    // Debug.Log("alsjdlakjsdlkajlskdjlakjd");
                    // Navigator.of(context).push(
                    //     new MaterialPageRoute(
                    //         builder: (buildContext => {
                    //                 // var tiles = _saved.All<ListTile>(s => {
                    //                 //     return new ListTile(
                    //                 //         title:new Text(""));
                    //                 // })
                    //                 return null;
                    //             }
                    //         )
                    Navigator.of(context)
                             .push(
                                  new MaterialPageRoute(
                                      builder: (buildContext => {
                                          var tiles = new HashSet<ListTile>();
                                          _saved.Each(
                                              s => {
                                                  tiles.Add(
                                                      new ListTile(
                                                          title: new Text(
                                                              data: s,
                                                              style: _biggerFont
                                                          )
                                                      )
                                                  );
                                              }
                                          );
                                          var divided = ListTile.divideTiles(
                                                                     context: buildContext,
                                                                     tiles: tiles
                                                                 )
                                                                .ToList();
                                          return new Scaffold(
                                              appBar: new AppBar(title: new Text("")),
                                              body: new ListView(children: divided)
                                          );
                                      })
                                  )
                              );
                }
            );
        }

        public override Widget build(BuildContext context) {
            // return new Text("asdjahksjdh");
            return new Scaffold(
                appBar: new AppBar(
                    title: new Text("123123123"),
                    actions: (new List<Widget>() {
                        new IconButton(
                            icon: new Icon(Icons.list),
                            onPressed: PushSaved()
                        )
                    })
                ),
                body: BuildSuggestions()
            );
            // return BuildSuggestions();
        }
    }
}