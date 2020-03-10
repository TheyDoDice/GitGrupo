import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:way_finder_app/models/concuros.dart';
import 'package:http/http.dart' as http;

class ListaConcursos extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => new _ListaConcursosState();
}

class _ListaConcursosState extends State<ListaConcursos> {
  //List<String> _list;
  BuildContext context;
  AsyncSnapshot snapshot;



  @override
  void initState() {
    //_errorMessage = "";
   // _isLoading = false;
   // _isLoginForm = true;
    super.initState();
  }


  Future<List<Race>> getData() async {

    List<Race> races = [];
    http.Response response_1 = await http.get("https://racetolightsaber20200217051734.azurewebsites.net/api/races");
    
    for (var x in json.decode(response_1.body)) {
      races.add(new Race(x["id"], x["name"]));
    }
    return races;
  }

  @override
  Widget build(BuildContext context){
    return Scaffold(
      appBar: AppBar(
        title: Text("Cursos disponibles")
      ),

      body: paginaList(context)
      
    );
  }

  Widget paginaList(BuildContext context){
    return Container(
      width: double.infinity,
      height: double.infinity,
      child: FutureBuilder(
        future: getData(),
        builder: (BuildContext context, AsyncSnapshot snapshot){
          if(snapshot.data == null){
            return _cargando();
          }
          return showList(snapshot, context);
        },
      ),
    );
  }

  Widget _cargando(){
    return Center(child: (CircularProgressIndicator()));
  }

  Widget showList(AsyncSnapshot snapshot, BuildContext context){
    return ListView.builder(
      itemCount: snapshot.data.length,
      itemBuilder: (BuildContext context, int index){
        return _race(snapshot, index, context);
      }
    );
  }

  Widget _race(AsyncSnapshot snapshot, int index, BuildContext context){
    return GestureDetector(
      child: Container(
        margin: EdgeInsets.symmetric(horizontal: 20, vertical: 25),
        decoration: BoxDecoration(
          //image:
          //color:
          //border:  
        ),
        child: _textConcursos(snapshot, index),
      ),
    onTap: () => Navigator.pushNamed(context, 'EscogerCiudad', arguments: snapshot.data[index].name)
    );
  }

  Widget _text(String text, double fontSize){
    return Text(
      text,
      style: TextStyle(
        color: Color.fromRGBO(187, 146, 95, 1),
        fontSize: fontSize,
      ),

    );
  }

  Widget _textConcursos(AsyncSnapshot snapshot, int index){
    return Container(
      //color: 
      child: Center(
        child: Column(
          children: <Widget>[
            _text(snapshot.data[index].name, 23)
          ]
        )
      ),
    );
  }

  /*Widget showList(){
    //if(_list.length > 0){
      return ListView.builder(
      shrinkWrap: true,
      itemCount: 1,
      itemBuilder: (BuildContext context, int index){
        return ListTile(  
          trailing: RaisedButton(
            shape: new RoundedRectangleBorder(
              borderRadius: new BorderRadius.circular(30.0)
            ),
            child: Text("Inscribir"),
        
            onPressed: () => _navigateToLocalizaciones(),
          ),     
        );
      }
      );
    //}
  }

   void _navigateToLocalizaciones()async{
    await Navigator.pushNamed(
      context, 
      'EscogerCiudad'
    );
  }*/
}