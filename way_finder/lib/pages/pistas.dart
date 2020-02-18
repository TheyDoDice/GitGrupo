import 'package:flutter/material.dart';

import 'package:flutter/material.dart';

class Pistas extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => new _PistasState();
}

class _PistasState extends State<Pistas> {
  List<String> _list;

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
      appBar: AppBar(
        title: Text("Mapa")
      ),
      body: showList(),
    );
  }

  Widget showList(){
    if(_list.length > 0){
      return ListView.builder(
      shrinkWrap: true,
      itemCount: _list.length,
      itemBuilder: (BuildContext context, int index){
        return Dismissible(
          key: null,
          child: ListTile(
            title: Text("Localizacion 1"),
            onTap: () => _navigateToPistas(),
          )
        );
      }
      );
    }
  }
  void _navigateToPistas()async{
    await Navigator.push(
      context, 
      MaterialPageRoute(builder: (context) =>Pistas())
    );
  }
}