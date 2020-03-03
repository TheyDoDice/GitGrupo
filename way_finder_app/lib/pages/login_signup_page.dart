import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:way_finder_app/pages/registrar.dart';
import 'package:way_finder_app/pages/lista_concursos.dart';

class Login extends StatefulWidget {

  @override
  State<StatefulWidget> createState() => new _LoginState();
}

class _LoginState extends State<Login> {
bool comprobar;
  @override
  void initState() {
    super.initState();
  }


  @override
  Widget build(BuildContext context) {
    return new Scaffold(
        body: Stack(
          children: <Widget>[
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
              showLogo(),
              padding(20),
              showNombreEquipoInput(),
              padding(20),
              showPasswordInput(),
              padding(30),
              showButtonIniciarSesion(),
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
        decoration: new InputDecoration(
          border: OutlineInputBorder(
            borderRadius: BorderRadius.circular(30)
          ),
            hintText: 'Nombre del equipo:',
           /* icon: new Icon(
              Icons.mail,
              color: Colors.grey,
            )*/),
        validator: (value) => value.isEmpty ? 'Email can\'t be empty' : null,
        //onSaved: (value) => _email = value.trim(),
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
        decoration: new InputDecoration(
          border: OutlineInputBorder(
            borderRadius: BorderRadius.circular(30)
          ),
            hintText: 'Contraseña',
        ),
        validator: (value) => value.isEmpty ? 'Password can\'t be empty' : null,
        //onSaved: (value) => _password = value.trim(),
      ),
    );
  }


  Widget showButtonIniciarSesion(){
    return Container(
      padding: EdgeInsets.only(left: 150.0, right: 20.0),
      child: new RaisedButton(
        shape: new RoundedRectangleBorder(
          borderRadius: new BorderRadius.circular(30.0)
        ),
        child: Text("IniciarSesión"),
        
        onPressed: () {
          log("Hola");
          Navigator.pushNamed( 
            context, 
            'Registrar'
          );
          log("adeu");
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
    Navigator.push(
      context, 
      MaterialPageRoute(builder: (context) => Registrar())
    );
  }
}


