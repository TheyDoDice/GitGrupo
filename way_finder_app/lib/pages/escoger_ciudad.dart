import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';
import 'package:way_finder_app/models/Location.dart';
import 'package:way_finder_app/models/city.dart';


class EscogerCiudad extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => new _EscogerCiudadState();
}

class _EscogerCiudadState extends State<EscogerCiudad> {
  //List<String> _list;

  int raceId;
  
  @override
  void initState() {
    //_errorMessage = "";
   // _isLoading = false;
   // _isLoginForm = true;
    super.initState();
  }

 @override
  Widget build(BuildContext context) {
    raceId = ModalRoute.of(context).settings.arguments;
    return new Scaffold(
      appBar: AppBar(
        title: Text("Ciudades")
      ),
      body: Stack(
        children: <Widget>[
          Image.asset(
            "assets/back_CursosLocalizaciones.png",
            height: MediaQuery.of(context).size.height,
            width: MediaQuery.of(context).size.width,
            fit: BoxFit.cover,
          ),
          paginaList(context),
        ],
      ),
      /*floatingActionButton: FloatingActionButton(
        onPressed: () {
          Navigator.pushNamed(context, 'Home');
        },
        child: Icon(Icons.chevron_right),
        backgroundColor: Colors.blue,
      ),*/
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
        child: ListTile(
          title: _textLocation(snapshot, index),
          trailing: RaisedButton(
            shape: new RoundedRectangleBorder(
              borderRadius: new BorderRadius.circular(30.0)
            ),
            child: Icon(Icons.arrow_forward_ios),
        
            onPressed: () =>  Navigator.pushNamed(context, 'EscogerLocalizacion', arguments: snapshot.data[index].id),
          ),

        )
      ));
    /*onTap: (){
         Navigator.pushNamed(context, 'Home', arguments: snapshot.data[index].id);
      }
      );*/
  }

  Widget _textLocation(AsyncSnapshot snapshot, int index){
    return Container(
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
        color: Colors.white,
        fontSize: fontSize,
      ),
    );
  }



  Future<List<City>> getData() async {

    List<City> cities = [];
    //---DESCOMENTAR QUAN LA API FUNCIONI---
    
    //http.Response response_1 = await http.get("http://apiwayfinder.gear.host/api/locations");
    http.Response response_2 = await http.get("http://wfapi.gear.host/api/city");

    /*Map<int, String> cities = Map.fromIterable(
      json.decode(response_2.body), 
      key: (x) => x["Id"], 
      value: (x) => x["Name"]
    );*/

/*    for (Map<String, dynamic> x in json.decode(response_1.body)) {
      locations.add(new Location(x["Id"], x["Name"], x["Clue"], x["IdRace"], x["IdCity"], cities[x["IdCity"]]));
    }*/

    for (Map<String, dynamic> x in json.decode(response_2.body)) {
      cities.add(new City(x["Id"], x["Name"]));
    }

    

   /* locations.add(new Location(1,"Hospitalet de Llobregat","TEST",1,1,"TEST"));
    locations.add(new Location(2,"Esplugues de Llobregat","TEST",1,1,"TEST"));
    locations.add(new Location(3,"Cornellá de Llobregat","TEST",1,1,"TEST"));
    locations.add(new Location(4,"Sant Feliu de Llobregat","TEST",1,1,"TEST"));*/

    return cities;
  }
}