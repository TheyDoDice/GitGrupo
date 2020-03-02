import 'package:flutter/material.dart';

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
  Widget showContainerList(){
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
      child: Form(
        child: ListView(
          shrinkWrap: true,
          children:<Widget>[
            Text("Pista 1"),
            Text("Pista 2"),
            Text("Pista 3")
          ]
        )
      ),
    );
  }
}
