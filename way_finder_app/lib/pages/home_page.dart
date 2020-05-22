import 'dart:developer';
import 'package:qr_flutter/qr_flutter.dart';
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

  int locationId;

  @override
  Widget build(BuildContext context) {
    locationId = ModalRoute.of(context).settings.arguments;
    print('locationid: ' + locationId.toString());
    return new Scaffold(
      appBar: AppBar(
        title: Text("Pantalla principal")
      ),
      body: Stack(
        children: <Widget>[
          Image.asset(
            "assets/back_Mapa.png",
            height: MediaQuery.of(context).size.height,
            width: MediaQuery.of(context).size.width,
            fit: BoxFit.cover,
          ),
          showForm(),
        ],
      ),
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
            showContainerList(),
            showContainer3(),
            showContainerList2(),
            _showQr()
          ]  
        ),
      ),              
    );
  }

  Widget _showQr(){
    return Column(
      children: <Widget>[
            QrImage(
              foregroundColor: Colors.white,
              padding: EdgeInsets.all(150),
              data: 'Conectat',
         )
          ]
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
      decoration: BoxDecoration(
        borderRadius: BorderRadius.only(
          topLeft: Radius.circular(10.0),
          topRight: Radius.circular(10.0)),
        color: Colors.blue),
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
            color: Colors.red
          ),
          top: BorderSide(
            color: Colors.red
          ),
          right: BorderSide(
            color: Colors.red
          ),
          left: BorderSide(
            color: Colors.red
          ),
        )
      ),
      child: Image.asset('assets/mapa.jpg'),
    );
  }

  Widget showContainer2(){
    return Container(
      padding: EdgeInsets.all(20.0),
      decoration: BoxDecoration(
        borderRadius: BorderRadius.only(
          topLeft: Radius.circular(10.0),
          topRight: Radius.circular(10.0)),
        color: Colors.blue),
      child: Text("Pista", style: TextStyle(
        color: Colors.white
        ),
      ),
    );
  }

   Widget showContainer3(){
    return Container(
      padding: EdgeInsets.all(20.0),
      decoration: BoxDecoration(
        borderRadius: BorderRadius.only(
          topLeft: Radius.circular(10.0),
          topRight: Radius.circular(10.0)),
        color: Colors.blue),
        child: Text("Informació de la prova", style: TextStyle(
        color: Colors.white
        ),
      ),
    );
  }


  Future<Trial> getData() async {

    Trial trial;
    http.Response response_1 = await http.get("http://wfapi.gear.host/api/locations/" + locationId.toString());
    http.Response response_2 = await http.get("http://wfapi.gear.host/api/trials/" + locationId.toString());
    
    String clue;

    /*for (Map<String, dynamic> x in json.decode(response_1.body)) {
      trials.add(new Location(x["Id"], x["Name"], x["Clue"], x["IdRace"], x["IdCity"], cities[x["IdCity"]]));
    }*/

    clue = json.decode(response_1.body)["Clue"];

    var trial1 = json.decode(response_2.body);

    trial = new Trial(trial1["Id"], trial1["Name"], clue, trial1["Description"]);

    return trial;
  }

  Widget showContainerList(){
     return Container(
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

  Widget showContainerList2(){
     return Container(
      child: FutureBuilder(
        future: getData(),
        builder: (BuildContext context, AsyncSnapshot snapshot){
          if(snapshot.data == null){
            return _cargando();
          }
          return showList2(snapshot, context);
        }
      )
    );
  }

  Widget _cargando(){
    return Center(child: (CircularProgressIndicator()));
  }

   Widget showList(AsyncSnapshot snapshot, BuildContext context){
    return ListView.builder(
      scrollDirection: Axis.vertical,
      shrinkWrap: true,
      itemCount: 1,
      itemBuilder: (BuildContext context, int index){
        return _trial(snapshot, index, context);
      }
    );
  }

  Widget showList2(AsyncSnapshot snapshot, BuildContext context){
    return ListView.builder(
      scrollDirection: Axis.vertical,
      shrinkWrap: true,
      itemCount: 1,
      itemBuilder: (BuildContext context, int index){
        return _trial2(snapshot, index, context);
      }
    );
  }

  Widget _trial(AsyncSnapshot snapshot, int index, BuildContext context){
    return GestureDetector(
      child: Container(
        margin: EdgeInsets.symmetric(horizontal: 20, vertical: 25),
        decoration: BoxDecoration(), 
        child: _textTrial(snapshot, index),
      ),
    onTap: (){
        //Navigator.pushNamed(context, 'EscogerCiudad');
      }
      );
  }

  Widget _trial2(AsyncSnapshot snapshot, int index, BuildContext context){
    return GestureDetector(
      child: Container(
        margin: EdgeInsets.symmetric(horizontal: 20, vertical: 25),
        decoration: BoxDecoration(), 
        child: _textTrial2(snapshot, index),
      ),
    onTap: (){
        //Navigator.pushNamed(context, 'EscogerCiudad');
      }
      );
  }

  Widget _textTrial(AsyncSnapshot snapshot, int index){
    return Container(
      child: Center(
        child: Column(
          children: <Widget>[
            _text(snapshot.data.clue , 23)
          ]
        )
      ),
    );
  }

  
  Widget _textTrial2(AsyncSnapshot snapshot, int index){
    return Container(
      child: Center(
        child: Column(
          children: <Widget>[
            _text2(snapshot.data.description , 23)
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

Widget _text2(String text, double fontSize){
    return Text(
      text,
      style: TextStyle(
        color: Color.fromRGBO(187, 146, 95, 1),
        fontSize: fontSize,
      ),
    );
  }
