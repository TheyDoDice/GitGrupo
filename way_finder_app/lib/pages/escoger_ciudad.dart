import 'package:flutter/material.dart';
import 'package:way_finder_app/pages/home_page.dart';


class EscogerCiudad extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => new _EscogerCiudadState();
}

class _EscogerCiudadState extends State<EscogerCiudad> {
  //List<String> _list;

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
        title: Text("Localizaciones")
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
          title: Text("Localizacion 1"),  
          onTap: () => _navigateToHome(), 
        );
      }
      );
    //}
  }

   void _navigateToHome()async{
    await Navigator.push(
      context, 
      MaterialPageRoute(builder: (context) => Home())
    );
  }
}