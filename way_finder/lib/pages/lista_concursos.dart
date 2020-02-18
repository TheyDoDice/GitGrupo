
import 'package:flutter/material.dart';

class ListaConcursos extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => new _ListaConcursosState();
}

class _ListaConcursosState extends State<ListaConcursos> {

  @override
  Widget build(BuildContext context) {
    return new MaterialApp(
      title: 'Generated App',
      theme: new ThemeData(
        primarySwatch: Colors.blue,
        primaryColor: const Color(0xFF2196f3),
        accentColor: const Color(0xFF2196f3),
        canvasColor: const Color(0xFFafbcc2),
      ),
      home: new MyHomePage(),
    );
  }
}

class MyHomePage extends StatefulWidget {
  MyHomePage({Key key}) : super(key: key);
  @override
  _MyHomePageState createState() => new _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
    @override
    Widget build(BuildContext context) {
      return new Scaffold(
        body:
          new Container(
            child:
              new Text(
              "Cursos Disponibles",
                style: new TextStyle(fontSize:22.0,
                color: const Color(0xFF000000),
                fontWeight: FontWeight.w600,
                fontFamily: "Roboto"),
              ),
    
            padding: const EdgeInsets.fromLTRB(25.0, 1.0, 25.0, 1.0),
            alignment: Alignment.topLeft,
            width: 450.0,
            height: 450.0,
          ),
    
      );
    }
}