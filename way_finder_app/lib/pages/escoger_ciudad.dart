import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';
import 'package:way_finder_app/models/Location.dart';


class EscogerCiudad extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => new _EscogerCiudadState();
}

class _EscogerCiudadState extends State<EscogerCiudad> {
  //List<String> _list;
  
  @override
  void initState() {
    //_errorMessage = "";
   // _isLoading = false;
   // _isLoginForm = true;
    super.initState();
  }

  @override
  Widget build(BuildContext context){
    //final int idRace = ModalRoute.of(context).settings.arguments;
    return Scaffold(
      appBar: AppBar(
        title: Text("Localizaciones")
      ),
      body: paginaList(context),
    );
  }

  Widget paginaList(BuildContext context){
    //if(_list.length > 0){
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
    //}
  }

  Widget _cargando(){
    return Center(child: (CircularProgressIndicator()));
  }

  Widget showList(AsyncSnapshot snapshot, BuildContext context){
    return ListView.builder(
      itemCount: snapshot.data.length,
      itemBuilder: (BuildContext context, int index){
        return _location(snapshot, index, context);
      }
    );
  }

  Widget _location(AsyncSnapshot snapshot, int index, BuildContext context){
    return GestureDetector(
      child: Container(
        margin: EdgeInsets.symmetric(horizontal: 20, vertical: 25),
        decoration: BoxDecoration(
          //image:
          //color:
          //border:  
        ), 
        child: _textLocation(snapshot, index),
      ),
    onTap: (){
         Navigator.pushNamed(context, 'Home', arguments: snapshot.data[index].id);
      }
      );
  }

  Widget _textLocation(AsyncSnapshot snapshot, int index){
    return Container(
      child: Center(
        child: Column(
          children: <Widget>[
            _text(snapshot.data[index].city + ": " + snapshot.data[index].name , 23)
          ]
        )
      ),
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



  Future<List<Location>> getData() async {

    List<Location> locations = [];

    http.Response response_1 = await http.get("https://racetolightsaber20200217051734.azurewebsites.net/api/locations");
    http.Response response_2 = await http.get("https://racetolightsaber20200217051734.azurewebsites.net/api/cities");

    Map<int, String> cities = Map.fromIterable(
      json.decode(response_2.body), 
      key: (x) => x["id"], 
      value: (x) => x["name"]
    );

    for (Map<String, dynamic> x in json.decode(response_1.body)) {
      locations.add(new Location(x["id"], x["name"], x["clue"], x["idRace"], x["idCity"], cities[x["idCity"]]));
    }

    return locations;
  }
}