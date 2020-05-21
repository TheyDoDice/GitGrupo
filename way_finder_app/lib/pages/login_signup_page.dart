import 'dart:developer';
import 'package:http/http.dart' as http;
import 'package:flutter/material.dart';

import 'dart:convert';
import 'package:way_finder_app/models/Team.dart';

class Login extends StatefulWidget {

  @override
  State<StatefulWidget> createState() => new _LoginState();
}

class _LoginState extends State<Login> {
bool comprobar;
String teamName; 
String password;


  @override
  void initState() {
    super.initState();
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
            padding(20),
          _showForm(),
          ],
        ));
  }

  Widget _showForm() {
    return new Container(
       // padding: EdgeInsets.all(5.0),
        child: new Form(
          //key: _formKey,
          child: new ListView(
            shrinkWrap: true,
            children: <Widget>[
              padding(20),
              //showLogo(),
              padding(120),
              showNombreEquipoInput(),
              padding(20),
              showPasswordInput(),
              padding(10),
              showButtonIniciarSesion(),
              showButtonRegistar(),
              //showSecondaryButton(),
              //showErrorMessage(),
            ],
          ),
        ));
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
          child: Image.asset('assets/logoUsers.png'),
        ),
      ),
    );
  }

  /*Widget showLabelNombreEquipo(){
    return Container(
      padding: EdgeInsets.only(left: 50, bottom: 15),
      child:  Text("Nombre del equipo"),
    );
  }*/


  Widget showNombreEquipoInput() {
    return Padding(
      padding: const EdgeInsets.only(left: 20.0, right: 20.0),
      child: new TextFormField(
        maxLines: 1,
        keyboardType: TextInputType.emailAddress,
        autofocus: false,
        style: TextStyle(
          color: Colors.white
        ),
        decoration: new InputDecoration(
          enabledBorder: const OutlineInputBorder(
            borderSide: const BorderSide(color: Colors.white, width: 0.0),
          ),
          border: OutlineInputBorder(
            borderRadius: BorderRadius.circular(30),
          ),
          hintText: 'Nombre del equipo',
          hintStyle: TextStyle(color: Colors.white),
        ),
        validator: (value) => value.isEmpty ? 'Name can\'t be empty' : null,
        onSaved: (value) => teamName = value.trim(),
      ),
    );
  }

  /*Widget showLabelPassword(){
    return Container(
      padding: EdgeInsets.only(left: 50, bottom: 15),
      child:  Text("Contraseña"),
    );
  }*/

  Widget showPasswordInput() {
    return Padding(
      padding: const EdgeInsets.only(left: 20.0, right: 20.0),
      child: new TextFormField(
        maxLines: 1,
        obscureText: true,
        autofocus: false,
        style: TextStyle(
          color: Colors.white
        ),
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
        onSaved: (value) => password = value.trim(),
      ),
    );
  }

  Widget showButtonIniciarSesion(){
    return Container(
      padding: EdgeInsets.only(left: 70.0, right: 70.0),
      child: new RaisedButton(
        shape: new RoundedRectangleBorder(
          borderRadius: new BorderRadius.circular(30.0)
        ),
        child: Text("Iniciar Sesión"),
        highlightColor: Colors.grey[600],
        onPressed: () {
          //crida api login
          if(login() == 0){
            //error
            Text('Dades incorrectes');
          }else{
            Navigator.pushNamed(context, 'ListaConcursos', arguments: login());
          }
          //
          
        },
      )
    );
  }

  Future<int> login() async {

    int teamId = 0;

    http.Response response_1 = await http.get("http://apiwayfinder.gear.host/api/teams/login/" + teamName + "/" + password);

    

    for (Map<String, dynamic> x in json.decode(response_1.body)) {
      if(x.isNotEmpty){
        teamId = x["Id"];
      }
    }

    return teamId;
  }

  Widget showButtonRegistar(){
    return Container(
      padding: EdgeInsets.only(left: 80.0, right: 80.0),
      child: new RaisedButton(
        shape: new RoundedRectangleBorder(
          borderRadius: new BorderRadius.circular(30.0)
        ),
        child: Text("Registrar"),
        highlightColor: Colors.grey[600],
        onPressed: () {
          Navigator.pushNamed(context, 'Registrar');
        },
      )
    );
  }

  void navigateToListaCursos()async{
    //BuildContext context;
    await Navigator.pushNamed(
      context, 
      'ListaConcursos'
    );
  }
  
  void comprobarUsuario(){
    Navigator.pushNamed(
      context, 
      'Registrar'
    );
  }
}


