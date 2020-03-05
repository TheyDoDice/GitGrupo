import 'package:flutter/material.dart';
import 'package:way_finder_app/models/concuros.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';


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
    onTap: (){Navigator.pushNamed(context, 'EscogerCiudad');}
      );
  }

  Widget _textLocation(AsyncSnapshot snapshot, int index){
    return Container(
      margin: new EdgeInsets.only(top: 210),
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

  Widget _text(String text, double fontSize){
    return Text(
      text,
      style: TextStyle(
        color: Color.fromRGBO(187, 146, 95, 1),
        fontSize: fontSize,
      ),

    );
  }



  Future<List<Race>> getData() async {

    List<Race> races = [];

    http.Response response_1 = await http.get("https://racetolightsaber20200217051734.azurewebsites.net/api/locations");
    
    for (var item in json.decode(response_1.body)) {
      

      int id;
      String name;

      item.forEach((property,value){
        switch (property) {
          case "id":
            id = int.parse(value.toString());
          break;
          case "Name":
            name = value;
          break;
        }
      });

      races.add(new Race(id, name));
    }
    
    return races;
  }


   void _navigateToHome()async{
    await Navigator.pushNamed(
      context, 
      'Home'
    );
  }
}