import 'package:flutter/material.dart';
import 'package:way_finder/pages/lista_concursos.dart';


class Registrar extends StatefulWidget{
  @override
  State<StatefulWidget> createState() => new _RegistrarState();
}

class _RegistrarState extends State<Registrar> {
  @override
  void initState() {
    //_errorMessage = "";
   // _isLoading = false;
   // _isLoginForm = true;
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return new Scaffold(
        body: Stack(
          children: <Widget>[
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
              showLogo(),
              padding(20),
              showNombreEquipoInput(),
              padding(20),
              showNombreParticipanteInputyButtonAdd(),
              //showButtonAdd(),
              showButtonRegistrar(),
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
          child: Image.asset('assets/firebase.png'),
        ),
      ),
    );
  }


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
        validator: (value) => value.isEmpty ? ' can\'t be empty' : null,
        //onSaved: (value) => _email = value.trim(),
      ),
    );
  }

  Widget showNombreParticipanteInputyButtonAdd() {
    return Padding(
      padding: const EdgeInsets.only(left: 20.0, right: 150.0),
      child: Row(
        //mainAxisSize: MainAxisSize.min,
        children:<Widget>[
          new Expanded(
            child: TextFormField(
              maxLines: 1,
              keyboardType: TextInputType.emailAddress,
              autofocus: false,
              decoration: new InputDecoration(
                border: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(30)
                ),
                hintText: 'Participante',
              ),
              validator: (value) => value.isEmpty ? 'Email can\'t be empty' : null,
              //onSaved: (value) => _email = value.trim(),
            ),
          ),
          padding(12),
          new Expanded(
            child: RaisedButton(
            shape: new RoundedRectangleBorder(
              borderRadius: new BorderRadius.circular(30.0)
            ),
            child: Text("Añadir"),
        
             onPressed: () => ListaConcursos(),
          ),
          )
        ], 
      )
    );
  }

 /* Widget showButtonAdd(){
    return Container(
      child: new RaisedButton(
        shape: new RoundedRectangleBorder(
          borderRadius: new BorderRadius.circular(30.0)
        ),
        child: Text("Añadir"),
        
        onPressed: () => ListaConcursos(),
      )
    );
  }*/

  Widget showButtonRegistrar(){
    return Container(
     margin: EdgeInsets.only(left: 50.0, right: 0.0),
     child: new RaisedButton(
        shape: new RoundedRectangleBorder(
          borderRadius: new BorderRadius.circular(30.0)
        ),

        child: Text("Registrar"),
        
        onPressed: () => comprobarUsuario(),

            
     ),
    );
  }

  void comprobarUsuario(){
    Navigator.push(
      context, 
      MaterialPageRoute(builder: (context) => Registrar())
    );
  }


  





}