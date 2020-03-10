import 'package:flutter/material.dart';
import 'package:way_finder_app/models/Trial.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class Home extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => new _HomeState();
}

class _HomeState extends State<Home> {
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
      body: 
      showForm(),
    );
  }


  Widget showForm(){
    return new Container(
      padding: EdgeInsets.all(30.0),
      child: new Form(
        child: new ListView(
          shrinkWrap: true,
          children:<Widget>[
            showContainer1(),
            showContainerImage(),
            padding(20.0),
            showContainer2(),
            showContainerList()
          ]  
        ),
      ),              
    );
  }

  Widget padding(double number) {
    return Padding(
      padding: EdgeInsets.all(number),
    );
  }
  Widget showContainer1(){
    return Container(
      padding: EdgeInsets.all(20.0),
      color: Colors.blueGrey,
      child: Text("Mapa", style: TextStyle(
        color: Colors.white
        ),
      ),
    );
  }

  Widget showContainerImage(){
    return Container(
      decoration: BoxDecoration(
        border: Border(
          bottom: BorderSide(
            color: Colors.black
          ),
          top: BorderSide(
            color: Colors.black
          ),
          right: BorderSide(
            color: Colors.black
          ),
          left: BorderSide(
            color: Colors.black
          ),
        )
      ),
    //  padding: EdgeInsets.all(20.0),
      child: Image.asset('assets/mapa.jpg'),
    );
  }

  Widget showContainer2(){
    return Container(
      //width: 30.0,
      padding: EdgeInsets.all(20.0),
      color: Colors.blueGrey,
      child: Text("Pistas", style: TextStyle(
        color: Colors.white
        ),
      ),
    );
  }

  Future<List<Trial>> getData() async {

    List<Trial> locations = [];

    http.Response response_1 = await http.get("https://racetolightsaber20200217051734.azurewebsites.net/api/locations");
    http.Response response_2 = await http.get("https://racetolightsaber20200217051734.azurewebsites.net/api/trials");

    Map<int, String> cities = Map.fromIterable(
      json.decode(response_2.body), 
      key: (x) => x["id"], 
      value: (x) => x["name"]
    );

    for (Map<String, dynamic> x in json.decode(response_1.body)) {
      //locations.add(new Trial(x["id"], x["name"], x["clue"], x["idRace"], x["idCity"], cities[x["idCity"]]));
    }

    return locations;
  }

  Widget showContainerList(){
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
        }
      )
    );
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
        //Navigator.pushNamed(context, 'EscogerCiudad');
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
}
