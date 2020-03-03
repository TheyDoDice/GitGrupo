import 'package:flutter/material.dart';
import 'package:way_finder/pages/escoger_ciudad.dart';

class ListaConcursos extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => new _ListaConcursosState();
}

class _ListaConcursosState extends State<ListaConcursos> {
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
        title: Text("Cursos disponibles")
      ),
      body: showList(),
    );
  }

  Widget showList(){
    //if(_list.length > 0){
      return ListView.builder(
      shrinkWrap: true,
      itemCount: 1,
      itemBuilder: (BuildContext context, int index){
        return ListTile(  
          trailing: RaisedButton(
            shape: new RoundedRectangleBorder(
              borderRadius: new BorderRadius.circular(30.0)
            ),
            child: Text("Inscribir"),
        
            onPressed: () => _navigateToLocalizaciones(),
          ),     
        );
      }
      );
    //}
  }

   void _navigateToLocalizaciones()async{
    await Navigator.push(
      context, 
      MaterialPageRoute(builder: (context) => EscogerCiudad())
    );
  }
}