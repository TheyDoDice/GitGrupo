import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'package:way_finder_app/models/Team.dart';
import 'dart:convert';


class Registrar extends StatefulWidget{
  @override
  State<StatefulWidget> createState() => new _RegistrarState();
}

class _RegistrarState extends State<Registrar> {
  String teamName;
  String password;
  String name;
  String teamId;
  Future<Team> _futureTeam;

final _controllerName = TextEditingController();
  final _controllerPassword = TextEditingController();
 // TextEditingController _controller;
 void netejarController(){
    _controllerName.clear();
    _controllerPassword.clear();
  }

  @override
  void initState() {
    //_errorMessage = "";
   // _isLoading = false;
   // _isLoginForm = true;
    super.initState();
  }

  Future<Team> createTeam() async {
   Map<String,String> headers = {
  'Content-type' : 'application/json', 
  'Accept': 'application/json',
  };
  final http.Response response = await http.post(
    'http://wfapi.gear.host/api/teams',
    headers: headers,
    body: json.encode({
      'name': teamName,
      'password': password
    }),
  );
  if (response.statusCode == 201) {
    // If the server did return a 201 CREATED response,
    // then parse the JSON.
    return Team.fromJson(json.decode(response.body));
  } else {
    // If the server did not return a 201 CREATED response,
    // then throw an exception.
    throw Exception('Failed to load album');
  }
}

  @override
  Widget build(BuildContext context) {
    return new Scaffold(
        body: Stack(
          children: <Widget>[
            Image.asset(
              "assets/back_LoginRegistro.png",
              height: MediaQuery.of(context).size.height,
              width: MediaQuery.of(context).size.width,
              fit: BoxFit.cover,
            ),
            _showForm(),
           // _showCircularProgress(),
          ],
        ));
  }


  Widget _showForm() {
    return new Container(
       // padding: EdgeInsets.all(50.0),
        child: new Form(
          //key: _formKey,
          child: new ListView(
            shrinkWrap: true,
            children: <Widget>[
              padding(20),
              padding(70),
              showLabelRegistroEquipos(),
              showNombreEquipoInput(),
              padding(10),
              showPassowrdInput(),
              padding(7),
              showButtonRegistrar(),
              padding(10),
              showLabelRegistroParticipante(),
              showNombreParticipanteInputyButtonAdd(),
             // showButtonIniciarSesion(),
              //showSecondaryButton(),
              //showErrorMessage(),
            ],
          ),
        )
      );
    }

    Widget padding(double number) {
    return Padding(
      padding: EdgeInsets.all(number),
    );
  }

    Widget showLogo() {
    return new Hero(
      tag: 'hero',
      child: Padding(
        padding: EdgeInsets.fromLTRB(0.0, 70.0, 0.0, 0.0),
        child: CircleAvatar(
          backgroundColor: Colors.transparent,
          radius: 48.0,
          child: Image.asset('assets/logoAddUser.png'),
        ),
      ),
    );
  }

  Widget showLabelRegistroEquipos(){
    return Container(
        margin: new EdgeInsets.only(left: 20.0),
      child:  TextFormField(
        decoration: InputDecoration(
          labelText: 'Registrar Equipos:',
          labelStyle: TextStyle(
            color: Colors.white,
            decoration: TextDecoration.underline
          )
        ),
      ),
    );
  }

  Widget showLabelRegistroParticipante(){
    return Container(
        margin: new EdgeInsets.only(left: 20.0),
      child:  TextFormField(
        decoration: InputDecoration(
          labelText: 'Registrar Participantes:',
          labelStyle: TextStyle(
            color: Colors.white,
            decoration: TextDecoration.underline
          )
        ),
      ),
    );
  }

  Widget showNombreEquipoInput() {
    return Padding(
      padding: const EdgeInsets.only(left: 20.0, right: 20.0),
      child: new TextFormField(
        controller: _controllerName,
        maxLines: 1,
        keyboardType: TextInputType.emailAddress,
        autofocus: false,
        style: TextStyle(color: Colors.white),
        decoration: new InputDecoration(
          enabledBorder: const OutlineInputBorder(
            borderSide: const BorderSide(color: Colors.white, width: 0.0),
          ),
          border: OutlineInputBorder(
            borderRadius: BorderRadius.circular(30),
          ),
            hintText: 'Nombre del equipo',
            hintStyle: TextStyle(color: Colors.white),
           /* icon: new Icon(
              Icons.mail,
              color: Colors.grey,
            )*/),
        validator: (value) => value.isEmpty ? ' can\'t be empty' : null,
        onChanged: (String text) {
          teamName =  text;
        },
        //onSaved: (value) => _email = value.trim(),
      ),
    );
  }

  Widget showNombreParticipanteInputyButtonAdd() {
    return Container(
      margin: EdgeInsets.only(left: 20.0),
      child: new Row(
            mainAxisAlignment: MainAxisAlignment.start,
            mainAxisSize: MainAxisSize.max,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: <Widget>[
              new Container(
                child:
                  new TextField(
                    style: TextStyle(color: Colors.white),
                    decoration: InputDecoration(
                      hintText: "Participante",
                      hintStyle: TextStyle(color: Colors.white),
                    enabledBorder: const OutlineInputBorder(
                      borderSide: const BorderSide(color: Colors.white, width: 0.0),
                    ),
                    border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(30),
                    ),
                    ),
                  ),
    
                padding: const EdgeInsets.all(0.0),
                alignment: Alignment.center,
                width: MediaQuery.of(context).size.width * 0.60,
                //height: 100.0,
              ),
                padding(5),
              new RaisedButton(key:null, onPressed: (){},
                shape: new RoundedRectangleBorder(
                  borderRadius: new BorderRadius.circular(30.0)
                ),
                child: new Text("Añadir"),
                highlightColor: Colors.grey[600]
              )
            ]
    
          ),
    
      );
    }
    void _navigateToListaCursos()async{
    //BuildContext context;
    await Navigator.pushNamed(context, 'ListaConcursos');
  }

  Widget showPassowrdInput() {
    return Padding(
      padding: const EdgeInsets.only(left: 20.0, right: 20.0),
      child: new TextFormField(
        controller: _controllerPassword,
        maxLines: 1,
        obscureText: true,
        autofocus: false,
        style: TextStyle(color: Colors.white),
        decoration: new InputDecoration(
          enabledBorder: const OutlineInputBorder(
            borderSide: const BorderSide(color: Colors.white, width: 0.0),
          ),
          border: OutlineInputBorder(
            borderRadius: BorderRadius.circular(30),
          ),
            hintText: 'Contraseña',
            hintStyle: TextStyle(color: Colors.white),
        ),
        validator: (value) => value.isEmpty ? 'Password can\'t be empty' : null,
        onChanged: (String text) {
          password =  text;
        },
        //onSaved: (value) => _password = value.trim(),
      ),
    );
  }

  Widget showButtonRegistrar(){
    return Container(
      margin: EdgeInsets.only(left: 150.0, right: 20.0),
     child: new RaisedButton(
        shape: new RoundedRectangleBorder(
          borderRadius: new BorderRadius.circular(30.0)
        ),
        child: Text("Registrar"),
        highlightColor: Colors.grey[600],
        onPressed: () {
          netejarController();
          setState(() {
            _futureTeam = createTeam();
          });
          
       //   createTeam();
          //Navigator.pushNamed(context, 'Login');
        }
     ),
    );
  }
}

/*
var body = {
      "Name": teamName,
      "Password": password
    };

    http.post("http://apiwayfinder.gear.host/api/teams",
      headers: {"Content-Type": "application/json"},
      body: body
    ).then((http.Response response) {
      var id  = response.id
    }));
    
*/


