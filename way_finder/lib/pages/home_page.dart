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
      child: new Form(
        child: new ListView(
          shrinkWrap: true,
          children:<Widget>[
            showContainer1(),
            showContainerImage(),
            showContainer2()
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
      height: 50,
      child: Text("Mapa", style: TextStyle(
        color: Colors.blueGrey
        ),
        textAlign: TextAlign.center,
      ),
    );
      
      /* children:<Widget>[
         Text(
          "Mapa",
        ),*/
        /*Image.asset("assets/mapa.jpg",
          height: MediaQuery.of(context).size.height * 0.0,
          )*/
     /*   Container(
          height: MediaQuery.of(context).size.height * 0.4,
          color: Colors.black,
        )
       ],
      );*/
  }

  Widget showContainerImage(){
    return Container(
      
    );
  }

  Widget showContainer2(){
    return Column(
      children: <Widget>[
        Text(
          "Pistas",
          style: TextStyle(
            background: Paint()..color = Colors.blueGrey
          )
        ),
        ListView.builder(
          shrinkWrap: true,
          itemCount: 1,
          itemBuilder: (BuildContext context, int index){
            return ListTile(  
              title: Text("Pista 1"),     
            );
          }
        )
      ],
    );
  }
}
