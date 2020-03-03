import 'package:flutter/material.dart';
import 'package:way_finder_app/pages/lista_concursos.dart';


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
              padding(50),
              showNombreEquipoInput(),
              padding(10),
              showNombreParticipanteInputyButtonAdd(),
              padding(10),
              showPassowrdInput(),
              padding(10),
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
          child: Image.asset('assets/logoAddUser.png'),
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
            hintText: 'Nombre del equipo',
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
      padding: const EdgeInsets.only(left: 20.0, right: 25.0),
      child: new Row(
            mainAxisAlignment: MainAxisAlignment.start,
            mainAxisSize: MainAxisSize.max,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: <Widget>[
              new Container(
                child:
                  new TextField(
                    decoration: InputDecoration(
                      hintText: "Participante",
                      border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(30)
                      ),
                    ),
                  ),
    
                padding: const EdgeInsets.all(0.0),
                alignment: Alignment.center,
                width: 250.0,
                height: 100.0,
              ),
                padding(10.0),
              new RaisedButton(key:null, onPressed: (){},
                shape: new RoundedRectangleBorder(
                  borderRadius: new BorderRadius.circular(30.0)
                ),
                child:
                  new Text("Añadir")
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

  Widget showButtonRegistrar(){
    return Container(
      margin: EdgeInsets.only(left: 150.0, right: 20.0),
     child: new RaisedButton(
        shape: new RoundedRectangleBorder(
          borderRadius: new BorderRadius.circular(30.0)
        ),

        child: Text("Registrar"),
        
        onPressed: () => _navigateToListaCursos()//comprobarUsuario(context),

            
     ),
    );
  }
}



